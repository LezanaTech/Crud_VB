Imports MySql.Data.MySqlClient
Imports Entidades
Public Class D_Empleados


    Private _cadenaConexion As String = "Server=127.0.0.1;User=root;Password=;Port=3306;database=crudvb"

    Public Sub ProbarConexion()


        Dim Conexion As New MySqlConnection(_cadenaConexion)


        Try
            Conexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show("Conectado")
        Conexion.Close()

    End Sub

    Public Sub Insertar(ByVal empleado As E_Empleados)
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "INSERT INTO empleados (
                                                        nombre, 
                                                        apellido, 
                                                        foto) 
                                VALUES ('" & empleado.Nombre & " ',
                                '" & empleado.Apellido & "',
                                '" & MySql.Data.MySqlClient.MySqlHelper.EscapeString(empleado.Foto) & "');"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()

        MessageBox.Show("Registro Creado")

    End Sub

    Public Sub Modificar(ByVal empleado As E_Empleados)
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "UPDATE empleados SET nombre='" & empleado.Nombre & "', apellido='" & empleado.Apellido & "', foto='" & MySql.Data.MySqlClient.MySqlHelper.EscapeString(empleado.Foto) & "'  WHERE  id= " & empleado.Id & ";"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()

        MessageBox.Show("Registro Modificado")

    End Sub

    Public Sub Eliminar(ByVal empleado As E_Empleados)
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "DELETE FROM empleados WHERE  id= " & empleado.Id & ";"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()

        MessageBox.Show("Registro Eliminado")

    End Sub


    Public Function Listar() As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "SELECT * FROM empleados ORDER BY id LIMIT 1000;"
        Dim Adaptador As MySqlDataAdapter
        Dim dataset As New DataSet

        Adaptador = New MySqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataset, "empleado")

        Return dataset

    End Function



End Class
