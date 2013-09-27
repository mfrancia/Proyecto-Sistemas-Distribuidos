Imports System.Data.SqlClient
Public Class buscar_planillas
    Dim obj As New operaciones
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        tbnum.Clear()
    End Sub

    Private Sub buscar_planillas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbnum.Focus()
    End Sub
End Class