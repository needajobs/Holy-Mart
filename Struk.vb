Public Class Struk
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Pesan As New Pesan()
        Pesan.Show()
        Me.Close()
    End Sub

    Private Sub bDaftar_Click(sender As Object, e As EventArgs) Handles bDaftar.Click
        gbDaftarCus.Show()
    End Sub

    Private Sub bDon_Click(sender As Object, e As EventArgs) Handles bDon.Click
        Dim Pesan As New Pesan()
        Pesan.Show()
        Me.Close()
    End Sub
End Class