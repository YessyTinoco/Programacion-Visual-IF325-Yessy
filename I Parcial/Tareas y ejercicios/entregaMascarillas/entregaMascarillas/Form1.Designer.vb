<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.txtCantidadmunicipio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.errorValidar = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.toolMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errorValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad de departamentos"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(82, 94)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 5
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cant. Departamentos"
        '
        'cmDepartamento
        '
        Me.cmDepartamento.FormattingEnabled = True
        Me.cmDepartamento.Location = New System.Drawing.Point(140, 125)
        Me.cmDepartamento.Name = "cmDepartamento"
        Me.cmDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cmDepartamento.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(140, 51)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cant. por Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEntregar)
        Me.GroupBox2.Controls.Add(Me.txtCantidadmunicipio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 210)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distribución"
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(77, 94)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntregar.TabIndex = 6
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'txtCantidadmunicipio
        '
        Me.txtCantidadmunicipio.Location = New System.Drawing.Point(110, 40)
        Me.txtCantidadmunicipio.Name = "txtCantidadmunicipio"
        Me.txtCantidadmunicipio.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadmunicipio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cant. Municipios"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(431, 256)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 2
        '
        'errorValidar
        '
        Me.errorValidar.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 291)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errorValidar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmDepartamento As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCantidadmunicipio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents btnEntregar As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents errorValidar As ErrorProvider
    Friend WithEvents toolMensaje As ToolTip
End Class
