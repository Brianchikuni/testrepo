<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaymentStatus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtcustomerId = New Label()
        btnUpdateStatus = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtBillAmount = New TextBox()
        cmbCustomer = New ComboBox()
        lblBillAmount = New Label()
        lblStatus = New Label()
        chkPaid = New CheckBox()
        Label2 = New Label()
        lblPaymentDate = New Label()
        lblCustomerID = New Label()
        dpPaymentDate = New Label()
        dpPayment = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 31)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 1
        Label1.Text = "Customer Name"
        ' 
        ' txtcustomerId
        ' 
        txtcustomerId.AutoSize = True
        txtcustomerId.Location = New Point(162, 42)
        txtcustomerId.Margin = New Padding(2, 0, 2, 0)
        txtcustomerId.Name = "txtcustomerId"
        txtcustomerId.Size = New Size(0, 15)
        txtcustomerId.TabIndex = 2
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Location = New Point(162, 239)
        btnUpdateStatus.Margin = New Padding(2)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(135, 28)
        btnUpdateStatus.TabIndex = 3
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 56)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 1
        Label3.Text = "Select customer "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 93)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 1
        Label4.Text = "Bill Amount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 120)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 1
        Label5.Text = "Amount Paid"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 161)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 15)
        Label6.TabIndex = 1
        Label6.Text = "Payment Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 187)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 15)
        Label7.TabIndex = 1
        Label7.Text = "Update Status"
        ' 
        ' txtBillAmount
        ' 
        txtBillAmount.Location = New Point(145, 120)
        txtBillAmount.Margin = New Padding(2)
        txtBillAmount.Name = "txtBillAmount"
        txtBillAmount.Size = New Size(178, 23)
        txtBillAmount.TabIndex = 0
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New Point(145, 53)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New Size(121, 23)
        cmbCustomer.TabIndex = 4
        ' 
        ' lblBillAmount
        ' 
        lblBillAmount.AutoSize = True
        lblBillAmount.Location = New Point(145, 93)
        lblBillAmount.Margin = New Padding(2, 0, 2, 0)
        lblBillAmount.Name = "lblBillAmount"
        lblBillAmount.Size = New Size(13, 15)
        lblBillAmount.TabIndex = 1
        lblBillAmount.Text = "$"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(145, 161)
        lblStatus.Margin = New Padding(2, 0, 2, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 15)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Status"
        ' 
        ' chkPaid
        ' 
        chkPaid.AutoSize = True
        chkPaid.Location = New Point(145, 183)
        chkPaid.Name = "chkPaid"
        chkPaid.Size = New Size(49, 19)
        chkPaid.TabIndex = 5
        chkPaid.Text = "paid"
        chkPaid.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 215)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 1
        Label2.Text = "Payment Date"
        ' 
        ' lblPaymentDate
        ' 
        lblPaymentDate.AutoSize = True
        lblPaymentDate.Location = New Point(145, 215)
        lblPaymentDate.Margin = New Padding(2, 0, 2, 0)
        lblPaymentDate.Name = "lblPaymentDate"
        lblPaymentDate.Size = New Size(0, 15)
        lblPaymentDate.TabIndex = 1
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Location = New Point(145, 27)
        lblCustomerID.Margin = New Padding(2, 0, 2, 0)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(72, 15)
        lblCustomerID.TabIndex = 1
        lblCustomerID.Text = "Customer Id"
        ' 
        ' dpPaymentDate
        ' 
        dpPaymentDate.AutoSize = True
        dpPaymentDate.Location = New Point(145, 215)
        dpPaymentDate.Margin = New Padding(2, 0, 2, 0)
        dpPaymentDate.Name = "dpPaymentDate"
        dpPaymentDate.Size = New Size(0, 15)
        dpPaymentDate.TabIndex = 1
        ' 
        ' dpPayment
        ' 
        dpPayment.Location = New Point(145, 208)
        dpPayment.Name = "dpPayment"
        dpPayment.Size = New Size(200, 23)
        dpPayment.TabIndex = 6
        ' 
        ' FormPaymentStatus
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(dpPayment)
        Controls.Add(chkPaid)
        Controls.Add(cmbCustomer)
        Controls.Add(btnUpdateStatus)
        Controls.Add(txtcustomerId)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblStatus)
        Controls.Add(lblPaymentDate)
        Controls.Add(lblCustomerID)
        Controls.Add(dpPaymentDate)
        Controls.Add(lblBillAmount)
        Controls.Add(Label1)
        Controls.Add(txtBillAmount)
        Margin = New Padding(2)
        Name = "FormPaymentStatus"
        Text = "FormPaymentStatus"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcustomerId As Label
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBillAmount As TextBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents lblBillAmount As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPaymentDate As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents dpPaymentDate As Label
    Friend WithEvents dpPayment As DateTimePicker
End Class
