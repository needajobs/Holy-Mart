<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataMaster))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.updateBarang = New System.Windows.Forms.Button()
        Me.hapusBarang = New System.Windows.Forms.Button()
        Me.tambahBarang = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_namaBarang = New System.Windows.Forms.TextBox()
        Me.tb_harga = New System.Windows.Forms.TextBox()
        Me.tb_stok = New System.Windows.Forms.TextBox()
        Me.tb_idBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.updateKat = New System.Windows.Forms.Button()
        Me.hapusKat = New System.Windows.Forms.Button()
        Me.tambahKat = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_namaKat = New System.Windows.Forms.TextBox()
        Me.tb_idKat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.updateCu = New System.Windows.Forms.Button()
        Me.hapusCu = New System.Windows.Forms.Button()
        Me.tambahCu = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_namaCu = New System.Windows.Forms.TextBox()
        Me.tb_idPromoCu = New System.Windows.Forms.TextBox()
        Me.tb_nomorTelp = New System.Windows.Forms.TextBox()
        Me.tb_idCu = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.updatePromo = New System.Windows.Forms.Button()
        Me.hapusPromo = New System.Windows.Forms.Button()
        Me.tambahPromo = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 407)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.updateBarang)
        Me.TabPage1.Controls.Add(Me.hapusBarang)
        Me.TabPage1.Controls.Add(Me.tambahBarang)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.tb_namaBarang)
        Me.TabPage1.Controls.Add(Me.tb_harga)
        Me.TabPage1.Controls.Add(Me.tb_stok)
        Me.TabPage1.Controls.Add(Me.tb_idBarang)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Barang"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'updateBarang
        '
        Me.updateBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.updateBarang.BackColor = System.Drawing.Color.Black
        Me.updateBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updateBarang.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updateBarang.Location = New System.Drawing.Point(594, 307)
        Me.updateBarang.Name = "updateBarang"
        Me.updateBarang.Size = New System.Drawing.Size(75, 23)
        Me.updateBarang.TabIndex = 25
        Me.updateBarang.Text = "Update"
        Me.updateBarang.UseVisualStyleBackColor = False
        '
        'hapusBarang
        '
        Me.hapusBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hapusBarang.BackColor = System.Drawing.Color.Black
        Me.hapusBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hapusBarang.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hapusBarang.Location = New System.Drawing.Point(675, 307)
        Me.hapusBarang.Name = "hapusBarang"
        Me.hapusBarang.Size = New System.Drawing.Size(75, 23)
        Me.hapusBarang.TabIndex = 24
        Me.hapusBarang.Text = "Delete"
        Me.hapusBarang.UseVisualStyleBackColor = False
        '
        'tambahBarang
        '
        Me.tambahBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tambahBarang.BackColor = System.Drawing.Color.Black
        Me.tambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tambahBarang.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tambahBarang.Location = New System.Drawing.Point(178, 307)
        Me.tambahBarang.Name = "tambahBarang"
        Me.tambahBarang.Size = New System.Drawing.Size(148, 23)
        Me.tambahBarang.TabIndex = 23
        Me.tambahBarang.Text = "Add"
        Me.tambahBarang.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(361, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(389, 235)
        Me.DataGridView1.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 31)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "INPUT DATA BARANG"
        '
        'tb_namaBarang
        '
        Me.tb_namaBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_namaBarang.Location = New System.Drawing.Point(178, 174)
        Me.tb_namaBarang.Name = "tb_namaBarang"
        Me.tb_namaBarang.Size = New System.Drawing.Size(148, 21)
        Me.tb_namaBarang.TabIndex = 20
        '
        'tb_harga
        '
        Me.tb_harga.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_harga.Location = New System.Drawing.Point(178, 266)
        Me.tb_harga.Name = "tb_harga"
        Me.tb_harga.Size = New System.Drawing.Size(148, 21)
        Me.tb_harga.TabIndex = 19
        '
        'tb_stok
        '
        Me.tb_stok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_stok.Location = New System.Drawing.Point(178, 220)
        Me.tb_stok.Name = "tb_stok"
        Me.tb_stok.Size = New System.Drawing.Size(148, 21)
        Me.tb_stok.TabIndex = 18
        '
        'tb_idBarang
        '
        Me.tb_idBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_idBarang.Location = New System.Drawing.Point(178, 127)
        Me.tb_idBarang.Name = "tb_idBarang"
        Me.tb_idBarang.Size = New System.Drawing.Size(148, 21)
        Me.tb_idBarang.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "HARGA BARANG"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "STOK"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "NAMA BARANG"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ID BARANG"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.updateKat)
        Me.TabPage2.Controls.Add(Me.hapusKat)
        Me.TabPage2.Controls.Add(Me.tambahKat)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.tb_namaKat)
        Me.TabPage2.Controls.Add(Me.tb_idKat)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Kategori Barang"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'updateKat
        '
        Me.updateKat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.updateKat.BackColor = System.Drawing.Color.Black
        Me.updateKat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updateKat.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateKat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updateKat.Location = New System.Drawing.Point(594, 307)
        Me.updateKat.Name = "updateKat"
        Me.updateKat.Size = New System.Drawing.Size(75, 23)
        Me.updateKat.TabIndex = 38
        Me.updateKat.Text = "Update"
        Me.updateKat.UseVisualStyleBackColor = False
        '
        'hapusKat
        '
        Me.hapusKat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hapusKat.BackColor = System.Drawing.Color.Black
        Me.hapusKat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hapusKat.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusKat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hapusKat.Location = New System.Drawing.Point(675, 307)
        Me.hapusKat.Name = "hapusKat"
        Me.hapusKat.Size = New System.Drawing.Size(75, 23)
        Me.hapusKat.TabIndex = 37
        Me.hapusKat.Text = "Delete"
        Me.hapusKat.UseVisualStyleBackColor = False
        '
        'tambahKat
        '
        Me.tambahKat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tambahKat.BackColor = System.Drawing.Color.Black
        Me.tambahKat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tambahKat.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahKat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tambahKat.Location = New System.Drawing.Point(178, 263)
        Me.tambahKat.Name = "tambahKat"
        Me.tambahKat.Size = New System.Drawing.Size(148, 23)
        Me.tambahKat.TabIndex = 36
        Me.tambahKat.Text = "Add"
        Me.tambahKat.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(361, 51)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(389, 235)
        Me.DataGridView2.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 62)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "INPUT DATA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KATEGORI BARANG"
        '
        'tb_namaKat
        '
        Me.tb_namaKat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_namaKat.Location = New System.Drawing.Point(178, 213)
        Me.tb_namaKat.Name = "tb_namaKat"
        Me.tb_namaKat.Size = New System.Drawing.Size(148, 21)
        Me.tb_namaKat.TabIndex = 33
        '
        'tb_idKat
        '
        Me.tb_idKat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_idKat.Location = New System.Drawing.Point(178, 166)
        Me.tb_idKat.Name = "tb_idKat"
        Me.tb_idKat.Size = New System.Drawing.Size(148, 21)
        Me.tb_idKat.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "NAMA KATEGORI"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "ID KATEGORI"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.updateCu)
        Me.TabPage3.Controls.Add(Me.hapusCu)
        Me.TabPage3.Controls.Add(Me.tambahCu)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.tb_namaCu)
        Me.TabPage3.Controls.Add(Me.tb_idPromoCu)
        Me.TabPage3.Controls.Add(Me.tb_nomorTelp)
        Me.TabPage3.Controls.Add(Me.tb_idCu)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 378)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Data Customer"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'updateCu
        '
        Me.updateCu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.updateCu.BackColor = System.Drawing.Color.Black
        Me.updateCu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updateCu.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateCu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updateCu.Location = New System.Drawing.Point(594, 307)
        Me.updateCu.Name = "updateCu"
        Me.updateCu.Size = New System.Drawing.Size(75, 23)
        Me.updateCu.TabIndex = 38
        Me.updateCu.Text = "Update"
        Me.updateCu.UseVisualStyleBackColor = False
        '
        'hapusCu
        '
        Me.hapusCu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hapusCu.BackColor = System.Drawing.Color.Black
        Me.hapusCu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hapusCu.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusCu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hapusCu.Location = New System.Drawing.Point(675, 307)
        Me.hapusCu.Name = "hapusCu"
        Me.hapusCu.Size = New System.Drawing.Size(75, 23)
        Me.hapusCu.TabIndex = 37
        Me.hapusCu.Text = "Delete"
        Me.hapusCu.UseVisualStyleBackColor = False
        '
        'tambahCu
        '
        Me.tambahCu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tambahCu.BackColor = System.Drawing.Color.Black
        Me.tambahCu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tambahCu.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahCu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tambahCu.Location = New System.Drawing.Point(178, 307)
        Me.tambahCu.Name = "tambahCu"
        Me.tambahCu.Size = New System.Drawing.Size(148, 23)
        Me.tambahCu.TabIndex = 36
        Me.tambahCu.Text = "Add"
        Me.tambahCu.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(361, 51)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(389, 235)
        Me.DataGridView3.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(42, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 62)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "INPUT DATA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUSTOMER"
        '
        'tb_namaCu
        '
        Me.tb_namaCu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_namaCu.Location = New System.Drawing.Point(178, 174)
        Me.tb_namaCu.Name = "tb_namaCu"
        Me.tb_namaCu.Size = New System.Drawing.Size(148, 21)
        Me.tb_namaCu.TabIndex = 33
        '
        'tb_idPromoCu
        '
        Me.tb_idPromoCu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_idPromoCu.Location = New System.Drawing.Point(178, 266)
        Me.tb_idPromoCu.Name = "tb_idPromoCu"
        Me.tb_idPromoCu.Size = New System.Drawing.Size(148, 21)
        Me.tb_idPromoCu.TabIndex = 32
        '
        'tb_nomorTelp
        '
        Me.tb_nomorTelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_nomorTelp.Location = New System.Drawing.Point(178, 220)
        Me.tb_nomorTelp.Name = "tb_nomorTelp"
        Me.tb_nomorTelp.Size = New System.Drawing.Size(148, 21)
        Me.tb_nomorTelp.TabIndex = 31
        '
        'tb_idCu
        '
        Me.tb_idCu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_idCu.Location = New System.Drawing.Point(178, 127)
        Me.tb_idCu.Name = "tb_idCu"
        Me.tb_idCu.Size = New System.Drawing.Size(148, 21)
        Me.tb_idCu.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(45, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "ID PROMO"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(45, 221)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "NOMOR TELEPON"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(45, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "NAMA CUSTOMER"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(45, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "ID CUSTOMER"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.updatePromo)
        Me.TabPage4.Controls.Add(Me.hapusPromo)
        Me.TabPage4.Controls.Add(Me.tambahPromo)
        Me.TabPage4.Controls.Add(Me.DataGridView4)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.TextBox9)
        Me.TabPage4.Controls.Add(Me.TextBox10)
        Me.TabPage4.Controls.Add(Me.TextBox11)
        Me.TabPage4.Controls.Add(Me.TextBox12)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(792, 378)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Data Promo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'updatePromo
        '
        Me.updatePromo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.updatePromo.BackColor = System.Drawing.Color.Black
        Me.updatePromo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updatePromo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePromo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updatePromo.Location = New System.Drawing.Point(594, 307)
        Me.updatePromo.Name = "updatePromo"
        Me.updatePromo.Size = New System.Drawing.Size(75, 23)
        Me.updatePromo.TabIndex = 38
        Me.updatePromo.Text = "Update"
        Me.updatePromo.UseVisualStyleBackColor = False
        '
        'hapusPromo
        '
        Me.hapusPromo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hapusPromo.BackColor = System.Drawing.Color.Black
        Me.hapusPromo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hapusPromo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusPromo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hapusPromo.Location = New System.Drawing.Point(675, 307)
        Me.hapusPromo.Name = "hapusPromo"
        Me.hapusPromo.Size = New System.Drawing.Size(75, 23)
        Me.hapusPromo.TabIndex = 37
        Me.hapusPromo.Text = "Delete"
        Me.hapusPromo.UseVisualStyleBackColor = False
        '
        'tambahPromo
        '
        Me.tambahPromo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tambahPromo.BackColor = System.Drawing.Color.Black
        Me.tambahPromo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tambahPromo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahPromo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tambahPromo.Location = New System.Drawing.Point(178, 307)
        Me.tambahPromo.Name = "tambahPromo"
        Me.tambahPromo.Size = New System.Drawing.Size(148, 23)
        Me.tambahPromo.TabIndex = 36
        Me.tambahPromo.Text = "Add"
        Me.tambahPromo.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(361, 51)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(389, 235)
        Me.DataGridView4.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(43, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(274, 31)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "INPUT DATA PROMO"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox9.Location = New System.Drawing.Point(178, 174)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(148, 21)
        Me.TextBox9.TabIndex = 33
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox10.Location = New System.Drawing.Point(178, 266)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(148, 21)
        Me.TextBox10.TabIndex = 32
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox11.Location = New System.Drawing.Point(178, 220)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(148, 21)
        Me.TextBox11.TabIndex = 31
        '
        'TextBox12
        '
        Me.TextBox12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox12.Location = New System.Drawing.Point(178, 127)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(148, 21)
        Me.TextBox12.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(45, 267)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "TANGGAL EXPIRED"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(45, 221)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 16)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "TANGGAL BERLAKU"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(45, 175)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 16)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "JENIS PROMO"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(45, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 16)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "ID PROMO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(487, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOLY ADMIN MENU."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(3, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "←"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DataMaster"
        Me.Text = "DataMaster"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents updateBarang As Button
    Friend WithEvents hapusBarang As Button
    Friend WithEvents tambahBarang As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_namaBarang As TextBox
    Friend WithEvents tb_harga As TextBox
    Friend WithEvents tb_stok As TextBox
    Friend WithEvents tb_idBarang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents updateKat As Button
    Friend WithEvents hapusKat As Button
    Friend WithEvents tambahKat As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_namaKat As TextBox
    Friend WithEvents tb_idKat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents updateCu As Button
    Friend WithEvents hapusCu As Button
    Friend WithEvents tambahCu As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_namaCu As TextBox
    Friend WithEvents tb_nomorTelp As TextBox
    Friend WithEvents tb_idCu As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents updatePromo As Button
    Friend WithEvents hapusPromo As Button
    Friend WithEvents tambahPromo As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tb_idPromoCu As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
End Class
