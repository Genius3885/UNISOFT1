Public Class Unisoft

    Private Sub Alumnos_Click(sender As Object, e As EventArgs) Handles Alumnos.Click, Button6.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(0)

    End Sub

    Private Sub PromoyDifu_Click(sender As Object, e As EventArgs) Handles PromoyDifu.Click, Button1.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(1)
    End Sub
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        N_prospecto.Show(nuevo)

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        B_Prospecto.Show(buscar)


    End Sub

    Private Sub Finanzas_Click(sender As Object, e As EventArgs) Handles Finanzas.Click, Button4.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(2)
    End Sub

    Private Sub EscolarOrd_Click(sender As Object, e As EventArgs) Handles EscolarOrd.Click, Button2.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(3)
    End Sub

    Private Sub Plante_Click(sender As Object, e As EventArgs) Handles Plante.Click, Button3.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(4)
    End Sub

    Private Sub Auditoria_Click(sender As Object, e As EventArgs) Handles Auditoria.Click, Button5.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(5)
    End Sub

    Private Sub Cerrarsession_Click(sender As Object, e As EventArgs) Handles Cerrarsession.Click, Button7.Click
        InicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub Unisoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EscolOrd_Click(sender As Object, e As EventArgs) Handles EscolOrd.Click

    End Sub

    Private Sub Plan_Click(sender As Object, e As EventArgs) Handles Plan.Click

    End Sub

    Private Sub Grupo_Click(sender As Object, e As EventArgs) Handles Grupo.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub pruebas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles nuevo.Click

    End Sub


    'EN CADA FUNCION QUE TENEMOS SE TIENE QUE DESARROLLAR LA PARTE QUE NOS TOCO A CADA UNO Y GENERALES LOS ACCESOS
End Class