Public Class AC12


    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12REMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12REMMATTableAdapter.Fill(Me.DataSet1.AC12REMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12INMMAT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12INMMATTableAdapter.Fill(Me.DataSet1.AC12INMMAT)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.AC12CHF'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.AC12CHFTableAdapter.Fill(Me.DataSet1.AC12CHF)

    End Sub
End Class