<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGenero))
        Me.imgProfesor = New System.Windows.Forms.PictureBox()
        Me.imgChico = New System.Windows.Forms.PictureBox()
        Me.imgChica = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDialogo = New System.Windows.Forms.Label()
        Me.lblChico = New System.Windows.Forms.Label()
        Me.lblChica = New System.Windows.Forms.Label()
        CType(Me.imgProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgChico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgChica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgProfesor
        '
        Me.imgProfesor.Image = CType(resources.GetObject("imgProfesor.Image"), System.Drawing.Image)
        Me.imgProfesor.Location = New System.Drawing.Point(-2, -2)
        Me.imgProfesor.Name = "imgProfesor"
        Me.imgProfesor.Size = New System.Drawing.Size(375, 487)
        Me.imgProfesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgProfesor.TabIndex = 1
        Me.imgProfesor.TabStop = False
        '
        'imgChico
        '
        Me.imgChico.Image = CType(resources.GetObject("imgChico.Image"), System.Drawing.Image)
        Me.imgChico.Location = New System.Drawing.Point(50, -2)
        Me.imgChico.Name = "imgChico"
        Me.imgChico.Size = New System.Drawing.Size(298, 440)
        Me.imgChico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgChico.TabIndex = 3
        Me.imgChico.TabStop = False
        '
        'imgChica
        '
        Me.imgChica.Image = CType(resources.GetObject("imgChica.Image"), System.Drawing.Image)
        Me.imgChica.Location = New System.Drawing.Point(452, -2)
        Me.imgChica.Name = "imgChica"
        Me.imgChica.Size = New System.Drawing.Size(307, 392)
        Me.imgChica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgChica.TabIndex = 5
        Me.imgChica.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblDialogo)
        Me.Panel1.Location = New System.Drawing.Point(12, 335)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 103)
        Me.Panel1.TabIndex = 6
        '
        'lblDialogo
        '
        Me.lblDialogo.AutoSize = True
        Me.lblDialogo.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDialogo.Location = New System.Drawing.Point(34, 41)
        Me.lblDialogo.Name = "lblDialogo"
        Me.lblDialogo.Size = New System.Drawing.Size(83, 23)
        Me.lblDialogo.TabIndex = 1
        Me.lblDialogo.Text = "Dialogo..."
        '
        'lblChico
        '
        Me.lblChico.AutoSize = True
        Me.lblChico.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblChico.Location = New System.Drawing.Point(185, 25)
        Me.lblChico.Name = "lblChico"
        Me.lblChico.Size = New System.Drawing.Size(55, 23)
        Me.lblChico.TabIndex = 2
        Me.lblChico.Text = "Chico"
        '
        'lblChica
        '
        Me.lblChica.AutoSize = True
        Me.lblChica.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChica.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblChica.Location = New System.Drawing.Point(579, 25)
        Me.lblChica.Name = "lblChica"
        Me.lblChica.Size = New System.Drawing.Size(55, 23)
        Me.lblChica.TabIndex = 7
        Me.lblChica.Text = "Chica"
        '
        'FormGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblChica)
        Me.Controls.Add(Me.lblChico)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imgChica)
        Me.Controls.Add(Me.imgChico)
        Me.Controls.Add(Me.imgProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGenero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGenero"
        CType(Me.imgProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgChico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgChica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgProfesor As PictureBox
    Friend WithEvents imgChico As PictureBox
    Friend WithEvents imgChica As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDialogo As Label
    Friend WithEvents lblChico As Label
    Friend WithEvents lblChica As Label
End Class
