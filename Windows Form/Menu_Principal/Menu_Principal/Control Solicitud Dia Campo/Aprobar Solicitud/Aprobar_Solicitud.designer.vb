<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aprobar_Solicitud
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
        Me.dgw1 = New System.Windows.Forms.DataGridView
        Me.Aprobado = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbtotal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnpri = New System.Windows.Forms.Button
        Me.btnant = New System.Windows.Forms.Button
        Me.btnsig = New System.Windows.Forms.Button
        Me.btnult = New System.Windows.Forms.Button
        Me.tbnom = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbclub = New System.Windows.Forms.ComboBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.rbnom = New System.Windows.Forms.RadioButton
        Me.rbclub = New System.Windows.Forms.RadioButton
        Me.btn_Aprobar = New System.Windows.Forms.Button
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgw1
        '
        Me.dgw1.AllowUserToAddRows = False
        Me.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Aprobado})
        Me.dgw1.Location = New System.Drawing.Point(12, 144)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw1.Size = New System.Drawing.Size(738, 272)
        Me.dgw1.TabIndex = 0
        '
        'Aprobado
        '
        Me.Aprobado.HeaderText = "Aprobar?"
        Me.Aprobado.Name = "Aprobado"
        Me.Aprobado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Aprobado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Aprobado.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(140, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "APROBAR SOLICITUD DE DIA DE CAMPO"
        '
        'tbtotal
        '
        Me.tbtotal.BackColor = System.Drawing.Color.AliceBlue
        Me.tbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotal.Location = New System.Drawing.Point(663, 422)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.Size = New System.Drawing.Size(87, 20)
        Me.tbtotal.TabIndex = 5
        Me.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(554, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Solicitudes:"
        '
        'btnpri
        '
        Me.btnpri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpri.Location = New System.Drawing.Point(14, 422)
        Me.btnpri.Name = "btnpri"
        Me.btnpri.Size = New System.Drawing.Size(28, 25)
        Me.btnpri.TabIndex = 7
        Me.btnpri.Text = "I<"
        Me.btnpri.UseVisualStyleBackColor = True
        Me.btnpri.Visible = False
        '
        'btnant
        '
        Me.btnant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnant.Location = New System.Drawing.Point(49, 422)
        Me.btnant.Name = "btnant"
        Me.btnant.Size = New System.Drawing.Size(28, 25)
        Me.btnant.TabIndex = 8
        Me.btnant.Text = "<"
        Me.btnant.UseVisualStyleBackColor = True
        Me.btnant.Visible = False
        '
        'btnsig
        '
        Me.btnsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsig.Location = New System.Drawing.Point(84, 422)
        Me.btnsig.Name = "btnsig"
        Me.btnsig.Size = New System.Drawing.Size(28, 25)
        Me.btnsig.TabIndex = 9
        Me.btnsig.Text = ">"
        Me.btnsig.UseVisualStyleBackColor = True
        Me.btnsig.Visible = False
        '
        'btnult
        '
        Me.btnult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnult.Location = New System.Drawing.Point(118, 422)
        Me.btnult.Name = "btnult"
        Me.btnult.Size = New System.Drawing.Size(28, 25)
        Me.btnult.TabIndex = 10
        Me.btnult.Text = ">I"
        Me.btnult.UseVisualStyleBackColor = True
        Me.btnult.Visible = False
        '
        'tbnom
        '
        Me.tbnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbnom.Enabled = False
        Me.tbnom.Location = New System.Drawing.Point(345, 19)
        Me.tbnom.Name = "tbnom"
        Me.tbnom.Size = New System.Drawing.Size(264, 22)
        Me.tbnom.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbclub)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.rbnom)
        Me.GroupBox1.Controls.Add(Me.tbnom)
        Me.GroupBox1.Controls.Add(Me.rbclub)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 75)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Tipo de Listado"
        '
        'cbclub
        '
        Me.cbclub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbclub.Enabled = False
        Me.cbclub.FormattingEnabled = True
        Me.cbclub.Location = New System.Drawing.Point(346, 46)
        Me.cbclub.Name = "cbclub"
        Me.cbclub.Size = New System.Drawing.Size(200, 24)
        Me.cbclub.TabIndex = 59
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.Menu_Principal.My.Resources.Resources.REPO3
        Me.PictureBox2.Location = New System.Drawing.Point(617, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'rbnom
        '
        Me.rbnom.AutoSize = True
        Me.rbnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnom.Location = New System.Drawing.Point(6, 19)
        Me.rbnom.Name = "rbnom"
        Me.rbnom.Size = New System.Drawing.Size(337, 19)
        Me.rbnom.TabIndex = 41
        Me.rbnom.TabStop = True
        Me.rbnom.Text = "Listado Por Nombre del Responsable de Familia"
        Me.rbnom.UseVisualStyleBackColor = True
        '
        'rbclub
        '
        Me.rbclub.AutoSize = True
        Me.rbclub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbclub.Location = New System.Drawing.Point(7, 46)
        Me.rbclub.Name = "rbclub"
        Me.rbclub.Size = New System.Drawing.Size(210, 19)
        Me.rbclub.TabIndex = 40
        Me.rbclub.TabStop = True
        Me.rbclub.Text = "Listado Por Nombre del Club"
        Me.rbclub.UseVisualStyleBackColor = True
        '
        'btn_Aprobar
        '
        Me.btn_Aprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aprobar.Location = New System.Drawing.Point(423, 421)
        Me.btn_Aprobar.Name = "btn_Aprobar"
        Me.btn_Aprobar.Size = New System.Drawing.Size(125, 26)
        Me.btn_Aprobar.TabIndex = 41
        Me.btn_Aprobar.Text = "Aprobar >>"
        Me.btn_Aprobar.UseVisualStyleBackColor = True
        '
        'Aprobar_Solicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_Principal.My.Resources.Resources.fondo_campo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 455)
        Me.Controls.Add(Me.btn_Aprobar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnult)
        Me.Controls.Add(Me.btnsig)
        Me.Controls.Add(Me.btnant)
        Me.Controls.Add(Me.btnpri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgw1)
        Me.Name = "Aprobar_Solicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobar Solicitud de Dia de Campo"
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgw1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnpri As System.Windows.Forms.Button
    Friend WithEvents btnant As System.Windows.Forms.Button
    Friend WithEvents btnsig As System.Windows.Forms.Button
    Friend WithEvents btnult As System.Windows.Forms.Button
    Friend WithEvents tbnom As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnom As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rbclub As System.Windows.Forms.RadioButton
    Friend WithEvents Aprobado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_Aprobar As System.Windows.Forms.Button
    Friend WithEvents cbclub As System.Windows.Forms.ComboBox
End Class
