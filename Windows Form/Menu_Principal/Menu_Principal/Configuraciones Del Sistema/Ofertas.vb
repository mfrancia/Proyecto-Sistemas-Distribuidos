Imports System.Messaging
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Ofertas
    Dim str As String = ""


    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        Dim path As String
        path = ".\private$\mfrancia"
        If (Not Messaging.MessageQueue.Exists(path)) Then
            MessageQueue.Create(path)
        End If


        Dim cola As New MessageQueue(path)
        Dim mensaje As New Message()
        Dim oferta As New BEOferta()
        'oferta.CoOferta = newid
        oferta.Nombre = txtnombre.Text
        oferta.Descripcion = txtdescripcion.Text
        oferta.FechaInicio = dtFecInicio.Value
        oferta.FechaCaducidad = dtFecCaducidad.Value

        mensaje.Label = "Nueva Oferta"
        mensaje.Body = oferta
        cola.Send(mensaje)
    End Sub
End Class