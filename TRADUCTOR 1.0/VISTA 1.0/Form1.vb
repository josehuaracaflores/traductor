Imports CONTROLADOR.CONTROLADOR
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, m, c, d, u As Long
        Dim t, t1, t2, t3 As DataTable
        Dim R As String
        Dim g As New gestionarBusqueda

        n = CLng(TextBox1.Text)

        R = " "

        If n >= 10 And n < 10000 Then
            m = n \ 1000
            n = n Mod 1000
            c = n \ 100
            n = n Mod 100
            d = n \ 10
            u = n Mod 10

            If m > 0 Then
                t = g.buscarM(m)
                R = t.Rows(0)("MILLAR_Q")

            End If

            If c > 0 Then
                t1 = g.buscarC(c)
                R = R & " " & t1.Rows(0)("CENTENA_Q")

            End If

            If d > 0 Then
                t2 = g.buscarD(d)
                R = R & " " & t2.Rows(0)("DECENA_Q")

            End If

            If u > 0 Then
                t3 = g.buscarU1(u)
                R = R & " " & t3.Rows(0)("UNIDAD_Q")

            End If

            TextBox2.Text = R

        ElseIf n > 0 And n < 10 Then
            t3 = g.buscarU(n)
            R = R & " " & t3.Rows(0)("UNIDAD_Q")
            TextBox2.Text = R
        ElseIf n < 0 And n >= 10000 Then
            R = "limpia y intruduce otro ..... no existe..."
            TextBox2.Text = R


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
