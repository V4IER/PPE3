Public Class AC12Modifier
    Dim myCommand As Odbc.OdbcCommand
    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub AC12Modifier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label3.Text = TRNNUM
        myCommand = New Odbc.OdbcCommand("SELECT * FROM TOURNEE WHERE TRNNUM = " & TRNNUM & ";", myConnection)
        ComboBox1.SelectedValue = TRNNUM
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        AC11.Show()
        Me.Hide()
    End Sub

    Private Sub AC12ANNULER_Click(sender As System.Object, e As System.EventArgs) Handles AC12ANNULER.Click
        AC11.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class