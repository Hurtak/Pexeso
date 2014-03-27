Public Class frmMainMenu
    Public frm1 As frmMainMenu

    'After game loads, sets first run variable to true
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmGameplay.SetFirstRun(True)
    End Sub

    'Play button
    Private Sub imgPlay_Click(sender As Object, e As EventArgs) Handles imgPlay.Click
        Me.Hide()
        frmGameSelect.Show()
        If frmGameplay.IsFirstRun = False Then frmGameSelect.RefreshTime()
    End Sub

    'Help button
    Private Sub imgHelp_Click(sender As Object, e As EventArgs) Handles imgHelp.Click
        Me.Hide()
        frmHelp.Show()
    End Sub

    'Stats button
    Private Sub imgStats_Click(sender As Object, e As EventArgs) Handles imgStats.Click
        Me.Hide()
        frmStats.Show()
        frmStats.InitializeLeaderboard()
    End Sub

    'Exit button
    Private Sub imgExit_Click(sender As Object, e As EventArgs) Handles imgExit.Click
        If MsgBox("Do you really want to exit the game?", vbYesNo + vbQuestion + vbDefaultButton2, "Exit game") = vbYes Then
            End
        End If
    End Sub

    'image loading for MouseMove and MouseLeave
    Private Sub imgPlay_MouseLeave(sender As Object, e As EventArgs) Handles imgPlay.MouseLeave
        imgPlay.Image = My.Resources.back
    End Sub

    Private Sub imgPlay_MouseMove(sender As Object, e As MouseEventArgs) Handles imgPlay.MouseMove
        imgPlay.Image = My.Resources.newgame
    End Sub

    Private Sub imgHelp_MouseLeave(sender As Object, e As EventArgs) Handles imgHelp.MouseLeave
        imgHelp.Image = My.Resources.back
    End Sub

    Private Sub imgHelp_MouseMove(sender As Object, e As MouseEventArgs) Handles imgHelp.MouseMove
        imgHelp.Image = My.Resources.help
    End Sub

    Private Sub imgStats_MouseLeave(sender As Object, e As EventArgs) Handles imgStats.MouseLeave
        imgStats.Image = My.Resources.back
    End Sub

    Private Sub imgStats_MouseMove(sender As Object, e As MouseEventArgs) Handles imgStats.MouseMove
        imgStats.Image = My.Resources.stats
    End Sub

    Private Sub imgExit_MouseLeave(sender As Object, e As EventArgs) Handles imgExit.MouseLeave
        imgExit.Image = My.Resources.back
    End Sub

    Private Sub imgExit_MouseMove(sender As Object, e As MouseEventArgs) Handles imgExit.MouseMove
        imgExit.Image = My.Resources.exitgame
    End Sub

End Class
