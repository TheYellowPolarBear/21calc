Public Class secNumBox
    Private Sub exitBox_Click(sender As Object, e As EventArgs) Handles exitBox.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub clearBox_Click(sender As Object, e As EventArgs) Handles clearBox.Click
        firstNumBox.Text = ""
        secondNumBox.Text = "" 'Changes all output boxes to nothing'
        outputBox.Text = ""
    End Sub

    Private Sub addBox_Click(sender As Object, e As EventArgs) Handles addBox.Click
        Dim num1 As Double
        Dim num2 As Double 'Declaring number and answer variables'
        Dim answer As Double

        num1 = firstNumBox.Text 'Assigning the first number to the first text box'
        num2 = secondNumBox.Text 'Assigning the second number to the second text box'
        answer = num1 + num2 'Adding the numbers'
        outputBox.Text = answer 'Putting the answer in the "output" box'

        If num1 = "9" And num2 = "10" Then
            outputBox.Text = "21" 'Just testing if statements with an inside joke'
        End If

    End Sub

    Private Sub subtractBox_Click(sender As Object, e As EventArgs) Handles subtractBox.Click
        Dim num1 As Double
        Dim num2 As Double 'Code is similar to the notes above'
        Dim answer As Double

        num1 = firstNumBox.Text
        num2 = secondNumBox.Text
        answer = num1 - num2
        outputBox.Text = answer

        If num1 = "9" And num2 = "10" Then
            outputBox.Text = "-21"
        End If

    End Sub

    Private Sub multiplyBox_Click(sender As Object, e As EventArgs) Handles multiplyBox.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double

        num1 = firstNumBox.Text
        num2 = secondNumBox.Text
        answer = num1 * num2
        outputBox.Text = answer

        If num1 = "9" And num2 = "10" Then
            outputBox.Text = "210"
        End If

    End Sub

    Private Sub divideBox_Click(sender As Object, e As EventArgs) Handles divideBox.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double

        num1 = firstNumBox.Text
        num2 = secondNumBox.Text
        answer = num1 / num2
        outputBox.Text = answer

        If num1 = "9" And num2 = "10" Then
            outputBox.Text = "2.1"
        End If

    End Sub

    Private Sub secNumBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class