Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click

        txtDígito1.Text = ""
        txtDígito2.Text = ""
        txtRESULTADO.Text = ""

    End Sub

    Private Sub btnSALIR_Click(sender As Object, e As EventArgs) Handles btnSALIR.Click
        Close()
    End Sub

    Private Sub CheckSuma_CheckedChanged(sender As Object, e As EventArgs) Handles CheckSuma.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)

        'Proceso
        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If
        RESULTADO = Dígito1 + Dígito2

        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If

    End Sub

    Private Sub CheckResta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckResta.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)

        'Proceso

        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If
        RESULTADO = Dígito1 - Dígito2

        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If

    End Sub

    Private Sub CheckMULTIPLICACION_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMULTIPLICACION.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)

        'Proceso
        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If
        RESULTADO = Dígito1 * Dígito2

        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If

    End Sub

    Private Sub CheckDIVISION_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDIVISION.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)
        'Proceso
        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If
        If Dígito2 > 0 Then
            RESULTADO = Dígito1 / Dígito2
            RESULTADO = Format(RESULTADO, "0.00")
        Else
            MsgBox("ERROR MATEMÁTICO", vbInformation)
        End If

        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If

    End Sub

    Private Sub CheckRAIZ_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRAIZCUA.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)

        'Proceso
        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If
        RESULTADO = Dígito1 ^ (1 / 2)

        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If


    End Sub

    Private Sub CheckPOTENCIA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPOTENCIA.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)

        'Proceso
        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If
        RESULTADO = Dígito1 ^ Dígito2

        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If

    End Sub

    Private Sub CheckRaizCu_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRaizCu.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)

        'Proceso
        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If
        RESULTADO = Dígito1 ^ (1 / 3)

        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If

    End Sub

    Private Sub CheckRaizX_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRaizX.CheckedChanged
        'Inicio 
        Dim Dígito1 As Integer
        Dim Dígito2 As Integer
        Dim RESULTADO As Integer

        Dígito1 = Val(txtDígito1.Text)
        Dígito2 = Val(txtDígito2.Text)

        'Proceso
        If txtDígito1.Text = "" Or txtDígito2.Text = "" Then
            MsgBox("Ingrese un dígito en las casillas", vbInformation)
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            txtDígito2.Text = ""
        ElseIf Not IsNumeric(txtDígito1.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito1.Text = ""
        ElseIf Not IsNumeric(txtDígito2.Text) Then
            MsgBox("Ingrese un valor numérico", vbInformation)
            txtDígito2.Text = ""
        End If

        If Dígito2 > 0 Then
            RESULTADO = Dígito1 ^ (1 / Val(txtDígito2.Text))
            RESULTADO = Format(RESULTADO, "0.00")
        Else
            MsgBox("ERROR MATEMÁTICO", vbInformation)
        End If


        'Resultado  
        txtRESULTADO.Text = RESULTADO

        If RESULTADO = 0 Then
            MsgBox("El resultado es un valor Cero", vbInformation)
        ElseIf RESULTADO > 0 Then
            MsgBox("El resultado es un valor Positivo")
        ElseIf RESULTADO < 0 Then
            MsgBox("El resultado es un valor Negativo")
        End If
    End Sub

    Private Sub txtDígito2_TextChanged(sender As Object, e As EventArgs) Handles txtDígito2.TextChanged

    End Sub
End Class