' The rule is used to approximate the time required for prices to double due to inflation
' If the inflation rate is r%, then the rule of 72 estimates that prices will double in 72/r years. 
' With an inflation rate of 6%, prices double in about 72/6 or 12 years
' Write a program that will test the accuracy of this from 1 to 20% interest, and print it out to a list box

Public Class frmRuleOf72

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        'Dim r As Double '  This is the interest rate
        'Dim rule As Integer

        'For r = 1 To 20
        '    rule = Int(72 / r)
        '    lstOutput.Items.Add(r & "%  " & rule & " years for prices to double")
        'Next r

        Dim years As Integer
        Dim amount As Double

        ' For every year btwn 1 and 20
        For intRate As Integer = 1 To 20
            years = 0
            amount = 100

            ' We will calculate within our do while loop, what is the rate for each year
            While amount < 200 '  While the amount is less than 200, keep increasing it. Once it hits over 200, stop. This is to see how many years it takes to double
                years += 1
                amount = (1 + intRate / 100) * amount '  With each iteration, the percent goes up, the amount increases thanks to inflation
            End While

            lstOutput.Items.Add("Interest Rate " & (intRate / 100).ToString("P0"))
            lstOutput.Items.Add("Rule of 72: " & Math.Round(72 / intRate))
            lstOutput.Items.Add("Actual Doubling Time: " & years)
            lstOutput.Items.Add("")
        Next
    End Sub
End Class
