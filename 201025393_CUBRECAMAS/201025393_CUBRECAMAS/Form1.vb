Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            yardas = 3
            valor = 65.5
        Else
            yardas = 0
            valor = 0
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            yardas = 5
            valor = 85.99
        Else
            yardas = 0
            valor = 0
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            yardas = 6
            valor = 99.99
        Else
            yardas = 0
            valor = 0
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            yardas = 7
            valor = 105.99
        Else
            yardas = 0
            valor = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y1, y2, y3, y4 As Double
        Dim v1, v2, v3, v4 As Double
        If CheckBox1.Checked = True Then
            y1 = Val(TextBox1.Text)
            v1 = y1 * 15
        Else
            y1 = 0
            v1 = 0
            TextBox1.Text = 0
        End If
        If CheckBox2.Checked = True Then
            y2 = Val(TextBox2.Text)
            v2 = y2 * 23.99
        Else
            y2 = 0
            v2 = 0
            TextBox2.Text = 0
        End If

        If CheckBox3.Checked = True Then
            y3 = Val(TextBox3.Text)
            v3 = y3 * 30.99
        Else
            y3 = 0
            v3 = 0
            TextBox3.Text = 0
        End If
        If CheckBox4.Checked = True Then
            y4 = Val(TextBox4.Text)
            v4 = y4 * 39.99
        Else
            y4 = 0
            v4 = 0
            TextBox4.Text = 0
        End If
        Dim suma As Double
        suma = y1 + y2 + y3 + y4
        If suma = yardas Then
            If valor > 0 Then
                calcularPrecio(v1, v2, v3, v4)
                Label1.Text = "Q. " & v1
                Label2.Text = "Q. " & v2
                Label3.Text = "Q. " & v3
                Label4.Text = "Q. " & v4

                TextBox5.Text = total
                TextBox6.Text = venta
            Else
                MsgBox("Debe de seleccionar un tipo de cama")
            End If
        Else
            MsgBox("La suma del material no coincide, debe de ser: " & yardas)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Salir()
    End Sub
End Class
