<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class planillas
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
        Me.tbnom = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbest = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbsex = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbdni = New System.Windows.Forms.TextBox
        Me.tbape = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbcod = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbneto = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tbdes = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tbben = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbsue = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkfon = New System.Windows.Forms.CheckBox
        Me.chkafp = New System.Windows.Forms.CheckBox
        Me.chkcts = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkdom = New System.Windows.Forms.CheckBox
        Me.chkfam = New System.Windows.Forms.CheckBox
        Me.chkvac = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbnum = New System.Windows.Forms.TextBox
        Me.btncalcular = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.tbsalir = New System.Windows.Forms.Button
        Me.lblmsg = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Planillas de Personal"
        '
        'tbnom
        '
        Me.tbnom.Location = New System.Drawing.Point(69, 38)
        Me.tbnom.Name = "tbnom"
        Me.tbnom.ReadOnly = True
        Me.tbnom.Size = New System.Drawing.Size(146, 20)
        Me.tbnom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbest)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbsex)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbdni)
        Me.GroupBox1.Controls.Add(Me.tbape)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbcod)
        Me.GroupBox1.Controls.Add(Me.tbnom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 162)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Personal"
        '
        'tbest
        '
        Me.tbest.Location = New System.Drawing.Point(69, 131)
        Me.tbest.Name = "tbest"
        Me.tbest.ReadOnly = True
        Me.tbest.Size = New System.Drawing.Size(146, 20)
        Me.tbest.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Estado Civil:"
        '
        'tbsex
        '
        Me.tbsex.Location = New System.Drawing.Point(69, 108)
        Me.tbsex.Name = "tbsex"
        Me.tbsex.ReadOnly = True
        Me.tbsex.Size = New System.Drawing.Size(100, 20)
        Me.tbsex.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DNI:"
        '
        'tbdni
        '
        Me.tbdni.Location = New System.Drawing.Point(69, 84)
        Me.tbdni.Name = "tbdni"
        Me.tbdni.ReadOnly = True
        Me.tbdni.Size = New System.Drawing.Size(100, 20)
        Me.tbdni.TabIndex = 7
        '
        'tbape
        '
        Me.tbape.Location = New System.Drawing.Point(69, 61)
        Me.tbape.Name = "tbape"
        Me.tbape.ReadOnly = True
        Me.tbape.Size = New System.Drawing.Size(229, 20)
        Me.tbape.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'cbcod
        '
        Me.cbcod.FormattingEnabled = True
        Me.cbcod.Location = New System.Drawing.Point(69, 14)
        Me.cbcod.Name = "cbcod"
        Me.cbcod.Size = New System.Drawing.Size(121, 21)
        Me.cbcod.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbneto)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbdes)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbben)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbsue)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbnum)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 192)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago"
        '
        'tbneto
        '
        Me.tbneto.Location = New System.Drawing.Point(243, 164)
        Me.tbneto.Name = "tbneto"
        Me.tbneto.ReadOnly = True
        Me.tbneto.Size = New System.Drawing.Size(73, 20)
        Me.tbneto.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(177, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Sueldo Neto:"
        '
        'tbdes
        '
        Me.tbdes.Location = New System.Drawing.Point(94, 164)
        Me.tbdes.Name = "tbdes"
        Me.tbdes.ReadOnly = True
        Me.tbdes.Size = New System.Drawing.Size(73, 20)
        Me.tbdes.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Tot Descuento:"
        '
        'tbben
        '
        Me.tbben.Location = New System.Drawing.Point(222, 135)
        Me.tbben.Name = "tbben"
        Me.tbben.ReadOnly = True
        Me.tbben.Size = New System.Drawing.Size(94, 20)
        Me.tbben.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(165, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Tot Benef:"
        '
        'tbsue
        '
        Me.tbsue.Location = New System.Drawing.Point(56, 135)
        Me.tbsue.MaxLength = 6
        Me.tbsue.Name = "tbsue"
        Me.tbsue.Size = New System.Drawing.Size(100, 20)
        Me.tbsue.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Sueldo:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkfon)
        Me.GroupBox4.Controls.Add(Me.chkafp)
        Me.GroupBox4.Controls.Add(Me.chkcts)
        Me.GroupBox4.Location = New System.Drawing.Point(174, 47)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 83)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Descuentos"
        '
        'chkfon
        '
        Me.chkfon.AutoSize = True
        Me.chkfon.Location = New System.Drawing.Point(11, 51)
        Me.chkfon.Name = "chkfon"
        Me.chkfon.Size = New System.Drawing.Size(78, 17)
        Me.chkfon.TabIndex = 2
        Me.chkfon.Text = "Fonavi  8%"
        Me.chkfon.UseVisualStyleBackColor = True
        '
        'chkafp
        '
        Me.chkafp.AutoSize = True
        Me.chkafp.Location = New System.Drawing.Point(11, 34)
        Me.chkafp.Name = "chkafp"
        Me.chkafp.Size = New System.Drawing.Size(72, 17)
        Me.chkafp.TabIndex = 1
        Me.chkafp.Text = "A.F.P  7%"
        Me.chkafp.UseVisualStyleBackColor = True
        '
        'chkcts
        '
        Me.chkcts.AutoSize = True
        Me.chkcts.Location = New System.Drawing.Point(11, 17)
        Me.chkcts.Name = "chkcts"
        Me.chkcts.Size = New System.Drawing.Size(76, 17)
        Me.chkcts.TabIndex = 0
        Me.chkcts.Text = "C.T.S 10%"
        Me.chkcts.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkdom)
        Me.GroupBox3.Controls.Add(Me.chkfam)
        Me.GroupBox3.Controls.Add(Me.chkvac)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 85)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Beneficios"
        '
        'chkdom
        '
        Me.chkdom.AutoSize = True
        Me.chkdom.Location = New System.Drawing.Point(11, 57)
        Me.chkdom.Name = "chkdom"
        Me.chkdom.Size = New System.Drawing.Size(106, 17)
        Me.chkdom.TabIndex = 2
        Me.chkdom.Text = "Dominicales 15%"
        Me.chkdom.UseVisualStyleBackColor = True
        '
        'chkfam
        '
        Me.chkfam.AutoSize = True
        Me.chkfam.Location = New System.Drawing.Point(11, 38)
        Me.chkfam.Name = "chkfam"
        Me.chkfam.Size = New System.Drawing.Size(84, 17)
        Me.chkfam.TabIndex = 1
        Me.chkfam.Text = "Familiar 20%"
        Me.chkfam.UseVisualStyleBackColor = True
        '
        'chkvac
        '
        Me.chkvac.AutoSize = True
        Me.chkvac.Location = New System.Drawing.Point(11, 20)
        Me.chkvac.Name = "chkvac"
        Me.chkvac.Size = New System.Drawing.Size(105, 17)
        Me.chkvac.TabIndex = 0
        Me.chkvac.Text = "Vacaciones 30%"
        Me.chkvac.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "numero de pago:"
        '
        'tbnum
        '
        Me.tbnum.Location = New System.Drawing.Point(118, 19)
        Me.tbnum.Name = "tbnum"
        Me.tbnum.ReadOnly = True
        Me.tbnum.Size = New System.Drawing.Size(100, 20)
        Me.tbnum.TabIndex = 0
        '
        'btncalcular
        '
        Me.btncalcular.Enabled = False
        Me.btncalcular.Location = New System.Drawing.Point(30, 453)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 5
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Enabled = False
        Me.btngrabar.Location = New System.Drawing.Point(118, 453)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 23)
        Me.btngrabar.TabIndex = 6
        Me.btngrabar.Text = "Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Enabled = False
        Me.btnnuevo.Location = New System.Drawing.Point(209, 453)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 7
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'tbsalir
        '
        Me.tbsalir.Location = New System.Drawing.Point(301, 453)
        Me.tbsalir.Name = "tbsalir"
        Me.tbsalir.Size = New System.Drawing.Size(75, 23)
        Me.tbsalir.TabIndex = 8
        Me.tbsalir.Text = "Salir"
        Me.tbsalir.UseVisualStyleBackColor = True
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Location = New System.Drawing.Point(12, 479)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(45, 13)
        Me.lblmsg.TabIndex = 9
        Me.lblmsg.Text = "Label13"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'planillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 519)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.tbsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "planillas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "planillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbcod As System.Windows.Forms.ComboBox
    Friend WithEvents tbest As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbsex As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbdni As System.Windows.Forms.TextBox
    Friend WithEvents tbape As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkcts As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkdom As System.Windows.Forms.CheckBox
    Friend WithEvents chkfam As System.Windows.Forms.CheckBox
    Friend WithEvents chkvac As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbnum As System.Windows.Forms.TextBox
    Friend WithEvents tbneto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbdes As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbben As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbsue As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkfon As System.Windows.Forms.CheckBox
    Friend WithEvents chkafp As System.Windows.Forms.CheckBox
    Friend WithEvents btncalcular As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents tbsalir As System.Windows.Forms.Button
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
