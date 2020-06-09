<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Me.txtLimpiar = New System.Windows.Forms.Button()
        Me.listAlmacen = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLimpiar
        '
        Me.txtLimpiar.Location = New System.Drawing.Point(338, 345)
        Me.txtLimpiar.Name = "txtLimpiar"
        Me.txtLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.txtLimpiar.TabIndex = 15
        Me.txtLimpiar.Text = "Limpiar"
        Me.txtLimpiar.UseVisualStyleBackColor = True
        '
        'listAlmacen
        '
        Me.listAlmacen.FormattingEnabled = True
        Me.listAlmacen.Location = New System.Drawing.Point(103, 163)
        Me.listAlmacen.Name = "listAlmacen"
        Me.listAlmacen.Size = New System.Drawing.Size(220, 173)
        Me.listAlmacen.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ventas de almacenes superiores a la media"
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(157, 85)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtMedia.TabIndex = 12
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(157, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(83, 32)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Venta de la media"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese las ventas"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(12, 348)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 26)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Regresar"
        Me.btnSalir.UseVisualStyleBackColor = False
        Me.btnSalir.Visible = False
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 386)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtLimpiar)
        Me.Controls.Add(Me.listAlmacen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Almacen"
        Me.Text = "Almacen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLimpiar As Button
    Friend WithEvents listAlmacen As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
End Class
