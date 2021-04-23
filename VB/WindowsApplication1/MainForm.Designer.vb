Namespace WindowsApplication1
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
			Me.components = New System.ComponentModel.Container()
'INSTANT VB NOTE: The variable resources was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim resources_Conflict As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.toolbarFormControl1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormControl()
			Me.toolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			CType(Me.toolbarFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolbarFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' toolbarFormControl1
			' 
			Me.toolbarFormControl1.Location = New System.Drawing.Point(0, 0)
			Me.toolbarFormControl1.Manager = Me.toolbarFormManager1
			Me.toolbarFormControl1.Name = "toolbarFormControl1"
			Me.toolbarFormControl1.Size = New System.Drawing.Size(643, 31)
			Me.toolbarFormControl1.TabIndex = 0
			Me.toolbarFormControl1.TabStop = False
			Me.toolbarFormControl1.TitleItemLinks.Add(Me.barButtonItem1)
			Me.toolbarFormControl1.TitleItemLinks.Add(Me.barEditItem1)
			Me.toolbarFormControl1.TitleItemLinks.Add(Me.barStaticItem1)
			Me.toolbarFormControl1.TitleItemLinks.Add(Me.barButtonItem2)
			Me.toolbarFormControl1.ToolbarForm = Me
			' 
			' toolbarFormManager1
			' 
			Me.toolbarFormManager1.DockControls.Add(Me.barDockControlTop)
			Me.toolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
			Me.toolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
			Me.toolbarFormManager1.DockControls.Add(Me.barDockControlRight)
			Me.toolbarFormManager1.Form = Me
			Me.toolbarFormManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barEditItem1, Me.barStaticItem1, Me.barButtonItem2, Me.barButtonItem3})
			Me.toolbarFormManager1.MaxItemId = 5
			Me.toolbarFormManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1})
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 31)
			Me.barDockControlTop.Manager = Me.toolbarFormManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(643, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 288)
			Me.barDockControlBottom.Manager = Me.toolbarFormManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(643, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
			Me.barDockControlLeft.Manager = Me.toolbarFormManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 257)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(643, 31)
			Me.barDockControlRight.Manager = Me.toolbarFormManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 257)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.ImageOptions.SvgImage = (CType(resources_Conflict.GetObject("barButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage))
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.barEditItem1.Caption = "barEditItem1"
			Me.barEditItem1.Edit = Me.repositoryItemTextEdit1
			Me.barEditItem1.Id = 1
			Me.barEditItem1.Name = "barEditItem1"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "barStaticItem1"
			Me.barStaticItem1.Id = 2
			Me.barStaticItem1.Name = "barStaticItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 3
			Me.barButtonItem2.Name = "barButtonItem2"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Id = 4
			Me.barButtonItem3.Name = "barButtonItem3"

			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(643, 288)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Controls.Add(Me.toolbarFormControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "MainForm"
			Me.Text = "MainForm"
			Me.ToolbarFormControl = Me.toolbarFormControl1
			CType(Me.toolbarFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolbarFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolbarFormControl1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormControl
		Private toolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace