<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.IBeam
        Button1.Location = New Point(3, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(801, 86)
        Button1.TabIndex = 0
        Button1.Text = "Make A payment"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.IBeam
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(181, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 30)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to our Water Billing System "
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.IBeam
        Button2.Location = New Point(3, 253)
        Button2.Name = "Button2"
        Button2.Size = New Size(801, 86)
        Button2.TabIndex = 0
        Button2.Text = "Customers "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.IBeam
        Button3.Location = New Point(3, 361)
        Button3.Name = "Button3"
        Button3.Size = New Size(801, 86)
        Button3.TabIndex = 0
        Button3.Text = "Meter Readings"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
