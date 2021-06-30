Public Class MyAttendence
    Private Sub AttendenceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendenceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendenceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)

    End Sub

    Private Sub MyAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.Attendence' table. You can move, or remove it, as needed.
        Me.AttendenceTableAdapter.Fill(Me.HRMDataSet.Attendence)
        Me.EmployeeIdToolStripTextBox.Text = loggedID
        Me.FillByToolStripButton.PerformClick()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.AttendenceTableAdapter.FillBy(Me.HRMDataSet.Attendence, New System.Nullable(Of Integer)(CType(EmployeeIdToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class