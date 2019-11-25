Imports System.Data.SqlClient
Imports System.Threading

Public Class N_Prospecto
    Public Conexion As String = "Data Source = ISAAC\SQLEXPRESS02; Initial Catalog = prueba; Integrated Security = True"
    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        'VOLVEMOS AL MENU PRINCIPAL
        Unisoft.Show(menu)
        Me.Hide()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click

        'LIMPIAMOS LAS VARIABLES 
        folio.Clear()
        nombres.Clear()
        ap_paterno.Clear()
        ap_materno.Clear()
        edad.Clear()
        sexo.Items.Clear()
        curp.Clear()
        nacion.Clear()
        correo.Clear()
        telefono.Clear()
        celular.Clear()
        est_civil.Items.Clear()
        calle.Clear()
        num_ext.Clear()
        num_int.Clear()
        ciudad.Clear()
        alcaldia.Clear()
        fecha_alta.Clear()
        licenciatura.Items.Clear()
        duracion.Items.Clear()
        promedio.Clear()
        procedencia.Clear()
        estatus.Items.Clear()
        ciclo.Clear()
        documentos.Items.Clear()


    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles imprimir.Click

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click

        'DECLARAMMOS VARIABLES

        Dim InsertProspecto As String
        Dim vfolio As Integer = folio.Text
        Dim nombre As String = nombres.Text.ToUpper
        Dim ap_pater As String = ap_paterno.Text.ToUpper
        Dim ap_mater As String = ap_materno.Text.ToUpper
        Dim vedad As Integer = edad.Text
        Dim sexos As String = sexo.Text.ToUpper
        Dim vcurp As String = curp.Text.ToUpper
        Dim vnacion As String = nacion.Text.ToUpper
        Dim vcorreo As String = correo.Text.ToUpper
        Dim tel As String = telefono.Text.ToUpper
        Dim cel As String = celular.Text.ToUpper
        Dim estadociv As String = est_civil.Text.ToUpper
        Dim street As String = calle.Text.ToUpper
        Dim numint As String = num_int.Text.ToUpper
        Dim numext As String = num_ext.Text.ToUpper
        Dim city As String = ciudad.Text.ToUpper
        Dim alcaldi As String = alcaldia.Text.ToUpper
        Dim fecha As String = fecha_alta.Text.ToUpper
        Dim lic As String = licenciatura.Text.ToUpper
        Dim dura As String = duracion.Text.ToUpper
        Dim prom As String = promedio.Text.ToUpper
        Dim escuela As String = procedencia.Text.ToUpper
        Dim status As String = estatus.Text.ToUpper
        Dim vciclo As String = ciclo.Text.ToUpper
        Dim ocupa As String = ocupacion.Text.ToUpper
        Dim file As String = documentos.Text.ToUpper

        Using connection As New SqlConnection(Conexion)

            InsertProspecto = "insert into Prospectos values (" + "'" + vfolio + "'" + "," + nombre + "'" + "," + "'" + ap_pater + "'" + "," + "'" + ap_mater + "'" + "," + vedad + "'" + "," + "'" + sexos + "'" + "," + "'" + vcurp + "'" + "," + "'" + vnacion + "'" + "," + "'" + vcorreo + "'" + "," + "'" + tel + "'" + "," + "'" + cel + "'" + "," + "'" + estadociv + "'" + "," + "'" + street + "'" + "," + "'" + numint + "'" + "," + "'" + numext + "'" + "," + "'" + city + "'" + "," + "'" + alcaldi + "'" + "," + fecha + "," + "'" + lic + "'" + "," + "'" + dura + "'" + "," + "'" + prom + "'" + "," + "'" + escuela + "'" + "," + "'" + status + "'" + "," + "'" + city + "'" + "," + "'" + ocupa + "'" + "," + "'" + file + "'" + ")"

            Dim command1 As New SqlCommand(InsertProspecto, connection)
            command1.Parameters.Add("@folio", SqlDbType.Int)
            command1.Parameters("@folio").Value = vfolio
            command1.Parameters.Add("@nombre", SqlDbType.VarChar)
            command1.Parameters("@nombre").Value = nombre
            command1.Parameters.Add("@apellido_paterno", SqlDbType.VarChar)
            command1.Parameters("@apellido_paterno").Value = ap_pater
            command1.Parameters.Add("@apellido_materno", SqlDbType.VarChar)
            command1.Parameters("@apellido_materno").Value = ap_mater
            command1.Parameters.Add("@edad", SqlDbType.Int)
            command1.Parameters("@edad").Value = vedad
            command1.Parameters.Add("@sexo", SqlDbType.VarChar)
            command1.Parameters("@sexo").Value = sexos
            command1.Parameters.Add("@curp", SqlDbType.VarChar)
            command1.Parameters("@curp").Value = vcurp
            command1.Parameters.Add("@nacionalidad", SqlDbType.VarChar)
            command1.Parameters("@nacionalidad").Value = vnacion
            command1.Parameters.Add("@coreo", SqlDbType.VarChar)
            command1.Parameters("@correo").Value = vcorreo
            command1.Parameters.Add("@telefono_local", SqlDbType.Int)
            command1.Parameters("@telefono_local").Value = tel
            command1.Parameters.Add("@telefono_celular", SqlDbType.Int)
            command1.Parameters("@telefono_celular").Value = cel
            command1.Parameters.Add("@edo_civil", SqlDbType.VarChar)
            command1.Parameters("@edo_civil").Value = estadociv
            command1.Parameters.Add("@calle", SqlDbType.VarChar)
            command1.Parameters("@calle").Value = street
            command1.Parameters.Add("@numero_interior", SqlDbType.Int)
            command1.Parameters("@numero_interior").Value = numint
            command1.Parameters.Add("@numero_exterior", SqlDbType.Int)
            command1.Parameters("@numero_exterior").Value = numext
            command1.Parameters.Add("@ciudad", SqlDbType.VarChar)
            command1.Parameters("@ciudad").Value = city
            command1.Parameters.Add("@alcaldia", SqlDbType.VarChar)
            command1.Parameters("@alcaldia").Value = alcaldi
            command1.Parameters.Add("@fecha_alta", SqlDbType.VarChar)
            command1.Parameters("@fecha_alta").Value = fecha
            command1.Parameters.Add("@licenciatura", SqlDbType.VarChar)
            command1.Parameters("@licenciatura").Value = lic
            command1.Parameters.Add("@duracion", SqlDbType.VarChar)
            command1.Parameters("@duracion").Value = dura
            command1.Parameters.Add("@promedio_prepa", SqlDbType.Int)
            command1.Parameters("@promedio_prepa").Value = prom
            command1.Parameters.Add("@escuela_procedencia", SqlDbType.VarChar)
            command1.Parameters("@escuela_procedencia").Value = escuela
            command1.Parameters.Add("@estatus", SqlDbType.Int)
            command1.Parameters("@estatus").Value = status
            command1.Parameters.Add("@ciclo", SqlDbType.VarChar)
            command1.Parameters("@ciclo").Value = vciclo
            command1.Parameters.Add("@ocupacion", SqlDbType.VarChar)
            command1.Parameters("@ocupacion").Value = ocupa
            command1.Parameters.Add("@documentos", SqlDbType.VarChar)
            command1.Parameters("@documentos").Value = file

            Try
                connection.Open()
                command1.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                MsgBox("No se Guardo El Registro Reportarlo a IT!")
                Me.Close()
            End Try
            Thread.Sleep(10000)
            MsgBox("Se Guardado el Registro Exitosamente!")
            Me.Hide()


        End Using





















    End Sub
End Class