Imports System.IO

Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Clear()
        Me.Text = "Untitled - NotepadSDI"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Using OpenFileDialog As New OpenFileDialog
            If OpenFileDialog.ShowDialog = DialogResult.OK Then
                TextBox1.Text = File.ReadAllText(OpenFileDialog.FileName)
                Me.Text = Path.GetFileName(OpenFileDialog.FileName) & " - NotepadSDI"
            End If
        End Using
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Using saveFileDialog As New SaveFileDialog
            If saveFileDialog.ShowDialog = DialogResult.OK Then
                File.WriteAllText(saveFileDialog.FileName, TextBox1.Text)
                Me.Text = Path.GetFileName(saveFileDialog.FileName) & " - NotepadSDI"
            End If
        End Using
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
