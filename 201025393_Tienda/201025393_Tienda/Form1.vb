Imports System.Math
Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GroupBox2.Visible = False

        cantidaddearroz.Clear()
        cantidaddefrijol.Clear()
        cantidaddeazucar.Clear()
        cantidaddecafe.Clear()
        txtsiniva.Clear()
        txtiva.Clear()
        txtconiva.Clear()
        txtdescuento.Clear()
        txtpagototal.Clear()

        cantidaddearroz.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim arroz As Double
        Dim frijol As Double
        Dim azucar As Double
        Dim cafe As Double
        Dim pagosiniva As Double
        Dim iva As Double
        Dim pagoconiva As Double
        Dim descuento As Double
        Dim totalpago As Double

        Const a = 2
        Const b = 1.75
        Const c = 2.5
        Const d = 0.12
        Const f = 1.25
        Const g = 0.025

        arroz = Val(cantidaddearroz.Text)
        frijol = Val(cantidaddefrijol.Text)
        azucar = Val(cantidaddeazucar.Text)
        cafe = Val(cantidaddecafe.Text)

        pagosiniva = (arroz * a) + (frijol * b) + (azucar * c) + (cafe * f)
        iva = pagosiniva * d
        pagoconiva = (pagosiniva * d) + pagosiniva
        descuento = pagoconiva * g
        totalpago = pagoconiva - descuento

        GroupBox2.Visible = True

        txtsiniva.Text = Str(Round(pagosiniva, 2))
        txtiva.Text = Str(Round(iva, 2))
        txtconiva.Text = Str(Round(pagoconiva, 2))
        txtdescuento.Text = Str(Round(descuento, 2))
        txtpagototal.Text = Str(Round(totalpago, 2))

    End Sub
End Class
