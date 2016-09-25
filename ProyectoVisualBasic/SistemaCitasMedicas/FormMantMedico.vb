Imports BackEnd

Public Class FormMantMedico
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim gestionarMedicoServicio As GestionarMedicoServicio = New GestionarMedicoServicio()
        Dim medico As Medico = New Medico()
        medico.CodigoProp = txtCodigo.Text
        medico.nombreProp = txtNombre.Text
        Dim respuesta As Integer = gestionarMedicoServicio.ingresar(medico)
        If respuesta = 1 Then
            MessageBox.Show("Registro correcto")
        Else
            MessageBox.Show("No se puede registrar")
        End If
    End Sub
End Class