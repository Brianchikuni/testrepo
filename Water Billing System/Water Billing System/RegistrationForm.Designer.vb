<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Name_Box = New TextBox()
        AddressBox = New TextBox()
        ContactBox = New TextBox()
        MeterBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        RegisterButton = New Button()
        Opn = New Button()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(340, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 15)
        Label1.TabIndex = 0
        Label1.Text = "Customer Registration Form"
        ' 
        ' Name_Box
        ' 
        Name_Box.Location = New Point(476, 73)
        Name_Box.Margin = New Padding(2)
        Name_Box.Name = "Name_Box"
        Name_Box.Size = New Size(276, 23)
        Name_Box.TabIndex = 1
        ' 
        ' AddressBox
        ' 
        AddressBox.Location = New Point(476, 119)
        AddressBox.Margin = New Padding(2)
        AddressBox.Name = "AddressBox"
        AddressBox.Size = New Size(276, 23)
        AddressBox.TabIndex = 1
        ' 
        ' ContactBox
        ' 
        ContactBox.Location = New Point(476, 170)
        ContactBox.Margin = New Padding(2)
        ContactBox.Name = "ContactBox"
        ContactBox.Size = New Size(276, 23)
        ContactBox.TabIndex = 1
        ' 
        ' MeterBox
        ' 
        MeterBox.Location = New Point(476, 230)
        MeterBox.Margin = New Padding(2)
        MeterBox.Name = "MeterBox"
        MeterBox.Size = New Size(276, 23)
        MeterBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(251, 74)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 2
        Label2.Text = "Customer Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(296, 119)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 2
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(230, 170)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 15)
        Label4.TabIndex = 2
        Label4.Text = "Contact Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(264, 230)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 2
        Label5.Text = "Meter ID"
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(412, 291)
        RegisterButton.Margin = New Padding(2)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(143, 31)
        RegisterButton.TabIndex = 3
        RegisterButton.Text = "Register"
        RegisterButton.UseVisualStyleBackColor = True
        ' 
        ' Opn
        ' 
        Opn.Location = New Point(705, 304)
        Opn.Name = "Opn"
        Opn.Size = New Size(75, 23)
        Opn.TabIndex = 4
        Opn.Text = "Opn"
        Opn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(213, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(105, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 6
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(893, 370)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Opn)
        Controls.Add(RegisterButton)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(MeterBox)
        Controls.Add(ContactBox)
        Controls.Add(AddressBox)
        Controls.Add(Name_Box)
        Controls.Add(Label1)
        Name = "RegistrationForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Name_Box As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents ContactBox As TextBox
    Friend WithEvents MeterBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents Opn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
