Imports AccesoDatos
Imports Entidades
Imports LogicaNegocio
Public Class FrmEmpleados

    Dim NegocioEmpleado As New N_Empleados()
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtId.Value = 0
        txtNombre.Text = ""
        txtApellido.Text = ""
        ptbFoto.Image = Nothing
        txtNombre.Focus()

    End Sub

    Private Sub lklFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklFoto.LinkClicked
        ofdFoto.ShowDialog()
        If ofdFoto.FileName <> "" Then
            ptbFoto.Load(ofdFoto.FileName)
        End If

        ofdFoto.FileName = ""

    End Sub
    Private Sub LimpiarDatos()
        ' Establecer los valores predeterminados
        txtId.Value = 0
        txtNombre.Text = ""
        txtApellido.Text = ""
        ptbFoto.Image = Nothing
        txtNombre.Focus()

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim empleado As New E_Empleados()
        Dim Validacion As Boolean

        empleado.Id = txtId.Value
        empleado.Nombre = txtNombre.Text
        empleado.Apellido = txtApellido.Text
        empleado.Foto = ptbFoto.ImageLocation

        Validacion = NegocioEmpleado.ValidarDatos(empleado)

        If Validacion = False Then Exit Sub

        If empleado.Id = 0 Then
            NegocioEmpleado.Insertar(empleado)
        Else
            NegocioEmpleado.Modificar(empleado)
        End If



        LimpiarDatos()
        CargarGrid()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If txtId.Value = 0 Then Exit Sub

        Dim empleado As New E_Empleados()
        empleado.Id = txtId.Value
        NegocioEmpleado.Eliminar(empleado)
        CargarGrid()
        LimpiarDatos()
    End Sub

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Private Sub CargarGrid()
        dgvDatos.DataSource = NegocioEmpleado.Listar().Tables("empleado")

    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        txtId.Value = dgvDatos.CurrentRow.Cells("id").Value
        txtNombre.Text = dgvDatos.CurrentRow.Cells("nombre").Value
        txtApellido.Text = dgvDatos.CurrentRow.Cells("apellido").Value

        If dgvDatos.CurrentRow.Cells("foto").Value <> "" Then
            If System.IO.File.Exists(dgvDatos.CurrentRow.Cells("foto").Value) Then
                ptbFoto.Load(dgvDatos.CurrentRow.Cells("foto").Value)
            End If
        End If
    End Sub
End Class