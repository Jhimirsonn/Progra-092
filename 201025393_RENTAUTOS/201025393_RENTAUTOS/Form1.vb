Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim placa, marca As String
        Dim dias As Integer
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            porcentaje1 = Val(TextBox4.Text)
            porcentaje2 = Val(TextBox5.Text)
        ElseIf CheckBox1.Checked = True Then
            porcentaje1 = 100
            TextBox4.Text = 100
        ElseIf CheckBox2.Checked = True Then
            porcentaje2 = 100
            TextBox5.Text = 100
        End If
        placa = TextBox2.Text
        marca = ComboBox1.Text
        dias = Val(TextBox3.Text)
        Calcular(placa, marca, dias, porcentaje1, porcentaje2)
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LimpiarListas()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        MsgBox("Se limpiaron las entradas")
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiarListas()
        ReDim placas(5), marcas(5), dias(5), pagos(5), descuentos(5), recargos(5), totales(5)
        c = 0
        MsgBox("Se limpiaron los vectores")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox4.Text = Nothing
            porcentaje1 = 0
        Else
            TextBox4.Text = 100
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            TextBox5.Text = Nothing
            porcentaje2 = 0
        Else
            TextBox5.Text = 100
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Pregunta = MsgBox("¿Desea salir del programa?", vbYesNo + vbQuestion, "RENTAUTOS")
        If Pregunta = vbNo Then
            MsgBox("Se cancelo la accion")
        Else
            MsgBox("¡Que tengas un buen dia!")
            Me.Close()
        End If
    End Sub
End Class
