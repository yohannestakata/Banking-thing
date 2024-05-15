Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim balance As New Balance

        Hide()
        balance.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim deposit As New Deposit
        Hide()
        deposit.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim withdraw As New Withdraw
        Hide()
        withdraw.ShowDialog()
    End Sub
End Class