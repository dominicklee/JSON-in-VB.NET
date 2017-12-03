Imports Newtonsoft.Json

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As New preferenceModel

        p.firstName = TextBox1.Text
        p.middleName = TextBox2.Text
        p.lastName = TextBox3.Text

        Dim result = JsonConvert.SerializeObject(p)

        RichTextBox1.Text = result

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As preferenceModel = JsonConvert.DeserializeObject(Of preferenceModel)(RichTextBox2.Text)

        TextBox4.Text = result.firstName
        TextBox5.Text = result.middleName
        TextBox6.Text = result.lastName

    End Sub
End Class
