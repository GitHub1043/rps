Public Class Form1
    Dim intScore As Integer = 5

    Private Sub btnThrow_Click(sender As Object, e As EventArgs) Handles btnThrow.Click

        Dim intComp As Integer 'Computer Throw
        Dim intUser As Integer 'User Throw

        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3
        Const LIZARD As Integer = 4
        Const SPOCK As Integer = 5

        ' set Computer Throw
        Randomize()
        intComp = Int(Rnd() * 5) + 1

        ' set User Throw
        If (radRock.Checked = True) Then
            intUser = ROCK

        ElseIf (radPaper.Checked = True) Then
            intUser = PAPER

        ElseIf (radScissors.Checked = True) Then
            intUser = SCISSORS

        ElseIf (radLizard.Checked = True) Then
            intUser = LIZARD

        ElseIf (radSpock.Checked = True) Then
            intUser = SPOCK
        End If


        If (intUser = ROCK) And (intComp = ROCK) Then
            lblResult.Text = "Computer Throws Rock. It's a Draw!"
        ElseIf (intUser = ROCK) And (intComp = PAPER) Then
            lblResult.Text = "Computer Throws Paper. You Lose!"
            intScore = intScore - 1
        ElseIf (intUser = ROCK) And (intComp = SCISSORS) Then
            lblResult.Text = "Computer Throws Scissors. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = ROCK) And (intComp = LIZARD) Then
            lblResult.Text = "Computer Throws Lizard. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = ROCK) And (intComp = SPOCK) Then
            lblResult.Text = "Computer Throws Spock. You Lose!"
            intScore = intScore - 1
        End If


        If (intUser = PAPER) And (intComp = PAPER) Then
            lblResult.Text = "Computer Throws Paper. It's a Draw!"
        ElseIf (intUser = PAPER) And (intComp = ROCK) Then
            lblResult.Text = "Computer Throws Rock. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = PAPER) And (intComp = SCISSORS) Then
            lblResult.Text = "Computer Throws Scissors. You Lose!"
            intScore = intScore - 1
        ElseIf (intUser = PAPER) And (intComp = LIZARD) Then
            lblResult.Text = "Computer Throws Lizard. You Lose!"
            intScore = intScore - 1
        ElseIf (intUser = PAPER) And (intComp = SPOCK) Then
            lblResult.Text = "Computer Throws Spock. You Win!"
            intScore = intScore + 1
        End If


        If (intUser = SCISSORS) And (intComp = SCISSORS) Then
            lblResult.Text = "Computer Throws Scissors. It's a Draw!"
        ElseIf (intUser = SCISSORS) And (intComp = ROCK) Then
            lblResult.Text = "Computer Throws Rock. You Lose!"
            intScore = intScore - 1
        ElseIf (intUser = SCISSORS) And (intComp = PAPER) Then
            lblResult.Text = "Computer Throws Paper. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = SCISSORS) And (intComp = LIZARD) Then
            lblResult.Text = "Computer Throws Lizard. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = SCISSORS) And (intComp = SPOCK) Then
            lblResult.Text = "Computer Throws Spock. You Lose!"
            intScore = intScore - 1
        End If


        If (intUser = LIZARD) And (intComp = LIZARD) Then
            lblResult.Text = "Computer Throws Scissors. It's a Draw!"
        ElseIf (intUser = LIZARD) And (intComp = ROCK) Then
            lblResult.Text = "Computer Throws Rock. You Lose!"
            intScore = intScore - 1
        ElseIf (intUser = LIZARD) And (intComp = PAPER) Then
            lblResult.Text = "Computer Throws Paper. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = LIZARD) And (intComp = SCISSORS) Then
            lblResult.Text = "Computer Throws Scissors. You Lose!"
            intScore = intScore - 1
        ElseIf (intUser = LIZARD) And (intComp = SPOCK) Then
            lblResult.Text = "Computer Throws Spock. You Win!"
            intScore = intScore + 1
        End If

        If (intUser = SPOCK) And (intComp = SPOCK) Then
            lblResult.Text = "Computer Throws Spock. It's a Draw!"
        ElseIf (intUser = SPOCK) And (intComp = ROCK) Then
            lblResult.Text = "Computer Throws Rock. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = SPOCK) And (intComp = PAPER) Then
            lblResult.Text = "Computer Throws Paper. You Lose!"
            intScore = intScore - 1
        ElseIf (intUser = SPOCK) And (intComp = SCISSORS) Then
            lblResult.Text = "Computer Throws Scissors. You Win!"
            intScore = intScore + 1
        ElseIf (intUser = SPOCK) And (intComp = LIZARD) Then
            lblResult.Text = "Computer Throws Lizard. You Lose!"
            intScore = intScore - 1
        End If

        lblScore.Text = "Score: " & intScore

        If (intScore = 0) Then
            MessageBox.Show("You Lose, Try Again!")
            intScore = 5
            lblScore.Text = "Score: " & intScore

        ElseIf (intScore = 10) Then
            MessageBox.Show("You Win, Play Again!")
            intScore = 5
            lblScore.Text = "Score: " & intScore
        End If

    End Sub
End Class
