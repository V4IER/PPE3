﻿Public Class AC11
    Dim donnee As DataTable
    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Tournee = "SELECT TRNNUM , CHFPRENOM , TRNCOMMENTAIRE, TRNDTE , VEHIMMAT , ETAPE_DEPART, ETAPE_ARRIVER  FROM PPE.V_TOURNEE"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(Tournee, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)

        myAdapter.Fill(donnee)
        ListeTournees.DataSource = donnee
    End Sub

    Private Sub Supprimer_Click(sender As System.Object, e As System.EventArgs) Handles Supprimer.Click
        Dim ans As String
        trnnum = Convert.ToString(ListeTournees.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Vous les vous confirmer la suppression de la tournée N° " & trnnum & " ?", vbYesNo)
        If ans = vbYes Then
            myCommande = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE TRNNUM = " & trnnum & ";", myConnection)
            myCommande.ExecuteNonQuery()
            myCommande = New Odbc.OdbcCommand("DELETE FROM TOURNEE WHERE TRNNUM = " & trnnum & ";", myConnection)
            myCommande.ExecuteNonQuery()
            Dim Tournee = "SELECT TRNNUM , CHFPRENOM , TRNCOMMENTAIRE, TRNDTE , VEHIMMAT , ETAPE_DEPART, ETAPE_ARRIVER  FROM PPE.V_TOURNEE"

            donnee = New DataTable
            myAdapter = New Odbc.OdbcDataAdapter(Tournee, myConnection)
            myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)

            myAdapter.Fill(donnee)
            ListeTournees.DataSource = donnee
        End If
    End Sub

    Private Sub Modifier_Click(sender As System.Object, e As System.EventArgs) Handles Modifier.Click
        Dim ans As String
        trnnum = Convert.ToString(ListeTournees.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Voulez vous modifier la tournée N° " & trnnum & " ?", vbYesNo)
        If ans = vbYes Then
            AC12_Modifier.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Ajouter_click(sender As System.Object, e As System.EventArgs) Handles Ajouter.Click
        AC12_Ajouter.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LabelTournee_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class