<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.cbtip_usu = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblmsg = New System.Windows.Forms.Label
        Me.tbusu = New System.Windows.Forms.TextBox
        Me.tbcon = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.img_error = New System.Windows.Forms.PictureBox
        Me.img_ok = New System.Windows.Forms.PictureBox
        Me.pb_usu = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_error, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_usu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbtip_usu
        '
        Me.cbtip_usu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtip_usu.FormattingEnabled = True
        Me.cbtip_usu.Location = New System.Drawing.Point(105, 14)
        Me.cbtip_usu.Name = "cbtip_usu"
        Me.cbtip_usu.Size = New System.Drawing.Size(198, 21)
        Me.cbtip_usu.Sorted = True
        Me.cbtip_usu.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tipo de Usuario:"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(70, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 24)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(197, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 24)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Contraseña:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'lblmsg
        '
        Me.lblmsg.ForeColor = System.Drawing.Color.DarkRed
        Me.lblmsg.Location = New System.Drawing.Point(101, 66)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(153, 13)
        Me.lblmsg.TabIndex = 24
        '
        'tbusu
        '
        Me.tbusu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbusu.Location = New System.Drawing.Point(104, 44)
        Me.tbusu.Name = "tbusu"
        Me.tbusu.ReadOnly = True
        Me.tbusu.Size = New System.Drawing.Size(199, 20)
        Me.tbusu.TabIndex = 28
        '
        'tbcon
        '
        Me.tbcon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbcon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcon.Location = New System.Drawing.Point(105, 81)
        Me.tbcon.Name = "tbcon"
        Me.tbcon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbcon.ReadOnly = True
        Me.tbcon.Size = New System.Drawing.Size(198, 21)
        Me.tbcon.TabIndex = 29
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.Menu_Principal.My.Resources.Resources.campo3
        Me.PictureBox2.Location = New System.Drawing.Point(334, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'img_error
        '
        Me.img_error.Image = Global.Menu_Principal.My.Resources.Resources.usu_2
        Me.img_error.Location = New System.Drawing.Point(4, 70)
        Me.img_error.Name = "img_error"
        Me.img_error.Size = New System.Drawing.Size(21, 18)
        Me.img_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_error.TabIndex = 23
        Me.img_error.TabStop = False
        Me.img_error.Visible = False
        '
        'img_ok
        '
        Me.img_ok.Image = Global.Menu_Principal.My.Resources.Resources.usu_1
        Me.img_ok.Location = New System.Drawing.Point(4, 44)
        Me.img_ok.Name = "img_ok"
        Me.img_ok.Size = New System.Drawing.Size(21, 18)
        Me.img_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_ok.TabIndex = 22
        Me.img_ok.TabStop = False
        Me.img_ok.Visible = False
        '
        'pb_usu
        '
        Me.pb_usu.Location = New System.Drawing.Point(309, 43)
        Me.pb_usu.Name = "pb_usu"
        Me.pb_usu.Size = New System.Drawing.Size(21, 20)
        Me.pb_usu.TabIndex = 21
        Me.pb_usu.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(513, 151)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbcon)
        Me.Controls.Add(Me.tbusu)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.img_error)
        Me.Controls.Add(Me.img_ok)
        Me.Controls.Add(Me.pb_usu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbtip_usu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login De Acceso Al Sistema"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_error, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_usu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbtip_usu As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pb_usu As System.Windows.Forms.PictureBox
    Friend WithEvents img_ok As System.Windows.Forms.PictureBox
    Friend WithEvents img_error As System.Windows.Forms.PictureBox
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tbusu As System.Windows.Forms.TextBox
    Friend WithEvents tbcon As System.Windows.Forms.TextBox
End Class
