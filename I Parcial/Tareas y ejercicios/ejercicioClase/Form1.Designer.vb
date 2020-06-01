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
        Me.cmbEquipos = New System.Windows.Forms.ComboBox()
        Me.btnMostra = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbEquipos
        '
        Me.cmbEquipos.AutoCompleteCustomSource.AddRange(New String() {"Jose", "Manuel", "Mario", "Cristiano ", "Oscar", "Jorge "})
        Me.cmbEquipos.FormattingEnabled = True
        Me.cmbEquipos.Items.AddRange(New Object() {"Barcelona", "Real Madrid", "Real España", "Juventus ", "Manchester", "Liverpool "})
        Me.cmbEquipos.Location = New System.Drawing.Point(77, 85)
        Me.cmbEquipos.Name = "cmbEquipos"
        Me.cmbEquipos.Size = New System.Drawing.Size(134, 21)
        Me.cmbEquipos.TabIndex = 0
        Me.cmbEquipos.Text = "Seleccione una opción"
        '
        'btnMostra
        '
        Me.btnMostra.Location = New System.Drawing.Point(102, 137)
        Me.btnMostra.Name = "btnMostra"
        Me.btnMostra.Size = New System.Drawing.Size(75, 23)
        Me.btnMostra.TabIndex = 1
        Me.btnMostra.Text = "MOSTRAR "
        Me.btnMostra.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnMostra)
        Me.Controls.Add(Me.cmbEquipos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbEquipos As ComboBox
    Friend WithEvents btnMostra As Button
End Class
