Imports System.ComponentModel.Design
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Net.Sockets
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud

Public Class ConnectedClients
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Str As String

    Private Sub ConnectedClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Timer1.Interval = 10000
        Timer1.Start()

        connected()


    End Sub

    Private Sub back_btn2_Click(sender As Object, e As EventArgs) Handles back_btn2.Click
        Dashboard.Show()
        Me.Hide()

    End Sub

    Public Sub connected()
        Try
            Str = "select * from isp_database.bill_table where connection = 'CONNECTED'"
            MysqlConn.Open()
            Dim Search As New MySqlDataAdapter(Str, MysqlConn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "isp_database.bill_table")
            DataGridView1.DataSource = ds.Tables("isp_database.bill_table")
            MysqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connected()
    End Sub
End Class