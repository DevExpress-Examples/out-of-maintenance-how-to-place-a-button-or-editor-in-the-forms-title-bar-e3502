Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Namespace WindowsApplication1
	Partial Public Class AdvancedXtraForm
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public ReadOnly Property TitleBarToolBar() As RibbonQuickAccessToolbar
			Get
				Return ribbon.Toolbar
			End Get
		End Property


	End Class
End Namespace