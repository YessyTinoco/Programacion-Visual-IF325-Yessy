<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.txtIniciando = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBienvenido = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIniciando
        '
        Me.txtIniciando.AutoSize = True
        Me.txtIniciando.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIniciando.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtIniciando.Image = CType(resources.GetObject("txtIniciando.Image"), System.Drawing.Image)
        Me.txtIniciando.Location = New System.Drawing.Point(225, 118)
        Me.txtIniciando.Name = "txtIniciando"
        Me.txtIniciando.Size = New System.Drawing.Size(82, 20)
        Me.txtIniciando.TabIndex = 1
        Me.txtIniciando.Text = "Iniciando"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(37, 144)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(462, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtBienvenido
        '
        Me.txtBienvenido.AutoSize = True
        Me.txtBienvenido.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBienvenido.Image = CType(resources.GetObject("txtBienvenido.Image"), System.Drawing.Image)
        Me.txtBienvenido.Location = New System.Drawing.Point(159, 48)
        Me.txtBienvenido.Name = "txtBienvenido"
        Me.txtBienvenido.Size = New System.Drawing.Size(224, 34)
        Me.txtBienvenido.TabIndex = 2
        Me.txtBienvenido.Text = "¡BIENVENIDO!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 213)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtBienvenido)
        Me.Controls.Add(Me.txtIniciando)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Bienvenida"
        Me.Text = "Bienvenida"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtIniciando As Label
    Friend WithEvents txtBienvenido As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
