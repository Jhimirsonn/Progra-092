Module Modulo
    Public yardas As Double
    Public valor As Double
    Public total As Double
    Public venta As Double

    Sub calcularPrecio(t1 As Double, t2 As Double, t3 As Double, t4 As Double)
        total = t1 + t2 + t3 + t4 + valor
        venta = total + total * 0.65
        MsgBox("Datos calculados exitosamente")
    End Sub

    Sub limpiar()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.TextBox5.Text = ""
        Form1.TextBox6.Text = ""
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.CheckBox4.Checked = False
        Form1.Label1.Text = "Q. "
        Form1.Label2.Text = "Q. "
        Form1.Label3.Text = "Q. "
        Form1.Label4.Text = "Q. "
        MsgBox("Se limpiaron los datos")
    End Sub

    Sub Salir()
        Dim mv = MsgBox("Esta seguro que desea salir", vbYesNo)
        If mv = vbYes Then
            Form1.Close()
        Else
            MsgBox("Se cancelo el cerrar el programa")
        End If
    End Sub
End Module
