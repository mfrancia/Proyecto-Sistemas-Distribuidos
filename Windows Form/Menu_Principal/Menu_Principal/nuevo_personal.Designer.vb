<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevo_personal
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtape = New System.Windows.Forms.TextBox
        Me.txtnom = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdni = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.nuedad = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbsexo = New System.Windows.Forms.ComboBox
        Me.cbest = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtem = New System.Windows.Forms.TextBox
        Me.txttel = New System.Windows.Forms.TextBox
        Me.cbdis = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.rbdiu = New System.Windows.Forms.RadioButton
        Me.rbnoc = New System.Windows.Forms.RadioButton
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtdir = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.chkem = New System.Windows.Forms.CheckBox
        Me.chktel = New System.Windows.Forms.CheckBox
        Me.cbarea = New System.Windows.Forms.ComboBox
        Me.cbcar = New System.Windows.Forms.ComboBox
        CType(Me.nuedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUEVO PERSONAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres:"
        '
        'txtape
        '
        Me.txtape.Enabled = False
        Me.txtape.Location = New System.Drawing.Point(98, 100)
        Me.txtape.Name = "txtape"
        Me.txtape.Size = New System.Drawing.Size(199, 20)
        Me.txtape.TabIndex = 2
        '
        'txtnom
        '
        Me.txtnom.Enabled = False
        Me.txtnom.Location = New System.Drawing.Point(98, 126)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(199, 20)
        Me.txtnom.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos:"
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Location = New System.Drawing.Point(98, 152)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(80, 20)
        Me.txtdni.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Edad:"
        '
        'nuedad
        '
        Me.nuedad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nuedad.Enabled = False
        Me.nuedad.Location = New System.Drawing.Point(98, 178)
        Me.nuedad.Maximum = New Decimal(New Integer() {55, 0, 0, 0})
        Me.nuedad.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nuedad.Name = "nuedad"
        Me.nuedad.ReadOnly = True
        Me.nuedad.Size = New System.Drawing.Size(46, 20)
        Me.nuedad.TabIndex = 8
        Me.nuedad.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sexo:"
        '
        'cbsexo
        '
        Me.cbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsexo.Enabled = False
        Me.cbsexo.FormattingEnabled = True
        Me.cbsexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbsexo.Location = New System.Drawing.Point(98, 209)
        Me.cbsexo.Name = "cbsexo"
        Me.cbsexo.Size = New System.Drawing.Size(121, 21)
        Me.cbsexo.TabIndex = 10
        '
        'cbest
        '
        Me.cbest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbest.Enabled = False
        Me.cbest.FormattingEnabled = True
        Me.cbest.Items.AddRange(New Object() {"Casado", "Conviviente", "Divorciado", "Soltero", "Viudo"})
        Me.cbest.Location = New System.Drawing.Point(98, 236)
        Me.cbest.Name = "cbest"
        Me.cbest.Size = New System.Drawing.Size(121, 21)
        Me.cbest.Sorted = True
        Me.cbest.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Estado civil:"
        '
        'txtem
        '
        Me.txtem.Enabled = False
        Me.txtem.Location = New System.Drawing.Point(97, 266)
        Me.txtem.Name = "txtem"
        Me.txtem.Size = New System.Drawing.Size(181, 20)
        Me.txtem.TabIndex = 16
        '
        'txttel
        '
        Me.txttel.Enabled = False
        Me.txttel.Location = New System.Drawing.Point(97, 292)
        Me.txttel.MaxLength = 8
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(80, 20)
        Me.txttel.TabIndex = 18
        '
        'cbdis
        '
        Me.cbdis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdis.Enabled = False
        Me.cbdis.FormattingEnabled = True
        Me.cbdis.Location = New System.Drawing.Point(97, 318)
        Me.cbdis.Name = "cbdis"
        Me.cbdis.Size = New System.Drawing.Size(132, 21)
        Me.cbdis.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Distrito:"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(67, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 33)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 33)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(336, 390)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 33)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Volver"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Enabled = False
        Me.dtp1.Location = New System.Drawing.Point(306, 151)
        Me.dtp1.MinDate = New Date(1850, 1, 1, 0, 0, 0, 0)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(303, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Establesca la Fecha de Ingreso:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(302, 308)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Cargo:"
        '
        'rbdiu
        '
        Me.rbdiu.AutoSize = True
        Me.rbdiu.Location = New System.Drawing.Point(17, 19)
        Me.rbdiu.Name = "rbdiu"
        Me.rbdiu.Size = New System.Drawing.Size(56, 17)
        Me.rbdiu.TabIndex = 28
        Me.rbdiu.TabStop = True
        Me.rbdiu.Text = "Diurno"
        Me.rbdiu.UseVisualStyleBackColor = True
        '
        'rbnoc
        '
        Me.rbnoc.AutoSize = True
        Me.rbnoc.Location = New System.Drawing.Point(97, 19)
        Me.rbnoc.Name = "rbnoc"
        Me.rbnoc.Size = New System.Drawing.Size(69, 17)
        Me.rbnoc.TabIndex = 29
        Me.rbnoc.TabStop = True
        Me.rbnoc.Text = "Nocturno"
        Me.rbnoc.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.rbdiu)
        Me.gb1.Controls.Add(Me.rbnoc)
        Me.gb1.Enabled = False
        Me.gb1.Location = New System.Drawing.Point(306, 242)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 44)
        Me.gb1.TabIndex = 30
        Me.gb1.TabStop = False
        Me.gb1.Text = "Eliga el Turno"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(303, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Seleccione el Area de Trabajo:"
        '
        'txtdir
        '
        Me.txtdir.Enabled = False
        Me.txtdir.Location = New System.Drawing.Point(97, 345)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(408, 20)
        Me.txtdir.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Dirección:"
        '
        'txtcod
        '
        Me.txtcod.BackColor = System.Drawing.SystemColors.Info
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(382, 100)
        Me.txtcod.MaxLength = 8
        Me.txtcod.Name = "txtcod"
        Me.txtcod.ReadOnly = True
        Me.txtcod.Size = New System.Drawing.Size(124, 22)
        Me.txtcod.TabIndex = 36
        Me.txtcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(315, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "CODIGO:"
        '
        'chkem
        '
        Me.chkem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkem.Enabled = False
        Me.chkem.Location = New System.Drawing.Point(23, 266)
        Me.chkem.Name = "chkem"
        Me.chkem.Size = New System.Drawing.Size(63, 17)
        Me.chkem.TabIndex = 37
        Me.chkem.Text = "Email"
        Me.chkem.UseVisualStyleBackColor = True
        '
        'chktel
        '
        Me.chktel.AutoSize = True
        Me.chktel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chktel.Enabled = False
        Me.chktel.Location = New System.Drawing.Point(18, 292)
        Me.chktel.Name = "chktel"
        Me.chktel.Size = New System.Drawing.Size(68, 17)
        Me.chktel.TabIndex = 38
        Me.chktel.Text = "Teléfono"
        Me.chktel.UseVisualStyleBackColor = True
        '
        'cbarea
        '
        Me.cbarea.Enabled = False
        Me.cbarea.FormattingEnabled = True
        Me.cbarea.Location = New System.Drawing.Point(306, 213)
        Me.cbarea.Name = "cbarea"
        Me.cbarea.Size = New System.Drawing.Size(199, 21)
        Me.cbarea.TabIndex = 39
        '
        'cbcar
        '
        Me.cbcar.Enabled = False
        Me.cbcar.FormattingEnabled = True
        Me.cbcar.Location = New System.Drawing.Point(360, 305)
        Me.cbcar.Name = "cbcar"
        Me.cbcar.Size = New System.Drawing.Size(145, 21)
        Me.cbcar.TabIndex = 40
        '
        'nuevo_personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 448)
        Me.Controls.Add(Me.cbcar)
        Me.Controls.Add(Me.cbarea)
        Me.Controls.Add(Me.chktel)
        Me.Controls.Add(Me.chkem)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtdir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbdis)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.txtem)
        Me.Controls.Add(Me.cbest)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbsexo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nuedad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtape)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "nuevo_personal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro - Nuevo Personal"
        CType(Me.nuedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtape As System.Windows.Forms.TextBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nuedad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbsexo As System.Windows.Forms.ComboBox
    Friend WithEvents cbest As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtem As System.Windows.Forms.TextBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents cbdis As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rbdiu As System.Windows.Forms.RadioButton
    Friend WithEvents rbnoc As System.Windows.Forms.RadioButton
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdir As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkem As System.Windows.Forms.CheckBox
    Friend WithEvents chktel As System.Windows.Forms.CheckBox
    Friend WithEvents cbarea As System.Windows.Forms.ComboBox
    Friend WithEvents cbcar As System.Windows.Forms.ComboBox
End Class
