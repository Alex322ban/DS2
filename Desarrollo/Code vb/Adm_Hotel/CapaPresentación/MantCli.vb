Imports cn = CapaNegocio
Public Class MantCli
    Private WithEvents HOTEL As New cn.HotelCN
    Private Sub MantCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCliente()
    End Sub
    Private Sub cargarCliente()
        dgv_cli.DataSource = HOTEL.ListCli()
    End Sub
    Private Sub BTN_addcli_Click(sender As Object, e As EventArgs) Handles BTN_addcli.Click
        HOTEL.AddCli(txt_nomb.Text, txt_ape.Text, txt_dni.Text)
        cargarCliente()
    End Sub
    Private Sub BTN_deltcli_Click(sender As Object, e As EventArgs) Handles BTN_deltcli.Click
        HOTEL.DelCli(txt_dni.Text)
        cargarCliente()
    End Sub
    Private Sub dgv_cli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cli.CellClick
        Dim i As Integer
        i = dgv_cli.CurrentRow.Index
        txt_dni.Text = dgv_cli.Item(2, i).Value()
        txt_nomb.Text = dgv_cli.Item(0, i).Value()
        txt_ape.Text = dgv_cli.Item(1, i).Value()
    End Sub
    Private Sub BTN_updcli_Click(sender As Object, e As EventArgs) Handles BTN_updcli.Click
        Dim result As Integer = MessageBox.Show("¿Seguro quiere actualizar?", "Actualizar", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            cargarCliente()
        ElseIf result = DialogResult.No Then
            cargarCliente()
        ElseIf result = DialogResult.Yes Then
            HOTEL.EditCli(txt_nomb.Text, txt_ape.Text, txt_dni.Text)
            cargarCliente()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txt_dni.Clear()
        txt_nomb.Clear()
        txt_ape.Clear()
    End Sub
End Class
