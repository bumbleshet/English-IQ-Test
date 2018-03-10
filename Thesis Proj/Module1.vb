Public Module Module1

    Public ageExaminee As Integer = 0
    Public counter As Integer = 0
    Public userName As String
    Public correctAnswersEasy = New Integer() {0, 0, 3, 0, 4, 0, 2, 0, 1, 2, 1, 3, 0, 0, 1, 0, 0, 3, 0, 2}
    Public correctAnswersHard = New Integer() {2, 3, 0, 2, 2, 0, 2, 0, 3, 0, 2, 1, 3, -1, 0, 3, 1, 2, 0, 0}
    Public userAnswerEasy = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public userAnswerHard = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public totalCorrectEasy As Integer
    Public totalCorrectHard As Integer
  
    Public Function remarks(ByVal result As Integer) As String
        Dim str As String
        Select Case result
            Case Is > 132
                str = "Congratulations youre IQ Test results revealed that you belong to the 2% of the population who are considered as very superior."
            Case 116 To 132
                str = "Congratulations you belong to the 14% of the population who are above average."
            Case 84 To 116
                str = "Congratulations you're IQ Test results shows that you belong to the 68% of the population who are average."
            Case 68 To 83
                str = "Your IQ Test results revealed that you belong to the population of 14% who are considered as below average"
            Case Else
                str = "You belong to the 2% of the population with low average"

        End Select
        Return str
    End Function
    Public Function score2() As Integer
        Dim score As Integer
        For i As Integer = 0 To 19
            If (userAnswerEasy(i) = correctAnswersEasy(i)) Then

                score = score + 1
                totalCorrectEasy = totalCorrectEasy + 1
            End If
        Next
        For o As Integer = 0 To 19
                If (userAnswerHard(o) = correctAnswersHard(o)) Then
                score = score + 1
                totalCorrectHard = totalCorrectHard + 1
            End If

        Next
        score = (score / ageExaminee) * 100
        Return score
    End Function
    Public Sub checkBox(ByRef listBox As CheckedListBox)
        Dim count As Integer = listBox.Items().Count
        Select Case count
            Case 2
                If listBox.SelectedIndex = 0 Then
                    listBox.SetItemChecked(1, False)

                ElseIf listBox.SelectedIndex = 1 Then
                    listBox.SetItemChecked(0, False)

                End If
            Case 3

                If listBox.SelectedIndex = 0 Then
                    listBox.SetItemChecked(1, False) : listBox.SetItemChecked(2, False)

                ElseIf listBox.SelectedIndex = 1 Then
                    listBox.SetItemChecked(2, False) : listBox.SetItemChecked(0, False)
                ElseIf listBox.SelectedIndex = 2 Then
                    listBox.SetItemChecked(1, False) : listBox.SetItemChecked(0, False)

                End If
            Case 4
                If listBox.SelectedIndex = 0 Then
                    listBox.SetItemChecked(1, False) : listBox.SetItemChecked(2, False) : listBox.SetItemChecked(3, False)

                ElseIf listBox.SelectedIndex = 1 Then
                    listBox.SetItemChecked(2, False) : listBox.SetItemChecked(3, False) : listBox.SetItemChecked(0, False)
                ElseIf listBox.SelectedIndex = 2 Then
                    listBox.SetItemChecked(1, False) : listBox.SetItemChecked(0, False) : listBox.SetItemChecked(3, False)
                ElseIf listBox.SelectedIndex = 3 Then
                    listBox.SetItemChecked(0, False) : listBox.SetItemChecked(1, False) : listBox.SetItemChecked(2, False)
                End If

            Case 5
                If listBox.SelectedIndex = 0 Then
                    listBox.SetItemChecked(1, False) : listBox.SetItemChecked(2, False) : listBox.SetItemChecked(3, False) : listBox.SetItemChecked(4, False)

                ElseIf listBox.SelectedIndex = 1 Then
                    listBox.SetItemChecked(2, False) : listBox.SetItemChecked(3, False) : listBox.SetItemChecked(4, False) : listBox.SetItemChecked(0, False)
                ElseIf listBox.SelectedIndex = 2 Then
                    listBox.SetItemChecked(1, False) : listBox.SetItemChecked(0, False) : listBox.SetItemChecked(3, False) : listBox.SetItemChecked(4, False)
                ElseIf listBox.SelectedIndex = 3 Then
                    listBox.SetItemChecked(0, False) : listBox.SetItemChecked(1, False) : listBox.SetItemChecked(2, False) : listBox.SetItemChecked(4, False)
                ElseIf listBox.SelectedIndex = 4 Then
                    listBox.SetItemChecked(0, False) : listBox.SetItemChecked(1, False) : listBox.SetItemChecked(2, False) : listBox.SetItemChecked(3, False)
                End If

        End Select
    End Sub

End Module
