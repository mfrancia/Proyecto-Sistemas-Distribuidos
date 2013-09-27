Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Form1
    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Aprobar_Solictud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Aprobar_Solictud.Click
        Aprobar_Solicitud.MdiParent = Me
        Aprobar_Solicitud.Show()
    End Sub

    'Private Sub NuevoPersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoPersonalToolStripMenuItem.Click
    '    nuevo_personal.MdiParent = Me
    '    nuevo_personal.Show()
    'End Sub
    'Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
    '    consultar_personal.MdiParent = Me
    '    consultar_personal.Show()
    'End Sub
    'Private Sub PersonalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem1.Click
    '    mantenimiento_personal.MdiParent = Me
    '    mantenimiento_personal.Show()
    'End Sub
    'Private Sub GenerarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarToolStripMenuItem.Click
    '    Planillas_personal.MdiParent = Me
    '    Planillas_personal.Show()
    'End Sub
    'Private Sub ControlPlanillasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlPlanillasToolStripMenuItem.Click
    '    Dim da As New SqlDataAdapter("get_remuneracion_planillas", cn)
    '    Try
    '        da.SelectCommand.CommandType = CommandType.StoredProcedure
    '        dt_pla.Clear()
    '        da.Fill(dt_pla)
    '        If dt_pla.Rows.Count < 1 Then
    '            MsgBox("No se ha Ingresado el tanto % de las remuneraciones" + _
    '            vbCrLf + Space(6) + "Ingrese configuraciones de Remuneraciones" + _
    '            vbCrLf + Space(14) + "En Configuraiones Del Sistema", 64, "Mensaje")
    '        Else
    '            Mantenimiento_de_Planillas.MdiParent = Me
    '            Mantenimiento_de_Planillas.Show()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Private Sub MantenerRemuneracionesPlanillasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenerRemuneracionesPlanillasToolStripMenuItem.Click
    '    Mant_rem___Planillas.MdiParent = Me
    '    Mant_rem___Planillas.Show()
    'End Sub
    'Private Sub ListadoDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
    '    Lista_productos.MdiParent = Me
    '    Lista_productos.Show()
    'End Sub
    'Private Sub SadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SadToolStripMenuItem.Click
    '    Registro_Clientes.MdiParent = Me
    '    Registro_Clientes.Show()
    'End Sub
    'Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
    '    Registro_Usuario.MdiParent = Me
    '    Registro_Usuario.Show()
    'End Sub
    'Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
    '    Registro_Empresa.MdiParent = Me
    '    Registro_Empresa.Show()
    'End Sub
    'Private Sub MantenimientoDeClaseMarcaModeloDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeClaseMarcaModeloDeProductosToolStripMenuItem.Click
    '    Mant_clase_marca_modelo.MdiParent = Me
    '    Mant_clase_marca_modelo.Show()
    'End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbhora.Text = Now.ToLongTimeString
        lbfecha.Text = UCase(Mid(Now.ToLongDateString, 1, 1)) & Mid(Now.ToLongDateString, 2)
    End Sub
    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Shell("C:\WINDOWS\system32\calc.exe", 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BuscaminasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscaminasToolStripMenuItem.Click
        Try
            Shell("C:\WINDOWS\system32\winmine.exe", 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub login_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim res As MsgBoxResult
        res = MsgBox("Esta Seguro de Salir del Sistema?", 4 + 32, "Salir")
        If res = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
    
End Class

