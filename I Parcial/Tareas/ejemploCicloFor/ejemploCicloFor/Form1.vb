Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        For a = 1 To Val(txtContar.Text)
            txtConteo.Text = txtConteo.Text & "  " & a
        Next
    End Sub

    Private Sub txtContar_TextChanged(sender As Object, e As EventArgs) Handles txtContar.TextChanged

    End Sub

    Private Sub txtContar_MouseHover(sender As Object, e As EventArgs) Handles txtContar.MouseHover
        ToolTip.SetToolTip(txtContar, "Ingrese un número")
        ToolTip.ToolTipTitle = ""
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
