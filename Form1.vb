Public Class frmBurgers
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        btnPrime.Enabled = False
        picPrime.Visible = True
        btnSelectMeal.Enabled = True
        picVeggie.Visible = False
        btnVeggie.Enabled = True
    End Sub

    Private Sub frmBurgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        btnVeggie.Enabled = False
        picVeggie.Visible = True
        btnSelectMeal.Enabled = True
        picPrime.Visible = False
        btnPrime.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
