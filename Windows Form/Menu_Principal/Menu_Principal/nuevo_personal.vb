Imports System.Data.SqlClient
Imports System.Data
Public Class nuevo_personal
    Dim cn As New SqlConnection("server=.;initial catalog=Sistema Integrado;uid=felipe;password=ramos")
    Public da As New SqlDataAdapter("", cn)
    Dim ds As New DataSet
    Public cod As String
    Private Sub nuevo_personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        motrar_distritos()
        mostrar_areas()
        dtp1.MaxDate = Today
        dtp1.MinDate = Today.AddMonths(-3)
    End Sub
    Private Sub chkem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkem.CheckedChanged
        validar()
        If chkem.Checked = True Then
            txtem.Enabled = True
            txtem.Focus()
        Else
            txtem.Text = ""
            txtem.Enabled = False
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("get_cod_per", cn)
            'da.SelectCommand.CommandText = "get_cod_per"
            'da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            txtcod.Text = dt.Rows(0).Item(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        activando_cajas(True)
        Button2.Enabled = False
        txtape.Text = ""
        txtnom.Text = ""
        txtdni.Text = ""
        nuedad.Value = 18
        cbsexo.SelectedIndex = -1
        cbest.SelectedIndex = -1
        chkem.Checked = False
        chktel.Checked = False
        cbdis.DisplayMember = 0
        txtdir.Text = ""
        dtp1.Value = Today
        cbarea.DisplayMember = 0
        rbdiu.Checked = False
        rbnoc.Checked = False
        cbcar.SelectedIndex = -1
    End Sub
    Private Sub chktel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktel.CheckedChanged
        validar()
        If chktel.Checked = True Then
            txttel.Enabled = True
            txttel.Focus()
        Else
            txttel.Text = ""
            txttel.Enabled = False
        End If
    End Sub
    Sub motrar_distritos()
        Try
            da.SelectCommand.CommandText = "get_distritos"
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "distritos")
            cbdis.DataSource = ds.Tables("distritos")
            cbdis.DisplayMember = "NomDis"
            cbdis.ValueMember = "CodDis"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub mostrar_areas()
        Try
            da.SelectCommand.CommandText = "get_area"
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "areas")
            cbarea.DataSource = ds.Tables("areas")
            cbarea.DisplayMember = "NomArea"
            cbarea.ValueMember = "CodArea"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbarea.SelectedIndexChanged
        Try
            Dim dt As New DataTable
            da.SelectCommand.CommandText = "get_car_personal"
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            dt.Clear()
            da.SelectCommand.Parameters.Clear()
            da.SelectCommand.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Char, 3)).Value = cbarea.SelectedValue.ToString
            da.Fill(dt)
            cbcar.DataSource = dt
            cbcar.DisplayMember = "DesCargo"
            cbcar.ValueMember = "CodCargo"
            validar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub validar()
        If txtape.Text.Trim <> "" And txtnom.Text.Trim <> "" And txtdni.Text.Trim.Length = 8 _
        And cbsexo.SelectedIndex > -1 And cbest.SelectedIndex > -1 _
        And cbdis.SelectedIndex > -1 And txtdir.Text.Trim <> "" _
        And (rbdiu.Checked = True Or rbnoc.Checked = True) And cbcar.SelectedIndex > -1 Then
            If chkem.Checked = True And InStr(txtem.Text.Trim, "@") + 1 > 2 And (chktel.Checked = False) Then
                Button1.Enabled = True
            ElseIf chkem.Checked = True And InStr(txtem.Text.Trim, "@") + 1 < 3 And (chktel.Checked = False) Then
                Button1.Enabled = False
            ElseIf chkem.Checked = False And chktel.Checked = False Then
                Button1.Enabled = True
            ElseIf chktel.Checked = True And txttel.Text.Trim.Length > 6 And (chkem.Checked = False) Then
                Button1.Enabled = True
            ElseIf chktel.Checked = True And txttel.Text.Trim.Length < 7 And (chkem.Checked = False) Then
                Button1.Enabled = False
            ElseIf chktel.Checked = True And chkem.Checked = True Then
                If InStr(txtem.Text.Trim, "@") + 1 > 2 And txttel.Text.Trim.Length > 6 Then
                    Button1.Enabled = True
                Else
                    Button1.Enabled = False
                End If
            End If
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub txtape_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtape.KeyPress
        Select Case e.KeyChar
            Case Chr(97) To Chr(192), Chr(241), Chr(13)
                e.Handled = False
            Case Chr(65) To Chr(90), Chr(209), Chr(8)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtape_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtape.TextChanged
        validar()
    End Sub
    Private Sub txtnom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom.KeyPress
        Select Case e.KeyChar
            Case Chr(97) To Chr(192), Chr(241), Chr(13)
                e.Handled = False
            Case Chr(65) To Chr(90), Chr(209), Chr(8)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtnom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom.TextChanged
        validar()
    End Sub
    Private Sub txtdni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        Select Case e.KeyChar
            Case Chr(48) To Chr(57), Chr(13), Chr(8)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtdni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdni.TextChanged
        validar()
    End Sub
    Private Sub cbsexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsexo.SelectedIndexChanged
        validar()
    End Sub
    Private Sub cbest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbest.SelectedIndexChanged
        validar()
    End Sub
    Private Sub cbdis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbdis.SelectedIndexChanged
        validar()
    End Sub
    Private Sub txtdir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdir.TextChanged
        validar()
    End Sub
    Private Sub rbdiu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdiu.CheckedChanged
        validar()
    End Sub
    Private Sub rbnoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnoc.CheckedChanged
        validar()
    End Sub
    Private Sub cbcar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcar.SelectedIndexChanged
        validar()
    End Sub
    Private Sub txtem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtem.TextChanged
        validar()
    End Sub
    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress
        Select Case e.KeyChar
            Case Chr(48) To Chr(57), Chr(13), Chr(8)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txttel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttel.TextChanged
        validar()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand("set_grabar_personal", cn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@ape", SqlDbType.Char, 50)).Value = txtape.Text.Trim
                .Parameters.Add(New SqlParameter("@nom", SqlDbType.Char, 50)).Value = txtnom.Text.Trim
                .Parameters.Add(New SqlParameter("@dni", SqlDbType.VarChar, 8)).Value = txtdni.Text.Trim
                .Parameters.Add(New SqlParameter("@edad", SqlDbType.VarChar, 2)).Value = nuedad.Value.ToString
                .Parameters.Add(New SqlParameter("@sexo", SqlDbType.VarChar, 9)).Value = cbsexo.SelectedItem.ToString
                .Parameters.Add(New SqlParameter("@e_civil", SqlDbType.VarChar, 11)).Value = cbest.SelectedItem.ToString
                .Parameters.Add(New SqlParameter("@tel", SqlDbType.VarChar, 8)).Value = txttel.Text.Trim
                .Parameters.Add(New SqlParameter("@dir", SqlDbType.VarChar, 200)).Value = txtdir.Text.Trim
                .Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 150)).Value = txtem.Text.Trim
                .Parameters.Add(New SqlParameter("@area", SqlDbType.Char, 3)).Value = cbarea.SelectedValue.ToString
                .Parameters.Add(New SqlParameter("@cargo", SqlDbType.Char, 3)).Value = cbcar.SelectedValue.ToString
                .Parameters.Add(New SqlParameter("@fing", SqlDbType.DateTime)).Value = dtp1.Value.Date
                If rbdiu.Checked = True Then
                    .Parameters.Add(New SqlParameter("@tur", SqlDbType.VarChar, 8)).Value = rbdiu.Text
                ElseIf rbnoc.Checked = True Then
                    .Parameters.Add(New SqlParameter("@tur", SqlDbType.VarChar, 8)).Value = rbnoc.Text
                End If
                .Parameters.Add(New SqlParameter("@ret", SqlDbType.Char, 2)).Value = "No"
            End With
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Se grabaron los Datos", 0 + 64, "Guardando Transacción")
            Button1.Enabled = False
            Button2.Enabled = True
            activando_cajas(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
    Sub activando_cajas(ByVal res As Boolean)
        If res = True Then
            txtnom.Enabled = True
            txtape.Enabled = True
            txtdni.Enabled = True
            cbsexo.Enabled = True
            cbdis.Enabled = True
            cbarea.Enabled = True
            cbcar.Enabled = True
            dtp1.Enabled = True
            cbest.Enabled = True
            nuedad.Enabled = True
            txtdir.Enabled = True
            gb1.Enabled = True
            chkem.Enabled = True
            chktel.Enabled = True
            txtape.Focus()
        Else
            txtnom.Enabled = False
            txtape.Enabled = False
            txtdni.Enabled = False
            cbsexo.Enabled = False
            cbdis.Enabled = False
            cbarea.Enabled = False
            cbcar.Enabled = False
            dtp1.Enabled = False
            cbest.Enabled = False
            nuedad.Enabled = False
            txtdir.Enabled = False
            txtem.Enabled = False
            txttel.Enabled = False
            gb1.Enabled = False
            chkem.Enabled = False
            chktel.Enabled = False
            Button2.Focus()
            Button2.Enabled = True
        End If
    End Sub
End Class
