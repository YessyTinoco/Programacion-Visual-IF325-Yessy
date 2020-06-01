Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPedido.Clear()
        txtTotalIndividual.Clear()
        txtTotalPagar.Clear()
    End Sub

    Private Sub btnOrden_Click(sender As Object, e As EventArgs) Handles btnOrden.Click
        Try
            Dim precio, total, totalPagar, orden As Integer
            orden = txtPedido.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                'Acumulador: guarda los valores ingresados previamente 
                totalPagar = totalPagar + precio 'totalPagar+- = precio
            Next
            total = totalPagar / orden
            txtTotalPagar.Text = totalPagar
            txtTotalIndividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
