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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellidos"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(84, 22)
        txtRut.Margin = New Padding(3, 2, 3, 2)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(168, 23)
        txtRut.TabIndex = 3
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(87, 56)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(165, 23)
        txtNombre.TabIndex = 4
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(88, 89)
        txtApellido.Margin = New Padding(3, 2, 3, 2)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(163, 23)
        txtApellido.TabIndex = 5
        ' 
        ' rbMasculino
        ' 
        rbMasculino.AutoSize = True
        rbMasculino.Location = New Point(27, 148)
        rbMasculino.Margin = New Padding(3, 2, 3, 2)
        rbMasculino.Name = "rbMasculino"
        rbMasculino.Size = New Size(80, 19)
        rbMasculino.TabIndex = 6
        rbMasculino.TabStop = True
        rbMasculino.Text = "Masculino"
        rbMasculino.UseVisualStyleBackColor = True
        ' 
        ' rbFemenino
        ' 
        rbFemenino.AutoSize = True
        rbFemenino.Location = New Point(160, 149)
        rbFemenino.Margin = New Padding(3, 2, 3, 2)
        rbFemenino.Name = "rbFemenino"
        rbFemenino.Size = New Size(78, 19)
        rbFemenino.TabIndex = 7
        rbFemenino.TabStop = True
        rbFemenino.Text = "Femenino"
        rbFemenino.UseVisualStyleBackColor = True
        ' 
        ' NoEspecifica
        ' 
        NoEspecifica.AutoSize = True
        NoEspecifica.Location = New Point(311, 149)
        NoEspecifica.Margin = New Padding(3, 2, 3, 2)
        NoEspecifica.Name = "NoEspecifica"
        NoEspecifica.Size = New Size(96, 19)
        NoEspecifica.TabIndex = 8
        NoEspecifica.TabStop = True
        NoEspecifica.Text = "No Especifica"
        NoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' cbComuna
        ' 
        cbComuna.FormattingEnabled = True
        cbComuna.Location = New Point(31, 195)
        cbComuna.Margin = New Padding(3, 2, 3, 2)
        cbComuna.Name = "cbComuna"
        cbComuna.Size = New Size(133, 23)
        cbComuna.TabIndex = 9
        cbComuna.Text = "Comuna"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(311, 23)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(82, 22)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(172, 251)
        txtCiudad.Margin = New Padding(3, 2, 3, 2)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(110, 23)
        txtCiudad.TabIndex = 11
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(172, 290)
        txtObservacion.Margin = New Padding(3, 2, 3, 2)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(110, 23)
        txtObservacion.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 13
        Label4.Text = "Ciudad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 14
        Label5.Text = "Observacion"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(311, 292)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 15
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(89, 1)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 16
        Label6.Text = "Ej.136700367"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(431, 338)
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
        Margin = New Padding(3, 2, 3, 2)
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

End Class
