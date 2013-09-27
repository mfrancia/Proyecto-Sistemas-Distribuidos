Imports System.Data.SqlClient
Public Class operaciones
    Dim cn As New SqlConnection("server=.;initial catalog=sistema integrado;uid=felipe;password=ramos")
    Public Function getcodper() As DataTable
        Try
            Dim da As New SqlDataAdapter("codigo_personal", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function getdatosper(ByVal codper As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("datos_personal", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add(New SqlParameter("@codper", SqlDbType.Char, 6)).Value = codper
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getconsultar() As DataTable
        Try
            Dim da As New SqlDataAdapter("get_planilla_Mostrar", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
