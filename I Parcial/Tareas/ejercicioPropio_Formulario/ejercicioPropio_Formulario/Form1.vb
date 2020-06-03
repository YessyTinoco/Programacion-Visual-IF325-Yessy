Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese su Nombre")
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese su Apellido")
        End If
    End Sub

    Private Sub comboNacionalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboNacionalidad.SelectedIndexChanged

    End Sub

    Private Sub comboNacionalidad_Validating(sender As Object, e As CancelEventArgs) Handles comboNacionalidad.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Seleccione una opción")
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "Ingrese aquí el NOMBRE del usuario")
        Toolmensaje.ToolTipTitle = "Nombre del Usuario"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "Ingrese aquí el APELLIDO del usuario")
        Toolmensaje.ToolTipTitle = "Apellido del Usuario"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub CheckBoxVISA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxVISA.CheckedChanged
        'Condición para seleccionar una opción
        If CheckBoxVISA.Checked = True Then
            CheckBoxMasterCard.Checked = False
        End If
    End Sub

    Private Sub CheckBoxMasterCard_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMasterCard.CheckedChanged
        'Condición para seleccionar una opción
        If CheckBoxMasterCard.Checked = True Then
            CheckBoxVISA.Checked = False
        End If

    End Sub
End Class
