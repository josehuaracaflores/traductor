Imports CONTROLADOR.CONTROLADOR
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim traductor As New TRADUCTOR
        Dim tabla As DataTable
        
        traductor.español = TextBox1.Text
        tabla = traductor.buscar(traductor.español)
        If traductor.buscar(traductor.español).Rows.Count = 0 Then
            MsgBox("NO EXISTE.... DESEA AGREGAR SU TRADUCION..")
            AGREGAR.Visible = True
            AGREGAR.TextBox1.Text = TextBox1.Text
            AGREGAR.Show()
        Else
            TextBox2.Text = tabla.Rows(0)("QUECHUA")
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
