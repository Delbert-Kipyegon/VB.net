Public Class frmAddStock
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmAddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelbertsDBDataSet.Product_Details' table. You can move, or remove it, as needed.
        Me.Product_DetailsTableAdapter.Fill(Me.DelbertsDBDataSet.Product_Details)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' update qty if product exists

        ProductDetailsBindingSource.EndEdit()
        Product_DetailsTableAdapter.Update(DelbertsDBDataSet)
        MessageBox.Show("Product Updated Successfully!")



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ProductDetailsBindingSource.AddNew()
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub
End Class