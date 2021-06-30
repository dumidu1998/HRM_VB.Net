Public Class MySalary
    Private Sub PaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)

    End Sub

    Private Sub MySalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.HRMDataSet.Payment)
        Me.EmployeeIdToolStripTextBox.Text = loggedID
        Me.FillByToolStripButton.PerformClick()

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.PaymentTableAdapter.FillBy(Me.HRMDataSet.Payment, New System.Nullable(Of Integer)(CType(EmployeeIdToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class