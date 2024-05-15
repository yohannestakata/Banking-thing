Public Class Form1
    Dim pass As String = "1234"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu As New Menu

        If TextBox1.Text = "1234" Then
            Hide()
            menu.ShowDialog()
        End If
    End Sub


End Class
