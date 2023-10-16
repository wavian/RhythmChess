Imports System.Media
Imports System.Xml

Public Class frmMain
    Dim strCountdown As String = 10
    Dim strTurn As String = "White"
    Dim bStart As Boolean = False
    Dim decBeginTime As Decimal = 10
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If bStart = False Then
            tmrTimer.Enabled = True
            bStart = True
        ElseIf strTurn = "White" Then
            strTurn = "Black"
            strCountdown = (decBeginTime - strCountdown) + 2
            decBeginTime = strCountdown
        ElseIf strTurn = "Black" Then
            strTurn = "White"
            strCountdown = (decBeginTime - strCountdown) + 2
            decBeginTime = strCountdown
        End If

    End Sub


    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        strCountdown = FormatCurrency(strCountdown - 0.05)
        strCountdown = strCountdown.Replace("$", "")
        If strCountdown > 0 Then
            If strTurn = "White" Then
            btnToggle.BackColor = Color.White
            btnToggle.ForeColor = Color.Black
            btnToggle.Text = "White's Turn" & vbCrLf & strCountdown
        End If
        If strTurn = "Black" Then
            btnToggle.BackColor = Color.Black
            btnToggle.ForeColor = Color.White
            btnToggle.Text = "Black's Turn" & vbCrLf & strCountdown
        End If
        ElseIf strCountdown <= 0 Then
        If strTurn = "Black" Then
                btnToggle.BackColor = Color.White
                btnToggle.ForeColor = Color.Black
                btnToggle.Text = "White Wins"
                strTurn = "End"
                tmrTimer.Enabled = False
            ElseIf strTurn = "White" Then
                btnToggle.BackColor = Color.Black
                btnToggle.ForeColor = Color.White
                btnToggle.Text = "Black Wins"
                strTurn = "End"
                tmrTimer.Enabled = False
            Else
                btnToggle.BackColor = Color.LightGray
                btnToggle.ForeColor = Color.Black
                btnToggle.Text = "Error"
            End If
        End If
    End Sub
End Class
