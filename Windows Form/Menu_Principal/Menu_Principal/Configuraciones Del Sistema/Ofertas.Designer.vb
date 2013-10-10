<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ofertas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.dtFecCaducidad = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFecInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(272, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Generar Ofertas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btguardar)
        Me.GroupBox1.Controls.Add(Me.dtFecCaducidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtFecInicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Location = New System.Drawing.Point(22, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 157)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Oferta"
        '
        'btguardar
        '
        Me.btguardar.ForeColor = System.Drawing.Color.Black
        Me.btguardar.Location = New System.Drawing.Point(590, 24)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(113, 28)
        Me.btguardar.TabIndex = 9
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'dtFecCaducidad
        '
        Me.dtFecCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecCaducidad.Location = New System.Drawing.Point(433, 44)
        Me.dtFecCaducidad.Name = "dtFecCaducidad"
        Me.dtFecCaducidad.Size = New System.Drawing.Size(138, 22)
        Me.dtFecCaducidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha Caducidad:"
        '
        'dtFecInicio
        '
        Me.dtFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecInicio.Location = New System.Drawing.Point(276, 44)
        Me.dtFecInicio.Name = "dtFecInicio"
        Me.dtFecInicio.Size = New System.Drawing.Size(138, 22)
        Me.dtFecInicio.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(276, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha Inicio:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(9, 91)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(562, 58)
        Me.txtdescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción de Oferta:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(9, 44)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(252, 22)
        Me.txtnombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Titulo de Oferta:"
        '
        'Ofertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_Principal.My.Resources.Resources.fondo_campo
        Me.ClientSize = New System.Drawing.Size(751, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Ofertas"
        Me.Text = "Ofertas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btguardar As System.Windows.Forms.Button
    Friend WithEvents dtFecCaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtFecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
