Public Class Calculadora

    Private numero1 As Double = 0.0
        Private numero2 As Double = 0.0
        Private signo As String

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtOpe.Text = txtOpe.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtOpe.Text = txtOpe.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtOpe.Text = txtOpe.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtOpe.Text = txtOpe.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtOpe.Text = txtOpe.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtOpe.Text = txtOpe.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtOpe.Text = txtOpe.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtOpe.Text = txtOpe.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtOpe.Text = txtOpe.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtOpe.Text = txtOpe.Text & "9"
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Try
            If txtOpe.Text <> "" Then
                numero1 = Val(txtOpe.Text)
                signo = "+"
                txtOpe.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        Try
            If txtOpe.Text <> "" Then
                numero1 = Val(txtOpe.Text)
                signo = "-"
                txtOpe.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAste_Click(sender As Object, e As EventArgs) Handles btnAste.Click
        Try
            If txtOpe.Text <> "" Then
                numero1 = Val(txtOpe.Text)
                signo = "*"
                txtOpe.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPleca_Click(sender As Object, e As EventArgs) Handles btnPleca.Click
        Try
            If txtOpe.Text <> "" Then
                numero1 = Val(txtOpe.Text)
                signo = "/"
                txtOpe.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOpe.Clear()
        numero1 = 0.0
        numero2 = 0.0
        signo = String.Empty
        History.Items.Clear()
    End Sub

    Private Sub btnMoM_Click(sender As Object, e As EventArgs) Handles btnMoM.Click
        Try
            If txtOpe.Text <> "" Then
                txtOpe.Text = txtOpe.Text * (-1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If txtOpe.Text = "" Then
            txtOpe.Text = "0."
        ElseIf punto(txtOpe.Text) = False Then
            txtOpe.Text = txtOpe.Text & "."
        End If

    End Sub
    Private Function punto(ByVal cadena As String) As Boolean
        Dim longitud As Integer
        Dim resultado As Boolean = False
        longitud = cadena.Length

        For i As Integer = 1 To longitud Step 1
            If Mid(cadena, i, 1) = "." Then
                resultado = True
            End If
        Next
        Return resultado
    End Function

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Try
            If txtOpe.Text <> "" And numero1 <> 0.0 Then
                numero2 = txtOpe.Text
                calcular()
                History.Items.Add(txtOpe.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub calcular()
        Select Case signo
            Case "+"
                txtOpe.Text = numero1 + numero2
            Case "-"
                txtOpe.Text = numero1 - numero2
            Case "*"
                txtOpe.Text = numero1 * numero2
            Case "/"
                txtOpe.Text = numero1 / numero2
            Case Else
                txtOpe.Text = "Math ERROR"
        End Select

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class