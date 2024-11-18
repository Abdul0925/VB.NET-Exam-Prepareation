Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim helper As New HelperForm
        helper.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim owned As New OwnedForm
        owned.Owner = Me
        owned.Show()
    End Sub
End Class
