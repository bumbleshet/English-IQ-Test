Imports System.Data
Imports System.Data.OleDb


Public Class Result





    Private Sub Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(380, 20)
        Dim score As Integer
        'MessageBox.Show(remarks(85))
        'Easy1-20
        Dim oldcolor
        Dim fontsz

        score = score2()
        txtCorrectEasy.Text = totalCorrectEasy.ToString + "/20"
        txtCorrectHard.Text = totalCorrectHard.ToString + "/20"
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionFont
        txtBox.SelectionFont = New Font("Microsoft sans serif", 20.0F)
        txtBox.AppendText("Easy:")
        txtBox.SelectionFont = oldcolor
        txtBox.AppendText(Environment.NewLine + Environment.NewLine)

        txtBox.AppendText("1. Which one of the five choices makes the best comparison?" + Environment.NewLine)
        txtBox.AppendText("     Finger is to Hand as Leaf is to:" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Twig" + Environment.NewLine)
        txtBox.AppendText("     Tree     " + Environment.NewLine)
        txtBox.AppendText("     Branch     " + Environment.NewLine)
        txtBox.AppendText("     Blossom " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Twig" + "      Your answer: ")
        If (userAnswerEasy(0) = correctAnswersEasy(0)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e1(userAnswerEasy(0)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("2. Computers are 'ubiquitous nowadays.'" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Everywhere" + Environment.NewLine)
        txtBox.AppendText("     Useful" + Environment.NewLine)
        txtBox.AppendText("     Rare" + Environment.NewLine)
        txtBox.AppendText("     Unfamiliar " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Everywhere" + "      Your answer: ")
        If (userAnswerEasy(1) = correctAnswersEasy(1)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e2(userAnswerEasy(1)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("3. Choose the word most similar to 'Trustworthy':" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Resolute" + Environment.NewLine)
        txtBox.AppendText("     Tenacity" + Environment.NewLine)
        txtBox.AppendText("     Relevant" + Environment.NewLine)
        txtBox.AppendText("     Reliable" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Reliable" + "      Your answer: ")
        If (userAnswerEasy(2) = correctAnswersEasy(2)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e3(userAnswerEasy(2)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("4. 'I think , that is not a good idea.' Michelle said. ' Don’t say that. There is more than  " + Environment.NewLine)
        txtBox.AppendText("    meets the eye.' What does the idiom , more than meets the eye means? " + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     There is more than what you actually can see " + Environment.NewLine)
        txtBox.AppendText("     Do not judge" + Environment.NewLine)
        txtBox.AppendText("     Never be quick to decide" + Environment.NewLine)
        txtBox.AppendText("     Pay attention to details" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: There is more than what you actually can see" + Environment.NewLine)
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("      Your answer: ")
        If (userAnswerEasy(3) = correctAnswersEasy(3)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e4(userAnswerEasy(3)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("5. Which one of the following things is the least like the others?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Poem" + Environment.NewLine)
        txtBox.AppendText("     Novel" + Environment.NewLine)
        txtBox.AppendText("     Painting" + Environment.NewLine)
        txtBox.AppendText("     Statue " + Environment.NewLine)
        txtBox.AppendText("     Flower " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Flower" + "      Your answer: ")
        If (userAnswerEasy(4) = correctAnswersEasy(4)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e5(userAnswerEasy(4)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("6. I knew my opinion would _____her choice, so I deliberately stayed quiet" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Affect" + Environment.NewLine)
        txtBox.AppendText("     Effect" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Affect" + "      Your answer: ")
        If (userAnswerEasy(5) = correctAnswersEasy(5)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e6(userAnswerEasy(5)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("7. Jong stole the eggs of his neighbour quietly. The Old man discovered what happened so " + Environment.NewLine)
        txtBox.AppendText("    he blew the whistle . Jong was then arrested. What does the statement 'blew the whistle' " + Environment.NewLine)
        txtBox.AppendText("    mean?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Nagged" + Environment.NewLine)
        txtBox.AppendText("     Bribed the authorities " + Environment.NewLine)
        txtBox.AppendText("     To report to the authorities" + Environment.NewLine)
        txtBox.AppendText("     To be angry and cause ruckus" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: To report to the authorities" + "      Your answer: ")
        If (userAnswerEasy(6) = correctAnswersEasy(6)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e7(userAnswerEasy(6)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("8. Please come see me _____ day you like" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Any" + Environment.NewLine)
        txtBox.AppendText("     Each" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Any" + "      Your answer: ")
        If (userAnswerEasy(7) = correctAnswersEasy(7)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e8(userAnswerEasy(7)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("9. Sorry, but this shoes are way _____ expensive" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     to" + Environment.NewLine)
        txtBox.AppendText("     too    " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: too" + "      Your answer: ")
        If (userAnswerEasy(8) = correctAnswersEasy(8)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e9(userAnswerEasy(8)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("10. The protests are increasing, creating a 'volatile' situation in the capital." + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     unite" + Environment.NewLine)
        txtBox.AppendText("     random" + Environment.NewLine)
        txtBox.AppendText("     out of control" + Environment.NewLine)
        txtBox.AppendText("     happy" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: out of control" + "      Your answer: ")
        If (userAnswerEasy(9) = correctAnswersEasy(9)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e10(userAnswerEasy(9)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("11. Harry is definitely stronger ____ his brother" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     then" + Environment.NewLine)
        txtBox.AppendText("     than" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: than" + "      Your answer: ")
        If (userAnswerEasy(10) = correctAnswersEasy(10)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e11(userAnswerEasy(10)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("12. Which word is the synonym of 'futile'?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Form" + Environment.NewLine)
        txtBox.AppendText("     Confident" + Environment.NewLine)
        txtBox.AppendText("     Clashing" + Environment.NewLine)
        txtBox.AppendText("     Pointless " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Pointless" + "      Your answer: ")
        If (userAnswerEasy(11) = correctAnswersEasy(11)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e12(userAnswerEasy(11)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("13. I have ____ much to do today" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     too" + Environment.NewLine)
        txtBox.AppendText("     to" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: too" + "      Your answer: ")
        If (userAnswerEasy(12) = correctAnswersEasy(12)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e13(userAnswerEasy(12)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("14. Choose the word most similar to 'Trustworthy':" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Famous" + Environment.NewLine)
        txtBox.AppendText("     Noteworthy" + Environment.NewLine)
        txtBox.AppendText("     Acclaimed" + Environment.NewLine)
        txtBox.AppendText("     Reliable " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Famous" + "      Your answer: ")
        If (userAnswerEasy(13) = correctAnswersEasy(13)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e14(userAnswerEasy(13)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor



        txtBox.AppendText("15. Choose the word which is similar to 'heed'" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Continue" + Environment.NewLine)
        txtBox.AppendText("     Listen" + Environment.NewLine)
        txtBox.AppendText("     Pause" + Environment.NewLine)
        txtBox.AppendText("     Ahead " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Listen" + "      Your answer: ")
        If (userAnswerEasy(14) = correctAnswersEasy(14)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e15(userAnswerEasy(14)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("16. Morbid is a synonym of? " + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Gruesome" + Environment.NewLine)
        txtBox.AppendText("     Happiness" + Environment.NewLine)
        txtBox.AppendText("     Unity" + Environment.NewLine)
        txtBox.AppendText("     Comfort " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Gruesome" + "      Your answer: ")
        If (userAnswerEasy(15) = correctAnswersEasy(15)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e16(userAnswerEasy(15)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("17. May I please have a snack? I’m famished." + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Hungry" + Environment.NewLine)
        txtBox.AppendText("     Sated" + Environment.NewLine)
        txtBox.AppendText("     Full" + Environment.NewLine)
        txtBox.AppendText("     Exported " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Hungry" + "      Your answer: ")
        If (userAnswerEasy(16) = correctAnswersEasy(16)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e17(userAnswerEasy(16)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("18. The fall 'foliage' in the woods of New England is beautiful. Foliage means" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Collection of jewelry" + Environment.NewLine)
        txtBox.AppendText("     Snow" + Environment.NewLine)
        txtBox.AppendText("     Taxes" + Environment.NewLine)
        txtBox.AppendText("     Collection of leaves " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Collection of leaves" + "      Your answer: ")
        If (userAnswerEasy(17) = correctAnswersEasy(17)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e18(userAnswerEasy(17)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("19. The reporter insisted that the letter he used was 'authentic'. Authentic means" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Genuine or real" + Environment.NewLine)
        txtBox.AppendText("     Carefully written" + Environment.NewLine)
        txtBox.AppendText("     Very old" + Environment.NewLine)
        txtBox.AppendText("     Full of tasty worms" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Genuine or real" + "      Your answer: ")
        If (userAnswerEasy(18) = correctAnswersEasy(18)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e19(userAnswerEasy(18)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("20. The news was based on a letter that was a fabrication" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Made of cloth" + Environment.NewLine)
        txtBox.AppendText("     Full of long words" + Environment.NewLine)
        txtBox.AppendText("     Fake" + Environment.NewLine)
        txtBox.AppendText("     Funny" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Fake" + "      Your answer: ")
        If (userAnswerEasy(19) = correctAnswersEasy(19)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(e20(userAnswerEasy(19)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor


        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionFont
        txtBox.SelectionFont = New Font("Microsoft sans serif", 20.0F)
        txtBox.AppendText(Environment.NewLine + "Hard:")
        txtBox.SelectionFont = oldcolor
        txtBox.AppendText(Environment.NewLine + Environment.NewLine)

        txtBox.AppendText("1. Rearrange the following letters to make a word and choose the category in which it fits." + Environment.NewLine + Environment.NewLine + "     'FADLOFDI'" + Environment.NewLine)
        txtBox.AppendText("     City " + Environment.NewLine)
        txtBox.AppendText("     Fruit" + Environment.NewLine)
        txtBox.AppendText("     Flower" + Environment.NewLine)
        txtBox.AppendText("     Vegetable" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Flower (DAFFODIL)" + "      Your answer: ")
        If (userAnswerHard(0) = correctAnswersEasy(0)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f1(userAnswerHard(0)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("2. Find the answer that best matches the stem pair in the analogy." + Environment.NewLine + "     SEDATIVE :: DROWSINESS" + Environment.NewLine)
        txtBox.AppendText("     EPIDEMIC : CONTAGIOUSNESS" + Environment.NewLine)
        txtBox.AppendText("     VACCINE : VIRUS" + Environment.NewLine)
        txtBox.AppendText("     LAXATIVE : DRUG" + Environment.NewLine)
        txtBox.AppendText("     ANESTHETIC : NUMBNESS" + Environment.NewLine)
        txtBox.AppendText("     THERAPY : PSYCHOSIS" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: ANESTHETIC : NUMBNESS" + "      Your answer: ")
        If (userAnswerHard(1) = correctAnswersHard(1)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f2(userAnswerHard(1)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("3. Existing from the beginning" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Primordial" + Environment.NewLine)
        txtBox.AppendText("     Scourge" + Environment.NewLine)
        txtBox.AppendText("     Priming" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Primordial" + "      Your answer: ")
        If (userAnswerHard(2) = correctAnswersHard(2)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f3(userAnswerHard(2)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("4. Force of unlimited power" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Universal " + Environment.NewLine)
        txtBox.AppendText("     Omega" + Environment.NewLine)
        txtBox.AppendText("     Omnipotence" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Omnipotence" + "      Your answer: ")
        If (userAnswerHard(3) = correctAnswersHard(3)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f4(userAnswerHard(3)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("5. To speak of or address with irreverence" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Utter" + Environment.NewLine)
        txtBox.AppendText("     Address      " + Environment.NewLine)
        txtBox.AppendText("     Blaspheme      " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Blaspheme" + "      Your answer: ")
        If (userAnswerHard(4) = correctAnswersHard(4)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f5(userAnswerHard(4)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("6. A series of loops; spiral" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Coil" + Environment.NewLine)
        txtBox.AppendText("     Rows" + Environment.NewLine)
        txtBox.AppendText("     Layer  " + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Coil" + "      Your answer: ")
        If (userAnswerHard(5) = correctAnswersHard(5)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f6(userAnswerHard(5)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("7. Which is a synonym of 'dilatory'?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Pleasant     " + Environment.NewLine)
        txtBox.AppendText("     Expansive " + Environment.NewLine)
        txtBox.AppendText("     Tardy " + Environment.NewLine)
        txtBox.AppendText("     Inclusive" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Tardy " + "      Your answer: ")
        If (userAnswerHard(6) = correctAnswersHard(6)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f7(userAnswerHard(6)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("8. He is a pugnacious partner to be with" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Aggressive     Passive" + Environment.NewLine)
        txtBox.AppendText("     Exciting     Bore" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Aggressive " + "      Your answer: ")
        If (userAnswerHard(7) = correctAnswersHard(7)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f8(userAnswerHard(7)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("9. Come hell or high water, I have to maintain my scholarship. " + Environment.NewLine + "     'Come hell or high water' means" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Satisfy all needs" + Environment.NewLine)
        txtBox.AppendText("     Within the rules and regulations" + Environment.NewLine)
        txtBox.AppendText("     Forget the past" + Environment.NewLine)
        txtBox.AppendText("     By all means" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: By all means" + "      Your answer: ")
        If (userAnswerHard(8) = correctAnswersHard(8)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f9(userAnswerHard(8)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("10. Which of the following is a British term meaning 'astounded'" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Gobsmacked" + Environment.NewLine)
        txtBox.AppendText("     Smit-withered" + Environment.NewLine)
        txtBox.AppendText("     Dollyshanked" + Environment.NewLine)
        txtBox.AppendText("     Pipped" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Gobsmacked " + "      Your answer: ")
        If (userAnswerHard(9) = correctAnswersHard(9)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f10(userAnswerHard(9)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("11. To beat as by blows of a whip" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Boon    " + Environment.NewLine)
        txtBox.AppendText("     Windfall" + Environment.NewLine)
        txtBox.AppendText("     Scourge" + Environment.NewLine)
        txtBox.AppendText("     Pipped" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Scourge" + "      Your answer: ")
        If (userAnswerHard(10) = correctAnswersHard(10)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f11(userAnswerHard(10)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("12. 'We cannot expect a newly hired employee to do complex tasks. She is a greenhorn!'" + Environment.NewLine + "     What does the idiomatic expression , greenhorn mean? " + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Idiot companion" + Environment.NewLine)
        txtBox.AppendText("     Newbie" + Environment.NewLine)
        txtBox.AppendText("     Someone who is not knowledgeable enough" + Environment.NewLine)
        txtBox.AppendText("     A stubborn, irresponsible companion" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Newbie" + "      Your answer: ")
        If (userAnswerHard(11) = correctAnswersHard(11)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f12(userAnswerHard(11)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("13. Speed processing is?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Ability to put together the mental processing components needed when problem-solving" + Environment.NewLine)
        txtBox.AppendText("     Coping with novel situations and learning new responses" + Environment.NewLine)
        txtBox.AppendText("     Information stored in long- term memory" + Environment.NewLine)
        txtBox.AppendText("     How rapidly a person can perform a mental task" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: How rapidly a person can perform a mental task" + Environment.NewLine + "     Your answer: ")
        If (userAnswerHard(12) = correctAnswersHard(12)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f13(userAnswerHard(12)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("14. Which one is correct? 'Penguins flies' or 'A Penguin flies'" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Penguins flies" + Environment.NewLine)
        txtBox.AppendText("     A Penguin flies" + Environment.NewLine)
        txtBox.AppendText("     None of the above" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: None of the above (Neither. Penguins don’t fly)" + "      Your answer: ")
        If (userAnswerHard(13) = correctAnswersHard(13)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f14(userAnswerHard(13)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor



        txtBox.AppendText("15. What part of speech is 'ultra mundane', meaning 'pertaining to supernatural things or to another life'?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Adjective" + Environment.NewLine)
        txtBox.AppendText("     Verb" + Environment.NewLine)
        txtBox.AppendText("     Noun" + Environment.NewLine)
        txtBox.AppendText("     Adverb" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Adjective" + "      Your answer: ")
        If (userAnswerHard(14) = correctAnswersHard(14)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f15(userAnswerHard(14)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("16. What part of speech is 'unanimity', meaning 'the state or quality of being of one mind'?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Adjective" + Environment.NewLine)
        txtBox.AppendText("     Verb" + Environment.NewLine)
        txtBox.AppendText("     Noun" + Environment.NewLine)
        txtBox.AppendText("     Adverb" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Noun" + "      Your answer: ")
        If (userAnswerHard(15) = correctAnswersHard(15)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f16(userAnswerHard(15)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("17. Which of the following can be arranged into a 5-letter English word?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     H E G S T" + Environment.NewLine)
        txtBox.AppendText("     R I L S A" + Environment.NewLine)
        txtBox.AppendText("     T O O M I" + Environment.NewLine)
        txtBox.AppendText("     W Q R G S" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: R I L S A (Rails)" + "      Your answer: ")
        If (userAnswerHard(16) = correctAnswersHard(16)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f17(userAnswerHard(16)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("18. Associate is to Colleague as Accomplice is to:" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Consort" + Environment.NewLine)
        txtBox.AppendText("     Friend" + Environment.NewLine)
        txtBox.AppendText("     Accessory" + Environment.NewLine)
        txtBox.AppendText("     Follower" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Accessory" + "      Your answer: ")
        If (userAnswerHard(17) = correctAnswersHard(17)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f18(userAnswerHard(17)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("19. By not studying and complying with your requirements, you are burning the bridge to " + Environment.NewLine + "     star honors! ' Burning the bridge means:" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     Doing something that makes it impossible to go back from the position you have taken" + Environment.NewLine)
        txtBox.AppendText("     Giving up from your dreams" + Environment.NewLine)
        txtBox.AppendText("     Disconnecting to the world/ a person" + Environment.NewLine)
        txtBox.AppendText("     Cut the connection where there is great difference" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: Doing something that makes it impossible to go back from the position you have taken" + Environment.NewLine + "     Your answer: ")
        If (userAnswerHard(18) = correctAnswersHard(18)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f19(userAnswerHard(18)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor

        txtBox.AppendText("20. If all Bloops are Razzies and all Razzies are Lazzies, all Bloops are definitely Lazzies?" + Environment.NewLine + Environment.NewLine)
        txtBox.AppendText("     True" + Environment.NewLine)
        txtBox.AppendText("     False" + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        txtBox.SelectionBackColor = Color.LightGreen
        txtBox.AppendText("     Answer: True" + "      Your answer: ")
        If (userAnswerHard(19) = correctAnswersHard(19)) Then
            txtBox.SelectionBackColor = Color.LightGreen

        Else
            txtBox.SelectionBackColor = Color.Red
        End If
        txtBox.AppendText(f20(userAnswerHard(19)) + Environment.NewLine + Environment.NewLine)
        txtBox.SelectionColor = oldcolor



        fontsz = txtBox.SelectionFont
        txtBox.SelectionFont = New Font("Microsoft sans serif", 20.0F)
        txtBox.AppendText("Your IQ is ")
        txtBox.SelectionStart = txtBox.Text.Length
        oldcolor = txtBox.SelectionColor
        Select Case score
            Case Is > 132
                txtBox.SelectionColor = Color.Green
            Case 116 To 132
                txtBox.SelectionColor = Color.YellowGreen
            Case 84 To 116
                txtBox.SelectionColor = Color.Yellow
            Case 68 To 83
                txtBox.SelectionColor = Color.Orange
            Case Else
                txtBox.SelectionColor = Color.Red

        End Select


        txtBox.AppendText(score.ToString)
        txtBox.SelectionFont = fontsz
        txtBox.SelectionColor = oldcolor

        txtBox.SelectionFont = New Font("Microsoft sans serif", 12.0F)
        txtBox.AppendText(Environment.NewLine + remarks(score))


        ' Get the current caret position.
        txtBox.SelectionStart = 0
        txtBox.ScrollToCaret()

        Dim tempstr As String = "'" + Now.ToString + "'" + ", " + "'" + userName + "'" + ", " + ageExaminee.ToString
        For i As Integer = 0 To 19
            tempstr = tempstr + ", " + "'" + abc(userAnswerEasy(i)) + "'"
        Next
        For o As Integer = 0 To 19
            tempstr = tempstr + ", " + "'" + abc(userAnswerHard(o)) + "'"
        Next
        tempstr = tempstr + ", " + score.ToString

        'write to database excel
        ' RefreshData()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test.xlsx;Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
        Dim insertStatement As String = "INSERT INTO [Sheet1$] ([DATE],[NAME], AGE, [E1],[E2],[E3],[E4],[E5],[E6],[E7],[E8],[E9],[E10],[E11],[E12],[E13],[E14],[E15],[E16],[E17],[E18],[E19],[E20],[H1],[H2],[H3],[H4],[H5],[H6],[H7],[H8],[H9],[H10],[H11],[H12],[H13],[H14],[H15],[H16],[H17],[H18],[H19],[H20],SCORE)VALUES (" & tempstr & ")"
        'Dim insertStatement As String = "INSERT INTO [Sheet1$] ([NAME], [AGE], [DATE], [SCORE])VALUES ('sidne21y', 1233, 87982, 1123)"
        'MessageBox.Show(insertStatement)
        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand(insertStatement, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        connection.Dispose()
        command.Dispose()
        ' RefreshData()

    End Sub
    Public Sub RefreshData()

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test2.xlsx;Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
        Dim selectStatement As String = "SELECT [NAME],AGE,DATE,SCORE FROM [Sheet1$]"
        Dim adapter As New OleDbDataAdapter(selectStatement, connectionString)
        Dim excelData As New DataTable
        adapter.Fill(excelData)
        'hello.DataSource = excelData
    End Sub
    Public Function abc(ByVal choice As Integer) As String
        Dim str As String
        Select choice
            Case 0
                str = "a"
            Case 1
                str = "b"
            Case 2
                str = "c"
            Case 3
                str = "d"
            Case 4
                str = "e"
            Case Else
                str = "None"
        End Select


        Return str
    End Function
    'easy-120
    Public Function countletters(ByVal str As String) As String
        Dim count As Integer = 0
        count = str.Length
        Return count
    End Function
    Public Function e1(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Twig"
            Case 1
                str = "Tree"
            Case 2
                str = "Branch"
            Case 3
                str = "Blossom  "
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e2(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Everywhere"
            Case 1
                str = " Useful"
            Case 2
                str = "Rare"
            Case 3
                str = "Unfamiliar"
            Case Else
                str = "None"
        End Select
        Return str

    End Function
    Public Function e3(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Resolute"
            Case 1
                str = "Tenacity"
            Case 2
                str = "Relevant"
            Case 3
                str = "Reliable"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e4(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "There is more than what you actually can see "
            Case 1
                str = "Do not judge"
            Case 2
                str = "Never be quick to decide"
            Case 3
                str = "Pay attention to details"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e5(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Poem"
            Case 1
                str = "Novel"
            Case 2
                str = "Painting"
            Case 3
                str = "Statue"
            Case 4
                str = "Flower"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e6(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Affect"
            Case 1
                str = "Effect"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e7(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Nagged"
            Case 1
                str = "Bribed the authorities"
            Case 2
                str = "To report to the authorities"
            Case 3
                str = "To be angry and cause ruckus"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e8(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Any"
            Case 1
                str = "Each"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e9(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "To"
            Case 1
                str = "Too"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e10(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "unite"
            Case 1
                str = "random"
            Case 2
                str = "out of control"
            Case 3
                str = "Happy"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e11(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "then"
            Case 1
                str = "than"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e12(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Form"
            Case 1
                str = "Confident"
            Case 2
                str = "Clashing"
            Case 3
                str = "Pointless"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e13(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "too"
            Case 1
                str = "to"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e14(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Famous"
            Case 1
                str = "Noteworthy"
            Case 2
                str = "Acclaimed"
            Case 3
                str = "Fabulous"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e15(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Continue"
            Case 1
                str = "Listen"
            Case 2
                str = "Pause"
            Case 3
                str = "Ahead"
            Case 4
                str = "Flower"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e16(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Gruesome"
            Case 1
                str = "Happiness"
            Case 2
                str = "Unity"
            Case 3
                str = "Comfort"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e17(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Hungry"
            Case 1
                str = "Sated"
            Case 2
                str = "Full"
            Case 3
                str = "Exported"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e18(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Collection of jewelry"
            Case 1
                str = "Snow"
            Case 2
                str = "Taxes"
            Case 3
                str = "Collection of leaves"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e19(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Genuine or real"
            Case 1
                str = "Carefully written"
            Case 2
                str = "Very old"
            Case 3
                str = "Full of tasty worms"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function e20(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Made of cloth"
            Case 1
                str = "Full of long words"
            Case 2
                str = "Fake"
            Case 3
                str = "Funny"
            Case Else
                str = "None"
        End Select
        Return str
    End Function

    'hard-120
    Public Function f1(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "City"
            Case 1
                str = "Fruit"
            Case 2
                str = "Flower"
            Case 3
                str = "Vegetable"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f2(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "EPIDEMIC : CONTAGIOUSNESS"
            Case 1
                str = "VACCINE : VIRUS"
            Case 2
                str = "LAXATIVE : DRUG"
            Case 3
                str = "ANESTHETIC : NUMBNESS"
            Case 4
                str = "THERAPY : PSYCHOSIS"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f3(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Primordial"
            Case 1
                str = "Scourge"
            Case 2
                str = "Priming"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f4(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Universal"
            Case 1
                str = "Omega"
            Case 2
                str = "Omnipotence"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f5(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Utter"
            Case 1
                str = "Address"
            Case 2
                str = "Blaspheme"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f6(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Coil"
            Case 1
                str = "Rows"
            Case 2
                str = "Layer"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f7(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Pleasant"
            Case 1
                str = "Expansive"
            Case 2
                str = "Tardy"
            Case 3
                str = "Inclusive"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f8(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Aggressive"
            Case 1
                str = "Passive"
            Case 2
                str = "Exciting"
            Case 3
                str = "Bore"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f9(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Satisfy all needs"
            Case 1
                str = "Within the rules and regulations"
            Case 2
                str = "Forget the past"
            Case 3
                str = "By all means"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f10(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Gobsmacked"
            Case 1
                str = "Smit-withered"
            Case 2
                str = "Dollyshanked"
            Case 3
                str = "Pipped"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f11(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Boon"
            Case 1
                str = "Windfall"
            Case 2
                str = "Scourge"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f12(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Idiot companion"
            Case 1
                str = "Newbie"
            Case 2
                str = "Someone who is not knowledgeable enough"
            Case 3
                str = "A stubborn, irresponsible companion"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f13(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Ability to put together the mental processing components needed when problem-solving"
            Case 1
                str = "Novel"
            Case 2
                str = "Coping with novel situations and learning new responses"
            Case 3
                str = "Information stored in long- term memory"
            Case 4
                str = "How rapidly a person can perform a mental task"

            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f14(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Penguins flies"
            Case 1
                str = "A Penguin flies"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f15(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Adjective"
            Case 1
                str = "Verb"
            Case 2
                str = "Noun"
            Case 3
                str = "Adverb"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f16(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Adjective"
            Case 1
                str = "Verb"
            Case 2
                str = "Noun"
            Case 3
                str = "Adverb"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f17(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "H E G S T"
            Case 1
                str = "R I L S A"
            Case 2
                str = "T O O M I"
            Case 3
                str = "W Q R G S"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f18(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Consort"
            Case 1
                str = "Friend"
            Case 2
                str = "Accessory"
            Case 3
                str = "Follower"
            Case 4
                str = "Flower"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f19(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "Doing something that makes it impossible to go back from the position you have taken"
            Case 1
                str = "Giving up from your dreams"
            Case 2
                str = "Disconnecting to the world/ a person"
            Case 3
                str = "Cut the connection where there is great difference"
            Case Else
                str = "None"
        End Select
        Return str
    End Function
    Public Function f20(ByVal answer As Integer)
        Dim str As String
        Select Case answer
            Case 0
                str = "True"
            Case 1
                str = "False"
            Case Else
                str = "None"
        End Select
        Return str
    End Function



    Private Sub txtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        userName = ""
        totalCorrectEasy = 0
        totalCorrectHard = 0
        AAMain.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class