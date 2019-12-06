Public Class AC13M
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As Collection
    Dim donnee1 As DataTable
    Dim donnee2 As DataTable
    Private Sub AC13M_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Connexion à supprimer après l'intégration
        connString = "DSN=CNXORA07;Uid=U_Mesguen;Pwd=estran;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim maRequete As String = "SELECT LIEUID, LIEUNOM FROM LIEU ORDER BY LIEUNOM ASC;"
        donnee1 = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(maRequete, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee1)

        Me.AC13M_ComboBox_Lieu.DataSource = donnee1
        Me.AC13M_ComboBox_Lieu.DisplayMember = "LIEUNOM"
        Me.AC13M_ComboBox_Lieu.ValueMember = "LIEUID"

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles AC13M_Button_Annuler.Click
        AC12Modifier.Show()
        Me.Close()
    End Sub

    Private Sub AC13M_Button_Valider_Click(sender As System.Object, e As System.EventArgs) Handles AC13M_Button_Valider.Click
        'Récupère le lieu que l'utilisateur entre
        Dim monLieu As String
        monLieu = Me.AC13M_ComboBox_Lieu.SelectedValue

        'Récupère la première date que l'utilisateur entre
        Dim monRDV As String
        monRDV = Me.AC13M_DateTimePicker_RDV.Value.ToString()

        'Récupère la seconde date que l'utilisateur entre
        Dim monRDV2 As String
        monRDV2 = Me.AC13M_DateTimePicker_RDV2.Value.ToString()

        'Récupère la date à laquelle l'utilisateur ajoute l'étape
        Dim maPEC As String
        maPEC = Me.AC13M_DateTimePicker_PEC.Value.ToString()

        'Récupère le commentaire de l'utilisateur
        Dim monCommentaire As String
        monCommentaire = Me.AC13M_RichTextBox_Commentaire.Text

        'TODO : Ajouter les variables de AC12 pour TRNNUM et ETPID
        Dim requete As String = "UPDATE ETAPE SET LIEUID ='" & monLieu & "',ETPHREDEBUT = TO_DATE('" & monRDV & "', 'DD/MM/YYYY HH24:MI:SS'),ETPHREFIN = TO_DATE('" & monRDV2 & "', 'DD/MM/YYYY HH24:MI:SS'),ETPCOMMENTAIRE = '" & monCommentaire & "' WHERE TRNNUM = " & TRNNUM & "AND ETPID = 1;"
        myCommand = New Odbc.OdbcCommand(requete, myConnection)
        MessageBox.Show(requete)
        myCommand.ExecuteScalar()
        AC12Modifier.Show()
        Me.Close()
    End Sub
End Class