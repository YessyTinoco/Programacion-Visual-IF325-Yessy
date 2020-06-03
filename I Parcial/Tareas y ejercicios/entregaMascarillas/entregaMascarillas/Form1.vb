Imports System.ComponentModel

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios As Integer
        Dim itemDepartamento As String
        idDepartamento = cmDepartamento.SelectedIndex
        itemDepartamento = cmDepartamento.SelectedItem.ToString
        municipios = Val(txtCantidadmunicipio.Text)

        Select Case idDepartamento
            Case 0
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 1
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 2
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 3
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 4
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 5
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 6
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 7
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 8
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 9
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 10
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 11
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 12
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 13
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 14
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 15
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 16
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
            Case 17
                txtStock.Text = cantidadMascarillas(municipios, itemDepartamento)
        End Select
        txtStock.Text = itemDepartamento
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'For, DoWhile
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtCantidad.Text)
        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("Ingrese la cantidad de mascarillas" & i, ", Ingresar")
            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmDepartamento.Items.Add(mascarillas)
        Next
    End Sub
    Public Function cantidadMascarillas(cantidadMunicipio As Integer, itemDepartamento As String)
        Dim cantidadEntrega As Integer


        For i = 1 To cantidadMunicipio Step 1
            While (itemDepartamento > 0)
                cantidadEntrega = Val(InputBox("Ingrese la cantidad a entregar" & i, "Entrega de mascarillas"))
                If (itemDepartamento > cantidadEntrega) Then
                    cantidadMunicipio += 1
                    itemDepartamento -= cantidadEntrega
                Else
                    MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End While
        Next

        Return itemDepartamento

    End Function

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidar.SetError(sender, "")
        Else
            Me.errorValidar.SetError(sender, "Ingrese su Nombre")
        End If
    End Sub

    Private Sub txtCantidadmunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadmunicipio.TextChanged

    End Sub

    Private Sub txtCantidadmunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidadmunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidar.SetError(sender, "")
        Else
            Me.errorValidar.SetError(sender, "Ingrese su Nombre")
        End If
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        toolMensaje.SetToolTip(txtCantidad, "Ingrese aquí la cantidad de departamentos")
        toolMensaje.ToolTipTitle = "Cantidad de Departamento "
        toolMensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidadmunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtCantidadmunicipio.MouseHover
        toolMensaje.SetToolTip(txtCantidadmunicipio, "Ingrese aquí la cantidad de departamentos")
        toolMensaje.ToolTipTitle = "Nombre del Usuario"
        toolMensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class

