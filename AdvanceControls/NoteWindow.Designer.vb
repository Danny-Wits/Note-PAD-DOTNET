<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NoteWindow
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteWindow))
        companyLink = New LinkLabel()
        RTB1 = New RichTextBox()
        ColorDialog1 = New ColorDialog()
        changeColorBtn = New Button()
        ToolTip1 = New ToolTip(components)
        changeFontBtn = New Button()
        FontDialog1 = New FontDialog()
        GitLink = New LinkLabel()
        MenuS = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        newFile = New ToolStripMenuItem()
        SaveFile = New ToolStripMenuItem()
        SaveAsFile = New ToolStripMenuItem()
        OpenFile = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        undoEdit = New ToolStripMenuItem()
        RedoEdit = New ToolStripMenuItem()
        ChangeColorEdit = New ToolStripMenuItem()
        ChangeFontEdit = New ToolStripMenuItem()
        SizeUpEdit = New ToolStripMenuItem()
        SizeDownEdit = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        VersionAbout = New ToolStripMenuItem()
        CreaterAbout = New ToolStripMenuItem()
        SponserAbout = New ToolStripMenuItem()
        sizeUpBtn = New Button()
        sizeDownBtn = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        MenuS.SuspendLayout()
        SuspendLayout()
        ' 
        ' companyLink
        ' 
        companyLink.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        companyLink.AutoSize = True
        companyLink.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        companyLink.LinkColor = Color.Black
        companyLink.Location = New Point(766, 556)
        companyLink.Margin = New Padding(5, 0, 5, 0)
        companyLink.Name = "companyLink"
        companyLink.Size = New Size(317, 20)
        companyLink.TabIndex = 0
        companyLink.TabStop = True
        companyLink.Text = "Presented by  Ocean of Sites"
        companyLink.VisitedLinkColor = Color.Gray
        ' 
        ' RTB1
        ' 
        RTB1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RTB1.Location = New Point(12, 75)
        RTB1.Margin = New Padding(5, 4, 5, 4)
        RTB1.Name = "RTB1"
        RTB1.Size = New Size(1071, 463)
        RTB1.TabIndex = 1
        RTB1.Text = ""
        ' 
        ' changeColorBtn
        ' 
        changeColorBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        changeColorBtn.Font = New Font("SimSun", 13.8F)
        changeColorBtn.Location = New Point(674, 28)
        changeColorBtn.Margin = New Padding(1)
        changeColorBtn.Name = "changeColorBtn"
        changeColorBtn.Size = New Size(190, 40)
        changeColorBtn.TabIndex = 2
        changeColorBtn.Text = "Change Color"
        changeColorBtn.UseVisualStyleBackColor = True
        ' 
        ' changeFontBtn
        ' 
        changeFontBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        changeFontBtn.Font = New Font("SimSun", 13.8F)
        changeFontBtn.Location = New Point(886, 27)
        changeFontBtn.Margin = New Padding(1)
        changeFontBtn.Name = "changeFontBtn"
        changeFontBtn.Size = New Size(190, 40)
        changeFontBtn.TabIndex = 3
        changeFontBtn.Text = "Change Font"
        changeFontBtn.UseVisualStyleBackColor = True
        ' 
        ' GitLink
        ' 
        GitLink.ActiveLinkColor = Color.Red
        GitLink.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        GitLink.AutoSize = True
        GitLink.Font = New Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GitLink.LinkArea = New LinkArea(11, 20)
        GitLink.LinkColor = Color.Black
        GitLink.Location = New Point(12, 551)
        GitLink.Name = "GitLink"
        GitLink.Size = New Size(213, 29)
        GitLink.TabIndex = 5
        GitLink.TabStop = True
        GitLink.Text = "Created by Danishwer"
        GitLink.UseCompatibleTextRendering = True
        GitLink.VisitedLinkColor = Color.Gray
        ' 
        ' MenuS
        ' 
        MenuS.ImageScalingSize = New Size(20, 20)
        MenuS.Items.AddRange(New ToolStripItem() {FileMenu, EditToolStripMenuItem, AboutToolStripMenuItem})
        MenuS.Location = New Point(0, 0)
        MenuS.Name = "MenuS"
        MenuS.Size = New Size(1086, 28)
        MenuS.TabIndex = 6
        MenuS.Text = "Menus"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {newFile, SaveFile, SaveAsFile, OpenFile})
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(46, 24)
        FileMenu.Text = "File"
        ' 
        ' newFile
        ' 
        newFile.Name = "newFile"
        newFile.Size = New Size(143, 26)
        newFile.Text = "New"
        ' 
        ' SaveFile
        ' 
        SaveFile.Name = "SaveFile"
        SaveFile.Size = New Size(143, 26)
        SaveFile.Text = "Save"
        ' 
        ' SaveAsFile
        ' 
        SaveAsFile.Name = "SaveAsFile"
        SaveAsFile.Size = New Size(143, 26)
        SaveAsFile.Text = "Save As"
        ' 
        ' OpenFile
        ' 
        OpenFile.Name = "OpenFile"
        OpenFile.Size = New Size(143, 26)
        OpenFile.Text = "Open"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {undoEdit, RedoEdit, ChangeColorEdit, ChangeFontEdit, SizeUpEdit, SizeDownEdit})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' undoEdit
        ' 
        undoEdit.Name = "undoEdit"
        undoEdit.Size = New Size(182, 26)
        undoEdit.Text = "Undo"
        ' 
        ' RedoEdit
        ' 
        RedoEdit.Name = "RedoEdit"
        RedoEdit.Size = New Size(182, 26)
        RedoEdit.Text = "Redo"
        ' 
        ' ChangeColorEdit
        ' 
        ChangeColorEdit.Name = "ChangeColorEdit"
        ChangeColorEdit.Size = New Size(182, 26)
        ChangeColorEdit.Text = "Change Color"
        ' 
        ' ChangeFontEdit
        ' 
        ChangeFontEdit.Name = "ChangeFontEdit"
        ChangeFontEdit.Size = New Size(182, 26)
        ChangeFontEdit.Text = "Change Font"
        ' 
        ' SizeUpEdit
        ' 
        SizeUpEdit.Name = "SizeUpEdit"
        SizeUpEdit.Size = New Size(182, 26)
        SizeUpEdit.Text = "Size up"
        ' 
        ' SizeDownEdit
        ' 
        SizeDownEdit.Name = "SizeDownEdit"
        SizeDownEdit.Size = New Size(182, 26)
        SizeDownEdit.Text = "Size Down"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VersionAbout, CreaterAbout, SponserAbout})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(64, 24)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' VersionAbout
        ' 
        VersionAbout.Name = "VersionAbout"
        VersionAbout.Size = New Size(145, 26)
        VersionAbout.Text = "Version"
        ' 
        ' CreaterAbout
        ' 
        CreaterAbout.Name = "CreaterAbout"
        CreaterAbout.Size = New Size(145, 26)
        CreaterAbout.Text = "Creater"
        ' 
        ' SponserAbout
        ' 
        SponserAbout.Name = "SponserAbout"
        SponserAbout.Size = New Size(145, 26)
        SponserAbout.Text = "Sponser"
        ' 
        ' sizeUpBtn
        ' 
        sizeUpBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        sizeUpBtn.Font = New Font("SimSun", 13.8F)
        sizeUpBtn.Location = New Point(462, 30)
        sizeUpBtn.Margin = New Padding(1)
        sizeUpBtn.Name = "sizeUpBtn"
        sizeUpBtn.Size = New Size(194, 40)
        sizeUpBtn.TabIndex = 7
        sizeUpBtn.Text = "Size up"
        sizeUpBtn.UseVisualStyleBackColor = True
        ' 
        ' sizeDownBtn
        ' 
        sizeDownBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        sizeDownBtn.Font = New Font("SimSun", 13.8F)
        sizeDownBtn.Location = New Point(247, 30)
        sizeDownBtn.Margin = New Padding(1)
        sizeDownBtn.Name = "sizeDownBtn"
        sizeDownBtn.Size = New Size(194, 40)
        sizeDownBtn.TabIndex = 8
        sizeDownBtn.Text = "Size Down"
        sizeDownBtn.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' NoteWindow
        ' 
        AutoScaleDimensions = New SizeF(13F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1086, 585)
        Controls.Add(sizeDownBtn)
        Controls.Add(sizeUpBtn)
        Controls.Add(GitLink)
        Controls.Add(changeFontBtn)
        Controls.Add(changeColorBtn)
        Controls.Add(RTB1)
        Controls.Add(companyLink)
        Controls.Add(MenuS)
        Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MainMenuStrip = MenuS
        Margin = New Padding(5, 4, 5, 4)
        Name = "NoteWindow"
        StartPosition = FormStartPosition.CenterParent
        Text = "NOTE PAD .NET"
        MenuS.ResumeLayout(False)
        MenuS.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents companyLink As LinkLabel
    Friend WithEvents RTB1 As RichTextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents changeColorBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents changeFontBtn As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents GitLink As LinkLabel
    Friend WithEvents MenuS As MenuStrip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents newFile As ToolStripMenuItem
    Friend WithEvents SaveFile As ToolStripMenuItem
    Friend WithEvents SaveAsFile As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents undoEdit As ToolStripMenuItem
    Friend WithEvents RedoEdit As ToolStripMenuItem
    Friend WithEvents ChangeColorEdit As ToolStripMenuItem
    Friend WithEvents ChangeFontEdit As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionAbout As ToolStripMenuItem
    Friend WithEvents CreaterAbout As ToolStripMenuItem
    Friend WithEvents SponserAbout As ToolStripMenuItem
    Friend WithEvents OpenFile As ToolStripMenuItem
    Friend WithEvents SizeUpEdit As ToolStripMenuItem
    Friend WithEvents SizeDownEdit As ToolStripMenuItem
    Friend WithEvents sizeUpBtn As Button
    Friend WithEvents sizeDownBtn As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
