<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnNuevo = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        lklFoto = New LinkLabel()
        txtId = New NumericUpDown()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        ptbFoto = New PictureBox()
        ofdFoto = New OpenFileDialog()
        dgvDatos = New DataGridView()
        CType(txtId, ComponentModel.ISupportInitialize).BeginInit()
        CType(ptbFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(20, 15)
        Label1.TabIndex = 0
        Label1.Text = "Id:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellido:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 3
        Label4.Text = "Foto:"
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(41, 355)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 4
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(153, 355)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 5
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(266, 355)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' lklFoto
        ' 
        lklFoto.AutoSize = True
        lklFoto.Location = New Point(92, 309)
        lklFoto.Name = "lklFoto"
        lklFoto.Size = New Size(67, 15)
        lklFoto.TabIndex = 7
        lklFoto.TabStop = True
        lklFoto.Text = "Seleccionar"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(92, 26)
        txtId.Name = "txtId"
        txtId.Size = New Size(56, 23)
        txtId.TabIndex = 8
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(92, 68)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(159, 23)
        txtNombre.TabIndex = 9
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(92, 112)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(159, 23)
        txtApellido.TabIndex = 10
        ' 
        ' ptbFoto
        ' 
        ptbFoto.BackColor = SystemColors.ActiveBorder
        ptbFoto.Location = New Point(92, 161)
        ptbFoto.Name = "ptbFoto"
        ptbFoto.Size = New Size(159, 145)
        ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        ptbFoto.TabIndex = 11
        ptbFoto.TabStop = False
        ' 
        ' ofdFoto
        ' 
        ofdFoto.FileName = "OpenFileDialog1"
        ' 
        ' dgvDatos
        ' 
        dgvDatos.AllowUserToAddRows = False
        dgvDatos.AllowUserToDeleteRows = False
        dgvDatos.AllowUserToOrderColumns = True
        dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDatos.Location = New Point(431, 68)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.ReadOnly = True
        dgvDatos.Size = New Size(500, 238)
        dgvDatos.TabIndex = 12
        ' 
        ' FrmEmpleados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(943, 390)
        Controls.Add(dgvDatos)
        Controls.Add(ptbFoto)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtId)
        Controls.Add(lklFoto)
        Controls.Add(btnGuardar)
        Controls.Add(btnEliminar)
        Controls.Add(btnNuevo)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "FrmEmpleados"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Empleados"
        CType(txtId, ComponentModel.ISupportInitialize).EndInit()
        CType(ptbFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lklFoto As LinkLabel
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents dgvDatos As DataGridView
End Class
