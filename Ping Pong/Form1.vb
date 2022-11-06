Public Class Form1
    Dim xspeed As Double = 4
    Dim yspeed As Double = 4
    Dim p1s, p2s As Integer
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ball.Top += yspeed
        ball.Left -= xspeed

        If ball.Bounds.IntersectsWith(p1.Bounds) Then
            If xspeed > 0 Then
                xspeed += 0.25
                xspeed = -xspeed
            Else
                xspeed = -xspeed
                xspeed += 0.25
            End If

        ElseIf ball.Bounds.IntersectsWith(p2.Bounds) Then
            If xspeed > 0 Then
                xspeed += 0.25
                xspeed = -xspeed
            Else
                xspeed = -xspeed
                xspeed += 0.25
            End If
        End If


        If ball.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            yspeed = -yspeed
        ElseIf ball.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            yspeed = -yspeed
        ElseIf ball.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            xspeed = -xspeed
            yspeed = -yspeed
            p2s += 1
            restart_game()
        ElseIf ball.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            xspeed = -xspeed
            yspeed = -yspeed
            p1s += 1
            restart_game()
        End If


    End Sub
    Private Sub restart_game()
        ball.Left = 332
        ball.Top = 191
        Label1.Text = p1s
        Label2.Text = p2s
        xspeed = 4
        yspeed = 4
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If p1.Top <= 347 Then
            p1.Top += 5
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If p1.Top >= 5 Then
            p1.Top -= 5
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If p2.Top <= 347 Then
            p2.Top += 5
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If p2.Top >= 5 Then
            p2.Top -= 5
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            Timer3.Enabled = True
        ElseIf e.KeyCode = Keys.Down Then
            Timer4.Enabled = True
        ElseIf e.KeyCode = Keys.S Then
            Timer1.Enabled = True
        ElseIf e.KeyCode = Keys.W Then
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Up Then
            Timer3.Enabled = False
        ElseIf e.KeyCode = Keys.Down Then
            Timer4.Enabled = False
        ElseIf e.KeyCode = Keys.S Then
            Timer1.Enabled = False
        ElseIf e.KeyCode = Keys.W Then
            Timer2.Enabled = False
        End If
    End Sub

End Class
