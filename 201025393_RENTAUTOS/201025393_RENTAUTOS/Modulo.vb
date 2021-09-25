Module Modulo
    Public porcentaje1, porcentaje2 As Double
    Public placas(5) As String
    Public marcas(5) As String
    Public dias(5) As Integer
    Public pagos(5) As Integer
    Public descuentos(5) As Double
    Public recargos(5) As Double
    Public totales(5) As Double
    Public c As Integer = 0

    Public Sub Calcular(placa As String, marca As String, dia As Integer, porcentaje1 As Double, porcentaje2 As Double)
        If c < 6 Then
            Dim tot = porcentaje1 + porcentaje2
            If tot = 100 Then
                placas(c) = placa
                marcas(c) = marca
                dias(c) = dia
                Select Case marca
                    Case "Honda"
                        pagos(c) = dia * 250
                    Case "Mercedes Benz"
                        pagos(c) = dia * 450
                    Case "Toyota"
                        pagos(c) = dia * 325
                    Case "Mazda"
                        pagos(c) = dia * 300
                End Select

                If porcentaje1 = 100 Then
                    descuentos(c) = Math.Round(pagos(c) * 0.05, 2)
                Else
                    descuentos(c) = 0
                End If

                If porcentaje2 = 100 Then
                    recargos(c) = Math.Round(pagos(c) * 0.025, 2)
                Else
                    recargos(c) = 0
                End If
                totales(c) = pagos(c) - descuentos(c) + recargos(c)
                MsgBox("Se guardo el dato exitosamente")
                c = c + 1
            Else
                MsgBox("El porcentaje no es valido")
            End If
        Else
            MsgBox("Las listas estan llenas")
        End If
        mostrarListas()
    End Sub

    Sub LimpiarListas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
    End Sub

    Sub mostrarListas()
        LimpiarListas()
        For i As Integer = 0 To 5
            If placas(i) <> Nothing Then
                Form1.ListBox1.Items.Add(placas(i))
                Form1.ListBox2.Items.Add(marcas(i))
                Form1.ListBox3.Items.Add(dias(i))
                Form1.ListBox4.Items.Add(pagos(i))
                Form1.ListBox5.Items.Add(descuentos(i))
                Form1.ListBox6.Items.Add(recargos(i))
                Form1.ListBox7.Items.Add(totales(i))
            End If
        Next
    End Sub
End Module
