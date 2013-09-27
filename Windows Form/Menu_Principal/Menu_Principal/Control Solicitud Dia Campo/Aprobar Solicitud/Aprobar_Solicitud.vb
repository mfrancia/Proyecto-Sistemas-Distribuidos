Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Aprobar_Solicitud
    Dim str As String = ""
    Dim foco As Integer = 0
    Dim ind As Integer = 0
    Private Sub rbclub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbclub.CheckedChanged
        If rbclub.Checked Then

            str = " select CoClub as Codigo, NoClub as Club from Club" & _
                  " order by 2 asc"

            Dim da As New MySQLDataAdapter(str, cn)
            Dim dt As New DataTable

            Try
                da.SelectCommand.CommandType = CommandType.Text
                da.Fill(dt)
                cbclub.DataSource = dt
                cbclub.DisplayMember = "Club"
                cbclub.ValueMember = "Codigo"
                cbclub.SelectedIndex = -1
                foco = 1
            Catch ex As MySQLException
                MessageBox.Show(ex.Message)
            End Try

            cbclub.Enabled = True
            tbnom.Text = ""
        Else
            cbclub.Enabled = False
        End If
        cbclub.Focus()
    End Sub
    Private Sub rbnom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnom.CheckedChanged
        If rbnom.Checked Then
            tbnom.Enabled = True
            cbclub.SelectedIndex = -1
            foco = 0
        Else
            tbnom.Enabled = False
        End If
        dgw1.DataSource = Nothing
        tbnom.Focus()
        validar_botones_dir(False)
        tbtotal.Text = ""
    End Sub
    Private Sub cbclub_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbclub.SelectedValueChanged
        If foco = 1 Then
            Consultar_Solicitud("club")
        End If
    End Sub
    'Private Sub cbcat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Select Case cbcat.SelectedIndex
    '            Case 0
    '                Dim da As New SqlDataAdapter("get_lista_prod_todos", cn)
    '                Dim dt As New DataTable
    '                da.Fill(dt)
    '                If dt.Rows.Count > 0 Then
    '                    dgw1.DataSource = dt
    '                    validar_botones_dir(True)
    '                    dgw1.SelectedCells(0).Selected = False
    '                    foco = True
    '                    TextBox1.Text = dt.Rows.Count
    '                End If
    '                ocultar(False)
    '            Case Is > 0
    '                Dim da1 As New SqlDataAdapter("", cn)
    '                Dim dt1 As New DataTable
    '                ocultar(True)
    '                validar_botones_dir(False)
    '                dgw1.DataSource = Nothing
    '                lbtipo.Text = "Seleccione Tipo de " & cbcat.SelectedItem
    '                If cbcat.SelectedIndex = 1 Then
    '                    With da1.SelectCommand
    '                        .CommandText = "get_Clase"
    '                        .CommandType = CommandType.StoredProcedure
    '                        da1.Fill(dt1)
    '                        cbtipo.DataSource = dt1
    '                        cbtipo.DisplayMember = "DesClase"
    '                        cbtipo.ValueMember = "CodClase"
    '                    End With
    '                ElseIf cbcat.SelectedIndex = 2 Then
    '                    With da1.SelectCommand
    '                        .CommandText = "get_Marca"
    '                        .CommandType = CommandType.StoredProcedure
    '                        da1.Fill(dt1)
    '                        cbtipo.DataSource = dt1
    '                        cbtipo.DisplayMember = "DesMarca"
    '                        cbtipo.ValueMember = "CodMarca"
    '                    End With
    '                ElseIf cbcat.SelectedIndex = 3 Then
    '                    With da1.SelectCommand
    '                        .CommandText = "get_Modelo"
    '                        .CommandType = CommandType.StoredProcedure
    '                        da1.Fill(dt1)
    '                        cbtipo.DataSource = dt1
    '                        cbtipo.DisplayMember = "DesModelo"
    '                        cbtipo.ValueMember = "CodModelo"
    '                    End With
    '                End If
    '                cbtipo.SelectedIndex = -1
    '                foco = False
    '                TextBox1.Text = ""
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Private Sub cbtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim da As New SqlDataAdapter("get_Productos_x_Tipo", cn)
    '        Dim dt As New DataTable
    '        da.SelectCommand.CommandType = CommandType.StoredProcedure
    '        With da.SelectCommand.Parameters
    '            .Add(New SqlParameter("@codClase", SqlDbType.VarChar, 120)).Value = cbtipo.SelectedValue
    '            .Add(New SqlParameter("@codModelo", SqlDbType.VarChar, 120)).Value = cbtipo.SelectedValue
    '            .Add(New SqlParameter("@codMarca", SqlDbType.VarChar, 120)).Value = cbtipo.SelectedValue
    '        End With
    '        da.Fill(dt)
    '        If dt.Rows.Count > 0 Then
    '            dgw1.DataSource = dt
    '            validar_botones_dir(True)
    '            foco = True
    '            dgw1.SelectedCells(0).Selected = False
    '            TextBox1.Text = dt.Rows.Count
    '        Else
    '            TextBox1.Text = ""
    '            validar_botones_dir(False)
    '            dgw1.DataSource = Nothing
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Sub validar_botones_dir(ByVal val As Boolean)
        If val = True Then
            btnult.Visible = True
            btnpri.Visible = True
            btnsig.Visible = True
            btnant.Visible = True
        Else
            btnult.Visible = False
            btnpri.Visible = False
            btnsig.Visible = False
            btnant.Visible = False
        End If
    End Sub
    Private Sub dgw1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgw1.SelectionChanged
        Try
            ind = dgw1.CurrentCell().RowIndex
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnpri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpri.Click
        ind = 0
        dgw1.CurrentCell = dgw1.Rows(ind).Cells(0)
    End Sub
    Private Sub btnult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnult.Click
        ind = dgw1.RowCount - 1
        dgw1.CurrentCell = dgw1.Rows(ind).Cells(0)
    End Sub
    Private Sub btnant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnant.Click
        dgw1_SelectionChanged(sender, e)
        ind = ind - 1
        If ind < 0 Then
            ind = 0
        End If
        dgw1.CurrentCell = dgw1.Rows(ind).Cells(0)
    End Sub
    Private Sub btnsig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsig.Click
        dgw1_SelectionChanged(sender, e)
        ind = ind + 1
        If ind > dgw1.RowCount - 1 Then
            ind = dgw1.RowCount - 1
        End If
        dgw1.CurrentCell = dgw1.Rows(ind).Cells(0)
    End Sub
    Private Sub tbnom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnom.TextChanged
        Consultar_Solicitud("nombre")
    End Sub
    Private Sub Consultar_Solicitud(ByVal tipo As String)
        If tipo = "nombre" Then
            str = " select CoDiaCampo as Codigo," & _
                  " concat(trim(NoApePaterno),' ' ,trim(NoApeMaterno), ' ' , trim(NoNombres)) as Nombre," & _
                  " FeDiaCampo as ""Dia De Campo""," & _
                  " NuTotalPersonas as ""Total Personas""," & _
                  " SsImporteTotal as ""Precio Total""," & _
                  " NoClub as Club" & _
                  " from solicitud_dia_campo s" & _
                  " inner join responsable_familia r" & _
                  " on s.CoResponsable = r.CoResponsable" & _
                  " inner join club c" & _
                  " on s.CoClub = c.CoClub" & _
                  " where concat(trim(NoApePaterno),' ' ,trim(NoApeMaterno), ' ' , trim(NoNombres)) like '%" & tbnom.Text & "%'" & _
                  " and FlAprobado is null"

        ElseIf tipo = "club" Then
            str = " select CoDiaCampo as Codigo," & _
                  " concat(trim(NoApePaterno),' ' ,trim(NoApeMaterno), ' ' , trim(NoNombres)) as Nombre," & _
                  " FeDiaCampo as ""Dia De Campo""," & _
                  " NuTotalPersonas as ""Total Personas""," & _
                  " SsImporteTotal as ""Precio Total""," & _
                  " NoClub as Club" & _
                  " from solicitud_dia_campo s" & _
                  " inner join responsable_familia r" & _
                  " on s.CoResponsable = r.CoResponsable" & _
                  " inner join club c" & _
                  " on s.CoClub = c.CoClub" & _
                  " where s.CoClub = " & Convert.ToString(cbclub.SelectedValue) & _
                  " and FlAprobado is null"
        End If

        Try
            Dim da As New MySQLDataAdapter(str, cn)
            Dim dt As New DataTable
            dt.Clear()
            If tbnom.Text.Trim <> "" Or cbclub.SelectedIndex > -1 Then
                da.SelectCommand.CommandType = CommandType.Text
                da.Fill(dt)
                dgw1.DataSource = dt
                tbtotal.Text = dt.Rows.Count
                If dt.Rows.Count() > 0 Then
                    validar_botones_dir(True)
                Else
                    validar_botones_dir(False)
                End If
            Else
                dgw1.DataSource = Nothing
                tbtotal.Text = ""
                validar_botones_dir(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btn_Aprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aprobar.Click
        Dim n, aprob As Integer
        Dim mensaje As String
        'codigo_usuario = 1 'Elminar esto para terminar la prueba
        Try
            For n = 0 To dgw1.Rows.Count - 1
                If dgw1.Rows(n).Cells(0).Value = True Then

                    str = " Update Solicitud_dia_campo set FlAprobado = 1, " & _
                          " FeAprobado = DATE_FORMAT(sysdate(), '%Y-%m-%d'), " & _
                          " CoUsuarioAdmin = " & codigo_usuario & _
                          " where CoDiaCampo = " & dgw1.Rows(n).Cells(1).Value & _
                          " and FlAprobado is null"

                    Dim cmd As New MySQLCommand(str, cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandType = CommandType.Text
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    aprob = aprob + 1
                End If
            Next

            If rbnom.Checked Then
                Consultar_Solicitud("nombre")
            Else
                Consultar_Solicitud("club")
            End If

            If aprob = 1 Then
                mensaje = "Se Aprobó: " & aprob & " Solicitud"
                MsgBox(mensaje, 64, "Actualizando")
            ElseIf aprob > 1 Then
                mensaje = "Se Aprobaron: " & aprob & " Solicitudes"
                MsgBox(mensaje, 64, "Actualizando")
            Else
                mensaje = "Por favor, seleccione como mínimo una Solicitud antes de Aprobar"
                MsgBox(mensaje, 48, "Mensaje del Sistema")
            End If

        Catch ex As MySQLException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class