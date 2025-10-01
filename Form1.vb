Imports System.Data
Imports System.Text.RegularExpressions

Public Class Form1
    Private currentInput As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        entry_box.Text = ""
        equation.Text = ""
        result.Text = ""
        memory.Text = ""
    End Sub

    ' Helper function to evaluate expressions with modulus (%)
    Private Function EvaluateModExpression(expr As String) As Double
        Dim pattern As String = "(\d+)\s*%\s*(\d+)" ' Matches "number % number"
        Dim regex As New Regex(pattern)
        Dim newExpr As String = expr

        While regex.IsMatch(newExpr)
            Dim match = regex.Match(newExpr)
            Dim leftNum = Convert.ToInt32(match.Groups(1).Value)
            Dim rightNum = Convert.ToInt32(match.Groups(2).Value)
            Dim modResult = leftNum Mod rightNum
            newExpr = regex.Replace(newExpr, modResult.ToString(), 1)
        End While

        Dim dt As New DataTable()
        Dim evalResult = dt.Compute(newExpr, Nothing)
        Return Convert.ToDouble(evalResult)
    End Function

    ' Evaluates currentInput, updates equation and result boxes
    Private Sub EvaluateInput()
        Try
            Dim inputExpr = currentInput
            equation.Text = inputExpr.Replace("%", " Mod ")
            Dim evalResult = EvaluateModExpression(inputExpr)
            result.Text = evalResult.ToString()
            currentInput = evalResult.ToString()
        Catch ex As Exception
            result.Text = "Error"
            currentInput = ""
        End Try
        entry_box.Text = currentInput
    End Sub

    ' Helper to add characters (numbers or operators) to input
    Private Sub AddToInput(value As String)
        currentInput &= value
        entry_box.Text = currentInput
    End Sub

    ' Clear everything
    Private Sub Button_c_Click(sender As Object, e As EventArgs) Handles Button_c.Click
        currentInput = ""
        entry_box.Text = ""
        equation.Text = ""
        result.Text = ""
    End Sub

    ' Clear last entry (CE)
    Private Sub Button_ce_Click(sender As Object, e As EventArgs) Handles Button_ce.Click
        If currentInput.Length > 0 Then
            currentInput = currentInput.Substring(0, currentInput.Length - 1)
            entry_box.Text = currentInput
        End If
    End Sub

    ' Equal button click - evaluate expression
    Private Sub Button_equal_Click(sender As Object, e As EventArgs) Handles Button_equal.Click
        EvaluateInput()
    End Sub

    ' Number buttons example - call AddToInput for each digit (add for all digits 0-9)
    Private Sub DigitButton_Click(sender As Object, e As EventArgs) _
        Handles entry_box.KeyPress
        ' You can add digit buttons similarly or allow keyboard input here
    End Sub

    ' Operator buttons
    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        AddToInput("+")
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        AddToInput("-")
    End Sub

    Private Sub times_Click(sender As Object, e As EventArgs) Handles times.Click
        AddToInput("*")
    End Sub

    Private Sub Button_divide_Click(sender As Object, e As EventArgs) Handles Button_divide.Click
        AddToInput("/")
    End Sub

    Private Sub Button_percent_Click(sender As Object, e As EventArgs) Handles Button_percent.Click
        AddToInput("%")
    End Sub

    ' Negate button (+/-)
    Private Sub negetive_Click(sender As Object, e As EventArgs) Handles negetive.Click
        If currentInput.Length > 0 AndAlso Double.TryParse(currentInput, Nothing) Then
            Dim num = Convert.ToDouble(currentInput)
            num = -num
            currentInput = num.ToString()
            entry_box.Text = currentInput
        Else
            ' If expression not a single number, do nothing or handle accordingly
        End If
    End Sub

    ' Memory Save (MS)
    Private Sub MS_Click(sender As Object, e As EventArgs) Handles MS.Click
        memory.Text = result.Text
    End Sub

    ' Memory Recall (MR)
    Private Sub MR_Click(sender As Object, e As EventArgs) Handles MR.Click
        If Not String.IsNullOrEmpty(memory.Text) Then
            AddToInput(memory.Text)
        End If
    End Sub

    ' Memory Clear (MC)
    Private Sub MC_Click(sender As Object, e As EventArgs) Handles MC.Click
        memory.Text = ""
    End Sub

    ' Exit button
    Private Sub Button_exit_Click(sender As Object, e As EventArgs) Handles Button_exit.Click
        Application.Exit()
    End Sub

    ' Keyboard input handler - allow digits and basic operators from keyboard
    Private Sub entry_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles entry_box.KeyPress
        Dim allowedChars As String = "0123456789+-*/%"

        If allowedChars.Contains(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            ' Allow character
        Else
            e.Handled = True
        End If
    End Sub

    ' Optional: Update currentInput when user types manually in entry_box
    Private Sub entry_box_TextChanged(sender As Object, e As EventArgs) Handles entry_box.TextChanged
        currentInput = entry_box.Text
    End Sub

End Class


