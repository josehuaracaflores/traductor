
Namespace MODELO

    Public Class Configuraciones

        Dim _cadena As String = "Data Source=JOSE;Initial Catalog=NUMERO;Integrated Security=True" 'Integrated Security=true cuando se entra por la autentificacion de windows

        Public ReadOnly Property CadenaConexion() As String 'propiedad de solo lectura
            Get
                Return _cadena
            End Get
        End Property

    End Class

End Namespace

