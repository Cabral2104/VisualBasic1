Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim x As Contacto
        x = New Contacto()
        x.fechadenacimiento_ = DateTime.Parse("2003/01/01")
        x.nombre_ = txtNombre.Text
        x.telefono_ = txtTelefono.Text
        Mostrar.Text = x.ToString
    End Sub
End Class
