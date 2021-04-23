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
		Inherits DevExpress.XtraBars.ToolbarForm.ToolbarForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barButtonItem2.ItemClick
			MessageBox.Show("Test")
		End Sub
	End Class
End Namespace
