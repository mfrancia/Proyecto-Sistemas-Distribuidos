<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro_planillas
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnlim = New System.Windows.Forms.Button
        Me.btngra = New System.Windows.Forms.Button
        Me.btncal = New System.Windows.Forms.Button
        Me.tbsne = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tbtde = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbtbe = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbsue = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.chkfon = New System.Windows.Forms.CheckBox
        Me.chkafp = New System.Windows.Forms.CheckBox
        Me.chkcts = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkdom = New System.Windows.Forms.CheckBox
        Me.chkfam = New System.Windows.Forms.CheckBox
        Me.chkvac = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbnum = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbeci = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbfem = New System.Windows.Forms.RadioButton
        Me.rbmas = New System.Windows.Forms.RadioButton
        Me.nudeda = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbnom = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbape = New System.Windows.Forms.TextBox
        Me.tbcod = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudeda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnsalir)
        Me.GroupBox3.Controls.Add(Me.btnlim)
        Me.GroupBox3.Controls.Add(Me.btngra)
        Me.GroupBox3.Controls.Add(Me.btncal)
        Me.GroupBox3.Controls.Add(Me.tbsne)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.tbtde)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tbtbe)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.tbsue)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.tbnum)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 224)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pagos"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(240, 184)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(72, 32)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "Salir"
        '
        'btnlim
        '
        Me.btnlim.Location = New System.Drawing.Point(160, 184)
        Me.btnlim.Name = "btnlim"
        Me.btnlim.Size = New System.Drawing.Size(72, 32)
        Me.btnlim.TabIndex = 14
        Me.btnlim.Text = "Nuevo"
        '
        'btngra
        '
        Me.btngra.Location = New System.Drawing.Point(88, 184)
        Me.btngra.Name = "btngra"
        Me.btngra.Size = New System.Drawing.Size(64, 32)
        Me.btngra.TabIndex = 13
        Me.btngra.Text = "Grabar"
        '
        'btncal
        '
        Me.btncal.Location = New System.Drawing.Point(8, 184)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(72, 32)
        Me.btncal.TabIndex = 12
        Me.btncal.Text = "Calcular"
        '
        'tbsne
        '
        Me.tbsne.Location = New System.Drawing.Point(248, 152)
        Me.tbsne.Name = "tbsne"
        Me.tbsne.ReadOnly = True
        Me.tbsne.Size = New System.Drawing.Size(64, 20)
        Me.tbsne.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(184, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Sueldo Neto:"
        '
        'tbtde
        '
        Me.tbtde.Location = New System.Drawing.Point(112, 152)
        Me.tbtde.Name = "tbtde"
        Me.tbtde.ReadOnly = True
        Me.tbtde.Size = New System.Drawing.Size(64, 20)
        Me.tbtde.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total Descuentos:"
        '
        'tbtbe
        '
        Me.tbtbe.Location = New System.Drawing.Point(224, 128)
        Me.tbtbe.Name = "tbtbe"
        Me.tbtbe.ReadOnly = True
        Me.tbtbe.Size = New System.Drawing.Size(80, 20)
        Me.tbtbe.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(136, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total Beneficios:"
        '
        'tbsue
        '
        Me.tbsue.Location = New System.Drawing.Point(72, 128)
        Me.tbsue.Name = "tbsue"
        Me.tbsue.ReadOnly = True
        Me.tbsue.Size = New System.Drawing.Size(64, 20)
        Me.tbsue.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Sueldo:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkfon)
        Me.GroupBox5.Controls.Add(Me.chkafp)
        Me.GroupBox5.Controls.Add(Me.chkcts)
        Me.GroupBox5.Location = New System.Drawing.Point(192, 40)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 80)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Descuento"
        '
        'chkfon
        '
        Me.chkfon.Location = New System.Drawing.Point(8, 48)
        Me.chkfon.Name = "chkfon"
        Me.chkfon.Size = New System.Drawing.Size(80, 24)
        Me.chkfon.TabIndex = 2
        Me.chkfon.Text = "Fonavi 8%"
        '
        'chkafp
        '
        Me.chkafp.Location = New System.Drawing.Point(8, 34)
        Me.chkafp.Name = "chkafp"
        Me.chkafp.Size = New System.Drawing.Size(72, 16)
        Me.chkafp.TabIndex = 1
        Me.chkafp.Text = "A.F.P 7%"
        '
        'chkcts
        '
        Me.chkcts.Location = New System.Drawing.Point(8, 16)
        Me.chkcts.Name = "chkcts"
        Me.chkcts.Size = New System.Drawing.Size(80, 16)
        Me.chkcts.TabIndex = 0
        Me.chkcts.Text = "C.T.S 10%"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkdom)
        Me.GroupBox4.Controls.Add(Me.chkfam)
        Me.GroupBox4.Controls.Add(Me.chkvac)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(136, 80)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Beneficios"
        '
        'chkdom
        '
        Me.chkdom.Location = New System.Drawing.Point(16, 55)
        Me.chkdom.Name = "chkdom"
        Me.chkdom.Size = New System.Drawing.Size(112, 24)
        Me.chkdom.TabIndex = 2
        Me.chkdom.Text = "Dominicales 15%"
        '
        'chkfam
        '
        Me.chkfam.Location = New System.Drawing.Point(16, 35)
        Me.chkfam.Name = "chkfam"
        Me.chkfam.Size = New System.Drawing.Size(104, 24)
        Me.chkfam.TabIndex = 1
        Me.chkfam.Text = "Familiar 20%"
        '
        'chkvac
        '
        Me.chkvac.Location = New System.Drawing.Point(16, 16)
        Me.chkvac.Name = "chkvac"
        Me.chkvac.Size = New System.Drawing.Size(112, 24)
        Me.chkvac.TabIndex = 0
        Me.chkvac.Text = "Vacaciones 30%"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Numero de Pago:"
        '
        'tbnum
        '
        Me.tbnum.Location = New System.Drawing.Point(128, 16)
        Me.tbnum.MaxLength = 6
        Me.tbnum.Name = "tbnum"
        Me.tbnum.ReadOnly = True
        Me.tbnum.Size = New System.Drawing.Size(100, 20)
        Me.tbnum.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbeci)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.nudeda)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbnom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbape)
        Me.GroupBox1.Controls.Add(Me.tbcod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 144)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'cbeci
        '
        Me.cbeci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbeci.Items.AddRange(New Object() {"Soltero ", "Casado", "Viudo", "Divorciado"})
        Me.cbeci.Location = New System.Drawing.Point(95, 112)
        Me.cbeci.MaxLength = 20
        Me.cbeci.Name = "cbeci"
        Me.cbeci.Size = New System.Drawing.Size(126, 21)
        Me.cbeci.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Estado civil:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbfem)
        Me.GroupBox2.Controls.Add(Me.rbmas)
        Me.GroupBox2.Location = New System.Drawing.Point(227, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 64)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
        '
        'rbfem
        '
        Me.rbfem.Location = New System.Drawing.Point(8, 35)
        Me.rbfem.Name = "rbfem"
        Me.rbfem.Size = New System.Drawing.Size(80, 24)
        Me.rbfem.TabIndex = 1
        Me.rbfem.Text = "Femenino"
        '
        'rbmas
        '
        Me.rbmas.Location = New System.Drawing.Point(8, 16)
        Me.rbmas.Name = "rbmas"
        Me.rbmas.Size = New System.Drawing.Size(88, 24)
        Me.rbmas.TabIndex = 0
        Me.rbmas.Text = "Masculino"
        '
        'nudeda
        '
        Me.nudeda.Location = New System.Drawing.Point(96, 88)
        Me.nudeda.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudeda.Name = "nudeda"
        Me.nudeda.ReadOnly = True
        Me.nudeda.Size = New System.Drawing.Size(56, 20)
        Me.nudeda.TabIndex = 7
        Me.nudeda.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Edad:"
        '
        'tbnom
        '
        Me.tbnom.Location = New System.Drawing.Point(96, 64)
        Me.tbnom.MaxLength = 35
        Me.tbnom.Name = "tbnom"
        Me.tbnom.ReadOnly = True
        Me.tbnom.Size = New System.Drawing.Size(125, 20)
        Me.tbnom.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos:"
        '
        'tbape
        '
        Me.tbape.Location = New System.Drawing.Point(96, 40)
        Me.tbape.MaxLength = 35
        Me.tbape.Name = "tbape"
        Me.tbape.ReadOnly = True
        Me.tbape.Size = New System.Drawing.Size(237, 20)
        Me.tbape.TabIndex = 2
        '
        'tbcod
        '
        Me.tbcod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbcod.Location = New System.Drawing.Point(96, 16)
        Me.tbcod.MaxLength = 6
        Me.tbcod.Name = "tbcod"
        Me.tbcod.Size = New System.Drawing.Size(96, 21)
        Me.tbcod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Control de Pagos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(70, 504)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Label12"
        '
        'registro_planillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 550)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "registro_planillas"
        Me.Text = "registro_planillas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudeda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnlim As System.Windows.Forms.Button
    Friend WithEvents btngra As System.Windows.Forms.Button
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents tbsne As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbtde As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbtbe As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbsue As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkfon As System.Windows.Forms.CheckBox
    Friend WithEvents chkafp As System.Windows.Forms.CheckBox
    Friend WithEvents chkcts As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkdom As System.Windows.Forms.CheckBox
    Friend WithEvents chkfam As System.Windows.Forms.CheckBox
    Friend WithEvents chkvac As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbnum As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbeci As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbfem As System.Windows.Forms.RadioButton
    Friend WithEvents rbmas As System.Windows.Forms.RadioButton
    Public WithEvents nudeda As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbnom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbape As System.Windows.Forms.TextBox
    Friend WithEvents tbcod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
