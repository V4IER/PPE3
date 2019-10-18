Public Class AC13

    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable3'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable3TableAdapter.Fill(Me.DataSet1.DataTable3)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Application.Restart()
        Me.Refresh()
    End Sub
End Class