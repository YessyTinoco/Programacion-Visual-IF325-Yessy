<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Numeros
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
        Me.components = New System.ComponentModel.Container()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNegativo = New System.Windows.Forms.TextBox()
        Me.txtPositivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImpar = New System.Windows.Forms.TextBox()
        Me.txtPar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbNum = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.errorEncontrado = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorEncontrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(371, 123)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(371, 50)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSuma)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCant)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNegativo)
        Me.GroupBox2.Controls.Add(Me.txtPositivo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtImpar)
        Me.GroupBox2.Controls.Add(Me.txtPar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 189)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Números Acumulados"
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(76, 157)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(38, 20)
        Me.txtSuma.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(15, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "TOTAL"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(307, 125)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(38, 20)
        Me.txtCant.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cantidad números ingresados"
        '
        'txtNegativo
        '
        Me.txtNegativo.Location = New System.Drawing.Point(438, 87)
        Me.txtNegativo.Name = "txtNegativo"
        Me.txtNegativo.Size = New System.Drawing.Size(38, 20)
        Me.txtNegativo.TabIndex = 9
        '
        'txtPositivo
        '
        Me.txtPositivo.Location = New System.Drawing.Point(438, 39)
        Me.txtPositivo.Name = "txtPositivo"
        Me.txtPositivo.Size = New System.Drawing.Size(38, 20)
        Me.txtPositivo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(262, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cantidad números negativos "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad números positivos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad números impares"
        '
        'txtImpar
        '
        Me.txtImpar.Location = New System.Drawing.Point(191, 84)
        Me.txtImpar.Name = "txtImpar"
        Me.txtImpar.Size = New System.Drawing.Size(38, 20)
        Me.txtImpar.TabIndex = 4
        '
        'txtPar
        '
        Me.txtPar.Location = New System.Drawing.Point(191, 38)
        Me.txtPar.Name = "txtPar"
        Me.txtPar.Size = New System.Drawing.Size(38, 20)
        Me.txtPar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad números pares"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbNum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNum)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 138)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cmbNum
        '
        Me.cmbNum.FormattingEnabled = True
        Me.cmbNum.Location = New System.Drawing.Point(9, 81)
        Me.cmbNum.Name = "cmbNum"
        Me.cmbNum.Size = New System.Drawing.Size(121, 21)
        Me.cmbNum.TabIndex = 3
        Me.cmbNum.Text = "            Historial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese dígitos"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(120, 26)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(62, 20)
        Me.txtNum.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(421, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 26)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Regresar"
        Me.btnSalir.UseVisualStyleBackColor = False
        Me.btnSalir.Visible = False
        '
        'errorEncontrado
        '
        Me.errorEncontrado.ContainerControl = Me
        '
        'Numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 425)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Numeros"
        Me.Text = "Numeros"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorEncontrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNegativo As TextBox
    Friend WithEvents txtPositivo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtImpar As TextBox
    Friend WithEvents txtPar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbNum As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents errorEncontrado As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
