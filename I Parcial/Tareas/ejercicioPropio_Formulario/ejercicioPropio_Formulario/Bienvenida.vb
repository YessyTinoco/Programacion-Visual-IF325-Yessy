Public Class Bienvenida
    Dim contador As Byte = 4
    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            'Efecto de desvanecimiento 
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then
                Me.Hide()
                Form1.Show()
                Timer1.Enabled = False
            End If
        Else
            ProgressBar1.Value += 4
            If ProgressBar1.Value = contador Then
                txtBienvenido.Text = "¡BIENVENIDO!"
            Else
                If ProgressBar1.Value = contador + 16 Then
                    txtBienvenido.Text = ""
                    contador += 20
                End If
                If ProgressBar1.Value = 28 Then
                    txtIniciando.Text = "Iniciando..."
                End If
            End If
        End If
    End Sub

    Private Sub txtBienvenido_Click(sender As Object, e As EventArgs) Handles txtBienvenido.Click

    End Sub
End Class