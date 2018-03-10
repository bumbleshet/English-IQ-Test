Public Class Hard2

  



    Private Sub listBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox.SelectedIndexChanged
        checkBox(listBox)
    End Sub

    Private Sub Hard2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(390, 200)
    End Sub

    Private Sub btnQuestion_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        userAnswerHard(counter) = listBox.SelectedIndex()
        counter += 1
        Hard3.Show()
        Me.Close()


    End Sub

    Private Sub Hard2_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class