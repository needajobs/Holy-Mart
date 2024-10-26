<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Struk
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
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Struk))
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDaftarCus = New System.Windows.Forms.GroupBox()
        Me.bBuat = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bDaftar = New System.Windows.Forms.Button()
        Me.bCek = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.bDon = New System.Windows.Forms.Button()
        Me.bCetak = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gbDaftarCus.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        GroupBox1.CausesValidation = False
        GroupBox1.Controls.Add(Me.rbCash)
        GroupBox1.Controls.Add(Me.rbCredit)
        GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        GroupBox1.Location = New System.Drawing.Point(-4, 61)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(801, 281)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbCash.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCash.Location = New System.Drawing.Point(520, 246)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(72, 27)
        Me.rbCash.TabIndex = 7
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbCredit
        '
        Me.rbCredit.AutoSize = True
        Me.rbCredit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbCredit.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCredit.Location = New System.Drawing.Point(151, 246)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(137, 27)
        Me.rbCredit.TabIndex = 6
        Me.rbCredit.TabStop = True
        Me.rbCredit.Text = "Debit/Credit"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 409)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.CausesValidation = False
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 380)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Metode Pembayaran"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(378, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PILIH METODE PEMBAYARAN"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.Pre_UAS_KASIR.My.Resources.Resources.cash
        Me.PictureBox2.Location = New System.Drawing.Point(446, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 213)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Pre_UAS_KASIR.My.Resources.Resources.credit
        Me.PictureBox1.Location = New System.Drawing.Point(118, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.gbDaftarCus)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 380)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PROMO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(60, 262)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(706, 97)
        Me.ListView2.TabIndex = 3
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID PROMO"
        Me.ColumnHeader5.Width = 121
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "JENIS PROMO"
        Me.ColumnHeader6.Width = 164
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TANGGAL BERLAKU"
        Me.ColumnHeader7.Width = 203
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TANGGAL EXPIRED"
        Me.ColumnHeader8.Width = 214
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 31)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "CUSTOMER PROMO"
        '
        'gbDaftarCus
        '
        Me.gbDaftarCus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbDaftarCus.Controls.Add(Me.bBuat)
        Me.gbDaftarCus.Controls.Add(Me.TextBox3)
        Me.gbDaftarCus.Controls.Add(Me.TextBox4)
        Me.gbDaftarCus.Controls.Add(Me.Label6)
        Me.gbDaftarCus.Controls.Add(Me.Label7)
        Me.gbDaftarCus.Location = New System.Drawing.Point(429, 106)
        Me.gbDaftarCus.Name = "gbDaftarCus"
        Me.gbDaftarCus.Size = New System.Drawing.Size(337, 139)
        Me.gbDaftarCus.TabIndex = 1
        Me.gbDaftarCus.TabStop = False
        Me.gbDaftarCus.Text = "DAFTAR CUSTOMER"
        Me.gbDaftarCus.Visible = False
        '
        'bBuat
        '
        Me.bBuat.BackColor = System.Drawing.Color.Black
        Me.bBuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bBuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bBuat.Location = New System.Drawing.Point(241, 99)
        Me.bBuat.Name = "bBuat"
        Me.bBuat.Size = New System.Drawing.Size(75, 23)
        Me.bBuat.TabIndex = 10
        Me.bBuat.Text = "CREATE"
        Me.bBuat.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(133, 66)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(183, 21)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(133, 31)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(183, 21)
        Me.TextBox4.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NOMOR TELEPON"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "NAMA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.bDaftar)
        Me.GroupBox2.Controls.Add(Me.bCek)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 139)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IDENTIFIKASI CUSTOMER"
        '
        'bDaftar
        '
        Me.bDaftar.BackColor = System.Drawing.Color.Black
        Me.bDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bDaftar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bDaftar.Location = New System.Drawing.Point(132, 99)
        Me.bDaftar.Name = "bDaftar"
        Me.bDaftar.Size = New System.Drawing.Size(102, 23)
        Me.bDaftar.TabIndex = 5
        Me.bDaftar.Text = "DAFTAR"
        Me.bDaftar.UseVisualStyleBackColor = False
        '
        'bCek
        '
        Me.bCek.BackColor = System.Drawing.Color.Black
        Me.bCek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bCek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bCek.Location = New System.Drawing.Point(240, 99)
        Me.bCek.Name = "bCek"
        Me.bCek.Size = New System.Drawing.Size(75, 23)
        Me.bCek.TabIndex = 4
        Me.bCek.Text = "CHECK"
        Me.bCek.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(132, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(183, 21)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NOMOR TELEPON"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NAMA"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.bDon)
        Me.TabPage3.Controls.Add(Me.bCetak)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 380)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "STRUK"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'bDon
        '
        Me.bDon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bDon.BackColor = System.Drawing.Color.Black
        Me.bDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bDon.Location = New System.Drawing.Point(620, 333)
        Me.bDon.Name = "bDon"
        Me.bDon.Size = New System.Drawing.Size(132, 23)
        Me.bDon.TabIndex = 6
        Me.bDon.Text = "SELESAI"
        Me.bDon.UseVisualStyleBackColor = False
        '
        'bCetak
        '
        Me.bCetak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bCetak.BackColor = System.Drawing.Color.Black
        Me.bCetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bCetak.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bCetak.Location = New System.Drawing.Point(480, 333)
        Me.bCetak.Name = "bCetak"
        Me.bCetak.Size = New System.Drawing.Size(134, 23)
        Me.bCetak.TabIndex = 5
        Me.bCetak.Text = "CETAK STRUK"
        Me.bCetak.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(475, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 28)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Rp. xxx.xxx,xx"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(476, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(276, 19)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "METODE PEMBAYARAN : BELUM DIPILIH"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(476, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "TIPE PROMO : TIDAK ADA"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(281, 31)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "STRUK PEMBAYARAN"
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(33, 60)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(417, 296)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID BARANG"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAMA BARANG"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "KUANTITAS"
        Me.ColumnHeader3.Width = 86
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "HARGA BARANG"
        Me.ColumnHeader4.Width = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(448, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HOLY PAYMENT MENU."
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "←"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Struk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Struk"
        Me.Text = "Struk"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbDaftarCus.ResumeLayout(False)
        Me.gbDaftarCus.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rbCredit As RadioButton
    Friend WithEvents gbDaftarCus As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bCek As Button
    Friend WithEvents bBuat As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bDon As Button
    Friend WithEvents bCetak As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents bDaftar As Button
    Friend WithEvents Button1 As Button
End Class
