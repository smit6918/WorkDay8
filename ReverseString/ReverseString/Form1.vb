﻿Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim st As String = txtInput.Text

        ' Please write your code here!
        Dim result As String
        For i As Integer = st.Length - 1 To 0 Step -1
            result = result & st.Chars(i)


        Next
        txtOutput.Text = result
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
