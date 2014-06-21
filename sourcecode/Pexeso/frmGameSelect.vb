Public Class frmGameSelect

    'Back to menu button
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    'Start the game button
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        frmGameplay.SetNumberOfCards(NumericUpDownX.Value, NumericUpDownY.Value)

        Me.Hide()

        If frmGameplay.IsFirstRun = False Then frmGameplay.InitializeCardBoard()
        frmGameplay.Show()
    End Sub

    'refreshes "Time to beat" section, sets number of cards X and Y accordingly to selected difficulty
    Private Sub lstDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDifficulty.SelectedIndexChanged
        Dim numberOfCardsX
        Dim numberOfCardsY

        RefreshTime()

        Select Case lstDifficulty.SelectedIndex
            Case 0 'Easy
                numberOfCardsX = 4
                numberOfCardsY = 4

                SetInputValue(numberOfCardsX, numberOfCardsY)
            Case 1 'Medium
                numberOfCardsX = 8
                numberOfCardsY = 4

                SetInputValue(numberOfCardsX, numberOfCardsY)
            Case 2 'Hard
                numberOfCardsX = 10
                numberOfCardsY = 5

                SetInputValue(numberOfCardsX, numberOfCardsY)
            Case 3 'Custom
                NumericUpDownX.Enabled = True
                NumericUpDownY.Enabled = True
        End Select

    End Sub

    'sets NumericUpDownX and NumericUpDownY values and disables them
    Private Sub SetInputValue(valueX, valueY)
        NumericUpDownX.Value = valueX
        NumericUpDownY.Value = valueY

        NumericUpDownX.Enabled = False
        NumericUpDownY.Enabled = False
    End Sub

    'refreshes time values in "Time to beat" section
    Public Sub RefreshTime()
        If lstDifficulty.SelectedIndex = 3 Then 'handles custom difficulty setting where no times or leaderboards are saved
            lblFirst.Text = "––:––"
            lblLast.Text = "––:––"
        Else
            lblFirst.Text = setTime(getDifficultyID(), 1) 'first player time
            lblLast.Text = setTime(getDifficultyID(), 10) 'last player time
        End If
    End Sub

    Private Sub NumericUpDownX_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownX.ValueChanged
        HandleOddNumbers(NumericUpDownX.Value, NumericUpDownY.Value)
    End Sub

    Private Sub NumericUpDownY_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownY.ValueChanged
        HandleOddNumbers(NumericUpDownX.Value, NumericUpDownY.Value)
    End Sub

    'handles situations when total number of cards is odd number
    Private Sub HandleOddNumbers(Number1, Number2)
        Dim number = Number1 * Number2
        Do While number > 0
            number -= 2
        Loop

        If number = 0 Then
            NumericUpDownX.BackColor = Color.White    'Changes BackColor to default color (white) and enables start button when total number of cards is even 
            NumericUpDownY.BackColor = Color.White
            lblTotalNumberOfCards.BackColor = Color.White

            cmdStart.Enabled = True
        Else
            NumericUpDownX.BackColor = Color.LightCoral     'Changes BackColor to light red and disables start button when total number of cards is odd
            NumericUpDownY.BackColor = Color.LightCoral
            lblTotalNumberOfCards.BackColor = Color.LightCoral

            cmdStart.Enabled = False
        End If

        RecalculateNumberOfCards()
    End Sub

    'calculates total number of cards from NumericUpDownX and NumericUpDownY values
    Private Sub RecalculateNumberOfCards()
        lblTotalNumberOfCards.Text = NumericUpDownX.Value * NumericUpDownY.Value
    End Sub

    'Returns difficulty name in string or in upper case string
    Function GetDifficulty(convertToUppercase As Boolean)
        Dim difficulty = lstDifficulty.Text
        If convertToUppercase = True Then difficulty = UCase(difficulty)
        Return difficulty
    End Function

    'when form loads selects default difficulty to easy
    Private Sub frmGameSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstDifficulty.SelectedIndex = 0
    End Sub

    'My.Settings.L1 - Easy difficulty player names  My.Settings.L2 - Easy difficulty player times 
    'My.Settings.L3 - Medium difficulty player names  My.Settings.L4 - Medium difficulty player times 
    'My.Settings.L5 - Hard difficulty player names  My.Settings.L6 - Hard difficulty player times 
    'returns difficulty number which is related to My.Settings 
    Function GetDifficultyID() As Integer
        Select Case GetDifficulty(False)
            Case "Easy"
                Return 1
            Case "Normal"
                Return 3
            Case "Hard"
                Return 5
            Case Else
                Return False
        End Select
    End Function

    'returns time of player, first argument specifies from which leader board it should take the data, second argument is for specifiing position of player <1;10>
    'this is used for "Time to beat" section
    Function SetTime(difficultyID, position) As String
        Dim settingsArray() = Split(My.Settings.Item("L" & CStr(difficultyID + 1)), ";")
        Return settingsArray(position - 1)
    End Function

End Class