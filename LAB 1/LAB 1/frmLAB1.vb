Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim sal, tax, total
        sal = Val(txtsal.Text) * 12

        tax = sal * 0.05
        total = sal - tax

        lblyear.Text = sal & Space(8) & "บาท"
        lbltax.Text = tax & Space(9) & "บาท"
        llbltotal.Text = total & Space(7) & "บาท"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
