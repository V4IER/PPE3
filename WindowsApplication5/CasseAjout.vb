Public Class CasseAjout

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.ImageLocation = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class