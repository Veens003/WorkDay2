Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        ' Your code here
        If num1 > num2 Then
            num1 = largerNum
        ElseIf num1 < num2 Then
            num2 = largerNum
        ElseIf num1 = num2 Then
            num1 = largerNum
        End If

            txtResult.Text = "Not implemented yet"
    End Sub

End Class
