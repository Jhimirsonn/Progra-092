Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkC1.CheckedChanged
        If chkC1.Checked = True Then
            c1 = True
            txtC1.Enabled = True
        Else
            c1 = False
            txtC1.Enabled = False
            txtC1.Text = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkC2.CheckedChanged
        If chkC2.Checked = True Then
            c2 = True
            txtC2.Enabled = True
        Else
            c2 = False
            txtC2.Enabled = False
            txtC2.Text = 0
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Chk3.CheckedChanged
        If Chk3.Checked = True Then
            c3 = True
            txtC3.Enabled = True
        Else
            c3 = False
            txtC3.Enabled = False
            txtC3.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor As Double
        Dim v1, v2, v3 As Double
        valor = Val(txtValor.Text)
        v1 = Val(txtC1.Text)
        v2 = Val(txtC2.Text)
        v3 = Val(txtC3.Text)
        If Monetarios.Checked = True Then
            tipo = 1
        ElseIf Premier.Checked = True Then
            tipo = 2
        ElseIf Ahorros.Checked = True Then
            tipo = 3
        Else
            tipo = 0
        End If
        If tipo > 0 Then
            If valor > 0 Then
                Calcular(valor, v1, v2, v3, tipo)

                txtSaldo.Text = nuevoS
                txtInteres.Text = intereses
                txtTotal.Text = total
            Else
                MsgBox("Se debe de ingresar un valor del deposito")
            End If
        Else
            MsgBox("Debe de seleccionar un tipo de deposito")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor.Text = ""
        txtC1.Text = ""
        txtC2.Text = ""
        txtC3.Text = ""
        txtSaldo.Text = ""
        txtInteres.Text = ""
        txtTotal.Text = ""
        Monetarios.Checked = False
        Premier.Checked = False
        Ahorros.Checked = False
        chkC1.Checked = False
        chkC2.Checked = False
        Chk3.Checked = False
        MsgBox("Se limpiaron los datos")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim Pregunta = MsgBox("¿Desea salir del programa?", vbYesNo + vbQuestion, "Depositos")
        If Pregunta = vbNo Then
            MsgBox("Se cancelo la accion")
        Else
            MsgBox("¡Que tengas un buen dia!")
            Me.Close()
        End If
    End Sub
End Class
