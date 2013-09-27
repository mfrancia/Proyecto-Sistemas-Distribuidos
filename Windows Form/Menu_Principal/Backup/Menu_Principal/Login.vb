Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Login
    Dim s As Integer
    Dim dt1 As New DataTable
    Dim str As String = ""
    Private Sub tbusu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbusu.TextChanged
        If Trim(tbusu.Text) <> "" Then

            str = " select trim(CoUsuario) CoUsuario, trim(CoTipoUsuario) TipoUsuario," & _
                  " trim(NoEmail) as NomUsuario, NoContrasena as Clave from usuario" & _
                  " where CoTipoUsuario = " & cbtip_usu.SelectedValue & _
                  " and UPPER(NoEmail) = '" & tbusu.Text.Trim & "'"

            Dim da As New MySQLDataAdapter(str, cn)
            tbcon.ReadOnly = True
            tbcon.Text = ""
            lblmsg.Text = ""
            dt1.Clear()
            da.SelectCommand.CommandType = CommandType.Text
            'With da.SelectCommand.Parameters
            '        .Add(New MySQLParameter("@codnivel", SqlDbType.VarChar, 3)).ToString = cbtip_usu.SelectedValue
            '        .Add(New MySQLParameter("@NomUsu", SqlDbType.VarChar, 50)).Value = Trim(tbusu.Text)
            'End With
            da.Fill(dt1)
            s = 0
            pb_usu.Image = Nothing
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        s = s + 1
        If s = 60 Then
            If dt1.Rows.Count > 0 Then
                pb_usu.Image = img_ok.Image
                lblmsg.Text = ""
                tbcon.ReadOnly = False
                tbcon.Focus()
            Else
                pb_usu.Image = img_error.Image
                lblmsg.Text = "El Usuario No Existe"
                tbusu.Focus()
            End If
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        str = " select CoSubCtl as Codigo, trim(NoDescripcion) as Desnivel from catalogo" & _
              " where CoCtl = 2" & _
              " order by 2 asc"

        Dim da As New MySQLDataAdapter(str, cn)
        Dim dt As New DataTable

        Try
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(dt)
            cbtip_usu.DataSource = dt
            cbtip_usu.DisplayMember = "DesNivel"
            cbtip_usu.ValueMember = "Codigo"
            cbtip_usu.SelectedIndex = -1
        Catch ex As MySQLException
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim res As MsgBoxResult
        res = MsgBox("Está seguro de Salir?", 32 + 4, "Salir")
        If res = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub tbcon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcon.TextChanged
        If Trim(tbcon.Text) <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub cbtip_usu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtip_usu.SelectedIndexChanged
        Select Case cbtip_usu.SelectedIndex
            Case Is > -1
                tbusu.ReadOnly = False
                tbusu.Focus()
            Case Else
                tbusu.ReadOnly = True
        End Select
        tbusu.Text = ""
        tbcon.Text = ""
        tbcon.ReadOnly = True
        lblmsg.Text = ""
        pb_usu.Image = Nothing
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As String = Trim(tbcon.Text)
        Dim da As New MySQLDataAdapter(str, cn)
        da.SelectCommand.CommandType = CommandType.Text

        'With da.SelectCommand.Parameters
        '    .Add(New SqlParameter("@codnivel", SqlDbType.VarChar, 3)).Value = cbtip_usu.SelectedValue
        '    .Add(New SqlParameter("@NomUsu", SqlDbType.VarChar, 50)).Value = Trim(tbusu.Text)
        'End With
        da.Fill(dt1)
        If con = UCase(dt1.Rows(0).Item(3).ToString) Then
            Form1.Show()
            codigo_usuario = Integer.Parse(dt1.Rows(0).Item(0).ToString)
            tipo_usuario = Integer.Parse(dt1.Rows(0).Item(1).ToString)
            Form1.lb_usuario.Text = UCase(dt1.Rows(0).Item(2).ToString)
            validar_perfil(tipo_usuario)
            Me.Close()
        Else
            MsgBox("La Contraseña es Incorrecta", 48, "Mensaje de Acceso")
        End If
    End Sub
    Sub validar_perfil(ByVal val As Integer)
        If val = 1 Then
            Form1.Menu_Aprobar_Solictud.Enabled = True
            Form1.Menu_Mantenimiento_Club.Enabled = True
        Else
            Form1.Menu_Aprobar_Solictud.Enabled = False
            Form1.Menu_Mantenimiento_Club.Enabled = False
        End If
    End Sub
End Class