Imports System.Data.Odbc
Public Class Peminjaman
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=db_perpustakaan_uas"
        con.Open()

    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String = "insert into tbpeminjam values('" & kodepem.Text & "','" & namapem.Text & "','" & nim.Text & "','" & kelas.Text & "','" & comkodbuk.Text & "','" & judulbuk.Text & "','" & tanggalpinjam.Text & "','" & tanggalkem.Text & "','" & namapus.Text & "','" & nohan.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tbpeminjam order by kode_peminjam asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try

    End Sub
    Sub tampilbuku()
        cmd = New OdbcCommand("select kode_buku from tbbuku", con)
        dr = cmd.ExecuteReader
        comkodbuk.Items.Clear()
        Do While dr.Read
            comkodbuk.Items.Add(dr.Item("kode_buku"))
        Loop
    End Sub
    Sub tampil_staff()
        cmd = New OdbcCommand("select kode_pustakawan from tbstaff", con)
        dr = cmd.ExecuteReader
        kodepus.Items.Clear()
        Do While dr.Read
            kodepus.Items.Add(dr.Item("kode_pustakawan"))
        Loop
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        tampilbuku()
        tampil_staff()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampil()

    End Sub

    Private Sub comkodbuk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comkodbuk.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbbuku where kode_buku='" & comkodbuk.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            judulbuk.Text = dr.Item("judul_buku")
            tahunter.Text = dr.Item("tahun_terbit")
            penerbit.Text = dr.Item("penerbit")
            pengarang.Text = dr.Item("pengarang")

        Else
            MsgBox("Maaf buku yang dicari belum di inputkan ke sistem !!!")
        End If
        comkodbuk.Focus()

    End Sub

    Private Sub kodepus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodepus.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbstaff where kode_pustakawan='" & kodepus.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            namapus.Text = dr.Item("nama_pustakawan")
            nohan.Text = dr.Item("no_handphone")

        Else
            MsgBox("Maaf Staff Tidak Terdaftar Di Sistem")
        End If
        kodepus.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Nilai yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan kode_peminjam=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from tbpeminjam where kode_peminjam='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data nilai BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        kodepem.Text = ""
        namapem.Text = ""
        nim.Text = ""
        tanggalpinjam.Text = ""
        kelas.Text = ""
        tanggalkem.Text = ""
        comkodbuk.Text = "-pilih-"
        judulbuk.Text = ""
        tahunter.Text = ""
        penerbit.Text = ""
        pengarang.Text = ""
        kodepus.Text = "-PILIH-"
        pengarang.Text = ""
        pengarang.Text = ""
        namapus.Text = ""
        nohan.Text = ""
        kodepem.Focus()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub tahunter_TextChanged(sender As Object, e As EventArgs) Handles tahunter.TextChanged

    End Sub
End Class


