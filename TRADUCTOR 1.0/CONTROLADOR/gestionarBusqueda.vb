Imports MODELO.MODELO
Namespace CONTROLADOR

    Public Class gestionarBusqueda

        Public Sub New()

        End Sub

        Public Function buscarC(ByVal elemento As Long) As DataTable
            Try

                Dim accesodatos As New AccesoDatos
                Dim sql As String
                Dim tabla As DataTable
                sql = "SELECT T.CENTENA_Q FROM CENTENA1 AS T WHERE T.CENTENA=" & elemento & ""
                tabla = accesodatos.ObtenerDatos(sql)
                Return tabla
            Catch ex As Exception
                Throw New Exception
            End Try

        End Function


        Public Function buscarD(ByVal elemento As Long) As DataTable
            Try

                Dim accesodatos As New AccesoDatos
                Dim sql As String
                Dim tabla As DataTable
                sql = "SELECT T.DECENA_Q FROM DECENA AS T WHERE T.DECENA=" & elemento & ""
                tabla = accesodatos.ObtenerDatos(sql)
                Return tabla
            Catch ex As Exception
                Throw New Exception
            End Try

        End Function

        Public Function buscarM(ByVal elemento As Long) As DataTable
            Try

                Dim accesodatos As New AccesoDatos
                Dim sql As String
                Dim tabla As DataTable
                sql = "SELECT T.MILLAR_Q FROM MILLAR AS T WHERE T.MILLAR=" & elemento & ""
                tabla = accesodatos.ObtenerDatos(sql)
                Return tabla
            Catch ex As Exception
                Throw New Exception
            End Try

        End Function

        Public Function buscarU(ByVal elemento As Long) As DataTable
            Try

                Dim accesodatos As New AccesoDatos
                Dim sql As String
                Dim tabla As DataTable
                sql = "SELECT T.UNIDAD_Q FROM UNIDAD AS T WHERE T.UNIDAD=" & elemento & ""
                tabla = accesodatos.ObtenerDatos(sql)
                Return tabla
            Catch ex As Exception
                Throw New Exception
            End Try

        End Function

        Public Function buscarU1(ByVal elemento As Long) As DataTable
            Try

                Dim accesodatos As New AccesoDatos
                Dim sql As String
                Dim tabla As DataTable
                sql = "SELECT T.UNIDAD_Q  FROM UNIDAD1 AS T WHERE T.UNIDAD='" & elemento & "'"
                tabla = accesodatos.ObtenerDatos(sql)
                Return tabla
            Catch ex As Exception
                Throw New Exception
            End Try

        End Function

    End Class


End Namespace
