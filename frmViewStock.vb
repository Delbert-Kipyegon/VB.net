Public Class frmViewStock
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmViewStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelbertsDBDataSet.Product_Details' table. You can move, or remove it, as needed.
        Me.Product_DetailsTableAdapter.Fill(Me.DelbertsDBDataSet.Product_Details)

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ProductDetailsBindingSource.MovePrevious()


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ProductDetailsBindingSource.MoveNext()
    End Sub
End Class