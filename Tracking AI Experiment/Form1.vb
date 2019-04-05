Public Class Form1
    Dim ballX = 50
    Dim ballY = 50

    Dim charX = 20
    Dim charY = 20

    Dim differenceX As Decimal
    Dim differenceY As Decimal
    Dim gradient As Decimal
    Dim hypotenuse As Decimal

    Dim gradient2five As Decimal

    Dim moveConstant = 2


    Sub maths()
        differenceX = (charX - ballX)
        differenceY = (charY - ballY)
        hypotenuse = Math.Sqrt(differenceX ^ 2 + differenceY ^ 2)

        If differenceX <> 0 Then
            gradient = differenceY / differenceX
        End If




        ' If hypotenuse <> 0 Then
        gradient2five = moveConstant / hypotenuse

        ' End If
    End Sub

    Sub trackNoGradient()
        'If charX <> ballX Then
        '    If charX <= ballX Then
        '        ballX = ballX - moveConstant
        '    Else
        '        ballX = ballX + moveConstant
        '        End
        '    End If
        'End If

        'If charY <= ballY Then
        '    ballY = ballY - (moveConstant)
        'Else
        '    ballY = ballY + (moveConstant)
        'End If
    End Sub
    'Does not change the gradient 

    Sub track()
        If differenceX ^ 2 > 25 Then
            ballX = ballX + differenceX * gradient2five
            ' Else
            ' ballX = charX
        End If
        If differenceY ^ 2 > 25 Then
            ballY = ballY + differenceY * gradient2five
            ' Else
            ' ballY = charY
        End If



        lbl_ballX.Text = ballX
        lbl_ballY.Text = ballY
        lbl_mouseX.Text = MousePosition.X
        lbl_mouseY.Text = MousePosition.Y
        lbl_charX.Text = charX
        lbl_charY.Text = charY
        lbl_grad.Text = gradient
        lbl_dX.Text = differenceX
        lbl_dY.Text = differenceY

        Playing_Area.Invalidate()
    End Sub


    Private Sub PaintGame(sender As Object, e As PaintEventArgs) Handles Playing_Area.Paint
        e.Graphics.DrawEllipse(Pens.Black, ballX, ballY, 10, 10)
        e.Graphics.DrawEllipse(Pens.Black, charX, charY, 10, 10)
    End Sub
    'paints the two game objects

    Private Sub Playing_Area_MouseMove(sender As Object, e As MouseEventArgs) Handles Playing_Area.MouseMove
        charX = e.Location.X
        charY = e.Location.Y
    End Sub
    'gives the character its coordinates

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        track()
        maths()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        moveConstant += 3
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        moveConstant -= 3
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
