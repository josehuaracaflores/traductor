Imports CONTROLADOR.CONTROLADOR
Public Class AGREGAR

    Private Sub AGREGAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Sub mostrar()
        Dim gl As New TRADUCTOR
        Dim ta As New DataTable
        ta = gl.mostraTodo
        DataGridView1.DataSource = ta
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim l As New TRADUCTOR
            Dim r As Boolean

            l.español = TextBox1.Text
            l.quechua = TextBox2.Text

            r = l.agregar()
            If r = True Then
                MessageBox.Show("se registro ok : " & TextBox1.Text & " y " & TextBox2.Text)
            Else
                MessageBox.Show("se cancelo..... ")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        mostrar()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim T As New TRADUCTOR
            Dim re As Boolean

            T.quechua = TextBox2.Text

            re = T.editar(T.quechua)
            If re = True Then
                MsgBox("actualizacion...... ok   " & TextBox1.Text)
            Else
                MsgBox("cancelado la actualizacion... corriga ")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mostrar()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim traductor As New TRADUCTOR
            Dim re As Boolean
            traductor.español = TextBox1.Text
            re = traductor.eliminar(traductor.español)
            If re = True Then
                MessageBox.Show("eliminado...... ok : " & TextBox1.Text)
            Else
                MessageBox.Show("cancelado la eliminacion... corriga")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        mostrar()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False

    End Sub
End Class