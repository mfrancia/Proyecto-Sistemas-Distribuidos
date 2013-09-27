Imports System.Data.SqlClient
Public Class operaciones
    Dim cn As New SqlConnection("server=.;initial catalog=Sistema Integrado;uid=felipe;password=ramos")
    Public Function GetCodPer() As DataTable
        Try
            Dim da As New SqlDataAdapter("set_personal", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

