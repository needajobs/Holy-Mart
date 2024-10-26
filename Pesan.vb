Public Class Pesan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Home As New Home()
        Home.Show()
        Me.Close()
    End Sub

    Private Sub bNext_Click(sender As Object, e As EventArgs) Handles bNext.Click
        Dim Struk As New Struk()
        Struk.Show()
        Me.Close()
    End Sub
End Class