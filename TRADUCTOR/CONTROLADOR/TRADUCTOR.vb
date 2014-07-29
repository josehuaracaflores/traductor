
Imports MODELO.MODELO

Namespace CONTROLADOR

    Public Class TRADUCTOR
        Private _español As String
        Private _quechua As String

        Function mostraTodo() As DataTable

            Dim accesoDatos As New AccesoDatos
            Dim sql As String
            Dim tabla As DataTable
            sql = "select * from TRADUCTOR"
            tabla = accesoDatos.ObtenerDatos(sql)
            Return tabla

        End Function

        Public Function editar(ByVal elemento As Object) As Boolean
            Try
                Dim accesoDatos As New AccesoDatos
                Dim sql As String

                sql = "update TRADUCTOR set QUECHUA='" & quechua & "' where ESPAÑOL='" & elemento & "'"

                If accesoDatos.ActualizarDatos(sql) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception

                Throw New Exception
            End Try

            'Return True
        End Function

        Public Function eliminar(ByVal elemento As Object) As Boolean
            Try
                Dim accesoDatos As New AccesoDatos
                Dim sql As String

                sql = "delete from TRADUCTOR where ESPAÑOL='" & español & "'"

                If accesoDatos.EleminarDatos(sql) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function

        Public Function buscar(ByVal elemento As Object) As DataTable
            Try

                Dim accesodatos As New AccesoDatos
                Dim sql As String
                Dim tabla As DataTable
                sql = "select t.QUECHUA  from TRADUCTOR as T where t.ESPAÑOL='" & elemento & "'"
                tabla = accesodatos.ObtenerDatos(sql)
                Return tabla
            Catch ex As Exception
                Throw New Exception
            End Try

        End Function

        Public Function agregar() As Boolean

            Try
                Dim accesoDatos As New AccesoDatos
                Dim sql As String
                sql = "insert into TRADUCTOR(ESPAÑOL,QUECHUA) values('" & español & "','" & quechua & "')"
                If accesoDatos.InsertarDatos(sql) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return True

        End Function



        Public Sub New()

        End Sub


        Public Property quechua() As String
            Get
                Return _quechua
            End Get
            Set(ByVal value As String)
                _quechua = value
            End Set
        End Property


        Public Property español() As String
            Get
                Return _español
            End Get
            Set(ByVal value As String)
                _español = value
            End Set
        End Property




    End Class

End Namespace

