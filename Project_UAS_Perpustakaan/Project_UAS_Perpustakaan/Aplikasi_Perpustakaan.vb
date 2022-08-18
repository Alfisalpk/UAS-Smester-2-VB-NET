Public Class Aplikasi_Perpustakaan
    Sub terkunci()
        LoginToolStripMenuItem.Visible = True
        DataBukuToolStripMenuItem1.Visible = False
        DataStaffPerpustakaanToolStripMenuItem.Visible = False
        peminjamanbukuperpustakaan.Visible = False

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Aplikasi_Perpustakaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkunci()



    End Sub

    Private Sub DataAnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataStaffPerpustakaanToolStripMenuItem.Click
        Data_Staff.Show()

    End Sub

    Private Sub DataBukuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataBukuToolStripMenuItem1.Click
        Data_Buku.Show()

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles peminjamanbukuperpustakaan.Click
        Peminjaman.Show()

    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click


    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.Show()

    End Sub
End Class
