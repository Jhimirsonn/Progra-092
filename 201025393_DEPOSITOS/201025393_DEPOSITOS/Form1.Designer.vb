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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ahorros = New System.Windows.Forms.RadioButton()
        Me.Premier = New System.Windows.Forms.RadioButton()
        Me.Monetarios = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.chkC1 = New System.Windows.Forms.CheckBox()
        Me.chkC2 = New System.Windows.Forms.CheckBox()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.txtC1 = New System.Windows.Forms.TextBox()
        Me.txtC2 = New System.Windows.Forms.TextBox()
        Me.txtC3 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ahorros)
        Me.GroupBox1.Controls.Add(Me.Premier)
        Me.GroupBox1.Controls.Add(Me.Monetarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos"
        '
        'Ahorros
        '
        Me.Ahorros.AutoSize = True
        Me.Ahorros.Location = New System.Drawing.Point(7, 75)
        Me.Ahorros.Name = "Ahorros"
        Me.Ahorros.Size = New System.Drawing.Size(79, 21)
        Me.Ahorros.TabIndex = 2
        Me.Ahorros.TabStop = True
        Me.Ahorros.Text = "Ahorros"
        Me.Ahorros.UseVisualStyleBackColor = True
        '
        'Premier
        '
        Me.Premier.AutoSize = True
        Me.Premier.Location = New System.Drawing.Point(7, 114)
        Me.Premier.Name = "Premier"
        Me.Premier.Size = New System.Drawing.Size(152, 21)
        Me.Premier.TabIndex = 1
        Me.Premier.TabStop = True
        Me.Premier.Text = "Monetarios Premier"
        Me.Premier.UseVisualStyleBackColor = True
        '
        'Monetarios
        '
        Me.Monetarios.AutoSize = True
        Me.Monetarios.Location = New System.Drawing.Point(7, 35)
        Me.Monetarios.Name = "Monetarios"
        Me.Monetarios.Size = New System.Drawing.Size(99, 21)
        Me.Monetarios.TabIndex = 0
        Me.Monetarios.TabStop = True
        Me.Monetarios.Text = "Monetarios"
        Me.Monetarios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor anterior"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(318, 6)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(276, 22)
        Me.txtValor.TabIndex = 2
        '
        'chkC1
        '
        Me.chkC1.AutoSize = True
        Me.chkC1.Location = New System.Drawing.Point(199, 47)
        Me.chkC1.Name = "chkC1"
        Me.chkC1.Size = New System.Drawing.Size(137, 21)
        Me.chkC1.TabIndex = 3
        Me.chkC1.Text = "Cheques propios"
        Me.chkC1.UseVisualStyleBackColor = True
        '
        'chkC2
        '
        Me.chkC2.AutoSize = True
        Me.chkC2.Location = New System.Drawing.Point(199, 87)
        Me.chkC2.Name = "chkC2"
        Me.chkC2.Size = New System.Drawing.Size(192, 21)
        Me.chkC2.TabIndex = 4
        Me.chkC2.Text = "Cheques de otros bancos"
        Me.chkC2.UseVisualStyleBackColor = True
        '
        'Chk3
        '
        Me.Chk3.AutoSize = True
        Me.Chk3.Location = New System.Drawing.Point(199, 127)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(87, 21)
        Me.Chk3.TabIndex = 5
        Me.Chk3.Text = "Efectivos"
        Me.Chk3.UseVisualStyleBackColor = True
        '
        'txtC1
        '
        Me.txtC1.Enabled = False
        Me.txtC1.Location = New System.Drawing.Point(448, 45)
        Me.txtC1.Name = "txtC1"
        Me.txtC1.Size = New System.Drawing.Size(146, 22)
        Me.txtC1.TabIndex = 6
        '
        'txtC2
        '
        Me.txtC2.Enabled = False
        Me.txtC2.Location = New System.Drawing.Point(448, 86)
        Me.txtC2.Name = "txtC2"
        Me.txtC2.Size = New System.Drawing.Size(146, 22)
        Me.txtC2.TabIndex = 7
        '
        'txtC3
        '
        Me.txtC3.Enabled = False
        Me.txtC3.Location = New System.Drawing.Point(448, 125)
        Me.txtC3.Name = "txtC3"
        Me.txtC3.Size = New System.Drawing.Size(146, 22)
        Me.txtC3.TabIndex = 8
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(199, 170)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(113, 27)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(336, 170)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 27)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(481, 170)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 27)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Saldo nuevo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(12, 233)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(182, 22)
        Me.txtSaldo.TabIndex = 13
        '
        'txtInteres
        '
        Me.txtInteres.Enabled = False
        Me.txtInteres.Location = New System.Drawing.Point(213, 233)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(191, 22)
        Me.txtInteres.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Intereses"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(425, 233)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(171, 22)
        Me.txtTotal.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(422, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 276)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtC3)
        Me.Controls.Add(Me.txtC2)
        Me.Controls.Add(Me.txtC1)
        Me.Controls.Add(Me.Chk3)
        Me.Controls.Add(Me.chkC2)
        Me.Controls.Add(Me.chkC1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Depositos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Ahorros As RadioButton
    Friend WithEvents Premier As RadioButton
    Friend WithEvents Monetarios As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents chkC1 As CheckBox
    Friend WithEvents chkC2 As CheckBox
    Friend WithEvents Chk3 As CheckBox
    Friend WithEvents txtC1 As TextBox
    Friend WithEvents txtC2 As TextBox
    Friend WithEvents txtC3 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
End Class
