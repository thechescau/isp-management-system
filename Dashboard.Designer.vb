<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.sdc = New System.Windows.Forms.Button()
        Me.scc = New System.Windows.Forms.Button()
        Me.supc = New System.Windows.Forms.Button()
        Me.spc = New System.Windows.Forms.Button()
        Me.stc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ncc = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cc = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.back_btn2 = New System.Windows.Forms.Button()
        Me.tnc = New System.Windows.Forms.Label()
        Me.te = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pc = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.upc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chartx = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.back_btn1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chartx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sdc
        '
        Me.sdc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sdc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sdc.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.sdc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sdc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdc.Location = New System.Drawing.Point(12, 402)
        Me.sdc.Name = "sdc"
        Me.sdc.Size = New System.Drawing.Size(279, 56)
        Me.sdc.TabIndex = 112
        Me.sdc.Text = "Show Disconnected Clients"
        Me.sdc.UseVisualStyleBackColor = False
        '
        'scc
        '
        Me.scc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.scc.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.scc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scc.Location = New System.Drawing.Point(12, 336)
        Me.scc.Name = "scc"
        Me.scc.Size = New System.Drawing.Size(279, 55)
        Me.scc.TabIndex = 111
        Me.scc.Text = "Show Connected Clients"
        Me.scc.UseVisualStyleBackColor = False
        '
        'supc
        '
        Me.supc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.supc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.supc.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.supc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supc.Location = New System.Drawing.Point(12, 271)
        Me.supc.Name = "supc"
        Me.supc.Size = New System.Drawing.Size(279, 54)
        Me.supc.TabIndex = 110
        Me.supc.Text = "Show Unpaid Clients"
        Me.supc.UseVisualStyleBackColor = False
        '
        'spc
        '
        Me.spc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.spc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.spc.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.spc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.spc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spc.Location = New System.Drawing.Point(12, 206)
        Me.spc.Name = "spc"
        Me.spc.Size = New System.Drawing.Size(279, 53)
        Me.spc.TabIndex = 109
        Me.spc.Text = "Show Paid Clients"
        Me.spc.UseVisualStyleBackColor = False
        '
        'stc
        '
        Me.stc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.stc.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.stc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stc.Location = New System.Drawing.Point(12, 140)
        Me.stc.Name = "stc"
        Me.stc.Size = New System.Drawing.Size(279, 53)
        Me.stc.TabIndex = 108
        Me.stc.Text = "Show All Clients"
        Me.stc.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(319, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 64)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "   New Clients"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ncc
        '
        Me.ncc.BackColor = System.Drawing.Color.IndianRed
        Me.ncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ncc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ncc.Location = New System.Drawing.Point(695, 205)
        Me.ncc.Name = "ncc"
        Me.ncc.Size = New System.Drawing.Size(116, 38)
        Me.ncc.TabIndex = 106
        Me.ncc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.IndianRed
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label14.Location = New System.Drawing.Point(553, 205)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 38)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "  Disconnected Users"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cc
        '
        Me.cc.BackColor = System.Drawing.Color.IndianRed
        Me.cc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cc.Location = New System.Drawing.Point(696, 145)
        Me.cc.Name = "cc"
        Me.cc.Size = New System.Drawing.Size(115, 38)
        Me.cc.TabIndex = 104
        Me.cc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.IndianRed
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label11.Location = New System.Drawing.Point(553, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 38)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "  Connected Users"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'back_btn2
        '
        Me.back_btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.back_btn2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.back_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_btn2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn2.Location = New System.Drawing.Point(12, 470)
        Me.back_btn2.Name = "back_btn2"
        Me.back_btn2.Size = New System.Drawing.Size(279, 53)
        Me.back_btn2.TabIndex = 102
        Me.back_btn2.Text = "Back to Menu"
        Me.back_btn2.UseVisualStyleBackColor = False
        '
        'tnc
        '
        Me.tnc.BackColor = System.Drawing.Color.DarkSalmon
        Me.tnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnc.Location = New System.Drawing.Point(319, 398)
        Me.tnc.Name = "tnc"
        Me.tnc.Size = New System.Drawing.Size(214, 88)
        Me.tnc.TabIndex = 99
        Me.tnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'te
        '
        Me.te.BackColor = System.Drawing.Color.Coral
        Me.te.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.te.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.te.Location = New System.Drawing.Point(551, 20)
        Me.te.Name = "te"
        Me.te.Size = New System.Drawing.Size(260, 69)
        Me.te.TabIndex = 97
        Me.te.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Coral
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(551, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(260, 58)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Total Earnings"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pc
        '
        Me.pc.BackColor = System.Drawing.Color.Salmon
        Me.pc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pc.Location = New System.Drawing.Point(319, 141)
        Me.pc.Name = "pc"
        Me.pc.Size = New System.Drawing.Size(214, 75)
        Me.pc.TabIndex = 94
        Me.pc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Salmon
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(319, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 60)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "   Paid Clients"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'upc
        '
        Me.upc.BackColor = System.Drawing.Color.Salmon
        Me.upc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.upc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upc.Location = New System.Drawing.Point(319, 273)
        Me.upc.Name = "upc"
        Me.upc.Size = New System.Drawing.Size(214, 70)
        Me.upc.TabIndex = 92
        Me.upc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Salmon
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 55)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "   Unpaid Clients"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.LightCoral
        Me.tc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.Location = New System.Drawing.Point(319, 20)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(214, 69)
        Me.tc.TabIndex = 87
        Me.tc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 38)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "   Total Clients "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'Chart2
        '
        ChartArea5.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend5)
        Me.Chart2.Location = New System.Drawing.Point(827, 20)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart2.Series.Add(Series5)
        Me.Chart2.Size = New System.Drawing.Size(398, 231)
        Me.Chart2.TabIndex = 114
        Me.Chart2.Text = "Chart2"
        '
        'Chartx
        '
        ChartArea6.Name = "ChartArea1"
        Me.Chartx.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.Chartx.Legends.Add(Legend6)
        Me.Chartx.Location = New System.Drawing.Point(556, 273)
        Me.Chartx.Name = "Chartx"
        Me.Chartx.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Me.Chartx.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))}
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.Chartx.Series.Add(Series6)
        Me.Chartx.Size = New System.Drawing.Size(669, 251)
        Me.Chartx.TabIndex = 115
        Me.Chartx.Text = "Chart3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.spc)
        Me.Panel1.Controls.Add(Me.supc)
        Me.Panel1.Controls.Add(Me.scc)
        Me.Panel1.Controls.Add(Me.stc)
        Me.Panel1.Controls.Add(Me.sdc)
        Me.Panel1.Controls.Add(Me.back_btn1)
        Me.Panel1.Controls.Add(Me.back_btn2)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 565)
        Me.Panel1.TabIndex = 116
        '
        'back_btn1
        '
        Me.back_btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.back_btn1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.back_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_btn1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn1.Location = New System.Drawing.Point(12, 469)
        Me.back_btn1.Name = "back_btn1"
        Me.back_btn1.Size = New System.Drawing.Size(279, 53)
        Me.back_btn1.TabIndex = 118
        Me.back_btn1.Text = "Back to Menu"
        Me.back_btn1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 28)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "   Total Clients "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 126)
        Me.Label2.TabIndex = 113
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 57)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "ISPMS Dashboard"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1249, 564)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Chartx)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cc)
        Me.Controls.Add(Me.tnc)
        Me.Controls.Add(Me.te)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.upc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ncc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chartx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sdc As Button
    Friend WithEvents scc As Button
    Friend WithEvents supc As Button
    Friend WithEvents spc As Button
    Friend WithEvents stc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ncc As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cc As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents back_btn2 As Button
    Friend WithEvents tnc As Label
    Friend WithEvents te As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pc As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents upc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chartx As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents back_btn1 As Button
    Friend WithEvents Label5 As Label
End Class
