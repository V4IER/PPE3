﻿Public Class AC12Ajouter

    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12REMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12REMMATTableAdapter.Fill(Me.DataSet1.AC12REMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12INMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12INMMATTableAdapter.Fill(Me.DataSet1.AC12INMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12CHF'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12CHFTableAdapter.Fill(Me.DataSet1.AC12CHF)

    End Sub

    Private Sub AC12VALIDER_Click(sender As System.Object, e As System.EventArgs) Handles AC12VALIDER.Click
        Dim maDte As Date
        Dim monChauffeur As String
        Dim unVehicule As String
        Dim uneRemorque As String
        Dim uneDtePEC As Date
        Dim unCommentaire As String
        maDte = Me.DateTimePicker3.Value.ToString
        monChauffeur = Me.boxChauffeur.SelectedValue
        unVehicule = Me.boxVehicule.SelectedValue
        uneRemorque = Me.boxRemorque.SelectedValue
        uneDtePEC = Me.DateTimePicker1.Value.ToString
        unCommentaire = Me.boxCommentaire.Text

        MsgBox(maDte & " ~ " & monChauffeur & " ~ " & unVehicule & " ~ " & uneRemorque & " ~ " & uneDtePEC & " ~ " & unCommentaire)
    End Sub
End Class