Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
    Imports System.Threading
    Imports System.Transactions
    Imports System.Windows.Forms.DataVisualization.Charting
    Imports System.Windows.Forms.VisualStyles.VisualStyleElement
    Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
    Imports System.Windows.Input
    Imports Google.Protobuf.WellKnownTypes
    Imports MySql.Data.MySqlClient
    Imports Mysqlx
    Imports Mysqlx.XDevAPI
    Imports Org.BouncyCastle.Asn1.X509


    Public Class Dashboard
        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        Dim Str As String
    Dim READER As MySqlDataReader

    Private Sub back_btn2_Click(sender As Object, e As EventArgs) Handles back_btn2.Click
        Employee.Show()
        Me.Hide()
    End Sub


    Public Sub totalcount()
        Dim MysqlConn As New MySqlConnection
        Dim Tclient As New MySqlCommand

        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"


        Try
            MysqlConn.Open()
            Dim TotalC As String = "SELECT count(*) FROM isp_database.client_table"
            Tclient = New MySqlCommand(TotalC, MysqlConn)
            ' plan1 = New MySqlCommand(planU, MysqlConn)
            Dim clientcount As Double
            'Dim p1count As Double
            clientcount = Tclient.ExecuteScalar
            MysqlConn.Close()
            tc.Text = clientcount
            'dplan1.Text = p1count
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Public Sub Paid()
        Dim MysqlConn As New MySqlConnection
        Dim Tclient As New MySqlCommand


        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        MysqlConn.Open()

        Try

            Dim p1tC As String = "SELECT count(*) FROM isp_database.bill_table WHERE status = 'PAID' AND connection = 'CONNECTED' "
            Tclient = New MySqlCommand(p1tC, MysqlConn)
            Dim clientcount As Double
            clientcount = Tclient.ExecuteScalar


            pc.Text = clientcount

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        MysqlConn.Close()
    End Sub

    Public Sub unpaid()
        Dim MysqlConn As New MySqlConnection
        Dim Tclient As New MySqlCommand


        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        MysqlConn.Open()

        Try

            Dim p1tC As String = "SELECT count(*) FROM isp_database.bill_table WHERE status = 'UNPAID' AND connection = 'CONNECTED' "
            Tclient = New MySqlCommand(p1tC, MysqlConn)
            Dim clientcount As Double
            clientcount = Tclient.ExecuteScalar


            upc.Text = clientcount

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        MysqlConn.Close()
    End Sub

    Public Sub totalE()
        Dim MysqlConn1 As New MySqlConnection()
        MysqlConn1.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"
        Dim READER As MySqlDataReader
        Dim totalE As Decimal = 0

        Try
            MysqlConn1.Open()
            Dim Query1 As String

            Query1 = "Select SUM(total_amount) from isp_database.bill_table"
            COMMAND = New MySqlCommand(Query1, MysqlConn1)
            READER = COMMAND.ExecuteReader()
            If READER.Read() Then
                If Not READER.IsDBNull(0) Then
                    totalE = READER.GetDecimal(0)
                End If
            End If

            te.Text = totalE

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Public Sub connected()
        Dim MysqlConn As New MySqlConnection
        Dim Tclient As New MySqlCommand


        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"



        Try
            MysqlConn.Open()
            Dim connC As String = "SELECT count(*) FROM isp_database.bill_table WHERE connection = 'CONNECTED' "
            Tclient = New MySqlCommand(connC, MysqlConn)
            Dim clientcount As Double
            clientcount = Tclient.ExecuteScalar


            cc.Text = clientcount

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        MysqlConn.Close()
    End Sub

    Public Sub disconnected()
        Dim MysqlConn As New MySqlConnection
        Dim Tclient As New MySqlCommand


        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        MysqlConn.Open()

        Try

            Dim connC As String = "SELECT count(*) FROM isp_database.bill_table WHERE connection= 'DISCONNECTED' "
            Tclient = New MySqlCommand(connC, MysqlConn)
            Dim clientcount As Double
            clientcount = Tclient.ExecuteScalar


            ncc.Text = clientcount

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        MysqlConn.Close()
    End Sub

    Public Sub planusers()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        MysqlConn.Open()

        Dim Query As String = "Select client_plan, count(*) as total from bill_table group by client_plan"
        Dim adapter As New MySqlDataAdapter(Query, MysqlConn)
        Dim dataset As New DataSet()
        adapter.Fill(dataset)
        Chartx.DataSource = dataset.Tables(0)
        Chartx.Series("Series1").ChartType = SeriesChartType.Column
        Chartx.Series("Series1").XValueMember = "client_plan"
        Chartx.Series("Series1").YValueMembers = "total"

        Chartx.ChartAreas(0).AxisX.Title = "Plan"
        Chartx.ChartAreas(0).AxisY.Title = "No. of Users"


        MysqlConn.Close()


    End Sub
    Public Sub paidunpaid()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        MysqlConn.Open()

        Dim Query As String = "Select status, count(*) as t from bill_table WHERE connection = 'CONNECTED' GROUP by status"
        Dim adapter As New MySqlDataAdapter(Query, MysqlConn)
        Dim dataset As New DataSet()
        adapter.Fill(dataset)
        Chart2.DataSource = dataset.Tables(0)
        Chart2.Series("Series1").ChartType = SeriesChartType.Doughnut
        Chart2.Series("Series1").XValueMember = "status"
        Chart2.Series("Series1").YValueMembers = "t"

        MysqlConn.Close()

    End Sub




    Public Sub chartdesigns()

        'Chart1.Series("Series1").Palette = ChartColorPalette.Pastel
        ' Chart1.BackColor = Color.WhiteSmoke
        'Chart1.Series("Series1").IsVisibleInLegend = True


        Chart2.Series("Series1").Palette = ChartColorPalette.SeaGreen
        Chart2.BackColor = Color.WhiteSmoke


        Chartx.Series("Series1").Palette = ChartColorPalette.BrightPastel
        Chartx.BackColor = Color.WhiteSmoke

        ' Chart1.ChartAreas(0).BackColor = Color.FromArgb(240, 240, 240)
        ' Chart1.ChartAreas(0).BorderDashStyle = ChartDashStyle.Solid
        ' Chart1.ChartAreas(0).BorderColor = Color.WhiteSmoke
        ' Chart1.ChartAreas(0).ShadowColor = Color.FromArgb(0, 0, 0, 0)


        ' Chart1.Titles.Add("Plan Users")
        ' Chart1.Titles(0).Font = New Font("Arial", 10, FontStyle.Bold)
        ' Chart1.Legends(0).Enabled = True
        '  Chart1.Legends(0).Docking = Docking.Bottom
        ' Chart1.Legends(0).BackColor = Color.WhiteSmoke


        Chart2.Titles.Add("Paid & Unpaid User Ratio")
        Chart2.Titles(0).Font = New Font("Arial", 10, FontStyle.Bold)
        Chart2.Legends(0).Enabled = True
        Chart2.Legends(0).Docking = Docking.Bottom
        Chart2.Legends(0).BackColor = Color.WhiteSmoke

        Chartx.Titles.Add("No. of Users Per Plan")
        Chartx.Titles(0).Font = New Font("Arial", 10, FontStyle.Bold)
        Chartx.Legends(0).Enabled = True
        Chartx.Legends(0).Docking = Docking.Bottom
        Chartx.Legends(0).BackColor = Color.WhiteSmoke
    End Sub

    Public Sub newClient()

        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        MysqlConn.Open()

        'Constructing SQL query to retrieve new clients created in the last 7 days
        Dim Query As String = "SELECT COUNT(*) FROM client_table WHERE client_install BETWEEN @StartDate AND @EndDate"

        'Calculating start and end dates for the last 7 days
        Dim endDate As DateTime = DateTime.Now.Date
        Dim startDate As DateTime = endDate.AddDays(-6)

        'Creating a SqlCommand object and setting its parameters
        Dim command As New MySqlCommand(Query, MysqlConn)
        command.Parameters.AddWithValue("@StartDate", startDate)
        command.Parameters.AddWithValue("@EndDate", endDate)

        'Executing the query and retrieving the count of new clients
        Dim newClientsCount As Integer = CInt(command.ExecuteScalar())

        'Printing the result to the console or displaying it in a form control
        tnc.Text = newClientsCount

        MysqlConn.Close()
    End Sub


    Private Sub stc_Click(sender As Object, e As EventArgs) Handles stc.Click
        AllClients.Show()
        Me.Hide()

    End Sub
    Private Sub spc_Click(sender As Object, e As EventArgs) Handles spc.Click
        PaidClients.Show()
        Me.Hide()

    End Sub

    Private Sub supc_Click(sender As Object, e As EventArgs) Handles supc.Click

        UnpaidClients.Show()
        Me.Hide()

    End Sub
    Private Sub scc_Click(sender As Object, e As EventArgs) Handles scc.Click

        ConnectedClients.Show()
        Me.Hide()

    End Sub

    Private Sub sdc_Click(sender As Object, e As EventArgs) Handles sdc.Click

        DisconnectedClients.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        totalcount()
        Paid()
        unpaid()
        totalE()
        connected()
        disconnected()
        planusers()
        paidunpaid()
        newClient()

        Label4.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy - hh:mm:ss tt")
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=root; database=isp_database"

        Timer1.Interval = 1000
        Timer1.Start()
        chartdesigns()
        connected()
        disconnected()
        planusers()
        paidunpaid()

        newClient()
        'clientlast7()
    End Sub

    Private Sub Chartx_Click(sender As Object, e As EventArgs) Handles Chartx.Click

    End Sub

    Private Sub back_btn1_Click(sender As Object, e As EventArgs) Handles back_btn1.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class