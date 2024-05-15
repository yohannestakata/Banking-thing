Public Class Withdraw
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Double
        Dim success As Boolean = Double.TryParse(TextBox1.Text, amount)

        If success Then
            If Account.accountBalance < amount Then
                MsgBox("Insufficient funds")
            Else
                Account.accountBalance -= amount
                MsgBox("Balance deducted")
            End If
        Else
            MsgBox("Please enter a valid amount (numbers only)")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim menu As New Menu
        Hide()
        menu.ShowDialog()
    End Sub
End Class