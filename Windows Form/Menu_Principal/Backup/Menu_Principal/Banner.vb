Public Class Banner
    Private Sub Banner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity -= 0.01
        If Me.Opacity = 0.0 Then
            Me.Timer1.Enabled = False
            Me.Hide()
            Login.Show()
        End If
    End Sub

End Class