Public Class Form1
    Private oper As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Single, oper As String
        a = Rnd() * 300 : b = Rnd() * 200

        TextBox1.Text = Math.Round(a, 1) 'проблема с эксепшеном формата решилась после анигиляции лишней пары скобок, уже и тильтовать собрался, что потратил около 50 минут времени на это проблему.
        TextBox3.Text = Math.Round(b, 1) 'функция Math.Round лучше

        oper = InputBox("Введите название операции", "операция") 'около 40 минут времени на поиск проблемы с эксепшенном опера
        Select Case (oper)
            Case "сложение"
                TextBox4.Text = Math.Round(a + b, 4)
                TextBox2.Text = "+"
            Case "вычитание"
                TextBox4.Text = Math.Round(a - b, 4)
                TextBox2.Text = "-"
            Case "умножение"
                TextBox4.Text = Math.Round(a * b, 4)
                TextBox2.Text = "*"
            Case "деление"
                TextBox4.Text = Math.Round(a / b, 4)
                TextBox2.Text = "/"
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Show()
        Goodbye.Show()

    End Sub
End Class
