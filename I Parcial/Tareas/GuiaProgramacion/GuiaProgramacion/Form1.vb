Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calculadora.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formula.Show()
        Me.Hide()
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Sueldos.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Almacen.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Numeros.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
