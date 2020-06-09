<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.btnHis = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.History = New System.Windows.Forms.ListBox()
        Me.txtOpe = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnAste = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnRest = New System.Windows.Forms.Button()
        Me.btnMoM = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnPleca = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHis
        '
        Me.btnHis.Enabled = False
        Me.btnHis.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHis.Location = New System.Drawing.Point(243, 12)
        Me.btnHis.Name = "btnHis"
        Me.btnHis.Size = New System.Drawing.Size(88, 27)
        Me.btnHis.TabIndex = 41
        Me.btnHis.Text = "History"
        Me.btnHis.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(178, 110)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(59, 52)
        Me.btnIgual.TabIndex = 40
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(178, 45)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 52)
        Me.btnClear.TabIndex = 39
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'History
        '
        Me.History.FormattingEnabled = True
        Me.History.Location = New System.Drawing.Point(243, 12)
        Me.History.Name = "History"
        Me.History.Size = New System.Drawing.Size(88, 147)
        Me.History.TabIndex = 38
        '
        'txtOpe
        '
        Me.txtOpe.Location = New System.Drawing.Point(22, 12)
        Me.txtOpe.Multiline = True
        Me.txtOpe.Name = "txtOpe"
        Me.txtOpe.Size = New System.Drawing.Size(215, 27)
        Me.txtOpe.TabIndex = 37
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(22, 105)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(33, 27)
        Me.btn1.TabIndex = 36
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(22, 75)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(33, 27)
        Me.btn4.TabIndex = 35
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSum.Location = New System.Drawing.Point(139, 135)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(33, 27)
        Me.btnSum.TabIndex = 34
        Me.btnSum.Text = "+"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnPunto
        '
        Me.btnPunto.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.Location = New System.Drawing.Point(100, 135)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(33, 27)
        Me.btnPunto.TabIndex = 33
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(61, 105)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(33, 27)
        Me.btn2.TabIndex = 32
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btnAste
        '
        Me.btnAste.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAste.Location = New System.Drawing.Point(139, 75)
        Me.btnAste.Name = "btnAste"
        Me.btnAste.Size = New System.Drawing.Size(33, 27)
        Me.btnAste.TabIndex = 31
        Me.btnAste.Text = "*"
        Me.btnAste.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(100, 105)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(33, 27)
        Me.btn3.TabIndex = 30
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(100, 75)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(33, 27)
        Me.btn6.TabIndex = 29
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnRest
        '
        Me.btnRest.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRest.Location = New System.Drawing.Point(139, 105)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(33, 27)
        Me.btnRest.TabIndex = 28
        Me.btnRest.Text = "-"
        Me.btnRest.UseVisualStyleBackColor = True
        '
        'btnMoM
        '
        Me.btnMoM.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoM.Location = New System.Drawing.Point(61, 135)
        Me.btnMoM.Name = "btnMoM"
        Me.btnMoM.Size = New System.Drawing.Size(33, 27)
        Me.btnMoM.TabIndex = 27
        Me.btnMoM.Text = "+/-"
        Me.btnMoM.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(100, 45)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(33, 27)
        Me.btn9.TabIndex = 26
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnPleca
        '
        Me.btnPleca.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPleca.Location = New System.Drawing.Point(139, 45)
        Me.btnPleca.Name = "btnPleca"
        Me.btnPleca.Size = New System.Drawing.Size(33, 27)
        Me.btnPleca.TabIndex = 25
        Me.btnPleca.Text = "/"
        Me.btnPleca.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(61, 75)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(33, 27)
        Me.btn5.TabIndex = 24
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(22, 135)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(33, 27)
        Me.btn0.TabIndex = 23
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(61, 45)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(33, 27)
        Me.btn8.TabIndex = 22
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(22, 45)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(33, 27)
        Me.btn7.TabIndex = 21
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(256, 177)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 42
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 212)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnHis)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.History)
        Me.Controls.Add(Me.txtOpe)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnPunto)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnAste)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btnRest)
        Me.Controls.Add(Me.btnMoM)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btnPleca)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHis As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents History As ListBox
    Friend WithEvents txtOpe As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnAste As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnRest As Button
    Friend WithEvents btnMoM As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnPleca As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnRegresar As Button
End Class
