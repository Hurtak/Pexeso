Public Class frmHelp

    'Back to menu button
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub

End Class