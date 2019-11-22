Public Class AC11
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AC12Ajouter.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ans As String
        Dim data As String
        data = Convert.ToString(DataGridView1.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Confirmé la suppression de la tournée N° " & data, vbYesNo)
        If ans = vbYes Then
            myCommand = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE TRNNUM = " & data & ";", myConnection)
            myCommand.ExecuteNonQuery()
            myCommand = New Odbc.OdbcCommand("DELETE FROM TOURNEE WHERE TRNNUM = " & data & ";", myConnection)
            myCommand.ExecuteNonQuery()
            MessageBox.Show(data)
            Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TRNNUM = Convert.ToString(DataGridView1.CurrentRow.Cells.Item(0).Value)
        AC12Modifier.Show()
        Me.Close()
    End Sub
End Class