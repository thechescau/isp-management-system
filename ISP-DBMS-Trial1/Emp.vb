Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Drawing.Printing
Imports Mysqlx
Imports Mysqlx.Crud
Imports Org.BouncyCastle.Asn1

Public Class Emp
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Str As String

    Private Sub back_btn1_Click(sender As Object, e As EventArgs) Handles back_btn1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "insert into isp_database.emp_table " _
                & "(employee_name, username, password) " _
                & "values ('" & name_tb.Text & "', '" _
                & un_tb.Text & "', '" & pw_tb.Text & "')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Employee Added!")

            MysqlConn.Close()
            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            id_tb.Text = ""
            name_tb.Text = ""
            un_tb.Text = ""
            pw_tb.Text = ""
        End Try
    End Sub

    Private Sub Emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "select * from isp_database.emp_table"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

        Display_Table()

    End Sub

    Public Sub Display_Table()
        Try
            Str = "select * from isp_database.emp_table"
            MysqlConn.Open()
            Dim Search As New MySqlDataAdapter(Str, MysqlConn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "isp_database.emp_table")
            DataGridView1.DataSource = ds.Tables("isp_database.emp_table")
            MysqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try

    End Sub

    Private Sub back_btn2_Click_1(sender As Object, e As EventArgs) Handles back_btn2.Click
        Employee.Show()
        Me.Hide()
    End Sub

    Private Sub user_cmb_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Try
            Str = "Delete from isp_database.emp_table where user_id=@user_id"
            Dim COMMAND As New MySqlCommand(Str, MysqlConn)
            MysqlConn.Open()
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
                    COMMAND.Parameters.AddWithValue("@user_id", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
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
            id_tb.Text = ""
            name_tb.Text = ""
            un_tb.Text = ""
            pw_tb.Text = ""
        End Try

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click

        Try
            MysqlConn.Open()
            COMMAND.Connection = MysqlConn
            COMMAND.CommandText = "update isp_database.emp_table set user_id='" & id_tb.Text & "', " _
                   & "employee_name= '" & name_tb.Text & "', username= '" & un_tb.Text & "', password= '" _
                  & pw_tb.Text & "' where user_id= '" & id_tb.Text & "'"
            COMMAND.ExecuteNonQuery()
            MysqlConn.Close()
            MsgBox("Account Updated")
            Display_Table()
            id_tb.Clear()
            name_tb.Clear()
            un_tb.Clear()
            pw_tb.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            id_tb.Text = row.Cells("user_id").Value.ToString
            name_tb.Text = row.Cells("employee_name").Value.ToString
            un_tb.Text = row.Cells("username").Value.ToString
            pw_tb.Text = row.Cells("password").Value.ToString
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles search_tb.TextChanged
        Str = "Select * from isp_database.emp_table where (LOWER(user_id) like ('%" & search_tb.Text & "%') or LOWER(employee_name) like ('%" & search_tb.Text & "%') or LOWER(username) like ('%" & search_tb.Text & "%') or LOWER(password) like ('%" & search_tb.Text & "%'))"
        MysqlConn.Open()
        Dim COMMAND As New MySqlCommand(Str, MysqlConn)
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(COMMAND)
        COMMAND.ExecuteNonQuery()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        MysqlConn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id_tb.Text = ""
        name_tb.Text = ""
        un_tb.Text = ""
        pw_tb.Text = ""
        name_tb.Focus()
    End Sub
End Class