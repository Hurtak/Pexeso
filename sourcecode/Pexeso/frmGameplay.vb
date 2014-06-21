Public Class frmGameplay
    Dim numberOfCardsX = 4 'number of cards on X axis
    Dim numberOfCardsY = 4 'number of cards on Y axis

    Const cardWidth = 71 'card width in pixels
    Const cardHeight = 96 'card height in pixels

    Const spaceBetweenCards = 10 'space between each card on board in pixels
    Const spaceAroundCards = 20 'space around cards on the edges in pixels

    Dim numberOfSelectedCards As Byte = 0   'specifies how many cards are selected at any given moment <0;2>

    Public Card(,) As ClassPictures

    Dim cardArray(numberOfCardsX - 1, numberOfCardsY - 1, 2) '0 card type in string, 1 card picture as picture, 2 boolean storing wheather of not card has been revealed

    Dim firtRun As Boolean

    'form load is only initialized on first run
    Public Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        InitializeCardBoard()
    End Sub

    'initializes whole card board
    Public Sub InitializeCardBoard()
        ClearCardBoard(firtRun, numberOfCardsX, numberOfCardsY) 'clears card board from previous plays (only initializes when firstRun = false)
        PrepareLblSelectedCardBorder()

        ReDim cardArray(numberOfCardsX - 1, numberOfCardsY - 1, 3)
        ReDim Card(numberOfCardsX - 1, numberOfCardsY - 1)

        Dim cardType As String = "s" ' s = spades d = diamonds c = clubs h = hearts 
        Dim cardValue = 1 ' 1 = ace 2 = two ... 10 = ten 11 = jack 12 = queen 13 = king
        Dim sameCard = False 'boolead used to make sure each of the cards is drawn on board twice
        Dim usedCardsArray(0 To 3, 0 To 12) As Boolean

        For i = 0 To numberOfCardsX - 1
            For j = 0 To numberOfCardsY - 1

                'on first run generates random card which has not been used berofe, on second run draws the same card 
                'as the one before to make sure each of the cards is on the board twice but no more
                If sameCard = False Then

