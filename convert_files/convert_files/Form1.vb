Imports System.Xml
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim age As String
        Dim address As String

        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("out.txt", True)

        name = TextBox1.Text
        age = TextBox2.Text
        address = TextBox3.Text

        file.WriteLine("Name: " + name)
        file.WriteLine("Age: " + age)
        file.WriteLine("Address: " + address)
        file.Close()
        MessageBox.Show("TEXT File Created")
        clearBoxes()
    End Sub
    Sub clearBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String
        Dim age As String
        Dim address As String
        Dim writer As New XmlTextWriter("out.xml", System.Text.Encoding.UTF8)
        name = TextBox1.Text
        age = TextBox2.Text
        address = TextBox3.Text

        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Converter")
        CreateXMLRec(name, age, address, writer)

        writer.WriteEndElement()

        writer.Close()

        MsgBox("XML File Created")
        clearBoxes()


    End Sub

    Private Function CreateXMLRec(ByVal IncomingName As String, ByVal IncomingAge As String, ByVal IncomingAddress As String, ByVal writer As XmlTextWriter)

        writer.WriteStartElement("Name")
        writer.WriteStartElement(IncomingName)
        writer.WriteEndElement()

        writer.WriteStartElement("Age")
        writer.WriteStartElement(IncomingAge)
        writer.WriteEndElement()

        writer.WriteStartElement("Address")
        writer.WriteStartElement(IncomingAddress)
        writer.WriteEndElement()

        writer.WriteEndElement()
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim name As String
        Dim age As String
        Dim address As String

        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("out.json", True)

        name = TextBox1.Text
        age = TextBox2.Text
        address = TextBox3.Text
        file.WriteLine("{")
        file.WriteLine("Name: " + name + ",")
        file.WriteLine("Age: " + age + ",")
        file.WriteLine("Address: " + address + ",")
        file.WriteLine("}")
        file.Close()
        MessageBox.Show("JSON File Created")
        clearBoxes()
    End Sub
End Class
