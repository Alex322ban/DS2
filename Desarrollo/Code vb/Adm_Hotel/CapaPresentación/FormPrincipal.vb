Public Class FormPrincipal
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Hide()
        Login.Show()

    End Sub
End Class