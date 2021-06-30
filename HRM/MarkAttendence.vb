Public Class MarkAttendence
    Private Sub AttendenceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendenceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendenceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)

    End Sub

    Private Sub MarkAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.Attendence' table. You can move, or remove it, as needed.
        'Me.AttendenceTableAdapter.Fill(Me.HRMDataSet.Attendence)
        Me.AttendenceBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.AttendenceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)
        MsgBox("Marked Sucessfully!")

        Me.AttendenceBindingSource.AddNew()
    End Sub
End Class