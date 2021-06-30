Public Class MakePayment
    Dim total = 0
    Private Sub PaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)
    End Sub

    Private Sub MakePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDataSet.Payment' table. You can move, or remove it, as needed.
        'Me.PaymentTableAdapter.Fill(Me.HRMDataSet.Payment)
        Me.PaymentBindingSource.AddNew()
    End Sub

    Private Sub OTRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles OTRateTextBox.KeyUp
        Dim basic = Val(BasicTextBox.Text)
        Dim OTHR = Val(OTHoursTextBox.Text)
        Dim OTRATE = Val(OTRateTextBox.Text)
        TotalTextBox.Text = basic + (OTHR * OTRATE)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HRMDataSet)
        MsgBox("Payment Sucessfully!")
        Me.PaymentBindingSource.AddNew()
    End Sub
End Class