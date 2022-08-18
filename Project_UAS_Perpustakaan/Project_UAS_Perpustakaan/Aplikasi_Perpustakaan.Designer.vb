<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplikasi_Perpustakaan
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.peminjamanbukuperpustakaan = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataStaffPerpustakaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanToolStripMenuItem, Me.peminjamanbukuperpustakaan, Me.DataBukuToolStripMenuItem1, Me.DataStaffPerpustakaanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(857, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LaporanToolStripMenuItem.Text = "Admin"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'peminjamanbukuperpustakaan
        '
        Me.peminjamanbukuperpustakaan.Name = "peminjamanbukuperpustakaan"
        Me.peminjamanbukuperpustakaan.Size = New System.Drawing.Size(186, 20)
        Me.peminjamanbukuperpustakaan.Text = "Peminjaman Buku Pepustakaan"
        '
        'DataBukuToolStripMenuItem1
        '
        Me.DataBukuToolStripMenuItem1.Name = "DataBukuToolStripMenuItem1"
        Me.DataBukuToolStripMenuItem1.Size = New System.Drawing.Size(73, 20)
        Me.DataBukuToolStripMenuItem1.Text = "Data Buku"
        '
        'DataStaffPerpustakaanToolStripMenuItem
        '
        Me.DataStaffPerpustakaanToolStripMenuItem.Name = "DataStaffPerpustakaanToolStripMenuItem"
        Me.DataStaffPerpustakaanToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.DataStaffPerpustakaanToolStripMenuItem.Text = "Data Staff Perpustakaan"
        '
        'Aplikasi_Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.BackgroundImage = Global.Project_UAS_Perpustakaan.My.Resources.Resources.pngegg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(857, 432)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "Aplikasi_Perpustakaan"
        Me.Text = "Sistem Informasi Perpustakaan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents peminjamanbukuperpustakaan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataStaffPerpustakaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
