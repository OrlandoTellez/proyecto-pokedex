<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pokedex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pokedex))
        Me.Fondo = New System.Windows.Forms.PictureBox()
        Me.Derecha = New System.Windows.Forms.Button()
        Me.Izquierda = New System.Windows.Forms.Button()
        Me.Apagar = New System.Windows.Forms.Button()
        CType(Me.Fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fondo
        '
        Me.Fondo.Image = CType(resources.GetObject("Fondo.Image"), System.Drawing.Image)
        Me.Fondo.Location = New System.Drawing.Point(0, -1)
        Me.Fondo.Name = "Fondo"
        Me.Fondo.Size = New System.Drawing.Size(995, 558)
        Me.Fondo.TabIndex = 0
        Me.Fondo.TabStop = False
        '
        'Derecha
        '
        Me.Derecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Derecha.FlatAppearance.BorderSize = 0
        Me.Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Derecha.Location = New System.Drawing.Point(401, 415)
        Me.Derecha.Name = "Derecha"
        Me.Derecha.Size = New System.Drawing.Size(26, 25)
        Me.Derecha.TabIndex = 1
        Me.Derecha.UseVisualStyleBackColor = False
        '
        'Izquierda
        '
        Me.Izquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Izquierda.FlatAppearance.BorderSize = 0
        Me.Izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Izquierda.Location = New System.Drawing.Point(321, 415)
        Me.Izquierda.Name = "Izquierda"
        Me.Izquierda.Size = New System.Drawing.Size(26, 25)
        Me.Izquierda.TabIndex = 2
        Me.Izquierda.UseVisualStyleBackColor = False
        '
        'Apagar
        '
        Me.Apagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Apagar.FlatAppearance.BorderSize = 0
        Me.Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Apagar.Location = New System.Drawing.Point(49, 364)
        Me.Apagar.Name = "Apagar"
        Me.Apagar.Size = New System.Drawing.Size(36, 35)
        Me.Apagar.TabIndex = 3
        Me.Apagar.UseVisualStyleBackColor = False
        '
        'Pokedex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 557)
        Me.Controls.Add(Me.Apagar)
        Me.Controls.Add(Me.Izquierda)
        Me.Controls.Add(Me.Derecha)
        Me.Controls.Add(Me.Fondo)
        Me.Name = "Pokedex"
        Me.Text = "Pokedex"
        CType(Me.Fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Fondo As PictureBox
    Friend WithEvents Derecha As Button
    Friend WithEvents Izquierda As Button
    Friend WithEvents Apagar As Button
End Class
