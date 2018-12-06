Public Class frmlab2
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim sel1, totalsel, comisionv As Integer
        Dim sel2, comisionc, comisiontotal As Integer
        sel1 = Val(txtgluta.Text)
        sel2 = Val(txtcom.Text)

        totalsel = sel1 + sel2
        lblseltotal.Text = totalsel

        comisionv = sel1 * 5 / 100
        comisionc = sel2 * 10 / 100

        lblcomgluta.Text = comisionv
        lblcomcom.Text = comisionc

        comisiontotal = comisionv + comisionc
        lblcomtotal.Text = comisiontotal
    End Sub
End Class