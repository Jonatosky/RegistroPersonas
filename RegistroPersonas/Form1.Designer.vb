<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtRut = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        rbMasculino = New RadioButton()
        rbFemenino = New RadioButton()
        NoEspecifica = New RadioButton()
        cbComuna = New ComboBox()
        btnGuardar = New Button()
        txtCiudad = New TextBox()
        txtObservacion = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnBuscar = New Button()
        Label6 = New Label()
        btnEliminar = New Button()
        btnModificar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 18)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 18)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 18)
        Label3.TabIndex = 2
        Label3.Text = "Apellidos"
        ' 
        ' txtRut
        ' 
        txtRut.BackColor = SystemColors.InactiveCaption
        txtRut.ForeColor = SystemColors.MenuHighlight
        txtRut.Location = New Point(99, 24)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(191, 26)
        txtRut.TabIndex = 3
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = SystemColors.InactiveCaption
        txtNombre.ForeColor = SystemColors.MenuHighlight
        txtNombre.Location = New Point(99, 68)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(188, 26)
        txtNombre.TabIndex = 4
        ' 
        ' txtApellido
        ' 
        txtApellido.BackColor = SystemColors.InactiveCaption
        txtApellido.ForeColor = SystemColors.HotTrack
        txtApellido.Location = New Point(101, 107)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(186, 26)
        txtApellido.TabIndex = 5
        ' 
        ' rbMasculino
        ' 
        rbMasculino.AutoSize = True
        rbMasculino.Location = New Point(9, 179)
        rbMasculino.Name = "rbMasculino"
        rbMasculino.Size = New Size(91, 22)
        rbMasculino.TabIndex = 6
        rbMasculino.TabStop = True
        rbMasculino.Text = "Masculino"
        rbMasculino.UseVisualStyleBackColor = True
        ' 
        ' rbFemenino
        ' 
        rbFemenino.AutoSize = True
        rbFemenino.Location = New Point(107, 179)
        rbFemenino.Name = "rbFemenino"
        rbFemenino.Size = New Size(92, 22)
        rbFemenino.TabIndex = 7
        rbFemenino.TabStop = True
        rbFemenino.Text = "Femenino"
        rbFemenino.UseVisualStyleBackColor = True
        ' 
        ' NoEspecifica
        ' 
        NoEspecifica.AutoSize = True
        NoEspecifica.Location = New Point(197, 179)
        NoEspecifica.Name = "NoEspecifica"
        NoEspecifica.Size = New Size(114, 22)
        NoEspecifica.TabIndex = 8
        NoEspecifica.TabStop = True
        NoEspecifica.Text = "No Especifica"
        NoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' cbComuna
        ' 
        cbComuna.BackColor = SystemColors.InactiveCaption
        cbComuna.ForeColor = SystemColors.InfoText
        cbComuna.FormattingEnabled = True
        cbComuna.Location = New Point(35, 234)
        cbComuna.Name = "cbComuna"
        cbComuna.Size = New Size(151, 26)
        cbComuna.TabIndex = 9
        cbComuna.Text = "Comuna"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = SystemColors.ActiveCaption
        btnGuardar.Location = New Point(387, 24)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 26)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' txtCiudad
        ' 
        txtCiudad.BackColor = SystemColors.InactiveCaption
        txtCiudad.ForeColor = SystemColors.HotTrack
        txtCiudad.Location = New Point(197, 302)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(125, 26)
        txtCiudad.TabIndex = 11
        ' 
        ' txtObservacion
        ' 
        txtObservacion.BackColor = SystemColors.InactiveCaption
        txtObservacion.ForeColor = SystemColors.MenuHighlight
        txtObservacion.Location = New Point(197, 348)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(125, 26)
        txtObservacion.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 18)
        Label4.TabIndex = 13
        Label4.Text = "Ciudad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(49, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 18)
        Label5.TabIndex = 14
        Label5.Text = "Observacion"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.ActiveCaption
        btnBuscar.Location = New Point(387, 140)
        btnBuscar.Margin = New Padding(3, 4, 3, 4)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 28)
        btnBuscar.TabIndex = 15
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(102, 1)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 18)
        Label6.TabIndex = 16
        Label6.Text = "Ej.136700367"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.ActiveCaption
        btnEliminar.Location = New Point(387, 68)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 26)
        btnEliminar.TabIndex = 17
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = SystemColors.ActiveCaption
        btnModificar.Location = New Point(387, 107)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(94, 26)
        btnModificar.TabIndex = 18
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(493, 406)
        Controls.Add(btnModificar)
        Controls.Add(btnEliminar)
        Controls.Add(Label6)
        Controls.Add(btnBuscar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtObservacion)
        Controls.Add(txtCiudad)
        Controls.Add(btnGuardar)
        Controls.Add(cbComuna)
        Controls.Add(NoEspecifica)
        Controls.Add(rbFemenino)
        Controls.Add(rbMasculino)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtRut)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Eva2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents NoEspecifica As RadioButton
    Friend WithEvents cbComuna As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button

End Class
