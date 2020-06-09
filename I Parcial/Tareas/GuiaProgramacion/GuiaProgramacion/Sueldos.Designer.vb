<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sueldos
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
        Me.txt25 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt20 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txt15 = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "25%"
        '
        'txt25
        '
        Me.txt25.Location = New System.Drawing.Point(111, 207)
        Me.txt25.Name = "txt25"
        Me.txt25.Size = New System.Drawing.Size(75, 20)
        Me.txt25.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "20%"
        '
        'txt20
        '
        Me.txt20.Location = New System.Drawing.Point(111, 166)
        Me.txt20.Name = "txt20"
        Me.txt20.Size = New System.Drawing.Size(75, 20)
        Me.txt20.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "15%"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MistyRose
        Me.Button2.Location = New System.Drawing.Point(30, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcular.Location = New System.Drawing.Point(111, 58)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 22
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'txt15
        '
        Me.txt15.Location = New System.Drawing.Point(111, 126)
        Me.txt15.Name = "txt15"
        Me.txt15.Size = New System.Drawing.Size(75, 20)
        Me.txt15.TabIndex = 21
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(164, 234)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(99, 20)
        Me.txtSueldo.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Sueldo neto"
        '
        'txtPago
        '
        Me.txtPago.Location = New System.Drawing.Point(164, 24)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(99, 20)
        Me.txtPago.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Deducción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ingresar sueldo"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(188, 267)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 26)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Regresar"
        Me.btnSalir.UseVisualStyleBackColor = False
        Me.btnSalir.Visible = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Sueldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 309)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt25)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt20)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txt15)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sueldos"
        Me.Text = "Sueldos"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txt25 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt20 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txt15 As TextBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPago As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
