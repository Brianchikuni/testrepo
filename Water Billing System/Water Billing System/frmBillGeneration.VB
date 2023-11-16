Imports MySql.Data.MySqlClient ' Replace with the appropriate namespace for your MySQL database connection

Public Class frmBillGeneration
    Private Sub frmBillGeneration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch customer names from the database and populate the dropdown.
        PopulateCustomerNames()
    End Sub

    Private Function GetConnectionString() As String
        Dim server As String = "localhost"
        Dim username As String = "root"
        Dim password As String = "rootuser"
        Dim database As String = "water_billing"

        Return $"server={server};database={database};uid={username};password={password};"
    End Function
    Private Sub PopulateCustomerNames()
        ' Replace the connection string with your actual connection details.
        Dim connectionString As String = GetConnectionString()

        Dim query As String = "SELECT CustomerID FROM Customers"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        cmbCustomer.Items.Add(reader("CustomerID").ToString())
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error while fetching customer names: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnGenerateBill_Click(sender As Object, e As EventArgs) Handles btnGenerateBill.Click
        Dim customerName As String = cmbCustomer.SelectedItem.ToString()
        Dim meterReading As Integer = Integer.Parse(txtMeterReading.Text)
        Dim readingDate As DateTime = dpReadingDate.Value

        ' Replace the connection string with your actual connection details.
        Dim connectionString As String = GetConnectionString()

        Dim query As String = "SELECT RatePerUnit FROM Rates WHERE @ReadingDate >= StartDate AND @ReadingDate <= EndDate"

        Dim ratePerUnit As Decimal = 0

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ReadingDate", readingDate)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        ratePerUnit = Convert.ToDecimal(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error while fetching rate per unit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using
        End Using

        ' Calculate the bill amount.
        Dim billAmount As Decimal = meterReading * ratePerUnit

        ' Display the bill amount in the label.
        lblBillAmount.Text = "Bill Amount: $" & billAmount.ToString("0.00")

        ' Save the bill to the database.
        Dim insertQuery As String = "INSERT INTO Bills (CustomerID, MeterReading, ReadingDate, BillAmount) VALUES (@CustomerName, @MeterReading, @ReadingDate, @BillAmount)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@CustomerName", customerName)
                command.Parameters.AddWithValue("@MeterReading", meterReading)
                command.Parameters.AddWithValue("@ReadingDate", readingDate)
                command.Parameters.AddWithValue("@BillAmount", billAmount)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Bill generated and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error while saving the bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Dim insertBillingHistoryQuery As String = "INSERT INTO BillingHistory (CustomerID, MeterReading, ReadingDate, BillAmount, BillGenerationDate) VALUES (@CustomerID, @MeterReading, @ReadingDate, @BillAmount, @BillGenerationDate)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(insertBillingHistoryQuery, connection)
                ' Assuming you have the CustomerID, replace 'Replace_With_CustomerID' with the actual CustomerID.
                command.Parameters.AddWithValue("@CustomerID", customerName)
                command.Parameters.AddWithValue("@MeterReading", meterReading)
                command.Parameters.AddWithValue("@ReadingDate", readingDate)
                command.Parameters.AddWithValue("@BillAmount", billAmount)
                command.Parameters.AddWithValue("@BillGenerationDate", DateTime.Now) ' Replace with the actual date the bill is generated.

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Bill generated and saved to BillingHistory table successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error while saving the bill to BillingHistory table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using
        End Using

    End Sub
End Class
