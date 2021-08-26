Module Module1
    Public tipo As Integer
    Public c1, c2, c3 As Boolean
    Public nuevoS, intereses, total As Double

    Public Sub Calcular(valor As Double, v1 As Double, v2 As Double, v3 As Double, tipo As Integer)
        Dim suma, interes As Double
        suma = v1 + v2 + v3 + valor
        If v1 + v2 + v3 > 0 Then
            interes = 0
            If tipo = 3 Then
                Select Case suma
                    Case 1 To 1001
                        interes = suma * 0.015
                    Case 1001 To 5000
                        interes = suma * 0.025
                    Case 5001 To 15000
                        interes = suma * 0.075
                    Case > 15001
                        interes = suma * 0.1
                End Select
            End If
            If tipo = 2 Then
                Select Case valor
                    Case 1 To 10000
                        interes = valor * 0.025
                    Case 10001 To 15000
                        interes = valor * 0.03
                    Case > 15001
                        interes = valor * 0.045
                End Select
            End If
            nuevoS = suma
            intereses = interes
            total = suma + intereses
            MsgBox("Se calcularon los datos exitosamente")
        Else
            MsgBox("No se pudo calcular el dato, por falta del valor del deposito/s")
            nuevoS = 0
            intereses = 0
            total = 0
        End If

    End Sub
End Module
