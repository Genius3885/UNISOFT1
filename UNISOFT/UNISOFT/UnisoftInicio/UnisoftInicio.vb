Imports System.Data.SqlClient
Imports System.Threading
Public Class UnisoftInicio
    Public Conexion As String = "Data Source = DAVE\SQLEXPRESS; Initial Catalog = UsuariosUnisoft; Integrated Security = True"
    Private Sub UnisoftInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ingresarsistema_Click(sender As Object, e As EventArgs) Handles ingresarsistema.Click
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            InicioSesion.Show()
            Me.Hide()
        End If
    End Sub
End Class