generateNewCard:
                    Dim randomCardType = Int(Rnd() * 4) 'generates random card type
                    Select Case randomCardType
                        Case 0
                            cardType = "s" 'spades
                        Case 1
                            cardType = "d" 'diamond
                        Case 2
                            cardType = "c" 'clubs
                        Case 3
                            cardType = "h" 'hearts
                    End Select
                    cardValue = Int(Rnd() * 13) + 1 'generates random card value

                    If usedCardsArray(randomCardType, cardValue - 1) = True Then 'if card is already on board twice generate new card
                        GoTo generateNewCard
                    Else
                        usedCardsArray(randomCardType, cardValue - 1) = True
                    End If

                    sameCard = True
                Else
                    sameCard = False 'generates the same card as the one before to make sure there is always pair of the same cards on board
                End If

                Dim tmpPicture As New PictureBox

                With tmpPicture
                    .Width = cardWidth
                    .Height = cardHeight
                    .Left = (cardWidth + spaceBetweenCards) * i + spaceAroundCards
                    .Top = (cardHeight + spaceBetweenCards) * j + spaceAroundCards
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Visible = True
                    .BackColor = Color.Red
                    .Image = DirectCast(My.Resources.ResourceManager.GetObject(cardType & CStr(cardValue)), Bitmap)
                End With

                Dim saveAddress As New ClassPictures(i, j, tmpPicture)
                Me.Card(i, j) = saveAddress
                Me.Controls.Add(Me.Card(i, j).PictureBoxCard)
                AddHandler Card(i, j).PictureBoxCard.Click, AddressOf Card(i, j).PictureBoxCard_MouseClick

                Card(i, j).PictureBoxCard.BringToFront() 'makes sure card borders are under the cards

                cardArray(i, j, 0) = cardType & CStr(cardValue) 'stores card value
                cardArray(i, j, 1) = Card(i, j).PictureBoxCard.Image() 'stores card image
                cardArray(i, j, 2) = False 'stores boolean value representing wheather or not this card has been revealed
            Next
        Next

        ResizeWindow(cardWidth, cardHeight, numberOfCardsX, numberOfCardsY, spaceBetweenCards, spaceAroundCards, Me)
        CenterWindow(Me)

        ShuffleCards() 'shuffle cards on board
        HideAllCards() 'hides all cards on board

        numberOfSelectedCards = 0

        ClearTimer()
        Timer1.Enabled = True 'counts time for each game
    End Sub

    Dim oldNumberOfCardsX
    Dim oldNumberOfCardsY
    'deletes all cards on board when firstRun = false
    Sub ClearCardBoard(firtRun, numberOfCardsX, numberOfCardsY)
        If firtRun = True Then
            SetFirstRun(False)
            'saves number of cards so when new game is started game knows how many old cards it should delete
            oldNumberOfCardsX = numberOfCardsX
            oldNumberOfCardsY = numberOfCardsY
        Else
            'removes all cards from board
            For i = 0 To oldNumberOfCardsX - 1
                For j = 0 To oldNumberOfCardsY - 1
                    Me.Controls.Remove(Me.Card(i, j).PictureBoxCard)
                Next
            Next
            'saves number of cards so when new game is started game knows how many old cards it should delete
            oldNumberOfCardsX = numberOfCardsX
            oldNumberOfCardsY = numberOfCardsY
        End If
    End Sub


    Dim border As Single = 4 'border around selected cards in pixels
    'prepares borders for selected cards
    Sub PrepareLblSelectedCardBorder()
        lblSelectedCardBorder1.Width = cardWidth + 2 * border
        lblSelectedCardBorder1.Height = cardHeight + 2 * border
        lblSelectedCardBorder1.Visible = False

        lblSelectedCardBorder2.Width = cardWidth + 2 * border
        lblSelectedCardBorder2.Height = cardHeight + 2 * border
        lblSelectedCardBorder2.Visible = False
    End Sub

    'sets positioin and visibility of border so its properly displayer behind selected card
    Sub setBorderPosition(X As Byte, Y As Byte, lblNumber As Byte)
        Dim tmpLeft = X * cardWidth + X * spaceBetweenCards + spaceAroundCards - border
        Dim tmpTop = Y * cardHeight + Y * spaceBetweenCards + spaceAroundCards - border

        If lblNumber = 1 Then
            lblSelectedCardBorder1.Left = tmpLeft
            lblSelectedCardBorder1.Top = tmpTop
            lblSelectedCardBorder1.Visible = True
        Else
            lblSelectedCardBorder2.Left = tmpLeft
            lblSelectedCardBorder2.Top = tmpTop
            lblSelectedCardBorder2.Visible = True
        End If
    End Sub

    Dim cardPositionX1
    Dim cardPositionY1
    Dim cardPositionX2
    Dim cardPositionY2
    'handles card clicking, hiding and revealing cards
    Sub CardHandler(X, Y)
        If IsRevealed(X, Y) = True And numberOfSelectedCards < 2 Then Exit Sub

        If numberOfSelectedCards = 0 Then 'no cards selected
            cardPositionX1 = X
            cardPositionY1 = Y

            RevealCard(cardPositionX1, cardPositionY1)

            setBorderPosition(X, Y, 1)
            numberOfSelectedCards += 1

        ElseIf numberOfSelectedCards = 1 Then ' one card selected
            cardPositionX2 = X
            cardPositionY2 = Y

            RevealCard(cardPositionX2, cardPositionY2)

            If cardPositionX1 = cardPositionX2 And cardPositionY1 = cardPositionY2 Then Exit Sub ' player clicked on the same card twice

            If GetCardValue(cardPositionX1, cardPositionY1) = GetCardValue(cardPositionX2, cardPositionY2) Then ' card values match
                SetRevealed(cardPositionX1, cardPositionY1)
                SetRevealed(cardPositionX2, cardPositionY2)

                numberOfSelectedCards = 0

                lblSelectedCardBorder1.Visible = False

                If IsGameFinished() Then ' checks if all cards are revealed
                    Timer1.Enabled = False
                    MsgBox("Cogratulations, you have finished the game on " & frmGameSelect.GetDifficulty(True) & " difficulty in " & lblTimer.Text, MsgBoxStyle.Information, "Game completed")
                    HandleLeaderboards()
                End If

            Else 'card values doesent match
                numberOfSelectedCards += 1
                setBorderPosition(X, Y, 2)
            End If

        Else ' 2 cards selected after player made incorrect guess
            HideCard(cardPositionX1, cardPositionY1)
            HideCard(cardPositionX2, cardPositionY2)
            numberOfSelectedCards = 0

            lblSelectedCardBorder1.Visible = False
            lblSelectedCardBorder2.Visible = False
        End If
    End Sub

    'resizes window accordingly to number of cards on board and spaces between them
    Sub ResizeWindow(objectWidth, objectHeight, numberOfObjectsX, numberOfObjectsY, spaceBetween, spaceAround, frm)
        Const windowsBorderSize = 8
        Const windowsBorderTopSize = 30

        frm.Width = objectWidth * numberOfObjectsX + spaceBetween * (numberOfObjectsX - 1) + (spaceAround + windowsBorderSize) * 2
        frm.Height = objectHeight * numberOfObjectsY + spaceBetween * (numberOfObjectsY - 1) + spaceAround * 2 + windowsBorderSize + windowsBorderTopSize + panBottom.Height
    End Sub

    'centers given form window
    Sub CenterWindow(window)
        window.Left = My.Computer.Screen.WorkingArea.Width / 2 - window.Width / 2
        window.Top = My.Computer.Screen.WorkingArea.Height / 2 - window.Height / 2
    End Sub

    'shuffles cards on board
    Private Sub ShuffleCards()
        Dim tmpCardArrayValue

        Dim randomPositionX1
        Dim randomPositionY1
        Dim randomPositionX2
        Dim randomPositionY2

        For i = 1 To (numberOfCardsX * numberOfCardsY) 'more cards more shuffling
            'randomly selects two cards from board
            randomPositionX1 = Int(Rnd() * numberOfCardsX)
            randomPositionY1 = Int(Rnd() * numberOfCardsY)
            randomPositionX2 = Int(Rnd() * numberOfCardsX)
            randomPositionY2 = Int(Rnd() * numberOfCardsY)

            For j = 0 To 1 'switches two randomly selected cards 
                tmpCardArrayValue = cardArray(randomPositionX1, randomPositionY1, j)
                cardArray(randomPositionX1, randomPositionY1, j) = cardArray(randomPositionX2, randomPositionY2, j)
                cardArray(randomPositionX2, randomPositionY2, j) = tmpCardArrayValue
            Next
        Next

        RedrawCardPictures()
    End Sub

    'hides card with given X and Y coordinates
    Sub HideCard(X, Y)
        Card(X, Y).PictureBoxCard.Image = My.Resources.backblue
    End Sub

    'hides all cards with false IsRevealsed value
    Sub HideAllCards()
        For i = 0 To numberOfCardsX - 1
            For j = 0 To numberOfCardsY - 1
                If IsRevealed(i, j) = False Then HideCard(i, j)
            Next
        Next
    End Sub

    'reveals card with given X and Y coordinates
    Sub RevealCard(X, Y)
        Card(X, Y).PictureBoxCard.Image = cardArray(X, Y, 1)
    End Sub

    'reveals all cards on board, used only for cheats
    Sub RedrawCardPictures()
        For i = 0 To numberOfCardsX - 1
            For j = 0 To numberOfCardsY - 1
                RevealCard(i, j)
            Next
        Next
    End Sub

    'returns boolean value wheather or not card with given X and Y coordinates have been revealed
    Function IsRevealed(X, Y) As Boolean
        If cardArray(X, Y, 2) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    'checks if game is finished
    Function IsGameFinished() As Boolean
        For i = 0 To numberOfCardsX - 1
            For j = 0 To numberOfCardsY - 1
                If IsRevealed(i, j) = False Then Return False
            Next
        Next

        Return True
    End Function

    'reveals card on given X and Y coordinates
    Sub SetRevealed(X, Y)
        cardArray(X, Y, 2) = True
    End Sub

    'returns face value of card with given X and Y coordinates
    Function GetCardValue(X, Y) As Object
        Return cardArray(X, Y, 0)
    End Function

    'cheats for debuging
    Dim cheats As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cheats = False Then
            RedrawCardPictures()
            cheats = True
        Else
            HideAllCards()
            cheats = False
        End If
    End Sub

    Public Sub SetNumberOfCards(X, Y)
        numberOfCardsX = X
        numberOfCardsY = Y
    End Sub

    Function IsFirstRun() As Boolean
        If firtRun = True Then Return True Else Return False
    End Function

    Sub SetFirstRun(booleanValue As Boolean)
        firtRun = booleanValue
    End Sub

    'Back to menu button
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        If IsGameFinished() = False Then
            If MsgBox("Do you really want to go back to menu?", vbYesNo + vbQuestion + vbDefaultButton2, "Back to main menu?") = vbNo Then Exit Sub
        End If

        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Dim gameplayTimeSeconds As Integer = 0
    Dim gameplayTimeMinutes As Integer = 0
    Dim zeroForSeconds As String = "0"
    Dim zeroForMinutes As String = "0"
    'timer counting player time for current game
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gameplayTimeSeconds += 1
        If gameplayTimeSeconds = 60 Then
            gameplayTimeMinutes += 1
            gameplayTimeSeconds = 0
            If gameplayTimeMinutes < 10 Then zeroForMinutes = "0" Else zeroForMinutes = ""
        End If

        If gameplayTimeSeconds < 10 Then zeroForSeconds = "0" Else zeroForSeconds = ""

        lblTimer.Text = zeroForMinutes & gameplayTimeMinutes & ":" & zeroForSeconds & gameplayTimeSeconds
    End Sub

    'clears timer and all related variables
    Private Sub ClearTimer()
        Timer1.Enabled = False
        gameplayTimeSeconds = 0
        gameplayTimeMinutes = 0
        zeroForSeconds = "0"
        zeroForMinutes = "0"
        lblTimer.Text = "00:00"
    End Sub

    'returns player time for current game
    Private Function GetPlayTime() As String
        Return lblTimer.Text
    End Function

    'handles leaderboard
    Private Sub HandleLeaderboards()
        Dim difficulty As Byte

        'My.Settings.L1 - Easy difficulty player names  My.Settings.L2 - Easy difficulty player times 
        'My.Settings.L3 - Medium difficulty player names  My.Settings.L4 - Medium difficulty player times 
        'My.Settings.L5 - Hard difficulty player names  My.Settings.L6 - Hard difficulty player times 
        'returns difficulty number which is related to My.Settings 
        difficulty = frmGameSelect.getDifficultyID()
        If difficulty = False Then Exit Sub 'custom difficulty doesent have leaderboards

        Dim settingTimeArray() = Split(My.Settings.Item("L" & CStr(difficulty + 1)), ";")
        Dim timeOfPlayer As String = GetPlayTime()

        If timeOfPlayer > settingTimeArray.Last Then Exit Sub ' checks if player was faster than last player on leaderboard

        Dim position As Byte = settingTimeArray.Count
        For i = settingTimeArray.Count - 2 To 0 Step -1 ' counts on what position player finished
            If timeOfPlayer < settingTimeArray(i) Then position -= 1
        Next i

        Dim positionGrammar As String 'handles grammar issues
        Select Case position
            Case 1
                positionGrammar = "st" '1st
            Case 2
                positionGrammar = "nd" '2nd
            Case 3
                positionGrammar = "rd" '3rd
            Case Else
                positionGrammar = "th" '4th - 10th
        End Select

        Dim nameOfPlayer As String = ""
        Dim isNameCharOnly = False
        Do Until Len(nameOfPlayer) <= 12 And Len(nameOfPlayer) > 0 And isNameCharOnly = True
            nameOfPlayer = InputBox("Cogratulations, You have finished at " & position & positionGrammar & " place in " & frmGameSelect.GetDifficulty(True) & " difficulty leaderboard with time " & timeOfPlayer & "." & vbNewLine & vbNewLine & "Enter your name, it must be between 1 and 12 characters.", frmGameSelect.GetDifficulty(True) & " leader board", "Player Name")
            isNameCharOnly = True
            For i = 1 To Len(nameOfPlayer) 'takes each letter from sentence and checks wheather or not it is present in english alphabet 97=a 122=z 32=space
                If (Asc(LCase(Mid(nameOfPlayer, i, 1))) < 97 And Asc(LCase(Mid(nameOfPlayer, i, 1))) <> 32) Or Asc(LCase(Mid(nameOfPlayer, i, 1))) > 122 Then
                    isNameCharOnly = False
                End If
            Next
        Loop

        'puts player name and time on position (place in leaderboard) he finished and moves every player bellow him one position bellow
        For i = 0 To 1
            Dim settingArray() = Split(My.Settings.Item("L" & CStr(difficulty + i)), ";")
            Dim tmpString1 As String = ""
            Dim tmpString2 As String = nameOfPlayer
            If i = 1 Then tmpString2 = timeOfPlayer

            For j = position - 1 To settingArray.Count - 1
                Select Case j
                    Case position - 1 ' first run
                        tmpString1 = settingArray(j)
                        settingArray(j) = tmpString2
                    Case settingArray.Count - 1 ' last position
                        settingArray(j) = tmpString1
                    Case Else 'handles positions between
                        tmpString2 = settingArray(j)
                        settingArray(j) = tmpString1
                        tmpString1 = tmpString2
                End Select
            Next

            SaveLeaderboard(settingArray, difficulty, i) ' saves leaderboards to My.Settings
        Next
    End Sub

    'saves given array with specified difficulty and type (times or player names) to My.Settings
    Private Sub SaveLeaderboard(array(), difficulty, type)
        Dim settingStringSave As String = ""

        For i = 0 To array.Count - 1
            Dim splitCharacter
            If i = array.Count - 1 Then splitCharacter = Nothing Else splitCharacter = ";"
            settingStringSave += array(i) & splitCharacter
        Next

        My.Settings.Item("L" & CStr(difficulty + type)) = settingStringSave

        My.Settings.Save()
    End Sub

End Class
