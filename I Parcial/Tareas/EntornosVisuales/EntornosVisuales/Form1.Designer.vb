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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDígito1 = New System.Windows.Forms.TextBox()
        Me.txtDígito2 = New System.Windows.Forms.TextBox()
        Me.btnSALIR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRESULTADO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.CheckSuma = New System.Windows.Forms.CheckBox()
        Me.CheckResta = New System.Windows.Forms.CheckBox()
        Me.CheckMULTIPLICACION = New System.Windows.Forms.CheckBox()
        Me.CheckDIVISION = New System.Windows.Forms.CheckBox()
        Me.CheckRAIZCUA = New System.Windows.Forms.CheckBox()
        Me.CheckPOTENCIA = New System.Windows.Forms.CheckBox()
        Me.CheckRaizCu = New System.Windows.Forms.CheckBox()
        Me.CheckRaizX = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OPERACIONES ARITMÉTICAS"
        '
        'txtDígito1
        '
        Me.txtDígito1.Location = New System.Drawing.Point(132, 164)
        Me.txtDígito1.Name = "txtDígito1"
        Me.txtDígito1.Size = New System.Drawing.Size(47, 20)
        Me.txtDígito1.TabIndex = 3
        '
        'txtDígito2
        '
        Me.txtDígito2.Location = New System.Drawing.Point(132, 208)
        Me.txtDígito2.Name = "txtDígito2"
        Me.txtDígito2.Size = New System.Drawing.Size(47, 20)
        Me.txtDígito2.TabIndex = 4
        '
        'btnSALIR
        '
        Me.btnSALIR.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALIR.Location = New System.Drawing.Point(452, 356)
        Me.btnSALIR.Name = "btnSALIR"
        Me.btnSALIR.Size = New System.Drawing.Size(57, 23)
        Me.btnSALIR.TabIndex = 9
        Me.btnSALIR.Text = "SALIR"
        Me.btnSALIR.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(351, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "RESULTADO"
        '
        'txtRESULTADO
        '
        Me.txtRESULTADO.Location = New System.Drawing.Point(440, 176)
        Me.txtRESULTADO.Name = "txtRESULTADO"
        Me.txtRESULTADO.Size = New System.Drawing.Size(45, 20)
        Me.txtRESULTADO.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(9, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ingrese un dígito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(9, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ingrese un dígito"
        '
        'btnLIMPIAR
        '
        Me.btnLIMPIAR.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLIMPIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIMPIAR.Location = New System.Drawing.Point(354, 226)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(68, 20)
        Me.btnLIMPIAR.TabIndex = 14
        Me.btnLIMPIAR.Text = "LIMPIAR"
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'CheckSuma
        '
        Me.CheckSuma.AutoSize = True
        Me.CheckSuma.BackColor = System.Drawing.Color.MistyRose
        Me.CheckSuma.Location = New System.Drawing.Point(201, 53)
        Me.CheckSuma.Name = "CheckSuma"
        Me.CheckSuma.Size = New System.Drawing.Size(57, 17)
        Me.CheckSuma.TabIndex = 15
        Me.CheckSuma.Text = "SUMA"
        Me.CheckSuma.UseVisualStyleBackColor = False
        '
        'CheckResta
        '
        Me.CheckResta.AutoSize = True
        Me.CheckResta.BackColor = System.Drawing.Color.MistyRose
        Me.CheckResta.Location = New System.Drawing.Point(201, 99)
        Me.CheckResta.Name = "CheckResta"
        Me.CheckResta.Size = New System.Drawing.Size(62, 17)
        Me.CheckResta.TabIndex = 16
        Me.CheckResta.Text = "RESTA"
        Me.CheckResta.UseVisualStyleBackColor = False
        '
        'CheckMULTIPLICACION
        '
        Me.CheckMULTIPLICACION.AutoSize = True
        Me.CheckMULTIPLICACION.BackColor = System.Drawing.Color.MistyRose
        Me.CheckMULTIPLICACION.Location = New System.Drawing.Point(201, 144)
        Me.CheckMULTIPLICACION.Name = "CheckMULTIPLICACION"
        Me.CheckMULTIPLICACION.Size = New System.Drawing.Size(115, 17)
        Me.CheckMULTIPLICACION.TabIndex = 17
        Me.CheckMULTIPLICACION.Text = "MULTIPLICACIÓN"
        Me.CheckMULTIPLICACION.UseVisualStyleBackColor = False
        '
        'CheckDIVISION
        '
        Me.CheckDIVISION.AutoSize = True
        Me.CheckDIVISION.BackColor = System.Drawing.Color.MistyRose
        Me.CheckDIVISION.Location = New System.Drawing.Point(201, 187)
        Me.CheckDIVISION.Name = "CheckDIVISION"
        Me.CheckDIVISION.Size = New System.Drawing.Size(73, 17)
        Me.CheckDIVISION.TabIndex = 18
        Me.CheckDIVISION.Text = "DIVISIÓN"
        Me.CheckDIVISION.UseVisualStyleBackColor = False
        '
        'CheckRAIZCUA
        '
        Me.CheckRAIZCUA.AutoSize = True
        Me.CheckRAIZCUA.BackColor = System.Drawing.Color.MistyRose
        Me.CheckRAIZCUA.Location = New System.Drawing.Point(201, 273)
        Me.CheckRAIZCUA.Name = "CheckRAIZCUA"
        Me.CheckRAIZCUA.Size = New System.Drawing.Size(114, 17)
        Me.CheckRAIZCUA.TabIndex = 19
        Me.CheckRAIZCUA.Text = "RAÍZ CUADRADA"
        Me.CheckRAIZCUA.UseVisualStyleBackColor = False
        '
        'CheckPOTENCIA
        '
        Me.CheckPOTENCIA.AutoSize = True
        Me.CheckPOTENCIA.BackColor = System.Drawing.Color.MistyRose
        Me.CheckPOTENCIA.Location = New System.Drawing.Point(201, 229)
        Me.CheckPOTENCIA.Name = "CheckPOTENCIA"
        Me.CheckPOTENCIA.Size = New System.Drawing.Size(80, 17)
        Me.CheckPOTENCIA.TabIndex = 20
        Me.CheckPOTENCIA.Text = "POTENCIA"
        Me.CheckPOTENCIA.UseVisualStyleBackColor = False
        '
        'CheckRaizCu
        '
        Me.CheckRaizCu.AutoSize = True
        Me.CheckRaizCu.BackColor = System.Drawing.Color.MistyRose
        Me.CheckRaizCu.Location = New System.Drawing.Point(201, 313)
        Me.CheckRaizCu.Name = "CheckRaizCu"
        Me.CheckRaizCu.Size = New System.Drawing.Size(93, 17)
        Me.CheckRaizCu.TabIndex = 21
        Me.CheckRaizCu.Text = "RAÍZ CÚBICA"
        Me.CheckRaizCu.UseVisualStyleBackColor = False
        '
        'CheckRaizX
        '
        Me.CheckRaizX.AutoSize = True
        Me.CheckRaizX.BackColor = System.Drawing.Color.MistyRose
        Me.CheckRaizX.Location = New System.Drawing.Point(201, 356)
        Me.CheckRaizX.Name = "CheckRaizX"
        Me.CheckRaizX.Size = New System.Drawing.Size(61, 17)
        Me.CheckRaizX.TabIndex = 22
        Me.CheckRaizX.Text = "RAÍZ X"
        Me.CheckRaizX.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(531, 400)
        Me.Controls.Add(Me.CheckRaizX)
        Me.Controls.Add(Me.CheckRaizCu)
        Me.Controls.Add(Me.CheckPOTENCIA)
        Me.Controls.Add(Me.CheckRAIZCUA)
        Me.Controls.Add(Me.CheckDIVISION)
        Me.Controls.Add(Me.CheckMULTIPLICACION)
        Me.Controls.Add(Me.CheckResta)
        Me.Controls.Add(Me.CheckSuma)
        Me.Controls.Add(Me.btnLIMPIAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRESULTADO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSALIR)
        Me.Controls.Add(Me.txtDígito2)
        Me.Controls.Add(Me.txtDígito1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDígito1 As TextBox
    Friend WithEvents txtDígito2 As TextBox
    Friend WithEvents btnSALIR As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRESULTADO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents CheckSuma As CheckBox
    Friend WithEvents CheckResta As CheckBox
    Friend WithEvents CheckMULTIPLICACION As CheckBox
    Friend WithEvents CheckDIVISION As CheckBox
    Friend WithEvents CheckRAIZCUA As CheckBox
    Friend WithEvents CheckPOTENCIA As CheckBox
    Friend WithEvents CheckRaizCu As CheckBox
    Friend WithEvents CheckRaizX As CheckBox
End Class
