


Imports System.ComponentModel

Public Class Formula

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valorA, valorB, valorC As Double
        'Dim x1, x2 As Double

        valorA = CInt(txtA.Text)
        valorB = CInt(txtB.Text)
        valorC = CInt(txtC.Text)

        txtX1.Text = ((-valorB + Math.Sqrt((valorB * valorB) - (4 * valorA * valorC))) / (2 * valorA))
        txtX2.Text = ((-valorB - Math.Sqrt((valorB * valorB) - (4 * valorA * valorC))) / (2 * valorA))

        'txtX1.Text = x1
        'txtX2.Text = x2

        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        txtX1.Visible = True
        txtX2.Visible = True
        btnSalir.Visible = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged

    End Sub



    Private Sub txtA_MouseHover(sender As Object, e As EventArgs) Handles txtA.MouseHover
        ToolTip.SetToolTip(txtA, "Ingrese el coeficiente de término cuadrático")
        ToolTip.ToolTipTitle = "Valor de a"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged

    End Sub

    Private Sub txtB_Validating(sender As Object, e As CancelEventArgs) Handles txtB.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub

    Private Sub txtB_MouseHover(sender As Object, e As EventArgs) Handles txtB.MouseHover
        ToolTip.SetToolTip(txtB, "Ingrese el coeficiente de término lineal")
        ToolTip.ToolTipTitle = "Valor de b"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged

    End Sub

    Private Sub txtC_Validating(sender As Object, e As CancelEventArgs) Handles txtC.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub

    Private Sub txtC_MouseHover(sender As Object, e As EventArgs) Handles txtC.MouseHover
        ToolTip.SetToolTip(txtB, "Ingrese el coeficiente de término independiente")
        ToolTip.ToolTipTitle = "Valor de c"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtA_Validating(sender As Object, e As CancelEventArgs) Handles txtA.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
End Class