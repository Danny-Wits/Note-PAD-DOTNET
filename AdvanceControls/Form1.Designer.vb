<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripMenuItem()
        ToolStripMenuItem8 = New ToolStripMenuItem()
        BoldToolStripMenuItem = New ToolStripMenuItem()
        ItalicsToolStripMenuItem = New ToolStripMenuItem()
        SizeUpToolStripMenuItem = New ToolStripMenuItem()
        SizeDownToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem9 = New ToolStripMenuItem()
        ToolStripMenuItem10 = New ToolStripMenuItem()
        ToolStripMenuItem11 = New ToolStripMenuItem()
        sizeUpbtn = New Button()
        sizeDownBtn = New Button()
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
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem4, OpenToolStripMenuItem})
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(46, 24)
        FileMenu.Text = "File"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(143, 26)
        ToolStripMenuItem2.Text = "New"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(143, 26)
        ToolStripMenuItem3.Text = "Save"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(143, 26)
        ToolStripMenuItem4.Text = "Save As"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(143, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem5, ToolStripMenuItem6, ToolStripMenuItem7, ToolStripMenuItem8, BoldToolStripMenuItem, ItalicsToolStripMenuItem, SizeUpToolStripMenuItem, SizeDownToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(182, 26)
        ToolStripMenuItem5.Text = "Undo"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(182, 26)
        ToolStripMenuItem6.Text = "Redo"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(182, 26)
        ToolStripMenuItem7.Text = "Change Color"
        ' 
        ' ToolStripMenuItem8
        ' 
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New Size(182, 26)
        ToolStripMenuItem8.Text = "Change Font"
        ' 
        ' BoldToolStripMenuItem
        ' 
        BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        BoldToolStripMenuItem.Size = New Size(182, 26)
        BoldToolStripMenuItem.Text = "Bold"
        ' 
        ' ItalicsToolStripMenuItem
        ' 
        ItalicsToolStripMenuItem.Name = "ItalicsToolStripMenuItem"
        ItalicsToolStripMenuItem.Size = New Size(182, 26)
        ItalicsToolStripMenuItem.Text = "Italics"
        ' 
        ' SizeUpToolStripMenuItem
        ' 
        SizeUpToolStripMenuItem.Name = "SizeUpToolStripMenuItem"
        SizeUpToolStripMenuItem.Size = New Size(182, 26)
        SizeUpToolStripMenuItem.Text = "Size up"
        ' 
        ' SizeDownToolStripMenuItem
        ' 
        SizeDownToolStripMenuItem.Name = "SizeDownToolStripMenuItem"
        SizeDownToolStripMenuItem.Size = New Size(182, 26)
        SizeDownToolStripMenuItem.Text = "Size Down"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem9, ToolStripMenuItem10, ToolStripMenuItem11})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(64, 24)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ToolStripMenuItem9
        ' 
        ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        ToolStripMenuItem9.Size = New Size(145, 26)
        ToolStripMenuItem9.Text = "Version"
        ' 
        ' ToolStripMenuItem10
        ' 
        ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        ToolStripMenuItem10.Size = New Size(145, 26)
        ToolStripMenuItem10.Text = "Creater"
        ' 
        ' ToolStripMenuItem11
        ' 
        ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        ToolStripMenuItem11.Size = New Size(145, 26)
        ToolStripMenuItem11.Text = "Sponser"
        ' 
        ' sizeUpbtn
        ' 
        sizeUpbtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        sizeUpbtn.Font = New Font("SimSun", 13.8F)
        sizeUpbtn.Location = New Point(462, 30)
        sizeUpbtn.Margin = New Padding(1)
        sizeUpbtn.Name = "sizeUpbtn"
        sizeUpbtn.Size = New Size(194, 40)
        sizeUpbtn.TabIndex = 7
        sizeUpbtn.Text = "Size up"
        sizeUpbtn.UseVisualStyleBackColor = True
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1086, 585)
        Controls.Add(sizeDownBtn)
        Controls.Add(sizeUpbtn)
        Controls.Add(GitLink)
        Controls.Add(changeFontBtn)
        Controls.Add(changeColorBtn)
        Controls.Add(RTB1)
        Controls.Add(companyLink)
        Controls.Add(MenuS)
        Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuS
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
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
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoldToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItalicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sizeUpbtn As Button
    Friend WithEvents sizeDownBtn As Button

End Class
