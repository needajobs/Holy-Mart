Public Class Home
    Private Sub bAdmin_Click(sender As Object, e As EventArgs) Handles bAdmin.Click
        Dim DataMaster As New DataMaster()
        DataMaster.Show()
        Me.Close()
    End Sub

    Private Sub bKasir_Click(sender As Object, e As EventArgs) Handles bKasir.Click
        Dim Pesan As New Pesan()
        Pesan.Show()
        Me.Close()
    End Sub
End Class