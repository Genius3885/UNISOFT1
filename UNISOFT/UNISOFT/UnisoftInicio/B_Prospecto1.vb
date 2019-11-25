Public Class B_Proscpecto

    Public Conexion As String = "Data Source = ISAAC\SQLEXPRESS02; Initial Catalog = prueba; Integrated Security = True"
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'LIMPIAMOS VARIABLES
        folio.Clear()
        nombre.Clear()
        ap_paterno.Clear()
        ap_materno.Clear()
        estatus.Items.Clear()
    End Sub
    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        'VOLVEMOS AL MENU PRINCIPAL
        Unisoft.Show(menu)
        Me.Hide()
    End Sub

End Class