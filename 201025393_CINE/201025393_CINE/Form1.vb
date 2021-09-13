Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles funcion1.CheckedChanged
        If funcion1.Checked = True Then
            funcion = "1"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles funcion2.CheckedChanged
        If funcion2.Checked = True Then
            funcion = "2"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles funcion3.CheckedChanged
        If funcion3.Checked = True Then
            funcion = "3"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles funcion4.CheckedChanged
        If funcion4.Checked = True Then
            funcion = "4"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles cineA.CheckedChanged
        If cineA.Checked = True Then
            cine = "A"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles cineB.CheckedChanged
        If cineB.Checked = True Then
            cine = "B"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles cineC.CheckedChanged
        If cineC.Checked = True Then
            cine = "C"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        entradas = Val(txtEntradas.Text)
        If cine IsNot "" Then
            If funcion IsNot "" Then
                If entradas > 0 Then
                    Calcular()
                Else
                    MsgBox("El número de entradas no es valido")
                End If
            Else
                MsgBox("Se debe de seleccionar una funcion")
            End If
        Else
            MsgBox("Se debe de seleccionar un cine")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles limpiarL.Click
        LimpiarListas()
        MsgBox("Se limpiaron las listas")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LimpiarE.Click
        funcion1.Checked = False
        funcion2.Checked = False
        funcion3.Checked = False
        funcion4.Checked = False
        cineA.Checked = False
        cineB.Checked = False
        cineC.Checked = False
        txtEntradas.Text = ""
        MsgBox("Se limpiaron las entradas")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles LimpiarV.Click
        ReDim funciones(8)
        ReDim cines(8)
        ReDim cantidades(8)
        ReDim subtotal(8)
        ReDim descuento1(8)
        ReDim descuento2(8)
        ReDim total(8)
        contador = 0
        MsgBox("Se limpiaron los vectores")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles salir.Click
        Dim Pregunta = MsgBox("¿Desea salir del programa?", vbYesNo + vbQuestion, "Cine")
        If Pregunta = vbNo Then
            MsgBox("Se cancelo la accion")
        Else
            MsgBox("¡Que tengas un buen dia!")
            Me.Close()
        End If
    End Sub
End Class
