<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class planillas_registro
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
        Me.tbnro = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbper = New System.Windows.Forms.TextBox
        Me.cbare = New System.Windows.Forms.ComboBox
        Me.cbcar = New System.Windows.Forms.ComboBox
        Me.tbbon = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbdes = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbtot = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbbru = New System.Windows.Forms.TextBox
        Me.lbnro = New System.Windows.Forms.ListBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbnom = New System.Windows.Forms.ListBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbbru = New System.Windows.Forms.ListBox
        Me.lbbon = New System.Windows.Forms.ListBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbdes = New System.Windows.Forms.ListBox
        Me.lbtot = New System.Windows.Forms.ListBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btagr = New System.Windows.Forms.Button
        Me.btnue = New System.Windows.Forms.Button
        Me.bteli = New System.Windows.Forms.Button
        Me.btgua = New System.Windows.Forms.Button
        Me.btvol = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NRO-Planilla:"
        '
        'tbnro
        '
        Me.tbnro.Location = New System.Drawing.Point(121, 46)
        Me.tbnro.MaxLength = 7
        Me.tbnro.Name = "tbnro"
        Me.tbnro.Size = New System.Drawing.Size(100, 20)
        Me.tbnro.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Personal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Eliga Area:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Eliga Cargo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Bonif:"
        '
        'tbper
        '
        Me.tbper.Location = New System.Drawing.Point(125, 105)
        Me.tbper.MaxLength = 25
        Me.tbper.Name = "tbper"
        Me.tbper.ReadOnly = True
        Me.tbper.Size = New System.Drawing.Size(232, 20)
        Me.tbper.TabIndex = 6
        '
        'cbare
        '
        Me.cbare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbare.FormattingEnabled = True
        Me.cbare.Location = New System.Drawing.Point(125, 130)
        Me.cbare.Name = "cbare"
        Me.cbare.Size = New System.Drawing.Size(121, 21)
        Me.cbare.TabIndex = 7
        '
        'cbcar
        '
        Me.cbcar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcar.FormattingEnabled = True
        Me.cbcar.Location = New System.Drawing.Point(125, 158)
        Me.cbcar.Name = "cbcar"
        Me.cbcar.Size = New System.Drawing.Size(121, 21)
        Me.cbcar.TabIndex = 8
        '
        'tbbon
        '
        Me.tbbon.Location = New System.Drawing.Point(81, 195)
        Me.tbbon.MaxLength = 10
        Me.tbbon.Name = "tbbon"
        Me.tbbon.Size = New System.Drawing.Size(59, 20)
        Me.tbbon.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(164, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Descto:"
        '
        'tbdes
        '
        Me.tbdes.Location = New System.Drawing.Point(206, 196)
        Me.tbdes.MaxLength = 10
        Me.tbdes.Name = "tbdes"
        Me.tbdes.Size = New System.Drawing.Size(59, 20)
        Me.tbdes.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total:"
        '
        'tbtot
        '
        Me.tbtot.Location = New System.Drawing.Point(327, 196)
        Me.tbtot.MaxLength = 10
        Me.tbtot.Name = "tbtot"
        Me.tbtot.Size = New System.Drawing.Size(58, 20)
        Me.tbtot.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(278, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "S.Bruto:"
        '
        'tbbru
        '
        Me.tbbru.Location = New System.Drawing.Point(327, 163)
        Me.tbbru.MaxLength = 10
        Me.tbbru.Name = "tbbru"
        Me.tbbru.Size = New System.Drawing.Size(58, 20)
        Me.tbbru.TabIndex = 15
        '
        'lbnro
        '
        Me.lbnro.FormattingEnabled = True
        Me.lbnro.Location = New System.Drawing.Point(27, 276)
        Me.lbnro.Name = "lbnro"
        Me.lbnro.Size = New System.Drawing.Size(47, 121)
        Me.lbnro.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Nombre"
        '
        'lbnom
        '
        Me.lbnom.FormattingEnabled = True
        Me.lbnom.Location = New System.Drawing.Point(75, 276)
        Me.lbnom.Name = "lbnom"
        Me.lbnom.Size = New System.Drawing.Size(120, 121)
        Me.lbnom.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(205, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "S. Bruto"
        '
        'lbbru
        '
        Me.lbbru.FormattingEnabled = True
        Me.lbbru.Location = New System.Drawing.Point(197, 277)
        Me.lbbru.Name = "lbbru"
        Me.lbbru.Size = New System.Drawing.Size(69, 121)
        Me.lbbru.TabIndex = 21
        '
        'lbbon
        '
        Me.lbbon.FormattingEnabled = True
        Me.lbbon.Location = New System.Drawing.Point(269, 277)
        Me.lbbon.Name = "lbbon"
        Me.lbbon.Size = New System.Drawing.Size(50, 121)
        Me.lbbon.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(276, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Bonif"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(322, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "DSCTO"
        '
        'lbdes
        '
        Me.lbdes.FormattingEnabled = True
        Me.lbdes.Location = New System.Drawing.Point(322, 276)
        Me.lbdes.Name = "lbdes"
        Me.lbdes.Size = New System.Drawing.Size(48, 121)
        Me.lbdes.TabIndex = 25
        '
        'lbtot
        '
        Me.lbtot.FormattingEnabled = True
        Me.lbtot.Location = New System.Drawing.Point(373, 276)
        Me.lbtot.Name = "lbtot"
        Me.lbtot.Size = New System.Drawing.Size(61, 121)
        Me.lbtot.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(378, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btagr
        '
        Me.btagr.Enabled = False
        Me.btagr.Location = New System.Drawing.Point(406, 68)
        Me.btagr.Name = "btagr"
        Me.btagr.Size = New System.Drawing.Size(75, 23)
        Me.btagr.TabIndex = 29
        Me.btagr.Text = "Agregar"
        Me.btagr.UseVisualStyleBackColor = True
        '
        'btnue
        '
        Me.btnue.Enabled = False
        Me.btnue.Location = New System.Drawing.Point(406, 103)
        Me.btnue.Name = "btnue"
        Me.btnue.Size = New System.Drawing.Size(75, 23)
        Me.btnue.TabIndex = 30
        Me.btnue.Text = "Nuevo"
        Me.btnue.UseVisualStyleBackColor = True
        '
        'bteli
        '
        Me.bteli.Enabled = False
        Me.bteli.Location = New System.Drawing.Point(407, 134)
        Me.bteli.Name = "bteli"
        Me.bteli.Size = New System.Drawing.Size(75, 23)
        Me.bteli.TabIndex = 31
        Me.bteli.Text = "Eliminar"
        Me.bteli.UseVisualStyleBackColor = True
        '
        'btgua
        '
        Me.btgua.Enabled = False
        Me.btgua.Location = New System.Drawing.Point(99, 410)
        Me.btgua.Name = "btgua"
        Me.btgua.Size = New System.Drawing.Size(75, 23)
        Me.btgua.TabIndex = 32
        Me.btgua.Text = "Guardar"
        Me.btgua.UseVisualStyleBackColor = True
        '
        'btvol
        '
        Me.btvol.Location = New System.Drawing.Point(195, 411)
        Me.btvol.Name = "btvol"
        Me.btvol.Size = New System.Drawing.Size(75, 23)
        Me.btvol.TabIndex = 33
        Me.btvol.Text = "Volver"
        Me.btvol.UseVisualStyleBackColor = True
        '
        'planillas_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 451)
        Me.Controls.Add(Me.btvol)
        Me.Controls.Add(Me.btgua)
        Me.Controls.Add(Me.bteli)
        Me.Controls.Add(Me.btnue)
        Me.Controls.Add(Me.btagr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbtot)
        Me.Controls.Add(Me.lbdes)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbbon)
        Me.Controls.Add(Me.lbbru)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbnom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbnro)
        Me.Controls.Add(Me.tbbru)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbtot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbdes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbbon)
        Me.Controls.Add(Me.cbcar)
        Me.Controls.Add(Me.cbare)
        Me.Controls.Add(Me.tbper)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbnro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "planillas_registro"
        Me.Text = "Registro - Planillas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbper As System.Windows.Forms.TextBox
    Friend WithEvents cbare As System.Windows.Forms.ComboBox
    Friend WithEvents cbcar As System.Windows.Forms.ComboBox
    Friend WithEvents tbbon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbdes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbtot As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbbru As System.Windows.Forms.TextBox
    Friend WithEvents lbnro As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbnom As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbbru As System.Windows.Forms.ListBox
    Friend WithEvents lbbon As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbdes As System.Windows.Forms.ListBox
    Friend WithEvents lbtot As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btagr As System.Windows.Forms.Button
    Friend WithEvents btnue As System.Windows.Forms.Button
    Friend WithEvents bteli As System.Windows.Forms.Button
    Friend WithEvents btgua As System.Windows.Forms.Button
    Friend WithEvents btvol As System.Windows.Forms.Button
End Class
