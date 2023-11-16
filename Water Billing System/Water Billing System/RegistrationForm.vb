
Imports MySql.Data.MysqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.ComponentModel.Design.Serialization

Public Class RegistrationForm

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqLData As New DataTable
    Dim Dta As New MySqlDataAdapter








    Private Function GetConnectionString() As String
        Dim server As String = "localhost"
        Dim username As String = "root"
        Dim password As String = "rootuser"
        Dim database As String = "water_billing"

        Return $"server={server};database={database};uid={username};password={password};"
    End Function

    Private Sub GetCustomerNames()
        Dim connectionString As String = GetConnectionString()

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Name FROM Customers"

            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim customerName As String = reader("Name").ToString()
                        ' Do something with the customerName, such as populating a listbox or dropdown.
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click, Label5.Click

    End Sub

    Private Sub Name_Box_TextChanged(sender As Object, e As EventArgs) Handles Name_Box.TextChanged


    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim name As String = Name_Box.Text
        Dim address As String = AddressBox.Text
        Dim contactInfo As String = ContactBox.Text
        Dim meterID As String = MeterBox.Text

        Dim connectionString As String = GetConnectionString()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Customers (Name, Address, ContactInfo, meter_ID) VALUES (@Name, @Address, @ContactInfo, @MeterID)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", name)
                    command.Parameters.AddWithValue("@Address", address)
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo)
                    command.Parameters.AddWithValue("@MeterID", meterID)

                    command.ExecuteNonQuery()

                    MessageBox.Show("Customer registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear input fields for the next registration.
                    Name_Box.Text = ""
                    AddressBox.Text = ""
                    ContactBox.Text = ""
                    MeterBox.Text = ""
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Opn_Click(sender As Object, e As EventArgs) Handles Opn.Click
        MeterReading.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBillGeneration.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPaymentStatus.Show()


    End Sub
End Class
