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
        Me.funcion1 = New System.Windows.Forms.RadioButton()
        Me.funcion2 = New System.Windows.Forms.RadioButton()
        Me.funcion3 = New System.Windows.Forms.RadioButton()
        Me.funcion4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cineA = New System.Windows.Forms.RadioButton()
        Me.cineB = New System.Windows.Forms.RadioButton()
        Me.cineC = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEntradas = New System.Windows.Forms.TextBox()
        Me.limpiarL = New System.Windows.Forms.Button()
        Me.LimpiarE = New System.Windows.Forms.Button()
        Me.LimpiarV = New System.Windows.Forms.Button()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.lbxCine = New System.Windows.Forms.ListBox()
        Me.lbxFuncion = New System.Windows.Forms.ListBox()
        Me.lbxEntradas = New System.Windows.Forms.ListBox()
        Me.lbxSubt = New System.Windows.Forms.ListBox()
        Me.lbxDesc1 = New System.Windows.Forms.ListBox()
        Me.lbxDesc2 = New System.Windows.Forms.ListBox()
        Me.lbxTotal = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.funcion4)
        Me.GroupBox1.Controls.Add(Me.funcion3)
        Me.GroupBox1.Controls.Add(Me.funcion2)
        Me.GroupBox1.Controls.Add(Me.funcion1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Funcion"
        '
        'funcion1
        '
        Me.funcion1.AutoSize = True
        Me.funcion1.Location = New System.Drawing.Point(20, 34)
        Me.funcion1.Name = "funcion1"
        Me.funcion1.Size = New System.Drawing.Size(91, 21)
        Me.funcion1.TabIndex = 0
        Me.funcion1.TabStop = True
        Me.funcion1.Text = "Funcion 1"
        Me.funcion1.UseVisualStyleBackColor = True
        '
        'funcion2
        '
        Me.funcion2.AutoSize = True
        Me.funcion2.Location = New System.Drawing.Point(20, 74)
        Me.funcion2.Name = "funcion2"
        Me.funcion2.Size = New System.Drawing.Size(91, 21)
        Me.funcion2.TabIndex = 1
        Me.funcion2.TabStop = True
        Me.funcion2.Text = "Funcion 2"
        Me.funcion2.UseVisualStyleBackColor = True
        '
        'funcion3
        '
        Me.funcion3.AutoSize = True
        Me.funcion3.Location = New System.Drawing.Point(20, 115)
        Me.funcion3.Name = "funcion3"
        Me.funcion3.Size = New System.Drawing.Size(91, 21)
        Me.funcion3.TabIndex = 2
        Me.funcion3.TabStop = True
        Me.funcion3.Text = "Funcion 3"
        Me.funcion3.UseVisualStyleBackColor = True
        '
        'funcion4
        '
        Me.funcion4.AutoSize = True
        Me.funcion4.Location = New System.Drawing.Point(20, 161)
        Me.funcion4.Name = "funcion4"
        Me.funcion4.Size = New System.Drawing.Size(91, 21)
        Me.funcion4.TabIndex = 3
        Me.funcion4.TabStop = True
        Me.funcion4.Text = "Funcion 4"
        Me.funcion4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cineC)
        Me.GroupBox2.Controls.Add(Me.cineB)
        Me.GroupBox2.Controls.Add(Me.cineA)
        Me.GroupBox2.Location = New System.Drawing.Point(173, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 74)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cine"
        '
        'cineA
        '
        Me.cineA.AutoSize = True
        Me.cineA.Location = New System.Drawing.Point(18, 34)
        Me.cineA.Name = "cineA"
        Me.cineA.Size = New System.Drawing.Size(70, 21)
        Me.cineA.TabIndex = 0
        Me.cineA.TabStop = True
        Me.cineA.Text = "Cine A"
        Me.cineA.UseVisualStyleBackColor = True
        '
        'cineB
        '
        Me.cineB.AutoSize = True
        Me.cineB.Location = New System.Drawing.Point(152, 34)
        Me.cineB.Name = "cineB"
        Me.cineB.Size = New System.Drawing.Size(70, 21)
        Me.cineB.TabIndex = 1
        Me.cineB.TabStop = True
        Me.cineB.Text = "Cine B"
        Me.cineB.UseVisualStyleBackColor = True
        '
        'cineC
        '
        Me.cineC.AutoSize = True
        Me.cineC.Location = New System.Drawing.Point(294, 34)
        Me.cineC.Name = "cineC"
        Me.cineC.Size = New System.Drawing.Size(70, 21)
        Me.cineC.TabIndex = 1
        Me.cineC.TabStop = True
        Me.cineC.Text = "Cine C"
        Me.cineC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. de Entrardas"
        '
        'txtEntradas
        '
        Me.txtEntradas.Location = New System.Drawing.Point(296, 94)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.Size = New System.Drawing.Size(268, 22)
        Me.txtEntradas.TabIndex = 7
        '
        'limpiarL
        '
        Me.limpiarL.Location = New System.Drawing.Point(158, 128)
        Me.limpiarL.Name = "limpiarL"
        Me.limpiarL.Size = New System.Drawing.Size(128, 34)
        Me.limpiarL.TabIndex = 8
        Me.limpiarL.Text = "Limpiar listas"
        Me.limpiarL.UseVisualStyleBackColor = True
        '
        'LimpiarE
        '
        Me.LimpiarE.Location = New System.Drawing.Point(296, 128)
        Me.LimpiarE.Name = "LimpiarE"
        Me.LimpiarE.Size = New System.Drawing.Size(128, 34)
        Me.LimpiarE.TabIndex = 9
        Me.LimpiarE.Text = "Limpiar entradas"
        Me.LimpiarE.UseVisualStyleBackColor = True
        '
        'LimpiarV
        '
        Me.LimpiarV.Location = New System.Drawing.Point(441, 128)
        Me.LimpiarV.Name = "LimpiarV"
        Me.LimpiarV.Size = New System.Drawing.Size(123, 34)
        Me.LimpiarV.TabIndex = 10
        Me.LimpiarV.Text = "Limpiar vectores"
        Me.LimpiarV.UseVisualStyleBackColor = True
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(158, 174)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(196, 34)
        Me.aceptar.TabIndex = 11
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(376, 174)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(188, 34)
        Me.salir.TabIndex = 12
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'lbxCine
        '
        Me.lbxCine.FormattingEnabled = True
        Me.lbxCine.ItemHeight = 16
        Me.lbxCine.Location = New System.Drawing.Point(36, 241)
        Me.lbxCine.Name = "lbxCine"
        Me.lbxCine.Size = New System.Drawing.Size(53, 164)
        Me.lbxCine.TabIndex = 13
        '
        'lbxFuncion
        '
        Me.lbxFuncion.FormattingEnabled = True
        Me.lbxFuncion.ItemHeight = 16
        Me.lbxFuncion.Location = New System.Drawing.Point(95, 242)
        Me.lbxFuncion.Name = "lbxFuncion"
        Me.lbxFuncion.Size = New System.Drawing.Size(55, 164)
        Me.lbxFuncion.TabIndex = 14
        '
        'lbxEntradas
        '
        Me.lbxEntradas.FormattingEnabled = True
        Me.lbxEntradas.ItemHeight = 16
        Me.lbxEntradas.Location = New System.Drawing.Point(158, 241)
        Me.lbxEntradas.Name = "lbxEntradas"
        Me.lbxEntradas.Size = New System.Drawing.Size(79, 164)
        Me.lbxEntradas.TabIndex = 15
        '
        'lbxSubt
        '
        Me.lbxSubt.FormattingEnabled = True
        Me.lbxSubt.ItemHeight = 16
        Me.lbxSubt.Location = New System.Drawing.Point(246, 242)
        Me.lbxSubt.Name = "lbxSubt"
        Me.lbxSubt.Size = New System.Drawing.Size(79, 164)
        Me.lbxSubt.TabIndex = 16
        '
        'lbxDesc1
        '
        Me.lbxDesc1.FormattingEnabled = True
        Me.lbxDesc1.ItemHeight = 16
        Me.lbxDesc1.Location = New System.Drawing.Point(331, 241)
        Me.lbxDesc1.Name = "lbxDesc1"
        Me.lbxDesc1.Size = New System.Drawing.Size(64, 164)
        Me.lbxDesc1.TabIndex = 17
        '
        'lbxDesc2
        '
        Me.lbxDesc2.FormattingEnabled = True
        Me.lbxDesc2.ItemHeight = 16
        Me.lbxDesc2.Location = New System.Drawing.Point(401, 240)
        Me.lbxDesc2.Name = "lbxDesc2"
        Me.lbxDesc2.Size = New System.Drawing.Size(63, 164)
        Me.lbxDesc2.TabIndex = 18
        '
        'lbxTotal
        '
        Me.lbxTotal.FormattingEnabled = True
        Me.lbxTotal.ItemHeight = 16
        Me.lbxTotal.Location = New System.Drawing.Point(467, 241)
        Me.lbxTotal.Name = "lbxTotal"
        Me.lbxTotal.Size = New System.Drawing.Size(79, 164)
        Me.lbxTotal.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 419)
        Me.Controls.Add(Me.lbxTotal)
        Me.Controls.Add(Me.lbxDesc2)
        Me.Controls.Add(Me.lbxDesc1)
        Me.Controls.Add(Me.lbxSubt)
        Me.Controls.Add(Me.lbxEntradas)
        Me.Controls.Add(Me.lbxFuncion)
        Me.Controls.Add(Me.lbxCine)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.LimpiarV)
        Me.Controls.Add(Me.LimpiarE)
        Me.Controls.Add(Me.limpiarL)
        Me.Controls.Add(Me.txtEntradas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Cine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents funcion4 As RadioButton
    Friend WithEvents funcion3 As RadioButton
    Friend WithEvents funcion2 As RadioButton
    Friend WithEvents funcion1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cineB As RadioButton
    Friend WithEvents cineA As RadioButton
    Friend WithEvents cineC As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEntradas As TextBox
    Friend WithEvents limpiarL As Button
    Friend WithEvents LimpiarE As Button
    Friend WithEvents LimpiarV As Button
    Friend WithEvents aceptar As Button
    Friend WithEvents salir As Button
    Friend WithEvents lbxCine As ListBox
    Friend WithEvents lbxFuncion As ListBox
    Friend WithEvents lbxEntradas As ListBox
    Friend WithEvents lbxSubt As ListBox
    Friend WithEvents lbxDesc1 As ListBox
    Friend WithEvents lbxDesc2 As ListBox
    Friend WithEvents lbxTotal As ListBox
End Class
