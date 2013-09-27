<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegResponsablelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Aprobar_Solictud = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.Menu_Mantenimiento_Club = New System.Windows.Forms.ToolStripMenuItem
        Me.EntretenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JuegosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscaminasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lb_usuario = New System.Windows.Forms.Label
        Me.lbfecha = New System.Windows.Forms.Label
        Me.lbhora = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.EntretenimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SadToolStripMenuItem, Me.RegResponsablelToolStripMenuItem, Me.ToolStripMenuItem1, Me.EmpresaToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'SadToolStripMenuItem
        '
        Me.SadToolStripMenuItem.Name = "SadToolStripMenuItem"
        Me.SadToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SadToolStripMenuItem.Text = "Club's"
        '
        'RegResponsablelToolStripMenuItem
        '
        Me.RegResponsablelToolStripMenuItem.Image = Global.Menu_Principal.My.Resources.Resources.POINT06
        Me.RegResponsablelToolStripMenuItem.Name = "RegResponsablelToolStripMenuItem"
        Me.RegResponsablelToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RegResponsablelToolStripMenuItem.Text = "Responsable de Familia"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 6)
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Image = Global.Menu_Principal.My.Resources.Resources.POINT06
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonalToolStripMenuItem.Text = "Dia de Campo"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Aprobar_Solictud, Me.ToolStripMenuItem2, Me.Menu_Mantenimiento_Club})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'Menu_Aprobar_Solictud
        '
        Me.Menu_Aprobar_Solictud.Image = Global.Menu_Principal.My.Resources.Resources.POINT06
        Me.Menu_Aprobar_Solictud.Name = "Menu_Aprobar_Solictud"
        Me.Menu_Aprobar_Solictud.Size = New System.Drawing.Size(222, 22)
        Me.Menu_Aprobar_Solictud.Text = "Aprobar Solicitud de Clientes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(219, 6)
        '
        'Menu_Mantenimiento_Club
        '
        Me.Menu_Mantenimiento_Club.Name = "Menu_Mantenimiento_Club"
        Me.Menu_Mantenimiento_Club.Size = New System.Drawing.Size(222, 22)
        Me.Menu_Mantenimiento_Club.Text = "Club's"
        '
        'EntretenimientoToolStripMenuItem
        '
        Me.EntretenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JuegosToolStripMenuItem, Me.CalculadoraToolStripMenuItem})
        Me.EntretenimientoToolStripMenuItem.Name = "EntretenimientoToolStripMenuItem"
        Me.EntretenimientoToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.EntretenimientoToolStripMenuItem.Text = "Entretenimiento"
        '
        'JuegosToolStripMenuItem
        '
        Me.JuegosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscaminasToolStripMenuItem})
        Me.JuegosToolStripMenuItem.Name = "JuegosToolStripMenuItem"
        Me.JuegosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JuegosToolStripMenuItem.Text = "Juegos"
        '
        'BuscaminasToolStripMenuItem
        '
        Me.BuscaminasToolStripMenuItem.Name = "BuscaminasToolStripMenuItem"
        Me.BuscaminasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BuscaminasToolStripMenuItem.Text = "Buscaminas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.lb_usuario)
        Me.Panel1.Controls.Add(Me.lbfecha)
        Me.Panel1.Controls.Add(Me.lbhora)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 524)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 32)
        Me.Panel1.TabIndex = 5
        '
        'lb_usuario
        '
        Me.lb_usuario.BackColor = System.Drawing.Color.White
        Me.lb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_usuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.lb_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_usuario.Location = New System.Drawing.Point(386, 0)
        Me.lb_usuario.Name = "lb_usuario"
        Me.lb_usuario.Size = New System.Drawing.Size(345, 32)
        Me.lb_usuario.TabIndex = 2
        Me.lb_usuario.Text = "Usuario"
        Me.lb_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbfecha
        '
        Me.lbfecha.BackColor = System.Drawing.Color.White
        Me.lbfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbfecha.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbfecha.Location = New System.Drawing.Point(2, 5)
        Me.lbfecha.Name = "lbfecha"
        Me.lbfecha.Size = New System.Drawing.Size(295, 24)
        Me.lbfecha.TabIndex = 1
        Me.lbfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbhora
        '
        Me.lbhora.BackColor = System.Drawing.Color.White
        Me.lbhora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbhora.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhora.Location = New System.Drawing.Point(731, 0)
        Me.lbhora.Name = "lbhora"
        Me.lbhora.Size = New System.Drawing.Size(89, 32)
        Me.lbhora.TabIndex = 0
        Me.lbhora.Text = "Hora"
        Me.lbhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 556)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sistema ""ENTRETENIMIENTO FAMILIAR"""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegResponsablelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Mantenimiento_Club As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntretenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JuegosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscaminasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbhora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbfecha As System.Windows.Forms.Label
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Aprobar_Solictud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lb_usuario As System.Windows.Forms.Label

End Class
