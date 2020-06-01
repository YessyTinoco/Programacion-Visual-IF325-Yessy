Public Class Form1
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If txtNumero.Text = "" Then
            MsgBox("Escriba un número en la casilla")
        End If

        'Evalúa si se ha ingresado un valor que no es numérico
        If Not IsNumeric(txtNumero.Text) Then
            MsgBox("Ingrese un valor numérico!", vbInformation)
            Exit Sub
        End If
        'Evalúa si se ha ingresado un valor negativo
        If (txtNumero.Text <= 0) Then
            MsgBox("Ingrese un valor válido", vbInformation)
            Exit Sub
        End If
    End Sub
End Class
