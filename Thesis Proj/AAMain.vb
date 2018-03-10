Imports Thesis_Proj.Module1
Public Class AAMain


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        userName = txtName.Text
    '        ageExaminee = Val(txtAge.Text)
    '        Me.Hide()
    '        Easy1.Show()
    '    Catch ex As Exception
    '        MessageBox.Show("Invalid Input" + vbCrLf + "Please Try Again")
    '    End Try

    'End Sub





    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            userName = txtName.Text
            ageExaminee = Val(txtAge.Text)
            counter = 0
            If (ageExaminee < 1) Then
                Throw New Exception
            End If
            MessageBox.Show("                   Welcome! You will be answering a series of questions that" + vbCrLf +
                    "                               will test how well you know your vocabulary," + vbCrLf +
                    "                       grammar and how wide your knowledge is in english" + vbCrLf +
                    "                                  which at the end will determine your IQ." + vbCrLf +
                    "           Some of the questions are tricky and may not require an answer." + vbCrLf +
                    "                                        Good luck and have fun!")
            MessageBox.Show("Part II" + vbCrLf + "Easy 1-20 questions")
            Easy1.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Invalid Input" + vbCrLf + "Please Try Again")
        End Try



        
    End Sub


    Private Sub AAMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(390, 200)

    End Sub
End Class
