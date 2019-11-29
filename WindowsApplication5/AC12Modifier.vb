Public Class AC12Modifier
    Dim myCommand As Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim myTRNNUM As Integer = TRNNUM
    Dim donnee4 As DataTable

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub AC12Modifier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.Casse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CasseTableAdapter.Fill(Me.DataSet1.Casse)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable4'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable4TableAdapter.Fill(Me.DataSet1.DataTable4)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12REMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12REMMATTableAdapter.Fill(Me.DataSet1.AC12REMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12INMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12INMMATTableAdapter.Fill(Me.DataSet1.AC12INMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12CHF'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12CHFTableAdapter.Fill(Me.DataSet1.AC12CHF)
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
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub modifier_Click(sender As System.Object, e As System.EventArgs) Handles modifier.Click
        AC13M.Show()
        Me.Hide()
    End Sub

    Private Sub ajouter_Click(sender As System.Object, e As System.EventArgs) Handles ajouter.Click
        AC13A.Show()
        Me.Hide()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.DataTable4TableAdapter.FillBy(Me.DataSet1.DataTable4)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CasseAjout.Show()
        Me.Close()
    End Sub

    Private Sub AC12VALIDER_Click(sender As System.Object, e As System.EventArgs) Handles AC12VALIDER.Click

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CasseAjout.Show()
        Me.Close()
    End Sub
End Class