Public Class ShowEmployee
    Private Sub EmpDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)

    End Sub

    Private Sub ShowEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.EmpDetails' table. You can move, or remove it, as needed.
        Me.EmpDetailsTableAdapter.Fill(Me.HRMDataSet.EmpDetails)

    End Sub
End Class