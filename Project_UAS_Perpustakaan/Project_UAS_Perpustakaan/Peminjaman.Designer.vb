<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peminjaman
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kodepem = New System.Windows.Forms.TextBox()
        Me.namapem = New System.Windows.Forms.TextBox()
        Me.nim = New System.Windows.Forms.TextBox()
        Me.tanggalpinjam = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tanggalkem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kelas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pengarang = New System.Windows.Forms.TextBox()
        Me.penerbit = New System.Windows.Forms.TextBox()
        Me.tahunter = New System.Windows.Forms.TextBox()
        Me.judulbuk = New System.Windows.Forms.TextBox()
        Me.comkodbuk = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.kodepus = New System.Windows.Forms.ComboBox()
        Me.namapus = New System.Windows.Forms.TextBox()
        Me.nohan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Peminjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Kembali"
        '
        'kodepem
        '
        Me.kodepem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodepem.Location = New System.Drawing.Point(185, 25)
        Me.kodepem.Name = "kodepem"
        Me.kodepem.Size = New System.Drawing.Size(169, 25)
        Me.kodepem.TabIndex = 4
        '
        'namapem
        '
        Me.namapem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namapem.Location = New System.Drawing.Point(185, 76)
        Me.namapem.Name = "namapem"
        Me.namapem.Size = New System.Drawing.Size(169, 25)
        Me.namapem.TabIndex = 5
        '
        'nim
        '
        Me.nim.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nim.Location = New System.Drawing.Point(185, 127)
        Me.nim.Name = "nim"
        Me.nim.Size = New System.Drawing.Size(169, 25)
        Me.nim.TabIndex = 6
        '
        'tanggalpinjam
        '
        Me.tanggalpinjam.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalpinjam.Location = New System.Drawing.Point(185, 249)
        Me.tanggalpinjam.Name = "tanggalpinjam"
        Me.tanggalpinjam.Size = New System.Drawing.Size(169, 25)
        Me.tanggalpinjam.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column9, Me.Column10, Me.Column4, Me.Column6, Me.Column2, Me.Column3, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(61, 465)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1050, 293)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Peminjam"
        Me.Column1.Name = "Column1"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nama Peminjam"
        Me.Column5.Name = "Column5"
        '
        'Column9
        '
        Me.Column9.HeaderText = "NIM"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Kelas"
        Me.Column10.Name = "Column10"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Kode Buku"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Judul Buku"
        Me.Column6.Name = "Column6"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tanggal Pinjam"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tanggal Kembali"
        Me.Column3.Name = "Column3"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Nama Pustakawan"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "No Handphone"
        Me.Column8.Name = "Column8"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.tanggalkem)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.kelas)
        Me.GroupBox1.Controls.Add(Me.tanggalpinjam)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nim)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.namapem)
        Me.GroupBox1.Controls.Add(Me.kodepem)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(170, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 365)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mahasiswa Peminjam"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 20)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "NIM"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 20)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Kelas"
        '
        'tanggalkem
        '
        Me.tanggalkem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalkem.Location = New System.Drawing.Point(185, 307)
        Me.tanggalkem.Name = "tanggalkem"
        Me.tanggalkem.Size = New System.Drawing.Size(169, 25)
        Me.tanggalkem.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nama Peminjam"
        '
        'kelas
        '
        Me.kelas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelas.Location = New System.Drawing.Point(185, 188)
        Me.kelas.Name = "kelas"
        Me.kelas.Size = New System.Drawing.Size(169, 25)
        Me.kelas.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(980, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(988, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(980, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 37)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "BARU"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(980, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 37)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "KELUAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(988, 381)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 37)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "PERBARUI"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(453, 29)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "PEMINJAMAN BUKU PERPUSTAKAAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.pengarang)
        Me.GroupBox2.Controls.Add(Me.penerbit)
        Me.GroupBox2.Controls.Add(Me.tahunter)
        Me.GroupBox2.Controls.Add(Me.judulbuk)
        Me.GroupBox2.Controls.Add(Me.comkodbuk)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(570, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 240)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Peminjaman Buku"
        '
        'pengarang
        '
        Me.pengarang.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.pengarang.Location = New System.Drawing.Point(158, 203)
        Me.pengarang.Name = "pengarang"
        Me.pengarang.Size = New System.Drawing.Size(213, 25)
        Me.pengarang.TabIndex = 12
        '
        'penerbit
        '
        Me.penerbit.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.penerbit.Location = New System.Drawing.Point(158, 157)
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Size = New System.Drawing.Size(213, 25)
        Me.penerbit.TabIndex = 11
        '
        'tahunter
        '
        Me.tahunter.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.tahunter.Location = New System.Drawing.Point(158, 117)
        Me.tahunter.Name = "tahunter"
        Me.tahunter.Size = New System.Drawing.Size(213, 25)
        Me.tahunter.TabIndex = 10
        '
        'judulbuk
        '
        Me.judulbuk.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.judulbuk.Location = New System.Drawing.Point(158, 66)
        Me.judulbuk.Name = "judulbuk"
        Me.judulbuk.Size = New System.Drawing.Size(213, 25)
        Me.judulbuk.TabIndex = 9
        '
        'comkodbuk
        '
        Me.comkodbuk.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.comkodbuk.FormattingEnabled = True
        Me.comkodbuk.Location = New System.Drawing.Point(158, 21)
        Me.comkodbuk.Name = "comkodbuk"
        Me.comkodbuk.Size = New System.Drawing.Size(213, 28)
        Me.comkodbuk.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Penerbit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pengarang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kode Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Judul Buku"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Controls.Add(Me.kodepus)
        Me.GroupBox3.Controls.Add(Me.namapus)
        Me.GroupBox3.Controls.Add(Me.nohan)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(570, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(404, 132)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Staff"
        '
        'kodepus
        '
        Me.kodepus.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.kodepus.FormattingEnabled = True
        Me.kodepus.Location = New System.Drawing.Point(180, 25)
        Me.kodepus.Name = "kodepus"
        Me.kodepus.Size = New System.Drawing.Size(191, 28)
        Me.kodepus.TabIndex = 12
        '
        'namapus
        '
        Me.namapus.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.namapus.Location = New System.Drawing.Point(180, 61)
        Me.namapus.Name = "namapus"
        Me.namapus.Size = New System.Drawing.Size(191, 25)
        Me.namapus.TabIndex = 10
        '
        'nohan
        '
        Me.nohan.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.nohan.Location = New System.Drawing.Point(180, 97)
        Me.nohan.Name = "nohan"
        Me.nohan.Size = New System.Drawing.Size(191, 25)
        Me.nohan.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "No Handphone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Kode Pustakawan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Nama Pustakawan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(419, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(352, 29)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "UNIVERSITAS DUTA BANGSA"
        '
        'Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.BackgroundImage = Global.Project_UAS_Perpustakaan.My.Resources.Resources.pngegg
        Me.ClientSize = New System.Drawing.Size(1187, 749)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Name = "Peminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kodepem As System.Windows.Forms.TextBox
    Friend WithEvents namapem As System.Windows.Forms.TextBox
    Friend WithEvents nim As System.Windows.Forms.TextBox
    Friend WithEvents tanggalpinjam As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tahunter As System.Windows.Forms.TextBox
    Friend WithEvents judulbuk As System.Windows.Forms.TextBox
    Friend WithEvents tanggalkem As System.Windows.Forms.TextBox
    Friend WithEvents kelas As System.Windows.Forms.TextBox
    Friend WithEvents comkodbuk As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents kodepus As System.Windows.Forms.ComboBox
    Friend WithEvents namapus As System.Windows.Forms.TextBox
    Friend WithEvents nohan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pengarang As System.Windows.Forms.TextBox
    Friend WithEvents penerbit As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
