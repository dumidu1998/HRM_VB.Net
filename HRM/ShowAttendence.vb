Public Class ShowAttendence
    Private Sub AttendenceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AttendenceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)

    End Sub

    Private Sub ShowAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.Attendence' table. You can move, or remove it, as needed.
        Me.AttendenceTableAdapter.Fill(Me.HRMDataSet.Attendence)

    End Sub


End Class