Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class AdvancedXtraForm
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
			Me.ribbon = New WindowsApplication1.AdvancedRibbonControl()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.clientPanel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbon
			' 
			Me.ribbon.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbon.ExpandCollapseItem.Id = 0
			Me.ribbon.ExpandCollapseItem.Name = ""
			Me.ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbon.ExpandCollapseItem})
			Me.ribbon.Location = New System.Drawing.Point(0, 0)
			Me.ribbon.MaxItemId = 2
			Me.ribbon.Name = "ribbon"
			Me.ribbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
			Me.ribbon.SelectedPage = Me.ribbonPage1
			Me.ribbon.ShowToolbarCustomizeItem = False
			Me.ribbon.Size = New System.Drawing.Size(540, 30)
			Me.ribbon.Toolbar.ShowCustomizeItem = False
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' clientPanel
			' 
			Me.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.clientPanel.Location = New System.Drawing.Point(0, 30)
			Me.clientPanel.Name = "clientPanel"
			Me.clientPanel.Size = New System.Drawing.Size(540, 448)
			Me.clientPanel.TabIndex = 2
			' 
			' AdvancedXtraForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(540, 478)
			Me.Controls.Add(Me.clientPanel)
			Me.Controls.Add(Me.ribbon)
			Me.Name = "AdvancedXtraForm"
			Me.Ribbon = Me.ribbon
			Me.Text = "RibbonForm1"
			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbon As AdvancedRibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private clientPanel As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace