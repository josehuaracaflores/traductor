'Imports MODELO.MODELO
Imports System.Data
Imports System.Data.SqlClient

Namespace MODELO

    Public Class AccesoDatos

        Public Function ObtenerDatos(ByVal sql As String) As DataTable
            Dim mDatos As New Metodo_Datos
            Dim oComando As SqlCommand = mDatos.CrearComando
            Try
                oComando.CommandText = sql  'falta hacer todavia aqui
                Return mDatos.EjecutarComandoSelect(oComando)
            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()
            End Try
        End Function

        Public Function InsertarDatos(ByVal sql As String) As Boolean
            Dim mDatos As New Metodo_Datos
            Dim oComando As SqlCommand = mDatos.CrearComando

            Try
                oComando.CommandText = sql
                Return mDatos.EjecutarComandoInsert(oComando)
            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()
            End Try

        End Function

        Public Function ActualizarDatos(ByVal sql As String) As Boolean
            Dim mDatos As New Metodo_Datos
            Dim oComando As SqlCommand = mDatos.CrearComando

            Try
                oComando.CommandText = sql
                Return mDatos.EjecutarComandoUpdate(oComando)
            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()

            End Try

        End Function

        Function EleminarDatos(ByVal sql As String) As Boolean
            Dim mDatos As New Metodo_Datos
            Dim oComando As SqlCommand = mDatos.CrearComando

            Try
                oComando.CommandText = sql
                Return mDatos.EjecutarComandoDelete(oComando)
            Catch ex As Exception
                Throw New Exception
            Finally
                oComando.Connection.Close()

            End Try
        End Function
    End Class


End Namespace
