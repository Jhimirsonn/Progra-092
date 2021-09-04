Module Modulo
    Public tipos(10) As String
    Public tarifas(10) As String
    Public saldos(10) As Double
    Public pagos(10) As Double
    Public moras(10) As Double
    Public descuentos(10) As Double
    Public totales(10) As Double
    Public contador As Integer = 0

    Sub Calcular(saldo As Double, cuota As Double, servicio As String, tarifa As String)
        If contador < 11 Then
            Dim inicial As Double
            inicial = Math.Round(CalcularConsumo(cuota, servicio), 2)
            Dim descuento, mora As Double
            Select Case tarifa
                Case "Social"
                    descuento = Math.Round(inicial * 0.2, 2)
                Case "No social"
                    descuento = Math.Round(inicial * 0.1, 2)
            End Select
            If saldo > 0 Then
                mora = Math.Round(saldo * 0.02, 2)
            Else
                mora = 0
            End If
            Dim total As Double
            total = inicial + saldo - descuento + mora
            tipos(contador) = servicio
            tarifas(contador) = tarifa
            saldos(contador) = saldo
            pagos(contador) = inicial
            moras(contador) = mora
            descuentos(contador) = descuento
            totales(contador) = total
            contador = contador + 1
            MsgBox("Se calcularon los datos exitosamente")
        Else
            MsgBox("Ya no se pueden ingresar mas clientes")
        End If
    End Sub

    Function CalcularConsumo(cuota As Double, servicio As String) As Double
        If servicio = "Residencial" Then
            Select Case cuota
                Case 1 To 100
                    Return 0.99 * cuota
                Case 101 To 300
                    Return 1.2 * cuota
                Case Is > 300
                    Return 3.0 * cuota
            End Select
        ElseIf servicio = "Industrial" Then
            Select Case cuota
                Case 1 To 100
                    Return 1.99 * cuota
                Case 101 To 300
                    Return 2.2 * cuota
                Case Is > 300
                    Return 4.0 * cuota
            End Select
        End If
    End Function
End Module
