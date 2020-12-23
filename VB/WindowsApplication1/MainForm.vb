Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class MainForm
		Inherits AdvancedXtraForm
		Public Sub New()
			InitializeComponent()
			Dim manager As DevExpress.XtraBars.Ribbon.RibbonBarManager = TitleBarToolBar.Ribbon.Manager
			TitleBarToolBar.ItemLinks.Add(New BarButtonItem(manager, "Test"))
			Dim riTextEdit As New RepositoryItemTextEdit()
			TitleBarToolBar.ItemLinks.Add(New BarEditItem(manager, riTextEdit))
			AddHandler riTextEdit.EditValueChanged, AddressOf riTextEdit_EditValueChanged
			Dim riButtonEdit As New RepositoryItemButtonEdit()
			AddHandler riButtonEdit.ButtonClick, AddressOf riButtonEdit_ButtonClick
			riButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			riButtonEdit.Buttons(0).Caption = "Button"
			riButtonEdit.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
			TitleBarToolBar.ItemLinks.Add(New BarEditItem(manager, riButtonEdit))
		End Sub

		Private Sub riButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
			MessageBox.Show("Test")
		End Sub

		Private Sub riTextEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Text = (TryCast(sender, TextEdit)).Text
		End Sub
	End Class
End Namespace
