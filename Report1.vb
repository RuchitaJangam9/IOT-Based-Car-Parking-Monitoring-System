Public Class Report1
    Private Sub Report1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.Database1DataSet2.Table2)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table2TableAdapter.FillBy(Me.Database1DataSet2.Table2)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class