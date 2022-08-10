Imports System.IO
Public Class Form1


    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim ContactFile As StreamWriter
        ContactFile = My.Computer.FileSystem.OpenTextFileWriter("ContactTracerOutput.txt", True)
        ContactFile.WriteLine(vbCrLf + vbCrLf + "****************************")

        ContactFile.WriteLine("FullName: " + TextBoxName.Text)
        ContactFile.WriteLine("Age: " + TextBoxAge.Text)
        ContactFile.WriteLine("Address: " + TextBoxaddresss.Text)
        ContactFile.WriteLine("Contact Number: " + TextBoxContactnumber.Text)

        If RadioButtonMale.Checked Then
            ContactFile.WriteLine("Gender: " + RadioButtonMale.Text)
        Else
            ContactFile.WriteLine("Gender: " + RadioButtonFemale.Text)
        End If
        ContactFile.Close()




        MessageBox.Show("Information Successfully Added!!!!")
    End Sub


End Class
