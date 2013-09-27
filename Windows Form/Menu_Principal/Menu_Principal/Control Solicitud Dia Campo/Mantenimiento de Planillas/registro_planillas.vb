Public Class registro_planillas
    Private objO As New operaciones
    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        Dim sue, ben, ben2, ben3, tben, des, des2, des3, tdes, sne As Integer
        'Calcular el Sueldo
        If cbeci.SelectedIndex = 0 And rbmas.Checked = True Then
            sue = 800
        ElseIf cbeci.SelectedIndex = 0 And rbfem.Checked = True Then
            sue = 700
        ElseIf cbeci.SelectedIndex = 1 And rbmas.Checked = True Then
            sue = 1000
        ElseIf cbeci.SelectedIndex = 1 And rbfem.Checked = True Then
            sue = 900
        ElseIf cbeci.SelectedIndex = 2 And rbmas.Checked = True Then
            sue = 1100
        ElseIf cbeci.SelectedIndex = 2 And rbfem.Checked = True Then
            sue = 1000
        ElseIf cbeci.SelectedIndex = 3 And rbmas.Checked = True Then
            sue = 1000
        ElseIf cbeci.SelectedIndex = 3 And rbfem.Checked = True Then
            sue = 900
        End If
        tbsue.Text = CStr(sue)

        'Calcular Beneficios
        If chkvac.Checked = True Then
            ben = CInt(sue * 0.3)
        End If
        If chkfam.Checked = True Then
            ben2 = CInt(sue * 0.2)
        End If
        If chkdom.Checked = True Then
            ben3 = CInt(sue * 0.15)
        End If
        tben = ben + ben2 + ben3
        tbtbe.Text = CStr(tben)

        'Calcular Descuentos
        If chkcts.Checked = True Then
            des = CInt(sue * 0.1)
        End If
        If chkafp.Checked = True Then
            des2 = CInt(sue * 0.07)
        End If
        If chkfon.Checked = True Then
            des3 = CInt(sue * 0.08)
        End If
        tdes = des + des2 + des3
        tbtde.Text = CStr(tdes)

        'Sueldo Neto
        sne = sue + tben - tdes
        tbsne.Text = CStr(sne)
    End Sub
    Sub Habilitar()
        Dim su, be, de, sn As Integer
        su = CInt(Val(tbsue.Text))
        be = CInt(Val(tbtbe.Text))
        de = CInt(Val(tbtde.Text))
        sn = CInt(Val(tbsne.Text))
        If tbcod.Text <> "" And tbape.Text <> "" And tbnom.Text <> "" _
        And nudeda.Value >= 18 And (rbmas.Checked = True Or rbfem.Checked = True) _
        And cbeci.SelectedIndex >= 0 And su > 0 And be > 0 And de > 0 And sn > 0 Then
            btngra.Enabled = True
        Else
            btngra.Enabled = False
        End If
    End Sub

    Private Sub tbape_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbape.TextChanged
        Habilitar()
    End Sub

    Private Sub tbcod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcod.SelectedIndexChanged
        Habilitar()
        Try
            Dim dt As New DataTable
            dt = objO.getdatosper(tbcod.Text)
            tbape.Text = CStr(dt.Rows(0)(0))
            tbnom.Text = CStr(dt.Rows(0)(1))
            nudeda.Value = CDec(dt.Rows(0)(2))
            If CStr(dt.Rows(0)(3)).ToUpper = "MASCULINO" Then
                rbmas.Checked = True
            Else
                rbfem.Checked = True
            End If
            If CStr(dt.Rows(0)(4)).ToUpper = "SOLTERO" Then
                cbeci.Text = "Soltero"
            ElseIf CStr(dt.Rows(0)(4)).ToUpper = "CASADO" Then
                cbeci.Text = "Casado"
            ElseIf CStr(dt.Rows(0)(4)).ToUpper = "VIUDO" Then
                cbeci.Text = "Viudo"
            ElseIf CStr(dt.Rows(0)(4)).ToUpper = "DIVORCIADO" Then
                cbeci.Text = "Divorciado"
            End If
        Catch ex As Exception

        End Try
    End Sub
    End Sub

    Private Sub tbnom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnom.TextChanged
        Habilitar()
    End Sub

    Private Sub nudeda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudeda.ValueChanged
        Habilitar()
    End Sub

    Private Sub cbeci_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeci.SelectedIndexChanged
        Habilitar()
    End Sub

    Private Sub rbmas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmas.CheckedChanged
        Habilitar()
    End Sub

    Private Sub rbfem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfem.CheckedChanged
        Habilitar()
    End Sub

    Private Sub tbnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnum.TextChanged
        Habilitar()
    End Sub

    Private Sub tbsue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsue.TextChanged
        Habilitar()
    End Sub

    Private Sub tbtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtde.TextChanged
        Habilitar()
    End Sub

    Private Sub tbtbe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtbe.TextChanged
        Habilitar()
    End Sub

    Private Sub tbsne_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsne.TextChanged
        Habilitar()
    End Sub

    Private Sub registro_planillas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tbcod.DataSource = objO.GetCodPer
            tbcod.DisplayMember = "CodPer"
            tbcod.SelectedIndex = -1
        Catch ex As Exception
            Label12.Text = ex.Message
        End Try
    End Sub
End Class