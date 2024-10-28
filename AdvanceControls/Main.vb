Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initialWindow As New NoteWindow()
        initialWindow.MdiParent = Me
        initialWindow.Show()

        Me.WindowState = FormWindowState.Maximized
        'Changing Background COlor 
        For Each Ctrl In Me.Controls
            If TypeOf Ctrl Is MdiClient Then
                Ctrl.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub AddNotePadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNotePadToolStripMenuItem.Click
        Dim newWindow As New NoteWindow()
        newWindow.MdiParent = Me
        newWindow.Show()
    End Sub
End Class