Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud

Public Class Plan
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Str As String

    Private Sub Plan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Try
            MysqlConn.Open()
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Display_Table()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles create_btn.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "insert into isp_database.plan_table " _
                & "(Plan_Name, Speed, Category, Price) " _
                & "values ('" & name_tb.Text & "', '" _
                & speed_tb.Text & "', '" & categ_cmb.SelectedItem & "', '" & price_tb.Text & "')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Plan Saved!")

            MysqlConn.Close()

            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            name_tb.Text = ""
            speed_tb.Text = ""
            categ_cmb.Text = ""
            price_tb.Text = ""

            Display_Table()
        End Try
    End Sub
    Public Sub Display_Table()
        Try
            Str = "select * from isp_database.plan_table"
            MysqlConn.Open()
            Dim Search As New MySqlDataAdapter(Str, MysqlConn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "isp_database.plan_table")
            DataGridView1.DataSource = ds.Tables("isp_database.plan_table")
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
            Str = "Delete from isp_database.plan_table where Plan_ID=@Plan_ID"
            MysqlConn.Open()
            Dim COMMAND As New MySqlCommand(Str, MysqlConn)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
                    COMMAND.Parameters.AddWithValue("@Plan_ID", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
                    COMMAND.ExecuteNonQuery()
                Next

            Else
                MessageBox.Show("Record not deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            MysqlConn.Close()
            Display_Table()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
            planid_tb.Text = ""
            name_tb.Text = ""
            speed_tb.Text = ""
            categ_cmb.Text = ""
            price_tb.Text = ""
        End Try

    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub search_tb_TextChanged(sender As Object, e As EventArgs) Handles search_tb.TextChanged
        Str = "select * from isp_database.plan_table where Plan_Name Like '%" & search_tb.Text & "%'"
        MysqlConn.Open()
        Dim COMMAND As New MySqlCommand(Str, MysqlConn)
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(COMMAND)
        COMMAND.ExecuteNonQuery()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        MysqlConn.Close()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click

        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader
        Dim Query As String
        Try
            MysqlConn.Open()

            Query = "update isp_database.plan_table set Plan_ID='" & planid_tb.Text & "', " _
                   & "Plan_Name= '" & name_tb.Text & "', Speed= '" & speed_tb.Text & "', Category= '" _
                  & categ_cmb.SelectedItem & "', Price= '" & price_tb.Text & "' where Plan_ID= '" & planid_tb.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()
            MessageBox.Show("Plan modification successful!")

            MysqlConn.Close()
            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            planid_tb.Text = ""
            name_tb.Text = ""
            speed_tb.Text = ""
            categ_cmb.Text = ""
            price_tb.Text = ""
        End Try

    End Sub

    Private Sub back_btn2_Click(sender As Object, e As EventArgs)
        Employee.Show()
        Me.Hide()
    End Sub

    Private Sub back_btn2_Click_1(sender As Object, e As EventArgs) Handles back_btn2.Click
        Employee.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            planid_tb.Text = row.Cells("Plan_ID").Value.ToString
            name_tb.Text = row.Cells("Plan_Name").Value.ToString
            speed_tb.Text = row.Cells("Speed").Value.ToString
            categ_cmb.Text = row.Cells("Category").Value.ToString
            price_tb.Text = row.Cells("Price").Value.ToString
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles clear_btn.Click
        planid_tb.Text = ""
        name_tb.Text = ""
        speed_tb.Text = ""
        categ_cmb.Text = ""
        price_tb.Text = ""
        name_tb.Focus()
    End Sub
End Class