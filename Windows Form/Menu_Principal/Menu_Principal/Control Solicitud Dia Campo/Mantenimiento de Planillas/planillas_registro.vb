Option Strict On
Imports System.Data.SqlClient
Imports System.Data
Public Class planillas_registro
    Dim cn As New SqlConnection("server=.;initial catalog=Sistema Integrado;uid=Deyvis;password=huaman")
    Dim da As New SqlDataAdapter("", cn)
    Dim ds As New DataSet
    Private Sub planillas_registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub limpiar()
        tbnro.Clear()
        tbper.Clear()
        cbare.Text = ""
        cbcar.Text = ""
        tbbru.Clear()
        tbdes.Clear()
        tbtot.Clear()
    End Sub

    Private Sub btagr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btagr.Click
        lbnro.Items.Add(tbnro.Text)
        lbnom.Items.Add(tbper.Text)
        lbbru.Items.Add(tbbru.Text)
        lbdes.Items.Add(tbdes.Text)
        lbtot.Items.Add(tbtot.Text)
    End Sub
    Private Sub btnue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnue.Click
        limpiar()
    End Sub

    Private Sub btvol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btvol.Click

        If tbnro.Text <> "" Or tbper.Text <> "" Or cbare.SelectedIndex > 0 _
                Or cbcar.SelectedIndex > 0 Or tbbru.Text <> "" Or tbdes.Text <> "" _
                Or tbtot.Text <> "" Then
          
            Me.Close()

        Else
            btagr.Enabled = False

        End If
    End Sub
    Sub validar_cajas()
        If tbnro.Text <> "" And tbper.Text <> "" And cbare.SelectedIndex > 0 _
        And cbcar.SelectedIndex > 0 And tbbru.Text <> "" And tbdes.Text <> "" _
        And tbtot.Text <> "" Then
            btagr.Enabled = True
        Else
            btagr.Enabled = False

        End If
    End Sub

    Private Sub tbbru_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbbru.KeyPress
        Select Case e.KeyChar
            Case Chr(48) To Chr(57), Chr(13), Chr(8)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub tbbon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbbon.KeyPress
        tbbru_KeyPress(sender, e)
    End Sub

    Private Sub tbdes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbdes.KeyPress
        Select Case e.KeyChar
            Case Chr(48) To Chr(57), Chr(13), Chr(8)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub tbtot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbtot.KeyPress
        tbdes_KeyPress(sender, e)
    End Sub

    Private Sub tbper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbper.KeyPress
        Select Case e.KeyChar
            Case Chr(97) To Chr(192), Chr(241), Chr(13)
                e.Handled = False
            Case Chr(65) To Chr(90), Chr(209), Chr(8), Chr(32)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub


End Class