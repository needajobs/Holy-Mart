<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.bKasir = New System.Windows.Forms.Button()
        Me.bAdmin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bKasir
        '
        Me.bKasir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bKasir.BackColor = System.Drawing.SystemColors.Desktop
        Me.bKasir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bKasir.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bKasir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bKasir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bKasir.Location = New System.Drawing.Point(113, 262)
        Me.bKasir.Name = "bKasir"
        Me.bKasir.Size = New System.Drawing.Size(157, 37)
        Me.bKasir.TabIndex = 1
        Me.bKasir.Text = "Kasir"
        Me.bKasir.UseVisualStyleBackColor = False
        '
        'bAdmin
        '
        Me.bAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bAdmin.BackColor = System.Drawing.SystemColors.InfoText
        Me.bAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAdmin.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAdmin.Location = New System.Drawing.Point(113, 315)
        Me.bAdmin.Name = "bAdmin"
        Me.bAdmin.Size = New System.Drawing.Size(157, 35)
        Me.bAdmin.TabIndex = 2
        Me.bAdmin.Text = "Admin"
        Me.bAdmin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HOLY MART™ 2023 - 2028 © "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Pre_UAS_KASIR.My.Resources.Resources.HOLY_MART
        Me.PictureBox1.Location = New System.Drawing.Point(113, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bAdmin)
        Me.Controls.Add(Me.bKasir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bKasir As Button
    Friend WithEvents bAdmin As Button
    Friend WithEvents Label1 As Label
End Class
