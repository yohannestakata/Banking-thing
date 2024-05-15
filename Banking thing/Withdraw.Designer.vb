<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button2 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(676, 404)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 9
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(251, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 8
        Button1.Text = "Withdraw"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(251, 117)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 31)
        TextBox1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(250, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(218, 25)
        Label2.TabIndex = 6
        Label2.Text = "Enter amount to withdraw"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(239, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 45)
        Label1.TabIndex = 5
        Label1.Text = "Withdraw"
        ' 
        ' Withdraw
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Withdraw"
        Text = "Withdrawal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
