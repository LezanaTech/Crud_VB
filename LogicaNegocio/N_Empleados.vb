Imports Entidades
Imports AccesoDatos
Public Class N_Empleados

    Dim DatosEmpleados As New D_Empleados()

    Public Function ValidarDatos(ByVal empleado As E_Empleados) As Boolean
        Dim Resultado As Boolean = True

        If empleado.Nombre = "" Then
            Resultado = False
            MessageBox.Show("El nombre es Obligatorio")
        End If

        If empleado.Apellido = "" Then
            Resultado = False
            MessageBox.Show("El apellido es Obligatorio")
        End If

        Return Resultado
    End Function

    Public Sub PruebaMysql()
        DatosEmpleados.ProbarConexion()

    End Sub

    Public Sub Insertar(ByVal empleado As E_Empleados)
        DatosEmpleados.Insertar(empleado)
    End Sub

    Public Sub Modificar(ByVal empleado As E_Empleados)
        DatosEmpleados.Modificar(empleado)
    End Sub

    Public Sub Eliminar(ByVal empleado As E_Empleados)
        If MessageBox.Show("¿Estas seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DatosEmpleados.Eliminar(empleado)
        End If

    End Sub

    Public Function Listar() As DataSet
        Return DatosEmpleados.Listar()
    End Function

End Class
