Public Class ClassPictures
    Public X As Integer
    Public Y As Integer

    Public WithEvents PictureBoxCard As PictureBox

    Public Sub New(ByVal X As Integer, ByVal Y As Integer, ByVal PictureBoxCard As PictureBox)
        Me.X = X
        Me.Y = Y
        Me.PictureBoxCard = PictureBoxCard
    End Sub

    'calls CardHandler(x coordinates, y coordinates) after each click on card
    Public Sub PictureBoxCard_MouseClick(ByVal sender As System.Object, ByVal e As MouseEventArgs)
        frmGameplay.CardHandler(X, Y)
    End Sub

End Class
