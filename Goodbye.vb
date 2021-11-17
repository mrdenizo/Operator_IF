Public Class Goodbye

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter

        ForeColor = Color.Red 'не меняется цвет на красный при наведении мышкой на лейбл закрытия

    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave

        ForeColor = Color.Gray 'не меняется цвет на серый, после покидания области лейбла закрытия

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        End

    End Sub

End Class