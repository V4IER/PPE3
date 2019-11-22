Public Class AC12Ajouter
    Dim cmd_insert_tournee As New Odbc.OdbcCommand
    Dim myConnection As New Odbc.OdbcConnection
    Dim connString As String


    Private Sub AC11ajout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12REMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12REMMATTableAdapter.Fill(Me.DataSet1.AC12REMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12INMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12INMMATTableAdapter.Fill(Me.DataSet1.AC12INMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12CHF'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12CHFTableAdapter.Fill(Me.DataSet1.AC12CHF)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12REMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12REMMATTableAdapter.Fill(Me.DataSet1.AC12REMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12INMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12INMMATTableAdapter.Fill(Me.DataSet1.AC12INMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12CHF'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12CHFTableAdapter.Fill(Me.DataSet1.AC12CHF)
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        AC11.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AC12VALIDER_Click(sender As System.Object, e As System.EventArgs) Handles AC12VALIDER.Click

        connString = "DSN=CNXORA07;Uid=U_Mesguen;Pwd=estran;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim maDte As String
        Dim monChauffeurId As String
        Dim unVehicule As String
        Dim uneRemorque As String
        Dim uneDtePEC As String
        Dim unCommentaire As String
        maDte = Me.DateTimePicker3.Value.ToString
        monChauffeurId = Me.boxChauffeur.SelectedValue
        unVehicule = Me.boxVehicule.SelectedValue
        uneRemorque = Me.boxRemorque.SelectedValue
        uneDtePEC = Me.DateTimePicker1.Value.ToString
        unCommentaire = Me.boxCommentaire.Text

        'MsgBox(maDte & " ~ " & monChauffeurId & " ~ " & unVehicule & " ~ " & uneRemorque & " ~ " & uneDtePEC & " ~ " & unCommentaire)

        'Dim requete As String = "INSERT INTO ETAPE(TRNNUM, LIEUID, ETPHREDEBUT, ETPHREFIN, ETPCOMMENTAIRE) VALUES ('1','" & monLieu & "',TO_DATE('" & monRDV & "', 'DD/MM/YYYY HH24:MI:SS'),TO_DATE('" & monRDV2 & "', 'DD/MM/YYYY HH24:MI:SS'),'" & monCommentaire & "');"
        Dim insert_tournee As String = "INSERT INTO tournee(VEHIMMAT, REMMAT, CHFID, TRNCOMMENTAIRE, TRNDTE, TRNPECCHAUFFEUR) VALUES('" & unVehicule & "','" & uneRemorque & "'," & monChauffeurId & ",'" & unCommentaire & "', TO_DATE('" & maDte & "','DD/MM/YYYY HH24:MI:SS') , TO_DATE('" & uneDtePEC & "', 'DD/MM/YYYY HH24:MI:SS') );"
        'Dim insert_tournee As String = "INSERT INTO tournee(TRNNUM, VEHIMMAT, REMMAT, CHFID, TRNCOMMENTAIRE, TRNDTE) VALUES(" & "3" & "," & unVehicule & "," & uneRemorque & "," & monChauffeurId & "," & unCommentaire & "," & uneDtePEC & ");"

        cmd_insert_tournee = New Odbc.OdbcCommand(insert_tournee, myConnection)
        Try
            cmd_insert_tournee.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'MsgBox(insert_tournee)
        AC11.Show()
        Me.Close()

    End Sub

    Private Sub AC12ANNULER_Click(sender As System.Object, e As System.EventArgs) Handles AC12ANNULER.Click
        AC11.Show()
        Me.Hide()
    End Sub
End Class