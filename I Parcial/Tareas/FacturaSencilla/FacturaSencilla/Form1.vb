Public Class Form1
    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click

        'Declaración de variables 
        Dim precioUnitario, Cantidad As Integer
        Dim subtotal, Descuento, ISV15, ISV17, Total As Integer


        btnNuevo.Enabled = False


            'Asignación de valores a las variable 
            precioUnitario = Val(txtprecioUnitario.Text)
        Cantidad = Val(txtCantidad.Text)

        'Evalúa si se han ingresado valores
        If (txtprecioUnitario.Text = "") And (txtCantidad.Text = "") Then
            MsgBox("Ingrese un valor en las casillas", vbInformation)
            Exit Sub
        End If

        If txtprecioUnitario.Text = "" Then
            MsgBox("Ingrese un precio", vbInformation)
            txtprecioUnitario.Focus()
            Exit Sub
        ElseIf txtCantidad.Text = "" Then
            MsgBox("Ingrese una cantidad", vbInformation)
            txtCantidad.Focus()
            Exit Sub
        End If

        'Evalúa si se ha ingresado un valor que no es numérico
        If Not IsNumeric(txtprecioUnitario.Text) Or Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor numérico!", vbInformation)
            Exit Sub
        End If

        'Evalúa si se ha ingresado un valor negativo
        If (txtprecioUnitario.Text <= 0) And (txtCantidad.Text <= 0) Then
            MsgBox("Ingrese un valor válido", vbInformation)
            Exit Sub
        ElseIf (txtprecioUnitario.Text <= 0) Then
            MsgBox("No hay precios negativos", vbInformation)
            Exit Sub
        ElseIf (txtCantidad.Text <= 0) Then
            MsgBox("No hay cantidades negativas", vbInformation)
            Exit Sub
        End If


        If ComboDescuento.SelectedIndex = -1 Then
            subtotal = (precioUnitario * Cantidad)
            txtDescuento.Text = ("No Aplica")
            txtISV15.Text = ("No Aplica")
            txtISV17.Text = ("No Aplica")
            Total = subtotal
        End If


        'Evalúa el cálculo del descuento 
        'Descuento Tercer edad 
        If ComboDescuento.SelectedIndex = 0 Then
            subtotal = (precioUnitario * Cantidad)
            Descuento = (subtotal * 0.5)
            Total = (subtotal - Descuento)

            'Descuento Comercial 
        ElseIf ComboDescuento.SelectedIndex = 1 Then
            subtotal = (precioUnitario * Cantidad)
            Descuento = (subtotal * 0.1)
            Total = (subtotal - Descuento)

            'Descuento Jubilado 
        ElseIf ComboDescuento.SelectedIndex = 2 Then
            subtotal = (precioUnitario * Cantidad)
            Descuento = (subtotal * 0.25)
            Total = (subtotal - Descuento)

            'Descuento Pimera Compra
        ElseIf ComboDescuento.SelectedIndex = 3 Then
            subtotal = (precioUnitario * Cantidad)
            Descuento = (subtotal * 0.2)
            Total = (subtotal - Descuento)

            'Descuento Cliente Preferencial 
        ElseIf ComboDescuento.SelectedIndex = 4 Then
            subtotal = (precioUnitario * Cantidad)
            Descuento = (subtotal * 0.25)
            Total = (subtotal - Descuento)

            'Descuento Liquidación 
        ElseIf ComboDescuento.SelectedIndex = 5 Then
            subtotal = (precioUnitario * Cantidad)
            Descuento = (subtotal * 0.1)
            Total = (subtotal - Descuento)
        End If

        'Evalúa el cálculo del impuesto 
        'Impuesto 15%
        If ComboISV.SelectedIndex = 0 Then
                subtotal = (precioUnitario * Cantidad)
            Descuento = 0
            ISV15 = (subtotal * 0.15)
                Total = (subtotal + ISV15)

                'Impuesto 17%
            ElseIf ComboISV.SelectedIndex = 1 Then
            subtotal = (precioUnitario * Cantidad)
            Descuento = 0
            ISV17 = (subtotal * 0.17)
            Total = (subtotal + ISV17)
        End If

        'Salida
        txtsubtotal.Text = subtotal
        txtDescuento.Text = Descuento
        txtISV15.Text = ISV15
        txtISV17.Text = ISV17
        txtTotal.Text = Total

        If (txtsubtotal.Text = "") And (txtprecioUnitario.Text = "") And (txtCantidad.Text = "") Then
            btnNuevo.Enabled = False
        Else
            btnNuevo.Enabled = True
        End If

    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtprecioUnitario.Clear()
        txtCantidad.Clear()
        txtsubtotal.Clear()
        txtDescuento.Clear()
        txtISV15.Clear()
        txtISV17.Clear()
        txtTotal.Clear()
        CheckDescuento.Checked = False
        CheckISV.Checked = False
        ComboDescuento.ResetText()
        ComboISV.ResetText()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        txtsubtotal.Clear()
        txtDescuento.Clear()
        txtISV15.Clear()
        txtISV17.Clear()
        txtTotal.Clear()
        CheckDescuento.Checked = False
        CheckISV.Checked = False
        ComboDescuento.Text = ""
        ComboISV.Text = ""
    End Sub

    Private Sub ComboDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDescuento.SelectedIndexChanged


    End Sub

    Private Sub ComboISV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboISV.SelectedIndexChanged

    End Sub

    Private Sub CheckDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDescuento.CheckedChanged
        'Condición para seleccionar una opción
        If CheckDescuento.Checked = True Then
            ComboDescuento.Enabled = True
            ComboISV.Enabled = False
            CheckISV.Checked = False
            ComboISV.SelectedIndex = -1

        Else
            ComboDescuento.Enabled = False
        End If

    End Sub

    Private Sub CheckISV_CheckedChanged(sender As Object, e As EventArgs) Handles CheckISV.CheckedChanged
        'Condición para seleccionar una opción
        If CheckISV.Checked = True Then
            ComboISV.Enabled = True
            ComboDescuento.Enabled = False
            CheckDescuento.Checked = False
            ComboISV.SelectedIndex = -1

        Else
            ComboISV.Enabled = False
        End If

    End Sub
End Class
