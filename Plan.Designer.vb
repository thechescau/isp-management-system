<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Plan
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
        Me.planid_tb = New System.Windows.Forms.TextBox()
        Me.name_tb = New System.Windows.Forms.TextBox()
        Me.speed_tb = New System.Windows.Forms.TextBox()
        Me.price_tb = New System.Windows.Forms.TextBox()
        Me.create_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.search_tb = New System.Windows.Forms.TextBox()
        Me.back_btn1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.categ_cmb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.back_btn2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'planid_tb
        '
        Me.planid_tb.Location = New System.Drawing.Point(103, 55)
        Me.planid_tb.Multiline = True
        Me.planid_tb.Name = "planid_tb"
        Me.planid_tb.ReadOnly = True
        Me.planid_tb.Size = New System.Drawing.Size(212, 24)
        Me.planid_tb.TabIndex = 5
        '
        'name_tb
        '
        Me.name_tb.Location = New System.Drawing.Point(32, 144)
        Me.name_tb.Multiline = True
        Me.name_tb.Name = "name_tb"
        Me.name_tb.Size = New System.Drawing.Size(283, 24)
        Me.name_tb.TabIndex = 6
        '
        'speed_tb
        '
        Me.speed_tb.Location = New System.Drawing.Point(32, 221)
        Me.speed_tb.Multiline = True
        Me.speed_tb.Name = "speed_tb"
        Me.speed_tb.Size = New System.Drawing.Size(283, 24)
        Me.speed_tb.TabIndex = 7
        '
        'price_tb
        '
        Me.price_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_tb.Location = New System.Drawing.Point(33, 367)
        Me.price_tb.Multiline = True
        Me.price_tb.Name = "price_tb"
        Me.price_tb.Size = New System.Drawing.Size(283, 24)
        Me.price_tb.TabIndex = 9
        '
        'create_btn
        '
        Me.create_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_btn.Location = New System.Drawing.Point(34, 433)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.Size = New System.Drawing.Size(128, 32)
        Me.create_btn.TabIndex = 10
        Me.create_btn.Text = "Create Plan"
        Me.create_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(375, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(862, 438)
        Me.DataGridView1.TabIndex = 11
        '
        'refresh_btn
        '
        Me.refresh_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.Location = New System.Drawing.Point(375, 517)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(98, 32)
        Me.refresh_btn.TabIndex = 12
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(34, 477)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(128, 32)
        Me.delete_btn.TabIndex = 14
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.Location = New System.Drawing.Point(187, 477)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(128, 32)
        Me.update_btn.TabIndex = 15
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'search_tb
        '
        Me.search_tb.Location = New System.Drawing.Point(1005, 21)
        Me.search_tb.Multiline = True
        Me.search_tb.Name = "search_tb"
        Me.search_tb.Size = New System.Drawing.Size(232, 25)
        Me.search_tb.TabIndex = 16
        '
        'back_btn1
        '
        Me.back_btn1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn1.Location = New System.Drawing.Point(1139, 517)
        Me.back_btn1.Name = "back_btn1"
        Me.back_btn1.Size = New System.Drawing.Size(98, 32)
        Me.back_btn1.TabIndex = 17
        Me.back_btn1.Text = "Back"
        Me.back_btn1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.categ_cmb)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.clear_btn)
        Me.Panel1.Controls.Add(Me.price_tb)
        Me.Panel1.Controls.Add(Me.create_btn)
        Me.Panel1.Controls.Add(Me.planid_tb)
        Me.Panel1.Controls.Add(Me.delete_btn)
        Me.Panel1.Controls.Add(Me.update_btn)
        Me.Panel1.Controls.Add(Me.name_tb)
        Me.Panel1.Controls.Add(Me.speed_tb)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 565)
        Me.Panel1.TabIndex = 44
        '
        'categ_cmb
        '
        Me.categ_cmb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categ_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categ_cmb.ForeColor = System.Drawing.Color.Gray
        Me.categ_cmb.FormattingEnabled = True
        Me.categ_cmb.ItemHeight = 16
        Me.categ_cmb.Items.AddRange(New Object() {"WRLS", "FIBER"})
        Me.categ_cmb.Location = New System.Drawing.Point(31, 295)
        Me.categ_cmb.Name = "categ_cmb"
        Me.categ_cmb.Size = New System.Drawing.Size(285, 24)
        Me.categ_cmb.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(97, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 21)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Create New Plan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(31, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Plan No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(31, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Plan Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(31, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Speed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(30, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(30, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Price"
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(187, 433)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(128, 32)
        Me.clear_btn.TabIndex = 16
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ISP_DBMS_Trial1.My.Resources.Resources.vecteezy_transparent_search_icon_15337677_6671
        Me.PictureBox1.Location = New System.Drawing.Point(959, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'back_btn2
        '
        Me.back_btn2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn2.Location = New System.Drawing.Point(1139, 517)
        Me.back_btn2.Name = "back_btn2"
        Me.back_btn2.Size = New System.Drawing.Size(98, 32)
        Me.back_btn2.TabIndex = 26
        Me.back_btn2.Text = "Back"
        Me.back_btn2.UseVisualStyleBackColor = True
        '
        'Plan
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
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Plan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents planid_tb As TextBox
    Friend WithEvents name_tb As TextBox
    Friend WithEvents speed_tb As TextBox
    Friend WithEvents price_tb As TextBox
    Friend WithEvents create_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents refresh_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents search_tb As TextBox
    Friend WithEvents back_btn1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents back_btn2 As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents categ_cmb As ComboBox
End Class
