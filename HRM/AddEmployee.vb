Public Class AddEmployee
    Private Sub EmpDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)

    End Sub

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.EmpDetails' table. You can move, or remove it, as needed.
        ' Me.EmpDetailsTableAdapter.Fill(Me.HRMDataSet.EmpDetails)
        Me.EmpDetailsBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.EmpDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)
            MsgBox("Added Sucessfully!")
        Catch ex As System.Exception
            MsgBox("Error Occured!Duplicate Employee Id!!")
        End Try
    End Sub
End Class