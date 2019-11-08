Public Class AC11

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)

    End Sub

    Private Sub AC11ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AC11ToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub PPE3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        choixChauffeur.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AC11ajout.Show()
    End Sub
End Class