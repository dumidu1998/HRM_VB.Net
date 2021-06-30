Public Class EmployeeHome
    Private Sub EmpDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)

    End Sub

    Private Sub EmployeeHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.EmpDetails' table. You can move, or remove it, as needed.
        Me.EmpDetailsTableAdapter.Fill(Me.HRMDataSet.EmpDetails)
        Me.EmployeeIdToolStripTextBox.Text = loggedID
        Me.FillByToolStripButton.PerformClick()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.EmpDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)
        MsgBox("Profile Updated Sucessfully!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyAttendence.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySalary.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class