Imports System.ComponentModel

Public Class Numeros

    Private Sub limpiar()
        cmbNum.Items.Clear()
    End Sub
    Private Sub txtNum_MouseHaover(sender As Object, e As EventArgs) Handles txtNum.MouseHover
        ToolTip.SetToolTip(txtNum, "Digite la cantidad de numeros que desea agregar")
        ToolTip.ToolTipTitle = "Número"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged

    End Sub



    Private Sub cmbNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNum.SelectedIndexChanged
        cmbNum.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim numeros As String
        Dim cantidad As Integer
        Dim numPar = 0.0, numImpar = 0.0, numPositivo = 0.0, numNegativo = 0.0, suma, valores As Integer
        cantidad = Val(txtNum.Text)

        Try
            If IsNumeric(txtNum.Text) = True And cantidad > 0 Then

                For i = 1 To cantidad Step 1
                    numeros = InputBox("Ingrese la cantidad de numeros " & i, "INGRESAR")
                    cmbNum.Items.Add(numeros)
                    txtCant.Text = cantidad
                    If IsNumeric(numeros) = True And numeros <> String.Empty Then
                        valores = Val(numeros)
                        suma += valores
                        txtSuma.Text = suma

                        If valores Mod 2 = 0 Then
                            numPar += 1
                            txtPar.Text = numPar
                        ElseIf valores Mod 2 <> 0 Then
                            numImpar += 1
                            txtImpar.Text = numImpar
                        End If

                        If valores > 0 Then
                            numPositivo += 1
                            txtPositivo.Text = numPositivo
                        ElseIf valores < 0 Then
                            numNegativo += 1
                            txtNegativo.Text = numPositivo
                        End If
                    Else
                        MessageBox.Show("Ingrese valores numericos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next
            Else
                MessageBox.Show("Ingrese valores numericos que sean mayores a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiar()
        txtNum.Clear()
        txtPar.Clear()
        txtImpar.Clear()
        txtNegativo.Clear()
        txtPositivo.Clear()
        txtCant.Clear()
        txtSuma.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Show()
        Me.Hide()
    End Sub



    Private Sub txtNum_Validating(sender As Object, e As CancelEventArgs) Handles txtNum.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorEncontrado.SetError(sender, "")
        Else
            Me.errorEncontrado.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
End Class