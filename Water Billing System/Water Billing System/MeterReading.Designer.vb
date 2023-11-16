<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeterReading
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
        SaveBtn = New Button()
        MeterReadingBox = New TextBox()
        DpReadingDate = New DateTimePicker()
        cmbCustomer = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 33)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "Customer "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(93, 95)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 0
        Label2.Text = "Meter Reading"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(93, 158)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 0
        Label3.Text = "Date"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Location = New Point(184, 205)
        SaveBtn.Margin = New Padding(2)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(78, 20)
        SaveBtn.TabIndex = 1
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = True
        ' 
        ' MeterReadingBox
        ' 
        MeterReadingBox.Location = New Point(272, 95)
        MeterReadingBox.Margin = New Padding(2)
        MeterReadingBox.Name = "MeterReadingBox"
        MeterReadingBox.Size = New Size(211, 23)
        MeterReadingBox.TabIndex = 2
        ' 
        ' DpReadingDate
        ' 
        DpReadingDate.Location = New Point(272, 158)
        DpReadingDate.Margin = New Padding(2)
        DpReadingDate.Name = "DpReadingDate"
        DpReadingDate.Size = New Size(211, 23)
        DpReadingDate.TabIndex = 3
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New Point(272, 31)
        cmbCustomer.Margin = New Padding(2)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New Size(211, 23)
        cmbCustomer.TabIndex = 4
        ' 
        ' MeterReading
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(cmbCustomer)
        Controls.Add(DpReadingDate)
        Controls.Add(MeterReadingBox)
        Controls.Add(SaveBtn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "MeterReading"
        Text = "MeterReading"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents MeterReadingBox As TextBox
    Friend WithEvents DpReadingDate As DateTimePicker
    Friend WithEvents cmbCustomer As ComboBox
End Class
