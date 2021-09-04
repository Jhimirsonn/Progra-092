Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim nombre, nit As String
        Dim saldo, cuota As Double
        Dim servicio, tarifa As String

        nombre = txtConsumidor.Text
        nit = txtNit.Text
        saldo = Val(txtSaldo.Text)
        cuota = Val(txtConsumo.Text)
        servicio = cmbServicio.Text
        tarifa = cmbTarifa.Text
        If nombre IsNot "" And nit IsNot "" Then
            If servicio IsNot "" Then
                If tarifa IsNot "" Then
                    If cuota > 0 Then
                        Calcular(saldo, cuota, servicio, tarifa)
                        agregarDatos()
                    Else
                        MsgBox("Se debe de escribir la cuota actual para el calculo")
                    End If
                Else
                    MsgBox("Se debe de seleccionar una tarifa")
                End If
            Else
                MsgBox("Se debe de seleccionar un servicio")
            End If
        Else
            MsgBox("Los datos del clientes no pueden ir vacios")
        End If
    End Sub

    Sub agregarDatos()
        lbServicio.Items.Clear()
        lbTarifa.Items.Clear()
        lbSaldo.Items.Clear()
        lbInicial.Items.Clear()
        lbMora.Items.Clear()
        lbDesc.Items.Clear()
        lbTotal.Items.Clear()

        For i As Integer = 0 To contador - 1
            lbServicio.Items.Add(tipos(i))
            lbTarifa.Items.Add(tarifas(i))
            lbSaldo.Items.Add(saldos(i))
            lbInicial.Items.Add(pagos(i))
            lbMora.Items.Add(moras(i))
            lbDesc.Items.Add(descuentos(i))
            lbTotal.Items.Add(totales(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lbServicio.Items.Clear()
        lbTarifa.Items.Clear()
        lbSaldo.Items.Clear()
        lbInicial.Items.Clear()
        lbMora.Items.Clear()
        lbDesc.Items.Clear()
        lbTotal.Items.Clear()
        txtConsumidor.Text = ""
        txtNit.Text = ""
        txtSaldo.Text = ""
        txtConsumo.Text = ""
        cmbServicio.Text = ""
        cmbTarifa.Text = ""
        MsgBox("Se limpiaron las entradas exitosamente")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim Pregunta = MsgBox("¿Desea salir del programa?", vbYesNo + vbQuestion, "Pago de Luz")
        If Pregunta = vbNo Then
            MsgBox("Se cancelo la accion")
        Else
            MsgBox("¡Que tengas un buen dia!")
            Me.Close()
        End If
    End Sub
End Class
