Public Class Hard914

    Private Sub btnQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        userAnswerHard(counter) = listBox.SelectedIndex()
        counter += 1
        Hard915.Show()
        Me.Close()

    End Sub



    Private Sub listBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBox.SelectedIndexChanged
        checkBox(listBox)
    End Sub

    Private Sub Hard914_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(390, 200)
    End Sub
End Class