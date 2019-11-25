Imports System.Data.SqlClient
Imports System.Threading
Public Class Unisoft
    Public Conexion As String = "Data Source = DAVE\SQLEXPRESS; Initial Catalog = UsuariosUnisoft; Integrated Security = True"

    Public Sub Alumnos_Click(sender As Object, e As EventArgs) Handles Alumnos.Click, Button6.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(0)
        Dim usuarioligin As String = ""
        Using connection1 As New SqlConnection(Conexion)
            usuarioligin = "select correo from UserUnisotf where Correo = " + "'" + LogUsurio + "' and Password = " + "'" + contrasena + "'"
            Dim command2 As New SqlCommand(usuarioligin, connection1)
            command2.Parameters.Add("@logusuario", SqlDbType.VarChar)
            command2.Parameters("@logusuario").Value = LogUsurio
            command2.Parameters.Add("@pass", SqlDbType.VarChar)
            command2.Parameters("@pass").Value = contrasena
            Try
                If LogUsurio.Contains("promoydifu ") Or LogUsurio.Contains("alumnos") Or LogUsurio.Contains("ORDINARIO") Or LogUsurio.Contains("plantel") Then
                    TabControl.TabPages.Item(1).Enabled = False
                    TabControl.TabPages.Item(2).Enabled = False
                    TabControl.TabPages.Item(3).Enabled = False
                    TabControl.TabPages.Item(4).Enabled = False
                    TabControl.TabPages.Item(5).Enabled = False
                Else
                    TabControl.TabPages.Item(0).Enabled = True
                End If
                connection1.Open()
                command2.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Error")
                Me.Close()
            End Try
        End Using
        If LogUsurio.Contains("auditoria") Then
            TabControl.TabPages.Item(0).Enabled = True
            TabControl.TabPages.Item(1).Enabled = True
            TabControl.TabPages.Item(3).Enabled = True
            TabControl.TabPages.Item(4).Enabled = True
            TabControl.TabPages.Item(5).Enabled = True
        End If
    End Sub

    Private Sub PromoyDifu_Click(sender As Object, e As EventArgs) Handles PromoyDifu.Click, Button1.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(1)
        Dim usuarioligin As String = ""
        Using connection1 As New SqlConnection(Conexion)
            usuarioligin = "select correo from UserUnisotf where Correo = " + "'" + LogUsurio + "' and Password = " + "'" + contrasena + "'"
            Dim command2 As New SqlCommand(usuarioligin, connection1)
            command2.Parameters.Add("@logusuario", SqlDbType.VarChar)
            command2.Parameters("@logusuario").Value = LogUsurio
            command2.Parameters.Add("@pass", SqlDbType.VarChar)
            command2.Parameters("@pass").Value = contrasena
            Try
                If LogUsurio.Contains("finanzas ") Or LogUsurio.Contains("alumnos") Or LogUsurio.Contains("ORDINARIO") Or LogUsurio.Contains("plantel") Then
                    TabControl.TabPages.Item(0).Enabled = False
                    TabControl.TabPages.Item(2).Enabled = False
                    TabControl.TabPages.Item(3).Enabled = False
                    TabControl.TabPages.Item(4).Enabled = False
                    TabControl.TabPages.Item(5).Enabled = False
                Else
                    TabControl.TabPages.Item(1).Enabled = True
                End If
                connection1.Open()
                command2.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Error")
                Me.Close()
            End Try


        End Using
        If LogUsurio.Contains("auditoria") Then
            TabControl.TabPages.Item(0).Enabled = True
            TabControl.TabPages.Item(1).Enabled = True
            TabControl.TabPages.Item(3).Enabled = True
            TabControl.TabPages.Item(4).Enabled = True
            TabControl.TabPages.Item(5).Enabled = True
        End If
    End Sub
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        N_Prospecto.Show(nuevo)
        Me.Hide()

    End Sub

    Public Sub Buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        B_Prospecto.Show(buscar)
        Me.Hide()

    End Sub

    Private Sub Finanzas_Click(sender As Object, e As EventArgs) Handles Finanzas.Click, Button4.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(2)
        Dim usuarioligin As String = ""
        Using connection1 As New SqlConnection(Conexion)
            usuarioligin = "select correo from UserUnisotf where Correo = " + "'" + LogUsurio + "' and Password = " + "'" + contrasena + "'"
            Dim command2 As New SqlCommand(usuarioligin, connection1)
            command2.Parameters.Add("@logusuario", SqlDbType.VarChar)
            command2.Parameters("@logusuario").Value = LogUsurio
            command2.Parameters.Add("@pass", SqlDbType.VarChar)
            command2.Parameters("@pass").Value = contrasena
            Try
                If LogUsurio.Contains("promoydifu ") Or LogUsurio.Contains("alumnos") Or LogUsurio.Contains("ORDINARIO") Or LogUsurio.Contains("plantel") Then
                    TabControl.TabPages.Item(0).Enabled = False
                    TabControl.TabPages.Item(1).Enabled = False
                    TabControl.TabPages.Item(3).Enabled = False
                    TabControl.TabPages.Item(4).Enabled = False
                    TabControl.TabPages.Item(5).Enabled = False
                Else
                    TabControl.TabPages.Item(2).Enabled = True
                End If
                connection1.Open()
                command2.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Error")
                Me.Close()
            End Try
        End Using
        If LogUsurio.Contains("auditoria") Then
            TabControl.TabPages.Item(0).Enabled = True
            TabControl.TabPages.Item(1).Enabled = True
            TabControl.TabPages.Item(3).Enabled = True
            TabControl.TabPages.Item(4).Enabled = True
            TabControl.TabPages.Item(5).Enabled = True
        End If
    End Sub

    Private Sub EscolarOrd_Click(sender As Object, e As EventArgs) Handles EscolarOrd.Click, Button2.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(3)
        Dim usuarioligin As String = ""
        Using connection1 As New SqlConnection(Conexion)
            usuarioligin = "select correo from UserUnisotf where Correo = " + "'" + LogUsurio + "' and Password = " + "'" + contrasena + "'"
            Dim command2 As New SqlCommand(usuarioligin, connection1)
            command2.Parameters.Add("@logusuario", SqlDbType.VarChar)
            command2.Parameters("@logusuario").Value = LogUsurio
            command2.Parameters.Add("@pass", SqlDbType.VarChar)
            command2.Parameters("@pass").Value = contrasena
            Try
                If LogUsurio.Contains("promoydifu ") Or LogUsurio.Contains("alumnos") Or LogUsurio.Contains("plantel") Or LogUsurio.Contains("finanzas") Then
                    TabControl.TabPages.Item(0).Enabled = False
                    TabControl.TabPages.Item(1).Enabled = False
                    TabControl.TabPages.Item(2).Enabled = False
                    TabControl.TabPages.Item(4).Enabled = False
                    TabControl.TabPages.Item(5).Enabled = False
                Else
                    TabControl.TabPages.Item(3).Enabled = True
                End If
                connection1.Open()
                command2.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Error")
                Me.Close()
            End Try
        End Using
        If LogUsurio.Contains("auditoria") Then
            TabControl.TabPages.Item(0).Enabled = True
            TabControl.TabPages.Item(1).Enabled = True
            TabControl.TabPages.Item(3).Enabled = True
            TabControl.TabPages.Item(4).Enabled = True
            TabControl.TabPages.Item(5).Enabled = True
        End If
    End Sub

    Private Sub Plante_Click(sender As Object, e As EventArgs) Handles Plante.Click, Button3.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(4)
        Dim usuarioligin As String = ""
        Using connection1 As New SqlConnection(Conexion)
            usuarioligin = "select correo from UserUnisotf where Correo = " + "'" + LogUsurio + "' and Password = " + "'" + contrasena + "'"
            Dim command2 As New SqlCommand(usuarioligin, connection1)
            command2.Parameters.Add("@logusuario", SqlDbType.VarChar)
            command2.Parameters("@logusuario").Value = LogUsurio
            command2.Parameters.Add("@pass", SqlDbType.VarChar)
            command2.Parameters("@pass").Value = contrasena
            Try
                If LogUsurio.Contains("promoydifu ") Or LogUsurio.Contains("alumnos") Or LogUsurio.Contains("ORDINARIO") Or LogUsurio.Contains("finanzas") Then
                    TabControl.TabPages.Item(0).Enabled = False
                    TabControl.TabPages.Item(1).Enabled = False
                    TabControl.TabPages.Item(2).Enabled = False
                    TabControl.TabPages.Item(3).Enabled = False
                    TabControl.TabPages.Item(5).Enabled = False
                Else
                    TabControl.TabPages.Item(4).Enabled = True
                End If
                connection1.Open()
                command2.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Error")
                Me.Close()
            End Try
        End Using
        If LogUsurio.Contains("auditoria") Then
            TabControl.TabPages.Item(0).Enabled = True
            TabControl.TabPages.Item(1).Enabled = True
            TabControl.TabPages.Item(3).Enabled = True
            TabControl.TabPages.Item(4).Enabled = True
            TabControl.TabPages.Item(5).Enabled = True
        End If
    End Sub

    Private Sub Auditoria_Click(sender As Object, e As EventArgs) Handles Auditoria.Click, Button5.Click
        TabControl.SelectedTab = TabControl.TabPages.Item(5)
        Dim usuarioligin As String = ""
        Using connection1 As New SqlConnection(Conexion)
            usuarioligin = "select correo from UserUnisotf where Correo = " + "'" + LogUsurio + "' and Password = " + "'" + contrasena + "'"
            Dim command2 As New SqlCommand(usuarioligin, connection1)
            command2.Parameters.Add("@logusuario", SqlDbType.VarChar)
            command2.Parameters("@logusuario").Value = LogUsurio
            command2.Parameters.Add("@pass", SqlDbType.VarChar)
            command2.Parameters("@pass").Value = contrasena
            Try
                If LogUsurio.Contains("auditoria") Then
                    TabControl.TabPages.Item(0).Enabled = True
                    TabControl.TabPages.Item(1).Enabled = True
                    TabControl.TabPages.Item(3).Enabled = True
                    TabControl.TabPages.Item(4).Enabled = True
                    TabControl.TabPages.Item(5).Enabled = True
                End If
                connection1.Open()
                command2.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Error")
                Me.Close()
            End Try
        End Using

    End Sub

    Private Sub Cerrarsession_Click(sender As Object, e As EventArgs) Handles Cerrarsession.Click, Button7.Click
        InicioSesion.Show()
        Me.Close()
    End Sub
End Class