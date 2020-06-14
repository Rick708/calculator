Public Class Form1
    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        txtkotae.Text = (Integer.Parse(txtatai1.Text) +
       Integer.Parse(txtatai2.Text)).ToString()
    End Sub
    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        txtkotae.Text = (Integer.Parse(txtatai1.Text) -
       Integer.Parse(txtatai2.Text)).ToString()
    End Sub
    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        txtkotae.Text = (Integer.Parse(txtatai1.Text) *
       Integer.Parse(txtatai2.Text)).ToString()
    End Sub
    Private Sub btndevide_Click(sender As Object, e As EventArgs) Handles btndevide.Click
        txtkotae.Text = (Integer.Parse(txtatai1.Text) /
       Integer.Parse(txtatai2.Text)).ToString()
    End Sub
End Class