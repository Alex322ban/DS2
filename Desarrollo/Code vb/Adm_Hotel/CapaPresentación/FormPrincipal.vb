﻿Public Class FormPrincipal
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_HOTELDataSet3.MenuStrip' table. You can move, or remove it, as needed.
        Me.MenuStripTableAdapter.Fill(Me.DB_HOTELDataSet3.MenuStrip)

        Dim item As New ToolStripMenuItem(tip)
        Me.MenuStrip1.Items.Add(item)


    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        MantCli.Show()
    End Sub

    Private Sub GarajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GarajeToolStripMenuItem.Click
        MantGaraj.Show()
    End Sub

    Private Sub HabitaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabitaciónToolStripMenuItem.Click
        MantHabit.Show()
    End Sub
End Class