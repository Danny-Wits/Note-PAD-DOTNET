Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        companyLink.Links.Add(13, companyLink.Text.Length, "https://www.oceanofsites.com")
        ToolTip1.SetToolTip(companyLink, "Click to goto OCEAN OF SITES")
        RTB1.Font = New Font("DIGIFACE", 28)
    End Sub

    Private Sub link1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles companyLink.LinkClicked
        openNewBrowserWindow(e.Link.LinkData.ToString())
    End Sub

    Private Shared Sub openNewBrowserWindow(link As String)
        Try
            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = link
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Unable to open the browser. " & ex.Message)
        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RTB1.TextChanged
        Debug.WriteLine(sender.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles changeColorBtn.Click
        Dim result = ColorDialog1.ShowDialog
        If result = DialogResult.OK Then
            RTB1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles changeFontBtn.Click
        Dim result = FontDialog1.ShowDialog()
        If result = DialogResult.OK Then
            RTB1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitLink.LinkClicked
        openNewBrowserWindow("https://github.com/Danny-Wits")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click

    End Sub
End Class
