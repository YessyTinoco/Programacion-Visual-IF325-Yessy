Public Class Almacen
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim almacen As Integer
        Dim promedio, total, almacen1, almacen2, almacen3, almacen4, almacen5, almacen6, almacen7, almacen8, almacen9, almacen10 As Integer
        Try
            almacen = 10

            almacen1 = InputBox("Ventas optenidas del almacén #1 Las 4 hermanas", "Ingresar")
            almacen2 = InputBox("Ventas optenidas del almacén #2 Molly", "Ingresar")
            almacen3 = InputBox("Ventas optenidas del almacén #3 Hurypetrosky", "Ingresar")
            almacen4 = InputBox("Ventas optenidas del almacén #4 Floppy", "Ingresar")
            almacen5 = InputBox("Ventas optenidas del almacén #5 Las Princesas", "Ingresar")
            almacen6 = InputBox("Ventas optenidas del almacén #6 Los Casa Grande", "Ingresar")
            almacen7 = InputBox("Ventas optenidas del almacén #7 El Dorado", "Ingresar")
            almacen8 = InputBox("Ventas optenidas del almacén #8 Los Castillos", "Ingresar")
            almacen9 = InputBox("Ventas optenidas del almacén #9 Cloe", "Ingresar")
            almacen10 = InputBox("Ventas optenidas del almacén #10 La Meseta", "Ingresar")

            total = (almacen1 + almacen2 + almacen3 + almacen4 + almacen5 + almacen6 + almacen7 + almacen8 + almacen9 + almacen10)
            promedio = (total / almacen)
            txtMedia.Text = promedio

            If almacen1 > promedio Then
                listAlmacen.Items.Add("Almacén 'Las 4 hermanas'" & " = " & almacen1)
            End If
            If almacen2 > promedio Then
                listAlmacen.Items.Add("Almacén 'Moly'" & " = " & almacen2)
            End If
            If almacen3 > promedio Then
                listAlmacen.Items.Add("Almacén 'Hurypetrosky'" & " = " & almacen3)
            End If
            If almacen4 > promedio Then
                listAlmacen.Items.Add("Almacén 'Floppy'" & " = " & almacen4)
            End If
            If almacen5 > promedio Then
                listAlmacen.Items.Add("Almacén 'Las Princesas'" & " = " & almacen5)
            End If
            If almacen6 > promedio Then
                listAlmacen.Items.Add("Almacén 'Los Casa Grande'" & " = " & almacen6)
            End If
            If almacen7 > promedio Then
                listAlmacen.Items.Add("Almacén 'El Dorado'" & " = " & almacen7)
            End If
            If almacen8 > promedio Then
                listAlmacen.Items.Add("Almacén 'Los Castillos'" & " = " & almacen8)
            End If
            If almacen9 > promedio Then
                listAlmacen.Items.Add("Almacén 'Cloe'" & " = " & almacen9)
            End If
            If almacen10 > promedio Then
                listAlmacen.Items.Add("Almacén 'La Meseta'" & " = " & almacen10)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtLimpiar_Click(sender As Object, e As EventArgs) Handles txtLimpiar.Click
        listAlmacen.Items.Clear()
        txtMedia.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class