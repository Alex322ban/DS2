Imports CapaDatos
Public Class HotelCN
    Private hotel As New HotelCD

    Public Function ListCli() As DataTable
        Return hotel.ListCliente
    End Function
    Public Function AddCli(ByVal nomb As String, ByVal ape As String, ByVal dni As String)
        Return hotel.AddCliente(nomb, ape, dni)
    End Function
    Public Function DelCli(ByVal dni As String)
        Return hotel.DeleteCliente(dni)
    End Function
    Public Function EditCli(ByVal idc As Integer, ByVal nomb As String, ByVal ape As String, ByVal dni As String)
        Return hotel.UpdateCliente(idc, nomb, ape, dni)
    End Function
    Public Function ListGaraj() As DataTable
        Return hotel.ListGaraje
    End Function
    Public Function AddVehiG(ByVal slot As Integer, ByVal placa As String, ByVal dni As String)
        Return hotel.AddVehiculoG(slot, placa, dni)
    End Function

End Class
