Namespace Astro_Renamer
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.originalStrBox = New System.Windows.Forms.TextBox()
            Me.renamedStrBox = New System.Windows.Forms.MaskedTextBox()
            Me.originalStrLabel = New System.Windows.Forms.Label()
            Me.renamedStrLabel = New System.Windows.Forms.Label()
            Me.groupValues = New System.Windows.Forms.GroupBox()
            Me.groupOptions = New System.Windows.Forms.GroupBox()
            Me.rnResources = New System.Windows.Forms.CheckBox()
            Me.rnAsmblyInfo = New System.Windows.Forms.CheckBox()
            Me.allBox = New System.Windows.Forms.CheckBox()
            Me.rnEventdef = New System.Windows.Forms.CheckBox()
            Me.rnField = New System.Windows.Forms.CheckBox()
            Me.rnProperty = New System.Windows.Forms.CheckBox()
            Me.rnFile = New System.Windows.Forms.CheckBox()
            Me.rnMdule = New System.Windows.Forms.CheckBox()
            Me.rnAsmbly = New System.Windows.Forms.CheckBox()
            Me.rnMethod = New System.Windows.Forms.CheckBox()
            Me.rnClass = New System.Windows.Forms.CheckBox()
            Me.rnString = New System.Windows.Forms.CheckBox()
            Me.creditsLabel = New System.Windows.Forms.Label()
            Me.panelGroup = New System.Windows.Forms.GroupBox()
            Me.fileLocationLabel = New System.Windows.Forms.Label()
            Me.btnSelectFile = New System.Windows.Forms.Button()
            Me.fileLocationBox = New System.Windows.Forms.TextBox()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnStart = New System.Windows.Forms.Button()
            Me.panelProgress = New System.Windows.Forms.GroupBox()
            Me.logsLabel = New System.Windows.Forms.Label()
            Me.processProgress = New System.Windows.Forms.ProgressBar()
            Me.logListBox = New System.Windows.Forms.ListBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.groupValues.SuspendLayout()
            Me.groupOptions.SuspendLayout()
            Me.panelGroup.SuspendLayout()
            Me.panelProgress.SuspendLayout()
            Me.SuspendLayout()
            '
            'originalStrBox
            '
            Me.originalStrBox.Location = New System.Drawing.Point(6, 40)
            Me.originalStrBox.Name = "originalStrBox"
            Me.originalStrBox.Size = New System.Drawing.Size(248, 20)
            Me.originalStrBox.TabIndex = 20
            '
            'renamedStrBox
            '
            Me.renamedStrBox.Location = New System.Drawing.Point(6, 82)
            Me.renamedStrBox.Name = "renamedStrBox"
            Me.renamedStrBox.Size = New System.Drawing.Size(248, 20)
            Me.renamedStrBox.TabIndex = 7
            '
            'originalStrLabel
            '
            Me.originalStrLabel.AutoSize = True
            Me.originalStrLabel.Location = New System.Drawing.Point(3, 24)
            Me.originalStrLabel.Name = "originalStrLabel"
            Me.originalStrLabel.Size = New System.Drawing.Size(72, 13)
            Me.originalStrLabel.TabIndex = 2
            Me.originalStrLabel.Text = "Original Value"
            '
            'renamedStrLabel
            '
            Me.renamedStrLabel.AutoSize = True
            Me.renamedStrLabel.Location = New System.Drawing.Point(3, 66)
            Me.renamedStrLabel.Name = "renamedStrLabel"
            Me.renamedStrLabel.Size = New System.Drawing.Size(83, 13)
            Me.renamedStrLabel.TabIndex = 3
            Me.renamedStrLabel.Text = "Renamed Value"
            '
            'groupValues
            '
            Me.groupValues.Controls.Add(Me.originalStrLabel)
            Me.groupValues.Controls.Add(Me.renamedStrLabel)
            Me.groupValues.Controls.Add(Me.originalStrBox)
            Me.groupValues.Controls.Add(Me.renamedStrBox)
            Me.groupValues.Location = New System.Drawing.Point(12, 12)
            Me.groupValues.Name = "groupValues"
            Me.groupValues.Size = New System.Drawing.Size(260, 123)
            Me.groupValues.TabIndex = 4
            Me.groupValues.TabStop = False
            Me.groupValues.Text = "Values"
            '
            'groupOptions
            '
            Me.groupOptions.Controls.Add(Me.rnResources)
            Me.groupOptions.Controls.Add(Me.rnAsmblyInfo)
            Me.groupOptions.Controls.Add(Me.allBox)
            Me.groupOptions.Controls.Add(Me.rnEventdef)
            Me.groupOptions.Controls.Add(Me.rnField)
            Me.groupOptions.Controls.Add(Me.rnProperty)
            Me.groupOptions.Controls.Add(Me.rnFile)
            Me.groupOptions.Controls.Add(Me.rnMdule)
            Me.groupOptions.Controls.Add(Me.rnAsmbly)
            Me.groupOptions.Controls.Add(Me.rnMethod)
            Me.groupOptions.Controls.Add(Me.rnClass)
            Me.groupOptions.Controls.Add(Me.rnString)
            Me.groupOptions.Location = New System.Drawing.Point(12, 141)
            Me.groupOptions.Name = "groupOptions"
            Me.groupOptions.Size = New System.Drawing.Size(156, 224)
            Me.groupOptions.TabIndex = 5
            Me.groupOptions.TabStop = False
            Me.groupOptions.Text = "Options"
            '
            'rnResources
            '
            Me.rnResources.AutoSize = True
            Me.rnResources.Checked = True
            Me.rnResources.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnResources.Location = New System.Drawing.Point(6, 196)
            Me.rnResources.Name = "rnResources"
            Me.rnResources.Size = New System.Drawing.Size(120, 17)
            Me.rnResources.TabIndex = 11
            Me.rnResources.Text = "Rename Resources"
            Me.rnResources.UseVisualStyleBackColor = True
            '
            'rnAsmblyInfo
            '
            Me.rnAsmblyInfo.AutoSize = True
            Me.rnAsmblyInfo.Checked = True
            Me.rnAsmblyInfo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnAsmblyInfo.Location = New System.Drawing.Point(6, 179)
            Me.rnAsmblyInfo.Name = "rnAsmblyInfo"
            Me.rnAsmblyInfo.Size = New System.Drawing.Size(134, 17)
            Me.rnAsmblyInfo.TabIndex = 10
            Me.rnAsmblyInfo.Text = "Rename Assembly Info"
            Me.rnAsmblyInfo.UseVisualStyleBackColor = True
            '
            'allBox
            '
            Me.allBox.AutoSize = True
            Me.allBox.Checked = True
            Me.allBox.CheckState = System.Windows.Forms.CheckState.Indeterminate
            Me.allBox.Location = New System.Drawing.Point(112, -1)
            Me.allBox.Name = "allBox"
            Me.allBox.Size = New System.Drawing.Size(37, 17)
            Me.allBox.TabIndex = 9
            Me.allBox.Text = "All"
            Me.allBox.UseVisualStyleBackColor = True
            '
            'rnEventdef
            '
            Me.rnEventdef.AutoSize = True
            Me.rnEventdef.Checked = True
            Me.rnEventdef.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnEventdef.Location = New System.Drawing.Point(6, 111)
            Me.rnEventdef.Name = "rnEventdef"
            Me.rnEventdef.Size = New System.Drawing.Size(102, 17)
            Me.rnEventdef.TabIndex = 8
            Me.rnEventdef.Text = "Rename Events"
            Me.rnEventdef.UseVisualStyleBackColor = True
            '
            'rnField
            '
            Me.rnField.AutoSize = True
            Me.rnField.Checked = True
            Me.rnField.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnField.Location = New System.Drawing.Point(6, 94)
            Me.rnField.Name = "rnField"
            Me.rnField.Size = New System.Drawing.Size(96, 17)
            Me.rnField.TabIndex = 7
            Me.rnField.Text = "Rename Fields"
            Me.rnField.UseVisualStyleBackColor = True
            '
            'rnProperty
            '
            Me.rnProperty.AutoSize = True
            Me.rnProperty.Checked = True
            Me.rnProperty.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnProperty.Location = New System.Drawing.Point(6, 77)
            Me.rnProperty.Name = "rnProperty"
            Me.rnProperty.Size = New System.Drawing.Size(116, 17)
            Me.rnProperty.TabIndex = 6
            Me.rnProperty.Text = "Rename Properties"
            Me.rnProperty.UseVisualStyleBackColor = True
            '
            'rnFile
            '
            Me.rnFile.AutoSize = True
            Me.rnFile.Checked = True
            Me.rnFile.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnFile.Location = New System.Drawing.Point(6, 60)
            Me.rnFile.Name = "rnFile"
            Me.rnFile.Size = New System.Drawing.Size(116, 17)
            Me.rnFile.TabIndex = 5
            Me.rnFile.Text = "Rename File Name"
            Me.rnFile.UseVisualStyleBackColor = True
            '
            'rnMdule
            '
            Me.rnMdule.AutoSize = True
            Me.rnMdule.Checked = True
            Me.rnMdule.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnMdule.Location = New System.Drawing.Point(6, 128)
            Me.rnMdule.Name = "rnMdule"
            Me.rnMdule.Size = New System.Drawing.Size(135, 17)
            Me.rnMdule.TabIndex = 4
            Me.rnMdule.Text = "Rename Module Name"
            Me.rnMdule.UseVisualStyleBackColor = True
            '
            'rnAsmbly
            '
            Me.rnAsmbly.AutoSize = True
            Me.rnAsmbly.Checked = True
            Me.rnAsmbly.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnAsmbly.Location = New System.Drawing.Point(6, 43)
            Me.rnAsmbly.Name = "rnAsmbly"
            Me.rnAsmbly.Size = New System.Drawing.Size(144, 17)
            Me.rnAsmbly.TabIndex = 3
            Me.rnAsmbly.Text = "Rename Assembly Name"
            Me.rnAsmbly.UseVisualStyleBackColor = True
            '
            'rnMethod
            '
            Me.rnMethod.AutoSize = True
            Me.rnMethod.Checked = True
            Me.rnMethod.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnMethod.Location = New System.Drawing.Point(6, 145)
            Me.rnMethod.Name = "rnMethod"
            Me.rnMethod.Size = New System.Drawing.Size(141, 17)
            Me.rnMethod.TabIndex = 2
            Me.rnMethod.Text = "Rename Method Names"
            Me.rnMethod.UseVisualStyleBackColor = True
            '
            'rnClass
            '
            Me.rnClass.AutoSize = True
            Me.rnClass.Checked = True
            Me.rnClass.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnClass.Location = New System.Drawing.Point(6, 26)
            Me.rnClass.Name = "rnClass"
            Me.rnClass.Size = New System.Drawing.Size(130, 17)
            Me.rnClass.TabIndex = 1
            Me.rnClass.Text = "Rename Class Names"
            Me.rnClass.UseVisualStyleBackColor = True
            '
            'rnString
            '
            Me.rnString.AutoSize = True
            Me.rnString.Checked = True
            Me.rnString.CheckState = System.Windows.Forms.CheckState.Checked
            Me.rnString.Location = New System.Drawing.Point(6, 162)
            Me.rnString.Name = "rnString"
            Me.rnString.Size = New System.Drawing.Size(101, 17)
            Me.rnString.TabIndex = 0
            Me.rnString.Text = "Rename Strings"
            Me.rnString.UseVisualStyleBackColor = True
            '
            'creditsLabel
            '
            Me.creditsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.creditsLabel.AutoSize = True
            Me.creditsLabel.Location = New System.Drawing.Point(607, 366)
            Me.creditsLabel.Name = "creditsLabel"
            Me.creditsLabel.Size = New System.Drawing.Size(107, 13)
            Me.creditsLabel.TabIndex = 6
            Me.creditsLabel.Text = "Credits: LockT#2434"
            '
            'panelGroup
            '
            Me.panelGroup.Controls.Add(Me.fileLocationLabel)
            Me.panelGroup.Controls.Add(Me.btnSelectFile)
            Me.panelGroup.Controls.Add(Me.fileLocationBox)
            Me.panelGroup.Controls.Add(Me.btnExit)
            Me.panelGroup.Controls.Add(Me.btnStart)
            Me.panelGroup.Location = New System.Drawing.Point(278, 12)
            Me.panelGroup.Name = "panelGroup"
            Me.panelGroup.Size = New System.Drawing.Size(435, 123)
            Me.panelGroup.TabIndex = 7
            Me.panelGroup.TabStop = False
            Me.panelGroup.Text = "Panel"
            '
            'fileLocationLabel
            '
            Me.fileLocationLabel.AutoSize = True
            Me.fileLocationLabel.Location = New System.Drawing.Point(3, 34)
            Me.fileLocationLabel.Name = "fileLocationLabel"
            Me.fileLocationLabel.Size = New System.Drawing.Size(67, 13)
            Me.fileLocationLabel.TabIndex = 4
            Me.fileLocationLabel.Text = "File Location"
            '
            'btnSelectFile
            '
            Me.btnSelectFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSelectFile.Location = New System.Drawing.Point(6, 94)
            Me.btnSelectFile.Name = "btnSelectFile"
            Me.btnSelectFile.Size = New System.Drawing.Size(38, 23)
            Me.btnSelectFile.TabIndex = 11
            Me.btnSelectFile.Text = "..."
            Me.btnSelectFile.UseVisualStyleBackColor = True
            '
            'fileLocationBox
            '
            Me.fileLocationBox.AllowDrop = True
            Me.fileLocationBox.Location = New System.Drawing.Point(6, 50)
            Me.fileLocationBox.Name = "fileLocationBox"
            Me.fileLocationBox.Size = New System.Drawing.Size(423, 20)
            Me.fileLocationBox.TabIndex = 4
            Me.fileLocationBox.Text = "Drag and Drop File"
            '
            'btnExit
            '
            Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExit.Location = New System.Drawing.Point(340, 94)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(89, 23)
            Me.btnExit.TabIndex = 9
            Me.btnExit.Text = "Exit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnStart
            '
            Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnStart.Location = New System.Drawing.Point(245, 94)
            Me.btnStart.Name = "btnStart"
            Me.btnStart.Size = New System.Drawing.Size(89, 23)
            Me.btnStart.TabIndex = 1
            Me.btnStart.Text = "Start Rename"
            Me.btnStart.UseVisualStyleBackColor = True
            '
            'panelProgress
            '
            Me.panelProgress.Controls.Add(Me.logsLabel)
            Me.panelProgress.Controls.Add(Me.processProgress)
            Me.panelProgress.Controls.Add(Me.logListBox)
            Me.panelProgress.Location = New System.Drawing.Point(174, 141)
            Me.panelProgress.Name = "panelProgress"
            Me.panelProgress.Size = New System.Drawing.Size(539, 224)
            Me.panelProgress.TabIndex = 8
            Me.panelProgress.TabStop = False
            Me.panelProgress.Text = "Progress"
            '
            'logsLabel
            '
            Me.logsLabel.AutoSize = True
            Me.logsLabel.Location = New System.Drawing.Point(3, 23)
            Me.logsLabel.Name = "logsLabel"
            Me.logsLabel.Size = New System.Drawing.Size(30, 13)
            Me.logsLabel.TabIndex = 9
            Me.logsLabel.Text = "Logs"
            '
            'processProgress
            '
            Me.processProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.processProgress.Location = New System.Drawing.Point(6, 194)
            Me.processProgress.Name = "processProgress"
            Me.processProgress.Size = New System.Drawing.Size(527, 23)
            Me.processProgress.TabIndex = 14
            '
            'logListBox
            '
            Me.logListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.logListBox.FormattingEnabled = True
            Me.logListBox.Items.AddRange(New Object() {"Waiting for logger..."})
            Me.logListBox.Location = New System.Drawing.Point(6, 39)
            Me.logListBox.Name = "logListBox"
            Me.logListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
            Me.logListBox.Size = New System.Drawing.Size(527, 147)
            Me.logListBox.TabIndex = 13
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 369)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(136, 13)
            Me.label1.TabIndex = 9
            Me.label1.Text = "Note: AsmInfo Don't Works"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(725, 382)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.panelProgress)
            Me.Controls.Add(Me.creditsLabel)
            Me.Controls.Add(Me.panelGroup)
            Me.Controls.Add(Me.groupOptions)
            Me.Controls.Add(Me.groupValues)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MainForm"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Astro Renamer"
            Me.groupValues.ResumeLayout(False)
            Me.groupValues.PerformLayout()
            Me.groupOptions.ResumeLayout(False)
            Me.groupOptions.PerformLayout()
            Me.panelGroup.ResumeLayout(False)
            Me.panelGroup.PerformLayout()
            Me.panelProgress.ResumeLayout(False)
            Me.panelProgress.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private originalStrBox As System.Windows.Forms.TextBox
		Private renamedStrBox As System.Windows.Forms.MaskedTextBox
		Private originalStrLabel As System.Windows.Forms.Label
		Private renamedStrLabel As System.Windows.Forms.Label
		Private groupValues As System.Windows.Forms.GroupBox
		Private groupOptions As System.Windows.Forms.GroupBox
		Private rnString As System.Windows.Forms.CheckBox
		Private rnClass As System.Windows.Forms.CheckBox
		Private rnMethod As System.Windows.Forms.CheckBox
		Private rnMdule As System.Windows.Forms.CheckBox
		Private rnAsmbly As System.Windows.Forms.CheckBox
		Private rnFile As System.Windows.Forms.CheckBox
		Private creditsLabel As System.Windows.Forms.Label
		Private panelGroup As System.Windows.Forms.GroupBox
		Private WithEvents btnExit As System.Windows.Forms.Button
		Private WithEvents btnStart As System.Windows.Forms.Button
		Private btnSelectFile As System.Windows.Forms.Button
		Private WithEvents fileLocationBox As System.Windows.Forms.TextBox
		Private panelProgress As System.Windows.Forms.GroupBox
		Private processProgress As System.Windows.Forms.ProgressBar
		Private fileLocationLabel As System.Windows.Forms.Label
		Private logsLabel As System.Windows.Forms.Label
		Private rnEventdef As System.Windows.Forms.CheckBox
		Private rnField As System.Windows.Forms.CheckBox
		Private rnProperty As System.Windows.Forms.CheckBox
		Private WithEvents allBox As System.Windows.Forms.CheckBox
		Public logListBox As System.Windows.Forms.ListBox
		Private rnAsmblyInfo As System.Windows.Forms.CheckBox
		Private rnResources As System.Windows.Forms.CheckBox
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace

