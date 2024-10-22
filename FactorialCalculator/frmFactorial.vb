' Program Name: Factorial Calculator
' Date: October 22, 2024
' Author: K Bola
' Purpose: This application compute and display factorials 

Public Class frmFactorial
    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Dim strFactorial As String
        Dim intNumber As Integer
        Dim intFactorial As Integer = 1
        Dim strInputMessage As String = "Enter a number from 1 To 12: "
        Dim strInputHeading As String = "Factorial Number"
        Dim strNonNumeric As String = "Error - Enter a number: "
        Dim strNegativeValue As String = "Error - Enter a positive number: "
        Dim strEmptyMessage As String = "Error - It is mandatory to enter a number: "
        strFactorial = InputBox(strInputMessage, strInputHeading, "")
        If strFactorial = "" Then
            MsgBox(strEmptyMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Empty")
        End If
        If IsNumeric(strFactorial) Then
            intNumber = Convert.ToInt32(strFactorial)
            If (intNumber < 0) Then
                MsgBox(strNegativeValue, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Negative Value")
            End If
            If (intNumber > 12) Then
                MsgBox("Enter a number from 1 To 12." & vbCrLf & "Sorry, Closing the Application!!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Exceeds Expected Number")
            End If
        Else
            MsgBox(strNonNumeric, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry!!!")
        End If
        lstFactorials.Items.Clear()
        For i As Integer = 1 To intNumber
            intFactorial *= i
            lstFactorials.Items.Add(i & "!" & " = " & intFactorial)
        Next
        btnFactorial.Enabled = False
        MsgBox("Clear the form to enable the button", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub frmFactorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstFactorials.Items.Clear()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstFactorials.Items.Clear()
        btnFactorial.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
