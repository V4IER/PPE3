Public Class AC13
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As Collection
    Dim donnee1 As DataTable
    Dim donnee2 As DataTable
    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable3'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable3TableAdapter.Fill(Me.DataSet1.DataTable3)

        'Connexion à supprimer après l'intégration
        connString = "DSN=CNXORA07;Uid=U_Mesguen;Pwd=estran;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim maRequete As String = "SELECT LIEUID, LIEUNOM FROM LIEU;"
        donnee1 = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(maRequete, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee1)

        Me.AC13_ComboBox_Lieu.DataSource = donnee1
        Me.AC13_ComboBox_Lieu.DisplayMember = "LIEUNOM"
        Me.AC13_ComboBox_Lieu.ValueMember = "LIEUID"

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles AC13_Button_Annuler.Click
        Application.Restart()
        Me.Refresh()
    End Sub

    Private Sub AC13_Button_Valider_Click(sender As System.Object, e As System.EventArgs) Handles AC13_Button_Valider.Click
        'Récupère le lieu que l'utilisateur entre
        Dim monLieu As String
        monLieu = Me.AC13_ComboBox_Lieu.SelectedValue
        MsgBox(monLieu)

        'Récupère la première date que l'utilisateur entre
        Dim monRDV As Date
        monRDV = Me.AC13_DateTimePicker_RDV.Value.ToString("dd/MM/yy H:mm:s")

        'Récupère la seconde date que l'utilisateur entre
        Dim monRDV2 As Date
        monRDV2 = Me.AC13_DateTimePicker_RDV2.Value.ToString("dd/MM/yy H:mm:s")

        'Récupère la date à laquelle l'utilisateur ajoute l'étape
        Dim maPEC As Date
        maPEC = Me.AC13_DateTimePicker_PEC.Value.ToString("dd/MM/yy H:mm:s")

        'Récupère le commentaire de l'utilisateur
        Dim monCommentaire As String
        monCommentaire = Me.AC13_RichTextBox_Commentaire.Text



    End Sub
End Class