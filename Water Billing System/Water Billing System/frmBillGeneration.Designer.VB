<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillGeneration
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblBillAmount = New Label()
        btnGenerateBill = New Button()
        cmbCustomer = New ComboBox()
        txtMeterReading = New TextBox()
        Label5 = New Label()
        dpReadingDate = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 43)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 1
        Label2.Text = "Customer "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 91)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 1
        Label3.Text = "Meter Reading"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 170)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 1
        Label4.Text = "Bill Amount"
        ' 
        ' lblBillAmount
        ' 
        lblBillAmount.AutoSize = True
        lblBillAmount.Location = New Point(221, 170)
        lblBillAmount.Margin = New Padding(2, 0, 2, 0)
        lblBillAmount.Name = "lblBillAmount"
        lblBillAmount.Size = New Size(22, 15)
        lblBillAmount.TabIndex = 1
        lblBillAmount.Text = "0.0"
        ' 
        ' btnGenerateBill
        ' 
        btnGenerateBill.Location = New Point(200, 220)
        btnGenerateBill.Margin = New Padding(2)
        btnGenerateBill.Name = "btnGenerateBill"
        btnGenerateBill.Size = New Size(78, 20)
        btnGenerateBill.TabIndex = 2
        btnGenerateBill.Text = "Generate Bill"
        btnGenerateBill.UseVisualStyleBackColor = True
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New Point(195, 37)
        cmbCustomer.Margin = New Padding(2)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New Size(257, 23)
        cmbCustomer.TabIndex = 4
        ' 
        ' txtMeterReading
        ' 
        txtMeterReading.Location = New Point(195, 83)
        txtMeterReading.Margin = New Padding(2)
        txtMeterReading.Name = "txtMeterReading"
        txtMeterReading.Size = New Size(252, 23)
        txtMeterReading.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 128)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 1
        Label5.Text = "Reading Date"
        ' 
        ' dpReadingDate
        ' 
        dpReadingDate.Location = New Point(195, 122)
        dpReadingDate.Name = "dpReadingDate"
        dpReadingDate.Size = New Size(252, 23)
        dpReadingDate.TabIndex = 6
        ' 
        ' frmBillGeneration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(dpReadingDate)
        Controls.Add(txtMeterReading)
        Controls.Add(cmbCustomer)
        Controls.Add(btnGenerateBill)
        Controls.Add(lblBillAmount)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "frmBillGeneration"
        Text = "frmBillGeneration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBillAmount As Label
    Friend WithEvents btnGenerateBill As Button
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents txtMeterReading As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dpReadingDate As DateTimePicker
End Class
