Option Strict On
Imports System.Data.SqlClient
Imports System.Data
Public Class planillas
    Dim obj As New operaciones
    Private Sub planillas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbcod.DataSource = obj.getcodper
            cbcod.DisplayMember = "codper"
            cbcod.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
        limpiar()
    End Sub
    Sub limpiar()
        tbnom.Clear()
        tbape.Clear()
        tbdni.Clear()
        tbest.Clear()
        tbsex.Clear()
    End Sub

    Private Sub cbcod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcod.SelectedIndexChanged
        Try
            Dim dt As New DataTable
            dt = obj.getdatosper(cbcod.Text)
            tbape.Text = CStr(dt.Rows(0)(0))
            tbnom.Text = CStr(dt.Rows(0)(1))
            tbdni.Text = CStr(dt.Rows(0)(2))
            tbsex.Text = CStr(dt.Rows(0)(3))
            tbest.Text = CStr(dt.Rows(0)(4))
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
        validar()
    End Sub

    Private Sub btncalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        Dim bon1, bon2, bon3, tbon, sue As Decimal
        sue = CDec(Val(tbsue.Text))
        'Bonificaciones
        If chkvac.Checked = True Then
            bon1 = CDec(sue * 0.3)
        End If
        If chkfam.Checked = True Then
            bon2 = CDec(sue * 0.2)
        End If
        If chkdom.Checked = True Then
            bon3 = CDec(sue * 0.15)
        End If
        tbon = bon1 + bon2 + bon3

        'Descuentos
        Dim des1, des2, des3, tdes, sneto As Decimal
        If chkcts.Checked = True Then
            des1 = CDec(sue * 0.1)
        End If
        If chkafp.Checked = True Then
            des2 = CDec(sue * 0.07)
        End If
        If chkfon.Checked = True Then
            des3 = CDec(sue * 0.08)
        End If
        tdes = des1 + des2 + des3
        tbben.Text = CStr(tbon)
        tbdes.Text = CStr(tdes)
        sneto = sue + tbon - tdes
        tbneto.Text = CStr(sneto)

        'validar en Guardar planillas 
        Dim a As String
        a = "G"
        If a = "G" Then
            btngrabar.Enabled = True
            tbsue.ReadOnly = True
        Else
            btngrabar.Enabled = False
            tbsue.ReadOnly = False
        End If
    End Sub

    Private Sub tbsue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbsue.KeyPress
        Select Case e.KeyChar
            Case Chr(48) To Chr(57), Chr(13), Chr(8)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        'Guardar las Bonificaciones y Descuentos
        Dim sue, vac, fam, dom, cts, afp, fon As Decimal
        sue = CDec(Val(tbsue.Text))
        If chkvac.Checked = True Then
            vac = CDec(sue * 0.3)
        End If
        If chkfam.Checked = True Then
            fam = CDec(sue * 0.2)
        End If
        If chkdom.Checked = True Then
            dom = CDec(sue * 0.15)
        End If
        If chkcts.Checked = True Then
            cts = CDec(sue * 0.1)
        End If
        If chkafp.Checked Then
            afp = CDec(sue * 0.07)
        End If
        If chkfon.Checked Then
            fon = CDec(sue * 0.08)
        End If
        Try
            Dim cmd As New SqlCommand("set_grabar_planilla", cn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@vacaciones", SqlDbType.Decimal)).Value = vac
                .Parameters.Add(New SqlParameter("@familiar", SqlDbType.Decimal)).Value = fam
                .Parameters.Add(New SqlParameter("@dominicales", SqlDbType.Decimal)).Value = dom
                .Parameters.Add(New SqlParameter("@cts", SqlDbType.Decimal)).Value = cts
                .Parameters.Add(New SqlParameter("@afp", SqlDbType.Decimal)).Value = afp
                .Parameters.Add(New SqlParameter("@fonavi", SqlDbType.Decimal)).Value = fon
                .Parameters.Add(New SqlParameter("@sueldo", SqlDbType.Decimal)).Value = tbsue.Text.Trim
                .Parameters.Add(New SqlParameter("@totben", SqlDbType.Decimal)).Value = tbben.Text.Trim
                .Parameters.Add(New SqlParameter("@totdes", SqlDbType.Decimal)).Value = tbdes.Text.Trim
                .Parameters.Add(New SqlParameter("@suenet", SqlDbType.Decimal)).Value = tbneto.Text.ToString
                .Parameters.Add(New SqlParameter("@codper", SqlDbType.Char, 6)).Value = cbcod.Text.ToString
            End With
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Se grabaron los Datos", CType(0 + 64, MsgBoxStyle), "Guardando Transacción")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        btngrabar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub tbsue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsue.TextChanged
        validar()
    End Sub

    Sub validar()
        If tbsue.Text <> "" And cbcod.SelectedIndex >= 0 Then
            btncalcular.Enabled = True
        Else
            btncalcular.Enabled = False
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        cbcod.Text = ""
        tbnom.Clear()
        tbape.Clear()
        tbdni.Clear()
        tbsex.Clear()
        tbest.Clear()
        tbnum.Clear()
        chkvac.Checked = False
        chkfam.Checked = False
        chkdom.Checked = False
        chkafp.Checked = False
        chkcts.Checked = False
        chkfon.Checked = False
        tbsue.Clear()
        tbsue.ReadOnly = False
        tbben.Clear()
        tbdes.Clear()
        tbneto.Clear()
        btngrabar.Enabled = False
        btnnuevo.Enabled = False
    End Sub

    Private Sub tbsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar_planillas.Location = New Point(513, 325)
        buscar_planillas.ShowDialog()
    End Sub
End Class