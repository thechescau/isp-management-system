<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.search_tb = New System.Windows.Forms.TextBox()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.contact_tb = New System.Windows.Forms.TextBox()
        Me.ad_tb = New System.Windows.Forms.TextBox()
        Me.name_tb = New System.Windows.Forms.TextBox()
        Me.id_tb = New System.Windows.Forms.TextBox()
        Me.plan_cmb = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.back_btn1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.gen_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.back_btn2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.Location = New System.Drawing.Point(791, 391)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(98, 32)
        Me.back_btn.TabIndex = 18
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'search_tb
        '
        Me.search_tb.Location = New System.Drawing.Point(980, 21)
        Me.search_tb.Multiline = True
        Me.search_tb.Name = "search_tb"
        Me.search_tb.Size = New System.Drawing.Size(257, 25)
        Me.search_tb.TabIndex = 35
        '
        'update_btn
        '
        Me.update_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.Location = New System.Drawing.Point(38, 489)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(130, 32)
        Me.update_btn.TabIndex = 34
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(187, 489)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(130, 32)
        Me.delete_btn.TabIndex = 33
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.Location = New System.Drawing.Point(375, 517)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(98, 32)
        Me.refresh_btn.TabIndex = 31
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(375, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(862, 438)
        Me.DataGridView1.TabIndex = 30
        '
        'add_btn
        '
        Me.add_btn.FlatAppearance.BorderSize = 3
        Me.add_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.Location = New System.Drawing.Point(38, 442)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(130, 32)
        Me.add_btn.TabIndex = 29
        Me.add_btn.Text = "Add Client"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'contact_tb
        '
        Me.contact_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact_tb.Location = New System.Drawing.Point(38, 268)
        Me.contact_tb.Multiline = True
        Me.contact_tb.Name = "contact_tb"
        Me.contact_tb.Size = New System.Drawing.Size(279, 24)
        Me.contact_tb.TabIndex = 27
        '
        'ad_tb
        '
        Me.ad_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad_tb.Location = New System.Drawing.Point(38, 206)
        Me.ad_tb.Multiline = True
        Me.ad_tb.Name = "ad_tb"
        Me.ad_tb.Size = New System.Drawing.Size(279, 24)
        Me.ad_tb.TabIndex = 26
        '
        'name_tb
        '
        Me.name_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_tb.Location = New System.Drawing.Point(38, 143)
        Me.name_tb.Multiline = True
        Me.name_tb.Name = "name_tb"
        Me.name_tb.Size = New System.Drawing.Size(279, 24)
        Me.name_tb.TabIndex = 25
        '
        'id_tb
        '
        Me.id_tb.Location = New System.Drawing.Point(38, 77)
        Me.id_tb.Multiline = True
        Me.id_tb.Name = "id_tb"
        Me.id_tb.ReadOnly = True
        Me.id_tb.Size = New System.Drawing.Size(278, 24)
        Me.id_tb.TabIndex = 24
        '
        'plan_cmb
        '
        Me.plan_cmb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.plan_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plan_cmb.ForeColor = System.Drawing.Color.Gray
        Me.plan_cmb.FormattingEnabled = True
        Me.plan_cmb.ItemHeight = 16
        Me.plan_cmb.Location = New System.Drawing.Point(38, 332)
        Me.plan_cmb.Name = "plan_cmb"
        Me.plan_cmb.Size = New System.Drawing.Size(277, 24)
        Me.plan_cmb.TabIndex = 36
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 393)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(279, 22)
        Me.DateTimePicker1.TabIndex = 40
        '
        'back_btn1
        '
        Me.back_btn1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn1.Location = New System.Drawing.Point(1139, 517)
        Me.back_btn1.Name = "back_btn1"
        Me.back_btn1.Size = New System.Drawing.Size(98, 32)
        Me.back_btn1.TabIndex = 42
        Me.back_btn1.Text = "Back"
        Me.back_btn1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.id_tb)
        Me.Panel1.Controls.Add(Me.clear_btn)
        Me.Panel1.Controls.Add(Me.name_tb)
        Me.Panel1.Controls.Add(Me.gen_btn)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ad_tb)
        Me.Panel1.Controls.Add(Me.delete_btn)
        Me.Panel1.Controls.Add(Me.plan_cmb)
        Me.Panel1.Controls.Add(Me.update_btn)
        Me.Panel1.Controls.Add(Me.add_btn)
        Me.Panel1.Controls.Add(Me.contact_tb)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 565)
        Me.Panel1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Account Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(35, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(36, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(36, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Contact Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(37, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Plan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(36, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Installation Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(80, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 21)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Create New Customer"
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(187, 442)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(130, 32)
        Me.clear_btn.TabIndex = 47
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'gen_btn
        '
        Me.gen_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gen_btn.Location = New System.Drawing.Point(219, 38)
        Me.gen_btn.Name = "gen_btn"
        Me.gen_btn.Size = New System.Drawing.Size(98, 29)
        Me.gen_btn.TabIndex = 46
        Me.gen_btn.Text = "Generate ID"
        Me.gen_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ISP_DBMS_Trial1.My.Resources.Resources.vecteezy_transparent_search_icon_15337677_6671
        Me.PictureBox1.Location = New System.Drawing.Point(934, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'back_btn2
        '
        Me.back_btn2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn2.Location = New System.Drawing.Point(1139, 517)
        Me.back_btn2.Name = "back_btn2"
        Me.back_btn2.Size = New System.Drawing.Size(98, 32)
        Me.back_btn2.TabIndex = 45
        Me.back_btn2.Text = "Back"
        Me.back_btn2.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1249, 561)
        Me.Controls.Add(Me.back_btn2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.back_btn1)
        Me.Controls.Add(Me.search_tb)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Client"
        Me.Text = "Client"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back_btn As Button
    Friend WithEvents search_tb As TextBox
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents add_btn As Button
    Friend WithEvents contact_tb As TextBox
    Friend WithEvents ad_tb As TextBox
    Friend WithEvents name_tb As TextBox
    Friend WithEvents id_tb As TextBox
    Friend WithEvents plan_cmb As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents back_btn1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents back_btn2 As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents gen_btn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
