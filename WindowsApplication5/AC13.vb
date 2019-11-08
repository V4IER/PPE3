Public Class AC13

    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable3'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable3TableAdapter.Fill(Me.DataSet1.DataTable3)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles AC13_Button_Annuler.Click
        Application.Restart()
        Me.Refresh()
    End Sub

    Private Sub AC13_Button_Valider_Click(sender As System.Object, e As System.EventArgs) Handles AC13_Button_Valider.Click
        'Récupère le lieu que l'utilisateur entre
        Dim monLieu As String
        monLieu = Me.AC13_ComboBox_Lieu.SelectedValue

        Dim monLieuSQL As Integer
        monLieuSQL = "Select LIEUID from LIEU WHERE LIEUNOM = " & monLieu
        MsgBox(monLieuSQL)

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