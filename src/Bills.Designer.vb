<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bills
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.back_btn1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.back_btn2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cid_tb = New System.Windows.Forms.TextBox()
        Me.name_tb = New System.Windows.Forms.TextBox()
        Me.plan_tb = New System.Windows.Forms.TextBox()
        Me.price_tb = New System.Windows.Forms.TextBox()
        Me.paid_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.date_txt = New System.Windows.Forms.Label()
        Me.print_btn = New System.Windows.Forms.Button()
        Me.view_btn = New System.Windows.Forms.Button()
        Me.disconn_btn = New System.Windows.Forms.Button()
        Me.id_tb = New System.Windows.Forms.TextBox()
        Me.gen_btn = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.prnt_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'back_btn1
        '
        Me.back_btn1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn1.Location = New System.Drawing.Point(1127, 504)
        Me.back_btn1.Name = "back_btn1"
        Me.back_btn1.Size = New System.Drawing.Size(98, 32)
        Me.back_btn1.TabIndex = 20
        Me.back_btn1.Text = "Back"
        Me.back_btn1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 24)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(1199, 220)
        Me.DataGridView1.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 489)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(290, 22)
        Me.DateTimePicker1.TabIndex = 23
        Me.DateTimePicker1.Value = New Date(2023, 4, 21, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Date Paid"
        '
        'back_btn2
        '
        Me.back_btn2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn2.Location = New System.Drawing.Point(1127, 506)
        Me.back_btn2.Name = "back_btn2"
        Me.back_btn2.Size = New System.Drawing.Size(98, 32)
        Me.back_btn2.TabIndex = 26
        Me.back_btn2.Text = "Back"
        Me.back_btn2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Account Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Client Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Plan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Price"
        '
        'cid_tb
        '
        Me.cid_tb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cid_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cid_tb.Location = New System.Drawing.Point(227, 340)
        Me.cid_tb.Name = "cid_tb"
        Me.cid_tb.ReadOnly = True
        Me.cid_tb.Size = New System.Drawing.Size(290, 22)
        Me.cid_tb.TabIndex = 31
        '
        'name_tb
        '
        Me.name_tb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.name_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_tb.Location = New System.Drawing.Point(227, 377)
        Me.name_tb.Name = "name_tb"
        Me.name_tb.ReadOnly = True
        Me.name_tb.Size = New System.Drawing.Size(290, 22)
        Me.name_tb.TabIndex = 32
        '
        'plan_tb
        '
        Me.plan_tb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.plan_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plan_tb.Location = New System.Drawing.Point(227, 413)
        Me.plan_tb.Name = "plan_tb"
        Me.plan_tb.ReadOnly = True
        Me.plan_tb.Size = New System.Drawing.Size(290, 22)
        Me.plan_tb.TabIndex = 33
        '
        'price_tb
        '
        Me.price_tb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.price_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_tb.Location = New System.Drawing.Point(227, 447)
        Me.price_tb.Name = "price_tb"
        Me.price_tb.ReadOnly = True
        Me.price_tb.Size = New System.Drawing.Size(290, 22)
        Me.price_tb.TabIndex = 34
        '
        'paid_btn
        '
        Me.paid_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paid_btn.Location = New System.Drawing.Point(523, 96)
        Me.paid_btn.Name = "paid_btn"
        Me.paid_btn.Size = New System.Drawing.Size(186, 43)
        Me.paid_btn.TabIndex = 35
        Me.paid_btn.Text = "Paid"
        Me.paid_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.Location = New System.Drawing.Point(1127, 265)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(98, 32)
        Me.refresh_btn.TabIndex = 36
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'date_txt
        '
        Me.date_txt.AutoSize = True
        Me.date_txt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_txt.Location = New System.Drawing.Point(24, 15)
        Me.date_txt.Name = "date_txt"
        Me.date_txt.Size = New System.Drawing.Size(96, 23)
        Me.date_txt.TabIndex = 38
        Me.date_txt.Text = "Date Time"
        Me.date_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'print_btn
        '
        Me.print_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print_btn.Location = New System.Drawing.Point(523, 151)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(186, 43)
        Me.print_btn.TabIndex = 39
        Me.print_btn.Text = "Print Receipt"
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'view_btn
        '
        Me.view_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_btn.Location = New System.Drawing.Point(25, 52)
        Me.view_btn.Name = "view_btn"
        Me.view_btn.Size = New System.Drawing.Size(220, 88)
        Me.view_btn.TabIndex = 42
        Me.view_btn.Text = "View Monthly Table"
        Me.view_btn.UseVisualStyleBackColor = True
        '
        'disconn_btn
        '
        Me.disconn_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disconn_btn.Location = New System.Drawing.Point(549, 465)
        Me.disconn_btn.Name = "disconn_btn"
        Me.disconn_btn.Size = New System.Drawing.Size(186, 43)
        Me.disconn_btn.TabIndex = 43
        Me.disconn_btn.Text = "Disconnect Client"
        Me.disconn_btn.UseVisualStyleBackColor = True
        '
        'id_tb
        '
        Me.id_tb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.id_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_tb.Location = New System.Drawing.Point(227, 303)
        Me.id_tb.Name = "id_tb"
        Me.id_tb.ReadOnly = True
        Me.id_tb.Size = New System.Drawing.Size(290, 22)
        Me.id_tb.TabIndex = 44
        '
        'gen_btn
        '
        Me.gen_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gen_btn.Location = New System.Drawing.Point(523, 43)
        Me.gen_btn.Name = "gen_btn"
        Me.gen_btn.Size = New System.Drawing.Size(186, 43)
        Me.gen_btn.TabIndex = 47
        Me.gen_btn.Text = "Generate Invoice"
        Me.gen_btn.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 86400000
        '
        'prnt_btn
        '
        Me.prnt_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prnt_btn.Location = New System.Drawing.Point(25, 164)
        Me.prnt_btn.Name = "prnt_btn"
        Me.prnt_btn.Size = New System.Drawing.Size(220, 87)
        Me.prnt_btn.TabIndex = 48
        Me.prnt_btn.Text = "Print Monthly Table"
        Me.prnt_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Invoice Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.paid_btn)
        Me.Panel1.Controls.Add(Me.gen_btn)
        Me.Panel1.Controls.Add(Me.print_btn)
        Me.Panel1.Location = New System.Drawing.Point(26, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 279)
        Me.Panel1.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(307, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 21)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Client Payments"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.date_txt)
        Me.Panel2.Controls.Add(Me.prnt_btn)
        Me.Panel2.Controls.Add(Me.view_btn)
        Me.Panel2.Location = New System.Drawing.Point(841, 260)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 279)
        Me.Panel2.TabIndex = 51
        '
        'Bills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1249, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_tb)
        Me.Controls.Add(Me.disconn_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.price_tb)
        Me.Controls.Add(Me.plan_tb)
        Me.Controls.Add(Me.name_tb)
        Me.Controls.Add(Me.cid_tb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.back_btn2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.back_btn1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bills"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back_btn1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents back_btn2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cid_tb As TextBox
    Friend WithEvents name_tb As TextBox
    Friend WithEvents plan_tb As TextBox
    Friend WithEvents price_tb As TextBox
    Friend WithEvents paid_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents date_txt As Label
    Friend WithEvents print_btn As Button
    Friend WithEvents view_btn As Button
    Friend WithEvents disconn_btn As Button
    Friend WithEvents id_tb As TextBox
    Friend WithEvents gen_btn As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents prnt_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
End Class
