Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connectionString As String = "server=localhost;database=registropersonas;user=root;password=;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComunas()
    End Sub

    ' === Cargar comunas desde la tabla comuna ===
    Private Sub CargarComunas()
        cbComuna.Items.Clear()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT NombreComuna FROM comuna ORDER BY NombreComuna ASC"
            Dim cmd As New MySqlCommand(query, conn)
            Try
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cbComuna.Items.Add(reader("NombreComuna").ToString())
                End While
            Catch ex As Exception
                MessageBox.Show("Error al cargar comunas: " & ex.Message)
            End Try
        End Using
    End Sub

    ' === Botón Guardar ===
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarCampos() Then Exit Sub

        Dim sexo As String = If(rbMasculino.Checked, "Masculino",
                          If(rbFemenino.Checked, "Femenino", "No especifica"))

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                  "VALUES (@RUT, @Nombre, @Apellido, @Sexo, @Comuna, @Ciudad, @Observacion)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RUT", txtRut.Text.Trim())
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
            cmd.Parameters.AddWithValue("@Sexo", sexo)
            cmd.Parameters.AddWithValue("@Comuna", cbComuna.Text)
            cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text.Trim())
            cmd.Parameters.AddWithValue("@Observacion", txtObservacion.Text.Trim())

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro guardado exitosamente.")
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error al guardar: " & ex.Message)
            End Try
        End Using
    End Sub

    ' === Botón Buscar ===
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtRut.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar un RUT.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM personas WHERE RUT = @RUT"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RUT", txtRut.Text.Trim())

            Try
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    txtNombre.Text = reader("Nombre").ToString()
                    txtApellido.Text = reader("Apellido").ToString()
                    txtCiudad.Text = reader("Ciudad").ToString()
                    txtObservacion.Text = reader("Observacion").ToString()

                    Dim sexo As String = reader("Sexo").ToString()
                    rbMasculino.Checked = (sexo = "Masculino")
                    rbFemenino.Checked = (sexo = "Femenino")
                    NoEspecifica.Checked = (sexo = "No especifica")

                    cbComuna.Text = reader("Comuna").ToString()

                    ' Bloquear los campos al encontrar un registro
                    BloquearCampos(True)
                    MessageBox.Show("Registro encontrado. Puede modificarlo o eliminarlo.")

                Else
                    MessageBox.Show("RUT no encontrado. Complete los datos para registrarlo.")
                    LimpiarFormulario(False)
                    BloquearCampos(False)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al buscar: " & ex.Message)
            End Try
        End Using
    End Sub

    ' === Botón Modificar ===
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Si los campos están bloqueados, desbloquear para editar
        If txtNombre.ReadOnly = True Then
            BloquearCampos(False)
            MessageBox.Show("Campos desbloqueados. Realice los cambios y presione nuevamente 'Modificar' para guardar.")
            Exit Sub
        End If

        ' Validar campos antes de actualizar
        If Not ValidarCampos() Then Exit Sub

        Dim sexo As String = If(rbMasculino.Checked, "Masculino",
                          If(rbFemenino.Checked, "Femenino", "No especifica"))

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE personas SET Nombre=@Nombre, Apellido=@Apellido, Sexo=@Sexo, Comuna=@Comuna, Ciudad=@Ciudad, Observacion=@Observacion WHERE RUT=@RUT"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RUT", txtRut.Text.Trim())
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
            cmd.Parameters.AddWithValue("@Sexo", sexo)
            cmd.Parameters.AddWithValue("@Comuna", cbComuna.Text)
            cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text.Trim())
            cmd.Parameters.AddWithValue("@Observacion", txtObservacion.Text.Trim())

            Try
                conn.Open()
                Dim filas As Integer = cmd.ExecuteNonQuery()
                If filas > 0 Then
                    MessageBox.Show("Registro modificado correctamente.")
                    BloquearCampos(True)
                Else
                    MessageBox.Show("No se encontró el registro para modificar.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al modificar: " & ex.Message)
            End Try
        End Using
    End Sub

    ' === Botón Eliminar ===
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtRut.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar un RUT para eliminar.")
            Exit Sub
        End If

        Dim respuesta = MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar eliminación",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = DialogResult.No Then Exit Sub

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "DELETE FROM personas WHERE RUT = @RUT"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RUT", txtRut.Text.Trim())

            Try
                conn.Open()
                Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                If filasAfectadas > 0 Then
                    MessageBox.Show("Registro eliminado correctamente.")
                    LimpiarFormulario()
                    BloquearCampos(False)
                Else
                    MessageBox.Show("No se encontró el registro para eliminar.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message)
            End Try
        End Using
    End Sub

    ' === Validar campos ===
    Private Function ValidarCampos() As Boolean
        If txtRut.Text.Trim() = "" OrElse
           txtNombre.Text.Trim() = "" OrElse
           txtApellido.Text.Trim() = "" OrElse
           txtCiudad.Text.Trim() = "" OrElse
           cbComuna.Text = "" Then
            MessageBox.Show("Debe completar todos los campos obligatorios.")
            Return False
        End If
        Return True
    End Function

    ' === Limpiar formulario ===
    Private Sub LimpiarFormulario(Optional limpiarRut As Boolean = True)
        If limpiarRut Then txtRut.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        rbMasculino.Checked = False
        rbFemenino.Checked = False
        NoEspecifica.Checked = False
        cbComuna.Text = ""
        txtRut.Focus()
    End Sub

    ' === Bloquear o desbloquear campos ===
    Private Sub BloquearCampos(bloquear As Boolean)
        txtNombre.ReadOnly = bloquear
        txtApellido.ReadOnly = bloquear
        txtCiudad.ReadOnly = bloquear
        txtObservacion.ReadOnly = bloquear
        cbComuna.Enabled = Not bloquear
        rbMasculino.Enabled = Not bloquear
        rbFemenino.Enabled = Not bloquear
        NoEspecifica.Enabled = Not bloquear
    End Sub

    Private Sub NoEspecifica_CheckedChanged(sender As Object, e As EventArgs) Handles NoEspecifica.CheckedChanged
        ' Evento vacío
    End Sub

End Class
