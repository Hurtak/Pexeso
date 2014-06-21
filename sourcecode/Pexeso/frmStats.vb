Public Class frmStats

    'Back to menu button
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    'My.Settings.L1 - Easy difficulty player names  My.Settings.L2 - Easy difficulty player times 
    'My.Settings.L3 - Medium difficulty player names  My.Settings.L4 - Medium difficulty player times 
    'My.Settings.L5 - Hard difficulty player names  My.Settings.L6 - Hard difficulty player times 
    'Initializes leader board data from my.settings and puts them in labels
    Sub InitializeLeaderboard()
        Dim settingItemArray()

        For i = 1 To 6
            settingItemArray = Split(My.Settings.Item("L" & CStr(i)), ";")
            Me.Controls.Find("lbl" & CStr(i), True)(0).Text = ""

            For j = 0 To settingItemArray.Count - 1
                Dim newLine
                If j = settingItemArray.Count - 1 Then newLine = Nothing Else newLine = vbNewLine

                Me.Controls.Find("lbl" & CStr(i), True)(0).Text += settingItemArray(j) & newLine
            Next
        Next
    End Sub

    'Resets leaderboard to default values
    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        If MsgBox("Do you really want to reset leaderboard?", vbYesNo + vbQuestion, "Leaderboard reset") = vbYes Then

            For i = 1 To 6
                Select Case i
                    Case 1, 3, 5
                        My.Settings.Item("L" & CStr(i)) = "Player1;Player2;Player3;Player4;Player5;Player6;Player7;Player8;Player9;Player10"
                    Case 2
                        My.Settings.Item("L" & CStr(i)) = "00:15;00:20;00:25;00:30;00:35;00:40;00:45;00:50;00:55;01:00"
                    Case 4
                        My.Settings.Item("L" & CStr(i)) = "01:10;01:15;01:20;01:25;01:30;01:35;01:40;01:45;01:50;01:55"
                    Case 6
                        My.Settings.Item("L" & CStr(i)) = "02:00;02:10;02:20;02:30;02:40;02:50;03:00;04:10;04:20;04:30"
                End Select
            Next

            My.Settings.Save()
            InitializeLeaderboard()
        End If
    End Sub

End Class