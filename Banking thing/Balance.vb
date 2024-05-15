Public Class Balance
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = Account.accountBalance
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu As New Menu
        Hide()
        menu.ShowDialog()
    End Sub
End Class