Imports System.Data.SqlClient
Imports System.Threading
Public Class InicioSesion
    Public Conexion As String = "Data Source = DAVE\SQLEXPRESS; Initial Catalog = UsuariosUnisoft; Integrated Security = True"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        Dim logusuario As String = usuario.Text
        Dim pass As String = passusuario.Text
        Dim usuarioligin As String
        'BUSCAMOS INFORMACION DEL USUARIO EN LA BD PARA DAR LOS ACCESOS
        Using connection1 As New SqlConnection(Conexion)
            usuarioligin = "select correo from UserUnisotf where Correo = " + "'" + logusuario + "' and Password = " + "'" + pass + "'"
            Dim command2 As New SqlCommand(usuarioligin, connection1)
            command2.Parameters.Add("@logusuario", SqlDbType.VarChar)
            command2.Parameters("@logusuario").Value = logusuario
            command2.Parameters.Add("@pass", SqlDbType.VarChar)
            command2.Parameters("@pass").Value = pass
            Try
                connection1.Open()
                command2.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Password o Usuario Incorrecto")
                Me.Close()
            End Try
            'EN CASO DE NO TENER CONTRASEÑA SE CIERRA LA APLICACION
            If logusuario = "" Or pass = "" Then
                MsgBox("Favor de Llenar los Campos")
            Else
                Logs.LogUsurio = usuario.Text
                Logs.contrasena = passusuario.Text
                Thread.Sleep(1000)
                MsgBox("Bienveni  " + logusuario)
                Unisoft.Show()
                Me.Hide()
            End If

        End Using

        'LIMPIAMOS COMBOS DE CONTRASEÑAS Y USUARIOS
        usuario.Clear()
        passusuario.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CrearUsuarios.Show()
    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        UnisoftInicio.Close()
    End Sub

End Class
