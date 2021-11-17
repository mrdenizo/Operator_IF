Public Class Form1
    Private oper As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Single, oper As String
        a = Rnd() * 300 : b = Rnd() * 200

        TextBox1.Text = Format(a, "###.#") 'проблема с эксепшеном формата решилась после анигиляции лишней пары скобок, уже и тильтовать собрался, что потратил около 50 минут времени на это проблему.
        TextBox3.Text = Format(b, "###.#")

        oper = InputBox("Введите название операции", "операция") 'около 40 минут времени на поиск проблемы с эксепшенном опера
        If oper = "сложение" Then
            c = a + b
            TextBox2.Text = Format("+")
        End If

        If oper = "вычитание" Then
            c = a - b
            TextBox2.Text = Format("-")
        End If

        If oper = "умножение" Then
            c = a * b
            TextBox2.Text = Format("*")
        End If

        If oper = "деление" Then
            c = a / b
            TextBox2.Text = Format("/")
        End If

        TextBox4.Text = Format(c, "######.####")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Show()
        Goodbye.Show()

    End Sub
End Class
