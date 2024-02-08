Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As Integer
        Dim b As Integer
        a = txtFirstnum.Text
        b = txtSecondnum.Text
        lblResult.Text = a - b


    End Sub
End Class
