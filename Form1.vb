Public Class frmDateFinder
    'End Program configuration
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declarations
        Dim i As Integer
        'Array used to store the number of days in each month
        Dim intMonths() = {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Dim intDays() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        'Variables used to store inputed numbers
        Dim intMonthInput As Integer
        Dim intDayInput As Integer
        Dim intYearInput As Integer
        Dim intAddedDaysInput As Integer
        Dim strFutureDate As String
        'Leap Year variable. Starts at 28 which means it's not a leap year
        Dim intLeapYearResult = 28

        'Inputs for the variables that store inputed numbers
        intMonthInput = nudMonthInput.Value
        intDayInput = nudDayInput.Value
        intYearInput = nudYearInput.Value
        intAddedDaysInput = nudAddedDaysInput.Value

        'Processing
        'Adds the added day input
        intAddedDaysInput = intAddedDaysInput + intDayInput

        'Checks if it's a leap year. 28 means no, 29 means yes
        If intYearInput Mod 4 = 0 Then
            If intYearInput Mod 100 <> 0 Then
                intLeapYearResult = 29
            ElseIf intYearInput Mod 400 = 0 Then
                intLeapYearResult = 29
            End If
        End If

        'If statement to make the days change if it's a leap year or not within the intDays(i) Array
        If intLeapYearResult = 28 Then
            intDays(1) = 28
        ElseIf intLeapYearResult = 29 Then
            intDays(1) = 29
        End If

        lblOutputDate.Text = intDays(1)

        'Currently having problems here
        If intAddedDaysInput > intDays(i) Then
            intDayInput = intDayInput - intDays(i)
            intMonthInput = intMonthInput + 1
            If intMonthInput > 12 Then
                intYearInput = intYearInput + 1
            End If
        End If

        strFutureDate = intMonthInput & "/" & intAddedDaysInput & "/" & intYearInput
        'Output
        lblOutputDate.Text = strFutureDate

    End Sub
End Class

