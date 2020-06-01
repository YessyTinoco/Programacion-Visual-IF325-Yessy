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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtFactura = New System.Windows.Forms.Label()
        Me.txtdatosRequeridos = New System.Windows.Forms.Label()
        Me.precioUnitario = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtdetallesFactura = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Descuento = New System.Windows.Forms.Label()
        Me.ISV15 = New System.Windows.Forms.Label()
        Me.ISV17 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtISV17 = New System.Windows.Forms.TextBox()
        Me.txtISV15 = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.CheckDescuento = New System.Windows.Forms.CheckBox()
        Me.CheckISV = New System.Windows.Forms.CheckBox()
        Me.ComboDescuento = New System.Windows.Forms.ComboBox()
        Me.ComboISV = New System.Windows.Forms.ComboBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFactura
        '
        Me.txtFactura.AutoSize = True
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(226, 32)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(222, 28)
        Me.txtFactura.TabIndex = 0
        Me.txtFactura.Text = "FACTURA SENCILLA"
        '
        'txtdatosRequeridos
        '
        Me.txtdatosRequeridos.AutoSize = True
        Me.txtdatosRequeridos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatosRequeridos.Location = New System.Drawing.Point(63, 102)
        Me.txtdatosRequeridos.Name = "txtdatosRequeridos"
        Me.txtdatosRequeridos.Size = New System.Drawing.Size(178, 22)
        Me.txtdatosRequeridos.TabIndex = 1
        Me.txtdatosRequeridos.Text = "Datos Requeridos "
        '
        'precioUnitario
        '
        Me.precioUnitario.AutoSize = True
        Me.precioUnitario.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precioUnitario.Location = New System.Drawing.Point(71, 137)
        Me.precioUnitario.Name = "precioUnitario"
        Me.precioUnitario.Size = New System.Drawing.Size(96, 20)
        Me.precioUnitario.TabIndex = 2
        Me.precioUnitario.Text = "Precio Unitario"
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(71, 186)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(61, 20)
        Me.Cantidad.TabIndex = 3
        Me.Cantidad.Text = "Cantidad"
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.Location = New System.Drawing.Point(181, 137)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.Size = New System.Drawing.Size(48, 20)
        Me.txtprecioUnitario.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(181, 186)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(48, 20)
        Me.txtCantidad.TabIndex = 5
        '
        'txtdetallesFactura
        '
        Me.txtdetallesFactura.AutoSize = True
        Me.txtdetallesFactura.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetallesFactura.Location = New System.Drawing.Point(415, 102)
        Me.txtdetallesFactura.Name = "txtdetallesFactura"
        Me.txtdetallesFactura.Size = New System.Drawing.Size(187, 22)
        Me.txtdetallesFactura.TabIndex = 6
        Me.txtdetallesFactura.Text = "Detalles de Factura"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.Location = New System.Drawing.Point(434, 137)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(57, 20)
        Me.subtotal.TabIndex = 7
        Me.subtotal.Text = "Subtotal"
        '
        'Descuento
        '
        Me.Descuento.AutoSize = True
        Me.Descuento.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(434, 170)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(73, 20)
        Me.Descuento.TabIndex = 8
        Me.Descuento.Text = "Descuento"
        '
        'ISV15
        '
        Me.ISV15.AutoSize = True
        Me.ISV15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISV15.Location = New System.Drawing.Point(434, 205)
        Me.ISV15.Name = "ISV15"
        Me.ISV15.Size = New System.Drawing.Size(60, 20)
        Me.ISV15.TabIndex = 9
        Me.ISV15.Text = "ISV 15%"
        '
        'ISV17
        '
        Me.ISV17.AutoSize = True
        Me.ISV17.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISV17.Location = New System.Drawing.Point(434, 240)
        Me.ISV17.Name = "ISV17"
        Me.ISV17.Size = New System.Drawing.Size(60, 20)
        Me.ISV17.TabIndex = 10
        Me.ISV17.Text = "ISV 17%"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(513, 137)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(68, 20)
        Me.txtsubtotal.TabIndex = 11
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(517, 292)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(64, 20)
        Me.txtTotal.TabIndex = 12
        '
        'txtISV17
        '
        Me.txtISV17.Location = New System.Drawing.Point(513, 242)
        Me.txtISV17.Name = "txtISV17"
        Me.txtISV17.Size = New System.Drawing.Size(68, 20)
        Me.txtISV17.TabIndex = 13
        '
        'txtISV15
        '
        Me.txtISV15.Location = New System.Drawing.Point(513, 207)
        Me.txtISV15.Name = "txtISV15"
        Me.txtISV15.Size = New System.Drawing.Size(68, 20)
        Me.txtISV15.TabIndex = 14
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(513, 172)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(68, 20)
        Me.txtDescuento.TabIndex = 15
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Red
        Me.Total.Location = New System.Drawing.Point(462, 292)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(52, 20)
        Me.Total.TabIndex = 16
        Me.Total.Text = "TOTAL"
        '
        'CheckDescuento
        '
        Me.CheckDescuento.AutoSize = True
        Me.CheckDescuento.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDescuento.Location = New System.Drawing.Point(46, 251)
        Me.CheckDescuento.Name = "CheckDescuento"
        Me.CheckDescuento.Size = New System.Drawing.Size(141, 24)
        Me.CheckDescuento.TabIndex = 17
        Me.CheckDescuento.Text = "Aplicar Descuento "
        Me.CheckDescuento.UseVisualStyleBackColor = True
        '
        'CheckISV
        '
        Me.CheckISV.AutoSize = True
        Me.CheckISV.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckISV.Location = New System.Drawing.Point(231, 251)
        Me.CheckISV.Name = "CheckISV"
        Me.CheckISV.Size = New System.Drawing.Size(94, 24)
        Me.CheckISV.TabIndex = 18
        Me.CheckISV.Text = "Aplicar ISV"
        Me.CheckISV.UseVisualStyleBackColor = True
        '
        'ComboDescuento
        '
        Me.ComboDescuento.FormattingEnabled = True
        Me.ComboDescuento.Items.AddRange(New Object() {"Tercera Edad", "Comercial", "Jubilado", "Primera Compra", "Cliente Preferencial", "Liquidación"})
        Me.ComboDescuento.Location = New System.Drawing.Point(46, 291)
        Me.ComboDescuento.Name = "ComboDescuento"
        Me.ComboDescuento.Size = New System.Drawing.Size(121, 21)
        Me.ComboDescuento.TabIndex = 19
        Me.ComboDescuento.Text = "Seleccione Opción"
        '
        'ComboISV
        '
        Me.ComboISV.FormattingEnabled = True
        Me.ComboISV.Items.AddRange(New Object() {"15%", "17%"})
        Me.ComboISV.Location = New System.Drawing.Point(231, 291)
        Me.ComboISV.Name = "ComboISV"
        Me.ComboISV.Size = New System.Drawing.Size(121, 21)
        Me.ComboISV.TabIndex = 20
        Me.ComboISV.Text = "Seleccione Opción"
        '
        'btnAplicar
        '
        Me.btnAplicar.BackColor = System.Drawing.Color.Cyan
        Me.btnAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar.Location = New System.Drawing.Point(154, 370)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 21
        Me.btnAplicar.Text = "APLICAR"
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Cyan
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(323, 346)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 22
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.Red
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.ForeColor = System.Drawing.Color.White
        Me.btnSALIR.Location = New System.Drawing.Point(583, 370)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(75, 23)
        Me.btnSALIR.TabIndex = 23
        Me.btnSALIR.Text = "SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar.Location = New System.Drawing.Point(323, 390)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Yessy Danira Tinoco"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(670, 420)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.ComboISV)
        Me.Controls.Add(Me.ComboDescuento)
        Me.Controls.Add(Me.CheckISV)
        Me.Controls.Add(Me.CheckDescuento)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtISV15)
        Me.Controls.Add(Me.txtISV17)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.ISV17)
        Me.Controls.Add(Me.ISV15)
        Me.Controls.Add(Me.Descuento)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.txtdetallesFactura)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtprecioUnitario)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.precioUnitario)
        Me.Controls.Add(Me.txtdatosRequeridos)
        Me.Controls.Add(Me.txtFactura)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "["
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFactura As Label
    Friend WithEvents txtdatosRequeridos As Label
    Friend WithEvents precioUnitario As Label
    Friend WithEvents Cantidad As Label
    Friend WithEvents txtprecioUnitario As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtdetallesFactura As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents Descuento As Label
    Friend WithEvents ISV15 As Label
    Friend WithEvents ISV17 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtISV17 As TextBox
    Friend WithEvents txtISV15 As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Total As Label
    Friend WithEvents CheckDescuento As CheckBox
    Friend WithEvents CheckISV As CheckBox
    Friend WithEvents ComboDescuento As ComboBox
    Friend WithEvents ComboISV As ComboBox
    Friend WithEvents btnAplicar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSALIR As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
