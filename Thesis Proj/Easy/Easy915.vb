Public Class Easy915

    Private Sub btnQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        userAnswerEasy(counter) = listBox.SelectedIndex()
        counter += 1
        Easy916.Show()
        Me.Close()

    End Sub



    Private Sub listBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBox.SelectedIndexChanged
        checkBox(listBox)
    End Sub

    Private Sub Easy915_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(390, 200)
    End Sub
End Class