<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formula
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Resultados"
        Me.Label7.Visible = False
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(90, 258)
        Me.txtX2.Multiline = True
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(130, 20)
        Me.txtX2.TabIndex = 20
        Me.txtX2.Visible = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Lime
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(253, 139)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "X2"
        Me.Label6.Visible = False
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(90, 220)
        Me.txtX1.Multiline = True
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(130, 20)
        Me.txtX1.TabIndex = 19
        Me.txtX1.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(253, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 26)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Regresar"
        Me.btnSalir.UseVisualStyleBackColor = False
        Me.btnSalir.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "X1"
        Me.Label5.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtC)
        Me.GroupBox1.Controls.Add(Me.txtB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 114)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(37, 80)
        Me.txtC.Multiline = True
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(52, 20)
        Me.txtC.TabIndex = 9
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(37, 54)
        Me.txtB.Multiline = True
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(52, 20)
        Me.txtB.TabIndex = 8
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "b"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "c"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(37, 25)
        Me.txtA.Multiline = True
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(52, 20)
        Me.txtA.TabIndex = 7
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Aqua
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(253, 87)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Fórmula General Cuadrática"
        '
        'ErrorP
        '
        Me.ErrorP.ContainerControl = Me
        '
        'Formula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 335)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Formula"
        Me.Text = "Formula"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorP As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
