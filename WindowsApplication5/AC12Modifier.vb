Public Class AC12Modifier
    Dim myCommand As Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim myTRNNUM As Integer = TRNNUM
    Dim donnee4 As DataTable
    Dim donnee5 As DataTable

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub AC12Modifier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable6'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable6TableAdapter.Fill(Me.DataSet1.DataTable6)
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


        Dim maRequete As String = "SELECT ETPID, LIEUNOM FROM ETAPE, LIEU WHERE ETAPE.LIEUID = LIEU.LIEUID AND ETAPE.TRNNUM = " & TRNNUM & ";"
        donnee5 = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(maRequete, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee5)

        Me.DataGridView1.DataSource = donnee5

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
        Dim requet
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

    Private Sub FillByToolStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked

    End Sub
End Class