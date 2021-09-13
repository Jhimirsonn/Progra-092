Module Modulo
    Public funcion, cine As String
    Public entradas As Integer
    Public funciones(8) As String
    Public cines(8) As String
    Public cantidades(8) As Integer
    Public subtotal(8) As Integer
    Public descuento1(8) As Double
    Public descuento2(8) As Double
    Public total(8) As Double
    Public contador As Integer = 0

    Sub Calcular()
        If contador < 9 Then
            funciones(contador) = funcion
            cines(contador) = cine
            cantidades(contador) = entradas
            Dim valor As Integer
            Select Case funcion
                Case "1"
                    Select Case cine
                        Case "A"
                            valor = 30
                        Case "B"
                            valor = 24
                        Case "C"
                            valor = 35
                    End Select
                Case "2"
                    Select Case cine
                        Case "A"
                            valor = 35
                        Case "B"
                            valor = 34
                        Case "C"
                            valor = 40
                    End Select
                Case "3"
                    Select Case cine
                        Case "A"
                            valor = 40
                        Case "B"
                            valor = 44
                        Case "C"
                            valor = 50
                    End Select
                Case "4"
                    Select Case cine
                        Case "A"
                            valor = 40
                        Case "B"
                            valor = 44
                        Case "C"
                            valor = 50
                    End Select
            End Select
            Dim subt = entradas * valor
            subtotal(contador) = entradas * valor
            Dim desc1, desc2 As Double
            desc1 = 0
            desc2 = 0

            If (funcion = "3" Or funcion = "4") Then
                If cine = "C" Or cine = "B" Then
                    desc1 = subt * 0.055
                End If
            ElseIf funcion = "1" Then
                If cine = "C" Or cine = "B" Then
                    desc1 = subt * 0.03
                End If
            ElseIf funcion = "2" Then
                If cine = "A" Then
                    desc1 = subt * 0.015
                End If
            End If

            descuento1(contador) = Math.Round(desc1, 2)

            Select Case subt
                Case 100 To 300
                    desc2 = subt * 0.02
                Case 301 To 500
                    desc2 = subt * 0.04
                Case 501 To 1000
                    desc2 = subt * 0.06
            End Select
            descuento2(contador) = Math.Round(desc2, 2)
            total(contador) = Math.Round(subt - desc1 - desc2, 2)
            MsgBox("Se calcularon los datos exitosamente")
            contador = contador + 1
            MostrarListas()
        Else
            MostrarListas()
            MsgBox("Los datos ya estan llenos")
        End If
    End Sub

    Sub LimpiarListas()
        Form1.lbxCine.Items.Clear()
        Form1.lbxFuncion.Items.Clear()
        Form1.lbxEntradas.Items.Clear()
        Form1.lbxSubt.Items.Clear()
        Form1.lbxDesc1.Items.Clear()
        Form1.lbxDesc2.Items.Clear()
        Form1.lbxTotal.Items.Clear()
    End Sub
    Sub MostrarListas()
        LimpiarListas()
        Dim limite As Integer

        If contador = 9 Then
            limite = 8
        Else
            limite = contador - 1
        End If
        For i As Integer = 0 To limite
            Form1.lbxCine.Items.Add(cines(i))
            Form1.lbxFuncion.Items.Add(funciones(i))
            Form1.lbxEntradas.Items.Add(cantidades(i))
            Form1.lbxSubt.Items.Add(subtotal(i))
            Form1.lbxDesc1.Items.Add(descuento1(i))
            Form1.lbxDesc2.Items.Add(descuento2(i))
            Form1.lbxTotal.Items.Add(total(i))
        Next
    End Sub
End Module
