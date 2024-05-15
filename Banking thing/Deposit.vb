Public Class Deposit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Account.accountBalance += Double.Parse(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim menu As New Menu
        Hide()
        menu.ShowDialog()
    End Sub
End Class