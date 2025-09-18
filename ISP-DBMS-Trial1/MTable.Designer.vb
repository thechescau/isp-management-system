<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MTable
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MTable))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.back_btn2 = New System.Windows.Forms.Button()
        Me.back_btn1 = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.prnt_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(85, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(704, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'back_btn2
        '
        Me.back_btn2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn2.Location = New System.Drawing.Point(691, 394)
        Me.back_btn2.Name = "back_btn2"
        Me.back_btn2.Size = New System.Drawing.Size(98, 32)
        Me.back_btn2.TabIndex = 28
        Me.back_btn2.Text = "Back"
        Me.back_btn2.UseVisualStyleBackColor = True
        '
        'back_btn1
        '
        Me.back_btn1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn1.Location = New System.Drawing.Point(691, 394)
        Me.back_btn1.Name = "back_btn1"
        Me.back_btn1.Size = New System.Drawing.Size(98, 32)
        Me.back_btn1.TabIndex = 27
        Me.back_btn1.Text = "Back"
        Me.back_btn1.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.Location = New System.Drawing.Point(569, 394)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(98, 32)
        Me.refresh_btn.TabIndex = 29
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'prnt_btn
        '
        Me.prnt_btn.BackColor = System.Drawing.SystemColors.Control
        Me.prnt_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.prnt_btn.FlatAppearance.BorderSize = 0
        Me.prnt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prnt_btn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prnt_btn.Location = New System.Drawing.Point(774, 1)
        Me.prnt_btn.Name = "prnt_btn"
        Me.prnt_btn.Size = New System.Drawing.Size(98, 32)
        Me.prnt_btn.TabIndex = 30
        Me.prnt_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(826, 43)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Current Month Records"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prnt_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.back_btn2)
        Me.Controls.Add(Me.back_btn1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MTable"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents back_btn2 As Button
    Friend WithEvents back_btn1 As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents prnt_btn As Button
    Friend WithEvents Label2 As Label
End Class
