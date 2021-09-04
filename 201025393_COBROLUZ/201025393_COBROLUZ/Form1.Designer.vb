<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConsumidor = New System.Windows.Forms.TextBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConsumo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.cmbTarifa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lbServicio = New System.Windows.Forms.ListBox()
        Me.lbTarifa = New System.Windows.Forms.ListBox()
        Me.lbSaldo = New System.Windows.Forms.ListBox()
        Me.lbInicial = New System.Windows.Forms.ListBox()
        Me.lbMora = New System.Windows.Forms.ListBox()
        Me.lbDesc = New System.Windows.Forms.ListBox()
        Me.lbTotal = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consumidor"
        '
        'txtConsumidor
        '
        Me.txtConsumidor.Location = New System.Drawing.Point(103, 13)
        Me.txtConsumidor.Name = "txtConsumidor"
        Me.txtConsumidor.Size = New System.Drawing.Size(180, 22)
        Me.txtConsumidor.TabIndex = 1
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(428, 13)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(143, 22)
        Me.txtNit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(117, 44)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(166, 22)
        Me.txtSaldo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo anterior"
        '
        'txtConsumo
        '
        Me.txtConsumo.Location = New System.Drawing.Point(428, 44)
        Me.txtConsumo.Name = "txtConsumo"
        Me.txtConsumo.Size = New System.Drawing.Size(143, 22)
        Me.txtConsumo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Consumo del mes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de Servicio"
        '
        'cmbServicio
        '
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Items.AddRange(New Object() {"Residencial", "Industrial"})
        Me.cmbServicio.Location = New System.Drawing.Point(140, 79)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(143, 24)
        Me.cmbServicio.TabIndex = 9
        '
        'cmbTarifa
        '
        Me.cmbTarifa.FormattingEnabled = True
        Me.cmbTarifa.Items.AddRange(New Object() {"Social", "No social"})
        Me.cmbTarifa.Location = New System.Drawing.Point(428, 79)
        Me.cmbTarifa.Name = "cmbTarifa"
        Me.cmbTarifa.Size = New System.Drawing.Size(143, 24)
        Me.cmbTarifa.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo de Tarifa"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(17, 122)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(167, 31)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "Calcular pago"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(211, 122)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(167, 31)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar entradas"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(404, 122)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(167, 31)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lbServicio
        '
        Me.lbServicio.FormattingEnabled = True
        Me.lbServicio.ItemHeight = 16
        Me.lbServicio.Location = New System.Drawing.Point(17, 184)
        Me.lbServicio.Name = "lbServicio"
        Me.lbServicio.Size = New System.Drawing.Size(80, 180)
        Me.lbServicio.TabIndex = 15
        '
        'lbTarifa
        '
        Me.lbTarifa.FormattingEnabled = True
        Me.lbTarifa.ItemHeight = 16
        Me.lbTarifa.Location = New System.Drawing.Point(103, 184)
        Me.lbTarifa.Name = "lbTarifa"
        Me.lbTarifa.Size = New System.Drawing.Size(82, 180)
        Me.lbTarifa.TabIndex = 16
        '
        'lbSaldo
        '
        Me.lbSaldo.FormattingEnabled = True
        Me.lbSaldo.ItemHeight = 16
        Me.lbSaldo.Location = New System.Drawing.Point(191, 184)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(61, 180)
        Me.lbSaldo.TabIndex = 17
        '
        'lbInicial
        '
        Me.lbInicial.FormattingEnabled = True
        Me.lbInicial.ItemHeight = 16
        Me.lbInicial.Location = New System.Drawing.Point(258, 184)
        Me.lbInicial.Name = "lbInicial"
        Me.lbInicial.Size = New System.Drawing.Size(97, 180)
        Me.lbInicial.TabIndex = 18
        '
        'lbMora
        '
        Me.lbMora.FormattingEnabled = True
        Me.lbMora.ItemHeight = 16
        Me.lbMora.Location = New System.Drawing.Point(361, 184)
        Me.lbMora.Name = "lbMora"
        Me.lbMora.Size = New System.Drawing.Size(50, 180)
        Me.lbMora.TabIndex = 19
        '
        'lbDesc
        '
        Me.lbDesc.FormattingEnabled = True
        Me.lbDesc.ItemHeight = 16
        Me.lbDesc.Location = New System.Drawing.Point(417, 184)
        Me.lbDesc.Name = "lbDesc"
        Me.lbDesc.Size = New System.Drawing.Size(56, 180)
        Me.lbDesc.TabIndex = 20
        '
        'lbTotal
        '
        Me.lbTotal.FormattingEnabled = True
        Me.lbTotal.ItemHeight = 16
        Me.lbTotal.Location = New System.Drawing.Point(486, 184)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(79, 180)
        Me.lbTotal.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Servicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tarifa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(188, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Saldo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Pago inicial"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(361, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Mora"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(414, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Desc"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(483, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 17)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Pago total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 376)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lbDesc)
        Me.Controls.Add(Me.lbMora)
        Me.Controls.Add(Me.lbInicial)
        Me.Controls.Add(Me.lbSaldo)
        Me.Controls.Add(Me.lbTarifa)
        Me.Controls.Add(Me.lbServicio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.cmbTarifa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbServicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConsumo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConsumidor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pago de Luz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtConsumidor As TextBox
    Friend WithEvents txtNit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConsumo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbServicio As ComboBox
    Friend WithEvents cmbTarifa As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lbServicio As ListBox
    Friend WithEvents lbTarifa As ListBox
    Friend WithEvents lbSaldo As ListBox
    Friend WithEvents lbInicial As ListBox
    Friend WithEvents lbMora As ListBox
    Friend WithEvents lbDesc As ListBox
    Friend WithEvents lbTotal As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
