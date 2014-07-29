Imports System.Data
Imports System.Data.SqlClient
Namespace MODELO
    Public Class Metodo_Datos

        Public Function CrearComando() As SqlCommand

            Dim config As New Configuraciones
            Dim _cadenaConexion As String = config.CadenaConexion
            Dim oConexion As New SqlConnection
            oConexion.ConnectionString = _cadenaConexion
            Dim oComando As New SqlCommand
            oComando = oConexion.CreateCommand
            oComando.CommandType = CommandType.Text
            Return oComando

        End Function

        Public Function EjecutarComandoSelect(ByVal oComando As SqlCommand) As DataTable

            Dim oTabla As New DataTable
            Try
                oComando.Connection.Open()
                Dim oAdapter As New SqlDataAdapter
                oAdapter.SelectCommand = oComando
                oAdapter.Fill(oTabla)

            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()
            End Try
            Return oTabla
        End Function

        Public Function EjecutarComandoInsert(ByVal oComando As SqlCommand) As Boolean
            Dim resp As Boolean = False
            Try
                oComando.Connection.Open()
                Dim oAdapter As New SqlDataAdapter
                oAdapter.SelectCommand = oComando
                If oComando.ExecuteNonQuery > 0 Then
                    resp = True
                Else
                    resp = False
                End If

            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()
            End Try

            Return resp

        End Function

        Public Function EjecutarComandoUpdate(ByVal oComando As SqlCommand) As Boolean
            Dim resp As Boolean = False
            Try
                oComando.Connection.Open()
                Dim oAdapter As New SqlDataAdapter
                oAdapter.SelectCommand = oComando
                If oComando.ExecuteNonQuery > 0 Then
                    resp = True
                Else
                    resp = False
                End If

            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()
            End Try

            Return resp

        End Function

        Public Function EjecutarComandoDelete(ByVal oComando As SqlCommand) As Boolean
            Dim resp As Boolean = False
            Try
                oComando.Connection.Open()
                Dim oAdapter As New SqlDataAdapter
                oAdapter.SelectCommand = oComando
                If oComando.ExecuteNonQuery > 0 Then
                    resp = True
                Else
                    resp = False
                End If

            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()
            End Try

            Return resp

        End Function




    End Class

End Namespace
