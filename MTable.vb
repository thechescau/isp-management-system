Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class MTable
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub View_Monthly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Display_Table()
    End Sub

    Public Sub Display_Table()
        Try
            Dim Str As String
            Str = "select * from isp_database.monthly_table"
            MysqlConn.Open()
            Dim Search As New MySqlDataAdapter(Str, MysqlConn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "isp_database.monthly_table")
            DataGridView1.DataSource = ds.Tables("isp_database.monthly_table")
            MysqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub back_btn2_Click_1(sender As Object, e As EventArgs) Handles back_btn2.Click
        Bills.Show()
        Me.Hide()
    End Sub

    Private Sub back_btn1_Click(sender As Object, e As EventArgs) Handles back_btn1.Click
        Bills.Show()
        Me.Hide()
    End Sub

    Public Sub PrintMonthly()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.Show()
    End Sub

    Private mr As Integer = 0
    Private np As Boolean = True

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("MONTHLY PAYMENT REPORT", New Font("Calibri", 20, FontStyle.Bold), Brushes.Black, New Point(400, 20), format)

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.Alignment = StringAlignment.Center


        Dim y As Integer = 100
        Dim x As Integer = 80
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow
        If np Then
            row = DataGridView1.Rows(mr)

            x = 80
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, DataGridView1.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        np = False
        Dim displayNow As Integer
        For displayNow = mr To DataGridView1.RowCount - 1
            row = DataGridView1.Rows(displayNow)
            x = 80
            h = 0

            For Each Cell As DataGridViewCell In row.Cells
                If Cell.Visible Then
                    rc = New Rectangle(x, y, Cell.Size.Width, Cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)

                    e.Graphics.DrawString(Cell.FormattedValue.ToString(), DataGridView1.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        Next
    End Sub

    Public Sub ClearAmount()
        Dim MysqlConn As New MySqlConnection()
        MysqlConn.ConnectionString = "server = localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader
        Dim Query As String
        Try
            MysqlConn.Open()
            Query = "update bill_table set amount = NULL where amount is not null"

            Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader()
            READER.Close()
            READER.Dispose()

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub ClearDate()
        Dim MysqlConn1 As New MySqlConnection()
        MysqlConn1.ConnectionString = "server = localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try

            MysqlConn1.Open()
            Dim Query1 As String
            Query1 = "update bill_table set date = NULL where date is not null"

            Command = New MySqlCommand(Query1, MysqlConn1)
            READER = Command.ExecuteReader()
            READER.Close()
            READER.Dispose()

            MysqlConn1.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn1.Dispose()
        End Try
    End Sub

    Public Sub ClearBilln1()
        Dim MysqlConn2 As New MySqlConnection()
        MysqlConn2.ConnectionString = "server = localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader
        Dim Query As String
        Try
            MysqlConn2.Open()
            Query = "update monthly_table set bill_no = NULL where bill_no is not null"

            Command = New MySqlCommand(Query, MysqlConn2)
            READER = Command.ExecuteReader()
            READER.Close()
            READER.Dispose()

            MysqlConn2.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn2.Dispose()
        End Try
    End Sub

    Public Sub ClearDate1()
        Dim MysqlConn1 As New MySqlConnection()
        MysqlConn1.ConnectionString = "server = localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try

            MysqlConn1.Open()
            Dim Query1 As String
            Query1 = "update monthly_table set date_paid = NULL where date_paid is not null"

            Command = New MySqlCommand(Query1, MysqlConn1)
            READER = Command.ExecuteReader()
            READER.Close()
            READER.Dispose()

            MysqlConn1.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn1.Dispose()
        End Try
    End Sub

    Public Sub ClearAmount1()
        Dim MysqlConn As New MySqlConnection()
        MysqlConn.ConnectionString = "server = localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader
        Dim Query As String
        Try
            MysqlConn.Open()
            Query = "update monthly_table set amount_paid = NULL where amount_paid is not null"

            Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader()
            READER.Close()
            READER.Dispose()

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateTime.Now.Day = 1 Then
            ClearBilln1()
            ClearDate1()
            ClearAmount1()
            Display_Table()
        ElseIf DateTime.Now.Day = 28 Then
            MessageBox.Show("Time to print this month's billing details...")
            PrintMonthly()

        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        Display_Table()
    End Sub

    Private Sub prnt_btn_Click(sender As Object, e As EventArgs) Handles prnt_btn.Click
        PrintMonthly()
    End Sub
End Class