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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Toolmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmMak = New System.Windows.Forms.ComboBox()
        Me.cmSkin = New System.Windows.Forms.ComboBox()
        Me.checkMak = New System.Windows.Forms.CheckBox()
        Me.checkSkin = New System.Windows.Forms.CheckBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaskedNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxMasterCard = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVISA = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedCredito = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboNacionalidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbMas = New System.Windows.Forms.RadioButton()
        Me.rbFeme = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbCompra = New System.Windows.Forms.RadioButton()
        Me.rbDatos = New System.Windows.Forms.RadioButton()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'Toolmensaje
        '
        Me.Toolmensaje.IsBalloon = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.btnSalir)
        Me.TabPage2.Controls.Add(Me.btnNuevo)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(629, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Compra Producto "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(20, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(80, 58)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Marsttar Demo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(420, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 20)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "La belleza no mira, solo es mirada"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(424, 330)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(424, 289)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(93, 23)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.btnComprar)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(335, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 191)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(101, 184)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(68, 21)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(125, 91)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(122, 21)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(125, 37)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(122, 21)
        Me.txtPrecio.TabIndex = 6
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnComprar
        '
        Me.btnComprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComprar.Location = New System.Drawing.Point(89, 154)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(93, 23)
        Me.btnComprar.TabIndex = 2
        Me.btnComprar.Text = "COMPRAR"
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 15)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "TOTAL                   L."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Precio Unitario     L."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.cmMak)
        Me.GroupBox3.Controls.Add(Me.cmSkin)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.checkMak)
        Me.GroupBox3.Controls.Add(Me.checkSkin)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 242)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos"
        '
        'cmMak
        '
        Me.cmMak.FormattingEnabled = True
        Me.cmMak.Items.AddRange(New Object() {"Labial Maybelline ", "Base Super Stay ", "Polvos traslúcidos ", "Sombras James ", "Bronzer wet n wild "})
        Me.cmMak.Location = New System.Drawing.Point(36, 129)
        Me.cmMak.Name = "cmMak"
        Me.cmMak.Size = New System.Drawing.Size(163, 23)
        Me.cmMak.TabIndex = 3
        Me.cmMak.Text = "Selecciona una opción"
        '
        'cmSkin
        '
        Me.cmSkin.FormattingEnabled = True
        Me.cmSkin.Items.AddRange(New Object() {"Ácido láctico", "Niacinamida", "Crema hidratante ", "Agua micelar", "Bloqueador solar"})
        Me.cmSkin.Location = New System.Drawing.Point(36, 58)
        Me.cmSkin.Name = "cmSkin"
        Me.cmSkin.Size = New System.Drawing.Size(163, 23)
        Me.cmSkin.TabIndex = 2
        Me.cmSkin.Text = "Seleccione una opción"
        '
        'checkMak
        '
        Me.checkMak.AutoSize = True
        Me.checkMak.Location = New System.Drawing.Point(36, 104)
        Me.checkMak.Name = "checkMak"
        Me.checkMak.Size = New System.Drawing.Size(71, 19)
        Me.checkMak.TabIndex = 1
        Me.checkMak.Text = "Makeup"
        Me.checkMak.UseVisualStyleBackColor = True
        '
        'checkSkin
        '
        Me.checkSkin.AutoSize = True
        Me.checkSkin.Location = New System.Drawing.Point(36, 33)
        Me.checkSkin.Name = "checkSkin"
        Me.checkSkin.Size = New System.Drawing.Size(74, 19)
        Me.checkSkin.TabIndex = 0
        Me.checkSkin.Text = "Skincare"
        Me.checkSkin.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(629, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaskedNum)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dateTime)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(409, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 308)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Perfil"
        '
        'MaskedNum
        '
        Me.MaskedNum.Location = New System.Drawing.Point(31, 269)
        Me.MaskedNum.Mask = "0000-0000"
        Me.MaskedNum.Name = "MaskedNum"
        Me.MaskedNum.Size = New System.Drawing.Size(100, 21)
        Me.MaskedNum.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Número de teléfono"
        '
        'dateTime
        '
        Me.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTime.Location = New System.Drawing.Point(31, 189)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(104, 21)
        Me.dateTime.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha de Nacimiento"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(31, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(130, 111)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxMasterCard)
        Me.GroupBox1.Controls.Add(Me.CheckBoxVISA)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MaskedCredito)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.comboNacionalidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbMas)
        Me.GroupBox1.Controls.Add(Me.rbFeme)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 313)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(239, 274)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'CheckBoxMasterCard
        '
        Me.CheckBoxMasterCard.AutoSize = True
        Me.CheckBoxMasterCard.Location = New System.Drawing.Point(226, 249)
        Me.CheckBoxMasterCard.Name = "CheckBoxMasterCard"
        Me.CheckBoxMasterCard.Size = New System.Drawing.Size(90, 19)
        Me.CheckBoxMasterCard.TabIndex = 13
        Me.CheckBoxMasterCard.Text = "MasterCard"
        Me.CheckBoxMasterCard.UseVisualStyleBackColor = True
        '
        'CheckBoxVISA
        '
        Me.CheckBoxVISA.AutoSize = True
        Me.CheckBoxVISA.Location = New System.Drawing.Point(131, 250)
        Me.CheckBoxVISA.Name = "CheckBoxVISA"
        Me.CheckBoxVISA.Size = New System.Drawing.Size(51, 19)
        Me.CheckBoxVISA.TabIndex = 12
        Me.CheckBoxVISA.Text = "VISA"
        Me.CheckBoxVISA.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de pago:"
        '
        'MaskedCredito
        '
        Me.MaskedCredito.Location = New System.Drawing.Point(182, 206)
        Me.MaskedCredito.Mask = "0000 0000 0000 0000"
        Me.MaskedCredito.Name = "MaskedCredito"
        Me.MaskedCredito.Size = New System.Drawing.Size(134, 21)
        Me.MaskedCredito.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Número de tarjeta de crédito"
        '
        'comboNacionalidad
        '
        Me.comboNacionalidad.FormattingEnabled = True
        Me.comboNacionalidad.Items.AddRange(New Object() {"Honduras", "El Salvador", "Guatemala", "Estados Unidos", "México", "España", "Nicaragua ", "Cuba", "Costa Rica ", "Argentina"})
        Me.comboNacionalidad.Location = New System.Drawing.Point(100, 162)
        Me.comboNacionalidad.Name = "comboNacionalidad"
        Me.comboNacionalidad.Size = New System.Drawing.Size(174, 23)
        Me.comboNacionalidad.TabIndex = 8
        Me.comboNacionalidad.Text = "Seleccione un país"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nacionalidad"
        '
        'rbMas
        '
        Me.rbMas.AutoSize = True
        Me.rbMas.Location = New System.Drawing.Point(99, 126)
        Me.rbMas.Name = "rbMas"
        Me.rbMas.Size = New System.Drawing.Size(82, 19)
        Me.rbMas.TabIndex = 6
        Me.rbMas.TabStop = True
        Me.rbMas.Text = "Masculino"
        Me.rbMas.UseVisualStyleBackColor = True
        '
        'rbFeme
        '
        Me.rbFeme.AutoSize = True
        Me.rbFeme.BackColor = System.Drawing.Color.Transparent
        Me.rbFeme.Location = New System.Drawing.Point(99, 102)
        Me.rbFeme.Name = "rbFeme"
        Me.rbFeme.Size = New System.Drawing.Size(81, 19)
        Me.rbFeme.TabIndex = 5
        Me.rbFeme.TabStop = True
        Me.rbFeme.Text = "Femenino"
        Me.rbFeme.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sexo"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(100, 63)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(174, 21)
        Me.txtApellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(99, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 21)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPage1)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage2)
        Me.TabControlPrincipal.Location = New System.Drawing.Point(0, 21)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(637, 413)
        Me.TabControlPrincipal.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.rbCompra)
        Me.Panel1.Controls.Add(Me.rbDatos)
        Me.Panel1.Location = New System.Drawing.Point(4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 48)
        Me.Panel1.TabIndex = 23
        '
        'rbCompra
        '
        Me.rbCompra.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbCompra.AutoSize = True
        Me.rbCompra.FlatAppearance.BorderSize = 0
        Me.rbCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.rbCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCompra.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCompra.ForeColor = System.Drawing.Color.Black
        Me.rbCompra.Location = New System.Drawing.Point(221, 10)
        Me.rbCompra.Name = "rbCompra"
        Me.rbCompra.Size = New System.Drawing.Size(66, 25)
        Me.rbCompra.TabIndex = 1
        Me.rbCompra.Text = "Compra"
        Me.rbCompra.UseVisualStyleBackColor = True
        '
        'rbDatos
        '
        Me.rbDatos.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDatos.AutoSize = True
        Me.rbDatos.Checked = True
        Me.rbDatos.FlatAppearance.BorderSize = 0
        Me.rbDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.rbDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDatos.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDatos.ForeColor = System.Drawing.Color.Black
        Me.rbDatos.Location = New System.Drawing.Point(66, 10)
        Me.rbDatos.Name = "rbDatos"
        Me.rbDatos.Size = New System.Drawing.Size(117, 25)
        Me.rbDatos.TabIndex = 0
        Me.rbDatos.TabStop = True
        Me.rbDatos.Text = "Datos Generales"
        Me.rbDatos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 408)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlPrincipal)
        Me.Name = "Form1"
        Me.Text = "Formulario "
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents Toolmensaje As ToolTip
    Friend WithEvents TabControlPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaskedNum As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CheckBoxMasterCard As CheckBox
    Friend WithEvents CheckBoxVISA As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MaskedCredito As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents comboNacionalidad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbMas As RadioButton
    Friend WithEvents rbFeme As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnComprar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmMak As ComboBox
    Friend WithEvents cmSkin As ComboBox
    Friend WithEvents checkMak As CheckBox
    Friend WithEvents checkSkin As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbCompra As RadioButton
    Friend WithEvents rbDatos As RadioButton
    Friend WithEvents PictureBox4 As PictureBox

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
