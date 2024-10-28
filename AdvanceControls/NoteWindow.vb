Imports System.IO
Public Class NoteWindow
    Property CurrentFilePath()
        Get
            Return currentFilePathV

        End Get
        Set(value)
            If currentFilePathV IsNot Nothing Then
                currentFilePathV = value
                Me.Text = Path.GetFileNameWithoutExtension(CurrentFilePath.ToString())
            End If
        End Set
    End Property
    Dim currentFilePathV As String = ""
    Dim serialFilePath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        serialFilePath = Path.GetTempPath() & "\temp.dat"
        companyLink.Links.Add(13, companyLink.Text.Length, "https://www.oceanofsites.com")
        ToolTip1.SetToolTip(companyLink, "Click to goto OCEAN OF SITES")
        RTB1.Font = New Font("DIGIFACE", 28)
        CurrentFilePath = ""
        SaveFileDialog1.DefaultExt = ".rtb"
        OpenFileDialog1.DefaultExt = ".rtb"
        Me.Text = "UnSaved"
    End Sub

    'Primary Actions

    Private Sub changeColor_Click(sender As Object, e As EventArgs) Handles changeColorBtn.Click
        Dim result = ColorDialog1.ShowDialog()
        If result = DialogResult.OK Then
            RTB1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub changeFont_Click(sender As Object, e As EventArgs) Handles changeFontBtn.Click
        Dim result = FontDialog1.ShowDialog()
        If result = DialogResult.OK Then
            RTB1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub changeSize_Click(sender As Object, e As EventArgs) Handles sizeDownBtn.Click, sizeUpBtn.Click
        If sender.Equals(sizeUpBtn) Then
            RTB1.SelectionFont = New Font(RTB1.SelectionFont.FontFamily, RTB1.SelectionFont.Size + 2)
        Else
            RTB1.SelectionFont = New Font(RTB1.SelectionFont.FontFamily, RTB1.SelectionFont.Size - 2)
        End If
    End Sub



    'Opening links
    Private Sub companyLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles companyLink.LinkClicked
        openNewBrowserWindow(e.Link.LinkData.ToString())
    End Sub

    Private Sub GitLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitLink.LinkClicked
        openNewBrowserWindow("https://github.com/Danny-Wits")
    End Sub

    Private Sub VersionAbout_Click(sender As Object, e As EventArgs) Handles VersionAbout.Click
        Message("VERSION 1.0.0 ")
    End Sub

    Private Sub CreaterAbout_Click(sender As Object, e As EventArgs) Handles CreaterAbout.Click
        openNewBrowserWindow("https://github.com/Danny-Wits")
        Message("OPENED A TAB IN YOU BROWSER CONTAINING INFO ABOUT THE CREATER")
    End Sub

    Private Sub SponserAbout_Click(sender As Object, e As EventArgs) Handles SponserAbout.Click
        openNewBrowserWindow("https://www.oceanofsites.com")
        Message("OPENED A TAB IN YOU BROWSER CONTAINING INFO ABOUT THE SPONSER")
    End Sub



    'Helper Functions
    Private Shared Sub openNewBrowserWindow(link As String)
        Try
            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = link
            Process.Start(psi)
        Catch ex As Exception
            Message("Unable to open the browser. " & ex.Message)
        End Try
    End Sub

    Private Shared Sub Message(Msg As String)
        MessageBox.Show(Msg, "NOTE PAD .NET SAYS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Menu Actions

    '1.File Actions
    Private Sub newFile_Click(sender As Object, e As EventArgs) Handles newFile.Click
        newFileCreate()
    End Sub

    Private Sub newFileCreate()
        Dim result = SaveFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Dim path = SaveFileDialog1.FileName
            LoadRTBFile(path)
        End If
    End Sub

    Private Sub SaveFile_Click(sender As Object, e As EventArgs) Handles SaveFile.Click
        saveFileH()
    End Sub

    Private Sub saveFileH()
        saveRTBfile(CurrentFilePath)
    End Sub

    Private Sub SaveAsFile_Click(sender As Object, e As EventArgs) Handles SaveAsFile.Click
        saveRTBfileAs()
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles OpenFile.Click
        OpenFileH()
    End Sub

    Private Sub OpenFileH()
        Dim result = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Dim path = OpenFileDialog1.FileName
            LoadRTBFile(path)
        End If
    End Sub



    '2. Edit Actions

    Private Sub undoEdit_Click(sender As Object, e As EventArgs) Handles undoEdit.Click
        UNDO()
    End Sub

    Private Sub UNDO()
        If RTB1.CanUndo() Then
            RTB1.Undo()
        End If
    End Sub

    Private Sub RedoEdit_Click(sender As Object, e As EventArgs) Handles RedoEdit.Click
        REDO()
    End Sub

    Private Sub REDO()
        If RTB1.CanRedo() Then
            RTB1.Redo()
        End If
    End Sub

    Private Sub ChangeColorEdit_Click(sender As Object, e As EventArgs) Handles ChangeColorEdit.Click
        ChangeColor()
    End Sub

    Private Sub ChangeColor()
        Dim result = ColorDialog1.ShowDialog
        If result = DialogResult.OK Then
            RTB1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ChangeFontEdit_Click(sender As Object, e As EventArgs) Handles ChangeFontEdit.Click
        ChangeFont()
    End Sub

    Private Sub ChangeFont()
        Dim result = FontDialog1.ShowDialog()
        If result = DialogResult.OK Then
            RTB1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub SizeUpEdit_Click(sender As Object, e As EventArgs) Handles SizeUpEdit.Click
        SizeUP()
    End Sub

    Private Sub SizeUP()
        RTB1.Font = New Font(RTB1.Font.FontFamily, RTB1.Font.Size + 2)
    End Sub

    Private Sub SizeDownEdit_Click(sender As Object, e As EventArgs) Handles SizeDownEdit.Click
        SizeDown()
    End Sub

    Private Sub SizeDown()
        RTB1.Font = New Font(RTB1.Font.FontFamily, RTB1.Font.Size - 2)
    End Sub

    'File System 
    Private Sub saveRTBfile(path As String)
        If path.Equals("") Then
            saveRTBfileAs()
        End If
        Try
            RTB1.SaveFile(path)
            CurrentFilePath = path
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
    Private Sub saveRTBfileAs()
        Dim result = SaveFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Dim path = SaveFileDialog1.FileNames(0)
            saveRTBfile(path)
        End If
    End Sub
    Private Sub LoadRTBFile(path As String)
        Console.WriteLine(path)
        If Not path.Equals("") Then
            RTB1.LoadFile(path)
            CurrentFilePath = path
        End If
    End Sub

    'Keyboard event listeners
    Private Sub keyHandler(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.Shift Then
            Select Case e.KeyCode
                Case Keys.S
                    saveRTBfileAs()
            End Select
        ElseIf e.Control Then
            Select Case e.KeyCode
                Case Keys.S
                    saveFileH()
                Case Keys.Z
                    UNDO()
                Case Keys.Y
                    REDO()
                Case Keys.O
                    OpenFileH()
                Case Keys.U
                    SizeUP()
                Case Keys.D
                    SizeDown()
            End Select
        End If

    End Sub

End Class
