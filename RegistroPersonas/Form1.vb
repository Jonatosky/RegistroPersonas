Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=; database=registropersonas;")

    ' Cargar comunas en el ComboBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.Open()
            Dim query As String = "SELECT NombreComuna FROM comuna ORDER BY NombreComuna"
            Dim cmd As New MySqlCommand(query, conexion)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cbComuna.Items.Add(reader("NombreComuna").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error al cargar comunas: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sexo As String = ""
        If rbMasculino.Checked Then
            sexo = "Masculino"
        ElseIf rbFemenino.Checked Then
            sexo = "Femenino"
        Else
            sexo = "No especif"
        End If

        Try
            conexion.Open()
            Dim query As String = "INSERT INTO personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                  "VALUES (@RUT, @Nombre, @Apellido, @Sexo, @Comuna, @Ciudad, @Observacion)"
            Dim cmd As New MySqlCommand(query, conexion)

            cmd.Parameters.AddWithValue("@RUT", txtRut.Text)
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@Sexo", sexo)
            cmd.Parameters.AddWithValue("@Comuna", cbComuna.Text)
            cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text)
            cmd.Parameters.AddWithValue("@Observacion", txtObservacion.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro guardado correctamente en MySQL")
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
