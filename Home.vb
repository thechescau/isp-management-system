Imports System.CodeDom
Imports System.Windows
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class Home
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim MysqlSda As MySqlDataAdapter
    Dim datatable As DataTable

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader
        Try
            Dim role As String = urole_cmb.SelectedItem.ToString()


            If String.IsNullOrEmpty(role) Then
                MessageBox.Show("Please select a user type.")
                Return
            End If

            Dim username As String = uname_tb.Text
            Dim password As String = pword_tb.Text

            If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
                MessageBox.Show("Please enter your username and password.")
                Return
            End If

            Dim redirectForm As Form
            Dim Query As String
            If role = "admin" Then
                Query = "select username from admin_table where username = '" & uname_tb.Text & "' AND password = '" & pword_tb.Text & "'"
                MessageBox.Show("You are logged in as ADMIN")
                redirectForm = Admin
            ElseIf role = "employee" Then
                Query = "select username from emp_table where username = '" & uname_tb.Text & "' AND password = '" & pword_tb.Text & "'"
                MessageBox.Show("You are logged in as EMPLOYEE")
                redirectForm = Employee
            End If

            MysqlConn = New MySqlConnection()
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

            MysqlConn.Open()
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@username", username)
            COMMAND.Parameters.AddWithValue("@password", password)
            READER = COMMAND.ExecuteReader

            If READER.HasRows() Then
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While

                If count = 1 Then
                    MessageBox.Show("Username & Password are correct!")
                    Me.Hide()
                    redirectForm.Show()
                ElseIf count > 1 Then
                    MessageBox.Show("Username & Password are duplicated!")
                Else
                    MessageBox.Show("Username & Password are incorrect!")
                End If

            Else
                MessageBox.Show("Invalid username and password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
            uname_tb.Text = ""
            pword_tb.Text = ""
            urole_cmb.Text = ""
        End Try
    End Sub

    Private Sub urole_cmb_KeyUp(sender As Object, e As KeyEventArgs) Handles urole_cmb.KeyUp
        urole_cmb.SelectedIndex = urole_cmb.FindStringExact(urole_cmb.Text)
    End Sub

    Private Sub urole_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles urole_cmb.SelectedIndexChanged
        If urole_cmb.SelectedItem.ToString = "admin" Then
            Client.back_btn1.Visible = True
            Bills.back_btn1.Visible = True
            Plan.back_btn1.Visible = True
            Emp.back_btn1.Visible = True
            Ad.back_btn1.Visible = True
            Dashboard.back_btn1.Visible = True
            MTable.back_btn1.Visible = True
            Client.back_btn2.Visible = False
            Bills.back_btn2.Visible = False
            Plan.back_btn2.Visible = False
            Emp.back_btn2.Visible = False
            Ad.back_btn2.Visible = False
            MTable.back_btn2.Visible = False
            Dashboard.back_btn2.Visible = False

        ElseIf urole_cmb.SelectedItem.ToString = "employee" Then
            Client.back_btn1.Visible = False
            Bills.back_btn1.Visible = False
            Plan.back_btn1.Visible = False
            Emp.back_btn1.Visible = False
            Ad.back_btn1.Visible = False
            MTable.back_btn1.Visible = False
            Dashboard.back_btn1.Visible = False
            Client.back_btn2.Visible = True
            Bills.back_btn2.Visible = True
            Plan.back_btn2.Visible = True
            Emp.back_btn2.Visible = True
            Ad.back_btn2.Visible = True
            MTable.back_btn2.Visible = True
            Dashboard.back_btn2.Visible = True
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
