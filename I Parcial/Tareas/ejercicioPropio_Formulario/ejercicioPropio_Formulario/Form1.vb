Imports System.ComponentModel

Public Class Form1

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedCredito.MaskInputRejected

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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dateTime.ValueChanged

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedNum.MaskInputRejected

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "Ingrese aquí su NOMBRE")
        Toolmensaje.ToolTipTitle = "Nombre del Usuario"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "Ingrese aquí su APELLIDO")
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        Dim cantidad, precioUnitario, total As Integer
        cantidad = txtCantidad.Text

        If cmSkin.SelectedIndex = 0 Then
                precioUnitario = 650
                total = (cantidad * precioUnitario)

            ElseIf cmSkin.SelectedIndex = 1 Then
                precioUnitario = 520
                total = (cantidad * precioUnitario)
            ElseIf cmSkin.SelectedIndex = 2 Then
                precioUnitario = 670
                total = (cantidad * precioUnitario)
            ElseIf cmSkin.SelectedIndex = 3 Then
                precioUnitario = 330
                total = (cantidad * precioUnitario)
            ElseIf cmSkin.SelectedIndex = 4 Then
                precioUnitario = 580
                total = (cantidad * precioUnitario)
            End If

            If cmMak.SelectedIndex = 0 Then
                precioUnitario = 230
                total = (cantidad * precioUnitario)
            ElseIf cmMak.SelectedIndex = 1 Then
                precioUnitario = 390
                total = (cantidad * precioUnitario)
            ElseIf cmMak.SelectedIndex = 2 Then
                precioUnitario = 330
                total = (cantidad * precioUnitario)
            ElseIf cmMak.SelectedIndex = 3 Then
                precioUnitario = 1500
                total = (cantidad * precioUnitario)
            ElseIf cmMak.SelectedIndex = 4 Then
                precioUnitario = 220
                total = (cantidad * precioUnitario)
            End If
            txtPrecio.Text = precioUnitario
            txtTotal.Text = total

        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Está seguro de realizar la compra?", "COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.No) Then
            Me.Close()
        End If

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "Ingrese la cantidad que desea comprar")
        Toolmensaje.ToolTipTitle = "Cantidad"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub checkSkin_CheckedChanged(sender As Object, e As EventArgs) Handles checkSkin.CheckedChanged
        If checkSkin.Checked = True Then
            cmSkin.Enabled = True
            cmMak.Enabled = False
            checkMak.Checked = False
            cmMak.SelectedIndex = -1

        Else
            cmSkin.Enabled = False
        End If

    End Sub

    Private Sub checkMak_CheckedChanged(sender As Object, e As EventArgs) Handles checkMak.CheckedChanged
        'Condición para seleccionar una opción
        If checkMak.Checked = True Then
            cmMak.Enabled = True
            cmSkin.Enabled = False
            checkSkin.Checked = False
            cmSkin.SelectedIndex = -1

        Else
            cmMak.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPrecio.Clear()
        txtNombre.Clear()
        txtTotal.Clear()
        txtApellido.Clear()
        checkSkin.Checked = False
        checkMak.Checked = False
        CheckBoxVISA.Checked = False
        CheckBoxMasterCard.Checked = False
        cmSkin.ResetText()
        cmMak.ResetText()
        comboNacionalidad.ResetText()
        MaskedCredito.Mask = ""
        MaskedCredito.Text = ""
        MaskedNum.Mask = ""
        MaskedNum.Text = ""
        rbFeme.Checked = False
        rbMas.Checked = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir de la app?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub

    Private Sub rbDatos_CheckedChanged(sender As Object, e As EventArgs) Handles rbDatos.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(0)
    End Sub

    Private Sub rbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles rbCompra.CheckedChanged
        TabControlPrincipal.SelectedTab = TabControlPrincipal.TabPages.Item(1)
    End Sub
End Class
