﻿Public Class Deposit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Double
        Dim success As Double = Double.TryParse(TextBox1.Text, amount)
        If success Then
            Account.accountBalance += amount
            MsgBox("Amount added to account balace")
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