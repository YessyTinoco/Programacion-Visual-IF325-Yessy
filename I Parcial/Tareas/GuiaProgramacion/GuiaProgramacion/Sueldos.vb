Imports System.ComponentModel

Public Class Sueldos

    Private Sub txtPago_MouseHover(sender As Object, e As EventArgs) Handles txtPago.MouseHover
        ToolTip.SetToolTip(txtPago, "")
        ToolTip.ToolTipTitle = "Ingrese su sueldo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPago_TextChanged(sender As Object, e As EventArgs) Handles txtPago.TextChanged

    End Sub


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim sueldo, Isv15, Isv20, Isv25, sueldoNeto As Double

        sueldo = Val(txtPago.Text)
        If sueldo <= 16582.92 Then
            MessageBox.Show("Excento de impuesto", "No aplica", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sueldoNeto = sueldo
        ElseIf (sueldo >= 16582.93) And (sueldo <= 23535.61) Then
            Isv15 = (sueldo * 0.15)
            sueldoNeto = (sueldo - Isv15)
        ElseIf (sueldo >= 23536.62) And (sueldo <= 50317.69) Then
            Isv20 = (sueldo * 0.2)
            sueldoNeto = (sueldo - Isv20)
        ElseIf (sueldo >= 50317.69) Then
            Isv25 = (sueldo * 0.25)
            sueldoNeto = (sueldo - Isv25)
        End If
        txt15.Text = Isv15
        txt20.Text = Isv20
        txt25.Text = Isv25
        txtSueldo.Text = sueldoNeto
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSueldo.Clear()
        txtPago.Clear()
        txt15.Clear()
        txt20.Clear()
        txt25.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txtPago_Validating(sender As Object, e As CancelEventArgs) Handles txtPago.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub
End Class