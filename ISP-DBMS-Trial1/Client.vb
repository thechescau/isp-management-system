Imports System.ComponentModel.Design
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Net.Sockets
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud

Public Class Client
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Str As String

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "select * from isp_database.plan_table"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim pName = READER.GetString(1)
                plan_cmb.Items.Add(pName)
            End While

            MysqlConn.Close()

            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        Display_Table()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim MysqlConn As MySqlConnection = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Try
            MysqlConn.Open()
            Dim Query2 As String
            Dim Query3 As String

            Dim inDate As DateTime = DateTimePicker1.Value
            Dim inDateStr As String = inDate.ToString("yyyy-MM-dd")

            Query2 = "insert into isp_database.client_table " _
            & "(client_id,client_name, client_address, client_contact, client_plan, client_install) " _
            & "values ('" & id_tb.Text & "', '" & name_tb.Text & "', '" _
            & ad_tb.Text & "', '" & contact_tb.Text & "', '" & plan_cmb.SelectedItem & "', '" & inDateStr & "')"
            Query3 = "insert into isp_database.bill_table " _
            & "(client_id,client_name,client_plan) " _
            & "values ('" & id_tb.Text & "', '" & name_tb.Text & "', '" & plan_cmb.SelectedItem & "')"

            Dim COMMAND As MySqlCommand = New MySqlCommand(Query2, MysqlConn)
            COMMAND.ExecuteNonQuery()
            COMMAND = New MySqlCommand(Query3, MysqlConn)
            COMMAND.ExecuteNonQuery()

            InsertToMonthly()

            Display_Table()

            Detect_Price()

            MessageBox.Show("Client Information Saved!")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If
            MysqlConn.Dispose()
            id_tb.Text = ""
            name_tb.Text = ""
            ad_tb.Text = ""
            contact_tb.Text = ""
            plan_cmb.Text = ""
            DateTimePicker1.Text = ""
        End Try
        Display_Table()
    End Sub


    Public Sub InsertToMonthly()
        Dim MysqlConn2 As New MySqlConnection()
        MysqlConn2.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn2.Open()
            Dim Query1 As String

            Query1 = "insert into isp_database.monthly_table " _
                & "(client_id) " _
                & "values ('" & id_tb.Text & "')"


            COMMAND = New MySqlCommand(Query1, MysqlConn2)
            READER = COMMAND.ExecuteReader()
            READER.Close()
            READER.Dispose()

            MysqlConn2.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn2.Dispose()

        End Try
    End Sub

    Public Sub Detect_Price()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Try
            Dim selectedPlan As String = plan_cmb.SelectedItem.ToString()

            MysqlConn.Open()

            Dim Query As String
            Query = "select Price from isp_database.plan_table where Plan_Name = @plan_name"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@plan_name", selectedPlan)

            Dim adapter As New MySqlDataAdapter(COMMAND)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim price As Decimal = Convert.ToDecimal(dt.Rows(0)(0))
                Dim cid As Integer = id_tb.Text
                Dim updateQuery As String = "Update isp_database.bill_table set amount = @amount where client_id = @client_id "
                Dim updateCommand As New MySqlCommand(updateQuery, MysqlConn)

                updateCommand.Parameters.AddWithValue("@amount", price)
                updateCommand.Parameters.AddWithValue("@client_id", cid)
                updateCommand.ExecuteNonQuery()

                Console.WriteLine("The price for the selected package is: " & price.ToString("C"))
            End If
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show("Please select a package for this client.")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub Display_Table()
        Try
            Str = "select * from isp_database.client_table"
            MysqlConn.Open()
            Dim Search As New MySqlDataAdapter(Str, MysqlConn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "isp_database.client_table")
            DataGridView1.DataSource = ds.Tables("isp_database.client_table")
            MysqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try

    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        Display_Table()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Try
            Str = "Delete from isp_database.client_table where client_id=@client_id"
            MysqlConn.Open()
            Dim COMMAND As New MySqlCommand(Str, MysqlConn)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
                    COMMAND.Parameters.AddWithValue("@client_id", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
                    COMMAND.ExecuteNonQuery()
                Next

            Else
                MessageBox.Show("Record not deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            MysqlConn.Close()
            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            id_tb.Text = ""
            name_tb.Text = ""
            ad_tb.Text = ""
            contact_tb.Text = ""
            plan_cmb.Text = ""
            DateTimePicker1.Text = ""
        End Try
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Dim inDate As DateTime = DateTimePicker1.Value ' Get selected date from DateTimePicker
        Dim inDateStr As String = inDate.ToString("yyyy-MM-dd") ' Convert to yyyy-MM-dd format
        Dim READER As MySqlDataReader
        Dim Query As String
        Try
            MysqlConn.Open()

            Query = "update isp_database.client_table set client_id='" & id_tb.Text & "', " _
                   & "client_name= '" & name_tb.Text & "', client_address= '" & ad_tb.Text & "', client_contact= '" _
                  & contact_tb.Text & "', client_plan= '" & plan_cmb.SelectedItem & "', client_install= '" & inDateStr & "'" _
                 & "where client_id= '" & id_tb.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()
            MessageBox.Show("Client information updated!")

            MysqlConn.Close()
            UpdateBill()
            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            id_tb.Text = ""
            name_tb.Text = ""
            ad_tb.Text = ""
            contact_tb.Text = ""
            plan_cmb.Text = ""
            DateTimePicker1.Text = ""
        End Try

    End Sub

    Public Sub UpdateBill()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Dim inDate As DateTime = DateTimePicker1.Value ' Get selected date from DateTimePicker
        Dim inDateStr As String = inDate.ToString("yyyy-MM-dd") ' Convert to yyyy-MM-dd format
        Dim READER As MySqlDataReader
        Dim Query As String
        Try
            MysqlConn.Open()

            Query = "update isp_database.bill_table set client_id='" & id_tb.Text & "', " _
                   & "client_name= '" & name_tb.Text & "', client_plan= '" & plan_cmb.SelectedItem & "' where client_id='" & id_tb.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub search_tb_TextChanged(sender As Object, e As EventArgs) Handles search_tb.TextChanged
        Str = "Select * from isp_database.client_table where (LOWER(client_id) like ('%" & search_tb.Text & "%') or LOWER(client_name) like ('%" & search_tb.Text & "%') or LOWER(client_address) like ('%" & search_tb.Text & "%') or LOWER(client_contact) like ('%" & search_tb.Text & "%') or LOWER(client_plan) like ('%" & search_tb.Text & "%'))"
        MysqlConn.Open()
        Dim COMMAND As New MySqlCommand(Str, MysqlConn)
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(COMMAND)
        COMMAND.ExecuteNonQuery()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        MysqlConn.Close()
    End Sub

    Private Sub back_btn1_Click(sender As Object, e As EventArgs) Handles back_btn1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub back_btn2_Click(sender As Object, e As EventArgs) Handles back_btn2.Click
        Employee.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            id_tb.Text = row.Cells("client_id").Value.ToString
            name_tb.Text = row.Cells("client_name").Value.ToString
            ad_tb.Text = row.Cells("client_address").Value.ToString
            contact_tb.Text = row.Cells("client_contact").Value.ToString
            plan_cmb.Text = row.Cells("client_plan").Value.ToString
            DateTimePicker1.Text = row.Cells("client_install").Value.ToString
        End If
    End Sub

    Private Sub gen_btn_Click(sender As Object, e As EventArgs) Handles gen_btn.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query1 As String

            Query1 = "select coalesce(max(client_id), 2023010000) as MaxID from isp_database.client_table"

            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader()

            If READER.Read AndAlso Not IsDBNull(READER("MaxID")) Then
                Dim nextId As Integer
                nextId = CInt(READER("MaxID")) + 1
                id_tb.Text = nextId

            End If

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        id_tb.Text = ""
        name_tb.Text = ""
        ad_tb.Text = ""
        contact_tb.Text = ""
        plan_cmb.Text = ""
        DateTimePicker1.Text = ""
        name_tb.Focus()
    End Sub
End Class