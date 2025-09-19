Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports Org.BouncyCastle.Crypto.Parameters
Imports System.Security.Cryptography
Imports System.Threading
Imports Org.BouncyCastle.Math

Public Class Bills
    Dim MysqlConn As MySqlConnection
    Dim MysqlConn2 As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private previousRowCount As Integer = 0

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; ConnectionTimeout=30"
        MysqlConn.Open()

        Dim Query As String
        Query = "SELECT * FROM isp_database.bill_table"
        Command = New MySqlCommand(Query, MysqlConn)

        Dim dt As New DataTable
        dt.Clear()
        DataGridView1.DataSource = dt

        Using da As New MySqlDataAdapter(Command)
            da.Fill(dt)
            previousRowCount = dt.Rows.Count
        End Using
        MysqlConn.Close()
        Timer1.Enabled = True

        Timer1.Interval = 1000
        Timer1.Stop()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Start()

    End Sub

    Private Function CheckForNewData() As Boolean
        Dim MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        MysqlConn.Open()

        Dim Query As String = "SELECT COUNT(*) FROM isp_database.bill_table"
        Command = New MySqlCommand(Query, MysqlConn)

        Dim dt As New DataTable
        dt.Clear()
        Using da As New MySqlDataAdapter(Command)
            da.Fill(dt)
        End Using

        Dim currentRowCount As Integer = dt.Rows(0)(0)

        If currentRowCount > previousRowCount Then
            previousRowCount = currentRowCount
            Return True
        End If

        Return False
        MysqlConn.Close()
        MysqlConn.Dispose()
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        date_txt.Text = Date.Now.ToString("MM-dd-yyyy hh:mm:ss")
        ' Check if new data has been inserted
        If CheckForNewData() Then
            UpdateStatusToUnpaid()
            UpdateDateDue()
            UpdateConnection()
            CheckUnpaidCustomers()
            UpdatePenalty()
        End If

        Timer1.Stop()
        Timer1.Start()
    End Sub

    Public Sub CheckUnpaidCustomers()
        Dim MysqlConn As MySqlConnection = New MySqlConnection()
        Dim selectCommand As MySqlCommand
        Dim READER As MySqlDataReader

        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; "

        ' Get current date
        Dim currentDate As DateTime = DateTime.Now

        ' Calculate due date as 28th day of the current month
        Dim dueDate As DateTime = New DateTime(currentDate.Year, currentDate.Month, 15)

        Try
            MysqlConn.Open()

            ' Create SQL SELECT statement
            Dim selectQuery As String = "SELECT client_id, amount, date_due, status FROM isp_database.bill_table WHERE status = 'UNPAID' AND date > @date_due"

            ' Create command object
            selectCommand = New MySqlCommand(selectQuery, MysqlConn)
            selectCommand.Parameters.AddWithValue("@date_due", dueDate)

            ' Execute the SELECT statement
            READER = selectCommand.ExecuteReader()

            ' Iterate through the records
            While READER.Read()
                Dim cid As Integer = READER("client_id")
                Dim amount As Single = If(Not Convert.IsDBNull(READER("amount")), Convert.ToSingle(READER("amount")), 0)
                Dim status As String = If(Not Convert.IsDBNull(READER("status")), Convert.ToString(READER("status")), "")
                Dim penaltyAmount As Single = If(status = "UNPAID" AndAlso currentDate > dueDate, Math.Round(amount * 0.2, 2), 0)

                ' Debugging statements
                Console.WriteLine($"Client ID: {cid}, Amount: {amount}, Penalty Amount: {penaltyAmount}, Current Date: {currentDate}, Due Date: {dueDate}")

                ' Update penalty and total amount using the same connection
                Dim updateQuery As String = "UPDATE isp_database.bill_table SET penalty = @penalty WHERE client_id = @client_id"
                Dim updateCommand As New MySqlCommand(updateQuery, MysqlConn)
                updateCommand.Parameters.AddWithValue("@penalty", penaltyAmount)
                updateCommand.Parameters.AddWithValue("@client_id", cid)
                updateCommand.ExecuteNonQuery()
            End While

        Catch ex As Exception
            ' Handle exceptions here
            Console.WriteLine("Error: " & ex.Message)

        Finally
            ' Close the reader and the database connection
            If READER IsNot Nothing Then READER.Close()
            If MysqlConn.State = ConnectionState.Open Then MysqlConn.Close()
        End Try
    End Sub

    Public Sub TotalAmt()
        Dim MysqlConn1 As MySqlConnection = New MySqlConnection()
        Dim MysqlConn2 As MySqlConnection = New MySqlConnection()
        Dim selectCommand As MySqlCommand
        Dim updateCommand As MySqlCommand
        Dim READER As MySqlDataReader

        MysqlConn1.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; "
        MysqlConn2.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; "

        Dim currentDate As DateTime = DateTime.Now

        Dim dueDate As DateTime = New DateTime(currentDate.Year, currentDate.Month, 15)

        MysqlConn1.Open()
        MysqlConn2.Open()

        Dim selectQuery As String = "SELECT client_id, amount, date_due FROM isp_database.bill_table WHERE client_id= '" & cid_tb.Text & "'"

        selectCommand = New MySqlCommand(selectQuery, MysqlConn1)
        selectCommand.Parameters.AddWithValue("@date_due", dueDate)

        READER = selectCommand.ExecuteReader()

        While READER.Read()
            Dim cid As Integer = READER("client_id")
            Dim amount As Decimal = 0

            If Not Convert.IsDBNull(READER("amount")) Then
                amount = Convert.ToDecimal(READER("amount"))
            End If

            Dim penaltyAmount As Decimal = 0
            Dim totalAmount As Decimal

            If currentDate <= dueDate Then
                totalAmount = amount
            Else
                penaltyAmount = amount * 0.2
                totalAmount = amount + penaltyAmount
            End If
            Dim updateQuery As String = "UPDATE isp_database.monthly_table SET amount_paid=@amount_paid WHERE client_id = @client_id"

            ' Create command object
            updateCommand = New MySqlCommand(updateQuery, MysqlConn2)
            updateCommand.Parameters.AddWithValue("@amount_paid", totalAmount)
            updateCommand.Parameters.AddWithValue("@client_id", cid)

            ' Execute the UPDATE statement
            updateCommand.ExecuteNonQuery()
        End While

        ' Close the reader and the database connections
        READER.Close()
        MysqlConn1.Close()
        MysqlConn2.Close()
    End Sub

    Private Sub UpdateStatusToUnpaid()
        Dim Conn1 As MySqlConnection = New MySqlConnection()
        Conn1.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; "
        Try
            Conn1.Open()
            Dim READER As MySqlDataReader
            Dim Query As String
            Query = "UPDATE isp_database.bill_table SET status = 'UNPAID' where status IS NULL"
            Command = New MySqlCommand(Query, Conn1)
            READER = Command.ExecuteReader()
            Conn1.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Conn1.Dispose()
        End Try
    End Sub

    Private Sub UpdateConnection()
        Dim Conn2 As MySqlConnection = New MySqlConnection()
        Conn2.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; "
        Try
            Conn2.Open()
            Dim READER As MySqlDataReader
            Dim Query As String
            Query = "UPDATE isp_database.bill_table SET connection = 'CONNECTED' where connection = 'CONNECTED' OR connection is null"
            Command = New MySqlCommand(Query, Conn2)
            READER = Command.ExecuteReader()
            Conn2.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Conn2.Dispose()
        End Try
    End Sub

    Private Sub UpdateDateDue()
        Dim Conn2 As MySqlConnection = New MySqlConnection()
        Conn2.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; "
        Try
            Conn2.Open()
            Dim READER As MySqlDataReader
            Dim currentDate As DateTime = DateTime.Now
            Dim dueDate As DateTime = New DateTime(currentDate.Year, currentDate.Month, 15)
            Dim due As String = dueDate.ToString("yyyy-MM-dd") ' Convert to yyyy-MM-dd format
            Dim Query As String
            Query = "UPDATE isp_database.bill_table SET date_due = '" & due & "'"
            Command = New MySqlCommand(Query, Conn2)
            READER = Command.ExecuteReader()
            Conn2.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Conn2.Dispose()
        End Try
    End Sub


    Public Sub GenerateBillNo()
        Dim MysqlConn1 As New MySqlConnection()
        MysqlConn1.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn1.Open()
            Dim Query1 As String

            Query1 = "select concat
            (23,lpad(floor(rand()*1000000),6,'0')) as MaxID from isp_database.monthly_table"

            Command = New MySqlCommand(Query1, MysqlConn1)
            READER = Command.ExecuteReader()

            If READER.Read AndAlso Not IsDBNull(READER("MaxID")) Then
                Dim nextId As Integer
                nextId = Convert.ToInt64((READER("MaxID")))
                id_tb.Text = nextId

            End If

            MysqlConn1.Close()

        Catch ex As OverflowException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn1.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles paid_btn.Click
        Dim MysqlConn As New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=isp_database"

        Try
            MysqlConn.Open()

            ' Check if the user is already disconnected
            Dim queryCheckDisconnected As String = "SELECT connection FROM bill_table WHERE client_id=@ClientId"
            Using cmdCheckDisconnected As New MySqlCommand(queryCheckDisconnected, MysqlConn)
                cmdCheckDisconnected.Parameters.AddWithValue("@ClientId", cid_tb.Text)
                Dim connectionStatus As String = cmdCheckDisconnected.ExecuteScalar()?.ToString()

                ' If the user is disconnected, show a message and exit the function
                If connectionStatus = "DISCONNECTED" Then
                    MessageBox.Show("This user is already disconnected and cannot be paid.")
                    Return
                End If
            End Using

            ' If the user is not disconnected, proceed with updating the bill status to "PAID"
            Dim inDate As DateTime = DateTimePicker1.Value ' Get selected date from DateTimePicker
            Dim inDateStr As String = inDate.ToString("yyyy-MM-dd") ' Convert to yyyy-MM-dd format
            Dim Query As String

            Query = "UPDATE bill_table SET status= 'PAID', date= @Date, total_amount=amount+penalty, bill_no=@BillNo WHERE client_id= @ClientId"
            Using Command As New MySqlCommand(Query, MysqlConn)
                Command.Parameters.AddWithValue("@Date", inDateStr)
                Command.Parameters.AddWithValue("@BillNo", id_tb.Text)
                Command.Parameters.AddWithValue("@ClientId", cid_tb.Text)
                Command.ExecuteNonQuery()
            End Using

            Dim cid As String = cid_tb.Text.ToString()
            MessageBox.Show("CUSTOMER " & cid & " PAID!")

            ' Remaining code...
            Dim totalAmount As Decimal = 0 ' Initialize totalAmount variable
            ' Calculate total amount with penalty
            If penalty <> "" AndAlso total <> "" Then
                Dim penaltyAmount As Decimal = Convert.ToDecimal(penalty)
                Dim currentTotal As Decimal = Convert.ToDecimal(total)
                totalAmount = currentTotal + penaltyAmount
            End If

            ' Display penalty and total amount (for debugging)
            MessageBox.Show($"Penalty: {penalty}, Total Amount: {totalAmount}")

            ' Existing code...
            StoreBill()
            UpdateMonthly()
            TotalAmt()

            MysqlConn.Close()
            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            cid_tb.Text = ""
            name_tb.Text = ""
            plan_tb.Text = ""
            price_tb.Text = ""
        End Try
    End Sub



    Public Sub StoreBill()
        MysqlConn2 = New MySqlConnection()
        MysqlConn2.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Dim cid As String = cid_tb.Text.ToString()

        MysqlConn2.Open()

        Dim Query As String
        Query = "select bill_no from isp_database.bill_table where client_id = @client_id"
        Command = New MySqlCommand(Query, MysqlConn2)
        Command.Parameters.AddWithValue("@client_id", cid)

        Dim adapter As New MySqlDataAdapter(Command)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim bid As Integer = id_tb.Text
            Dim updateQuery As String = "update isp_database.monthly_table set bill_no = @bill_no where client_id = @client_id "
            Dim updateCommand As New MySqlCommand(updateQuery, MysqlConn2)

            updateCommand.Parameters.AddWithValue("@bill_no", bid)
            updateCommand.Parameters.AddWithValue("@client_id", cid)
            updateCommand.ExecuteNonQuery()

        End If
        MysqlConn2.Close()
        MysqlConn2.Dispose()
    End Sub

    Public Sub UpdateMonthly()
        Dim MysqlConn1 As New MySqlConnection()
        MysqlConn1.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Try
            MysqlConn1.Open()

            Dim Query As String
            Dim Command As MySqlCommand
            Dim Reader As MySqlDataReader
            Dim inDate As DateTime = DateTimePicker1.Value ' Get selected date from DateTimePicker
            Dim inDateStr As String = inDate.ToString("yyyy-MM-dd") ' Convert to yyyy-MM-dd format

            Query = "update isp_database.monthly_table set date_paid= '" & inDateStr & "' where client_id= '" & cid_tb.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn1)
            Reader = Command.ExecuteReader()
            Reader.Close()
            Reader.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn1.Dispose()
        End Try
    End Sub

    Public Sub Display_Table()
        Try
            Dim Str As String
            Str = "select * from isp_database.bill_table ORDER BY connection ASC"
            MysqlConn.Open()
            Dim da As New MySqlDataAdapter(Str, MysqlConn)
            Dim ds As DataSet = New DataSet
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        Display_Table()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            cid_tb.Text = row.Cells("client_id").Value.ToString
            name_tb.Text = row.Cells("client_name").Value.ToString
            plan_tb.Text = row.Cells("client_plan").Value.ToString
            price_tb.Text = row.Cells("amount").Value.ToString
            penalty = row.Cells("penalty").Value.ToString
            due = row.Cells("date_due").Value.ToString
            total = row.Cells("total_amount").Value.ToString
            id_tb.Text = row.Cells("bill_no").Value.ToString
            'bill_tb.Text = row.Cells("bill_id").Value.ToString
            'DateTimePicker1.Text = row.Cells("client_install").Value.ToString
        End If
    End Sub

    Private Sub back_btn2_Click(sender As Object, e As EventArgs) Handles back_btn2.Click
        Employee.Show()
        Me.Hide()
    End Sub

    Private Sub print_btn_Click(sender As Object, e As EventArgs) Handles print_btn.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()  'Direct Print
    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Dim penalty As String
    Dim bill As String
    Dim due As String
    Dim total As String

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 200
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------"

        e.Graphics.DrawString("Net 4G XPRESS", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("BULACAN, PHILIPPINES", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("NO. +639959625545", f10, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(id_tb.Text, f8, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Acc no", f8, Brushes.Black, 0, 80)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 80)
        e.Graphics.DrawString(cid_tb.Text, f8, Brushes.Black, 70, 80)

        e.Graphics.DrawString("Date", f8, Brushes.Black, 0, 100)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 100)
        e.Graphics.DrawString(DateTimePicker1.Text, f8, Brushes.Black, 70, 100)

        e.Graphics.DrawString("Due Date", f8, Brushes.Black, 0, 110)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 110)
        e.Graphics.DrawString(due, f8, Brushes.Black, 70, 110)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 130)

        e.Graphics.DrawString("Client Name", f8, Brushes.Black, 0, 140)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 140)
        e.Graphics.DrawString(name_tb.Text, f8, Brushes.Black, 70, 140)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 150)

        e.Graphics.DrawString("Plan", f8, Brushes.Black, 0, 180)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 180)
        e.Graphics.DrawString(plan_tb.Text, f8, Brushes.Black, 70, 180)

        e.Graphics.DrawString("Price", f8, Brushes.Black, 0, 200)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 200)
        e.Graphics.DrawString(price_tb.Text, f8, Brushes.Black, 70, 200)

        e.Graphics.DrawString("Penalty", f8, Brushes.Black, 0, 210)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 210)
        e.Graphics.DrawString(penalty, f8, Brushes.Black, 70, 210)

        e.Graphics.DrawString("__________________________", f8, Brushes.Black, 0, 210)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 150)

        e.Graphics.DrawString("Total", f8, Brushes.Black, 0, 220)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 220)
        e.Graphics.DrawString(total, f8, Brushes.Black, 70, 220)

    End Sub

    Private Sub view_btn_Click(sender As Object, e As EventArgs) Handles view_btn.Click
        MTable.Show()
        Me.Hide()
    End Sub

    Private Sub disconn_btn_Click(sender As Object, e As EventArgs) Handles disconn_btn.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim inDate As DateTime = DateTimePicker1.Value ' Get selected date from DateTimePicker
            Dim inDateStr As String = inDate.ToString("yyyy-MM-dd") ' Convert to yyyy-MM-dd format
            Dim Query As String

            Query = "update isp_database.bill_table set connection='DISCONNECTED' where client_id= '" & cid_tb.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            Dim cid As String = cid_tb.Text.ToString()
            MessageBox.Show("CUSTOMER WITH ID:" & cid & "IS NOW DISCONNECTED.")

            MysqlConn.Close()

            Display_Table()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            cid_tb.Text = ""
            name_tb.Text = ""
            plan_tb.Text = ""
            price_tb.Text = ""
        End Try
    End Sub







    Private Sub gen_btn_Click(sender As Object, e As EventArgs) Handles gen_btn.Click
        GenerateBillNo()
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

    Public Sub ClearBilln()
        Dim MysqlConn2 As New MySqlConnection()
        MysqlConn2.ConnectionString = "server = localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader
        Dim Query As String
        Try
            MysqlConn2.Open()
            Query = "update bill_table set bill_no = NULL where bill_no is not null"

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


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If DateTime.Now.Day = 1 Then
            ClearDate()
            ClearAmount()
            ClearBilln()
            Display_Table()
        ElseIf DateTime.Now.Day = 1 Then
            MessageBox.Show("Time to print this month's billing details...")
            MTable.Show()
            MTable.prnt_btn.PerformClick()
        End If
    End Sub

    Private Sub prnt_btn_Click(sender As Object, e As EventArgs) Handles prnt_btn.Click
        MTable.Show()
        MTable.prnt_btn.PerformClick()
    End Sub

    Public Sub InsertBillFromPlan(ByVal Plan_ID As Integer)
        Dim price As Decimal = GetPriceFromPlan(Plan_ID)

        Using MysqlConn As New MySqlConnection("server=localhost;userid=root;password=root;database=isp_database")
            MysqlConn.Open()

            Dim query As String = "INSERT INTO Bill (amount) VALUES (" & price & ")"
            Using command As New MySqlCommand(query, MysqlConn)
                command.Parameters.AddWithValue("@Price", price)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function GetPriceFromPlan(ByVal Plan_ID As Integer) As Decimal
        Dim price As Decimal = 0

        Using MysqlConn As New MySqlConnection("server=localhost;userid=root;password=root;database=isp_database")
            MysqlConn.Open()

            Dim query As String = "SELECT Price FROM Plan WHERE Plan_ID = @Plan_ID"
            Using command As New MySqlCommand(query, MysqlConn)
                command.Parameters.AddWithValue("@Plan_ID", Plan_ID)
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    price = Convert.ToDecimal(result)
                End If
            End Using
        End Using

        Return price
    End Function

    Private Sub UpdatePenalty()
        Dim Conn2 As MySqlConnection = New MySqlConnection()
        Conn2.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database; "
        Try
            Conn2.Open()
            Dim READER As MySqlDataReader
            'Dim currentDate As DateTime = DateTime.Now
            'Dim dueDate As DateTime = New DateTime(currentDate.Year, currentDate.Month, 15)
            'Dim due As String = dueDate.ToString("yyyy-MM-dd") ' Convert to yyyy-MM-dd format
            Dim Query As String
            Query = "UPDATE isp_database.bill_table SET penalty = CASE WHEN date_due < NOW() AND status = 'UNPAID' THEN amount * 0.20 ELSE 0 END"
            Command = New MySqlCommand(Query, Conn2)
            READER = Command.ExecuteReader()
            Conn2.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Conn2.Dispose()
        End Try
    End Sub

    Private Sub date_txt_Click(sender As Object, e As EventArgs) Handles date_txt.Click

    End Sub
End Class