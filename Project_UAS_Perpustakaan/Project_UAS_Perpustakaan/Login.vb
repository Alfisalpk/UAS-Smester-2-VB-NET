Imports System.Data.Odbc
Public Class Login
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Dim MyDb As String
    Sub koneksi()
        MyDb = "Driver={MySQL ODBC 8.0 ANSI Driver};database=db_perpustakaan;server=localhost;uid=root "
        con = New OdbcConnection(MyDb)
        If con.State = ConnectionState.Closed Then con.Open()
    End Sub

    Sub terbuka()
        Aplikasi_Perpustakaan.LoginToolStripMenuItem.Visible = False
        Aplikasi_Perpustakaan.DataBukuToolStripMenuItem1.Visible = True
        Aplikasi_Perpustakaan.DataStaffPerpustakaanToolStripMenuItem.Visible = True
        Aplikasi_Perpustakaan.peminjamanbukuperpustakaan.Visible = True
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan Masukan Username Dan Password !!!")
        Else
            koneksi()
            cmd = New OdbcCommand("select *from tb_admin where kodeadmin='" & TextBox1.Text & "' and passadmin='" & TextBox2.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Close()
                Call terbuka()
            Else
                MsgBox("Yang Anda Masukan Salah")
            End If


        End If

    End Sub
End Class