Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class AdvancedRibbonControl
		Inherits RibbonControl

		Public Sub New()
			Toolbar.ShowCustomizeItem = False
			RibbonStyle = RibbonControlStyle.MacOffice
		End Sub

		Protected Overrides Function CreateViewInfo() As RibbonViewInfo
			Return New AdvancedRibbonViewInfo(Me)
		End Function
	End Class

	Public Class AdvancedRibbonViewInfo
		Inherits RibbonViewInfo
		Public Sub New(ByVal ribbon As RibbonControl)
			MyBase.New(ribbon)

		End Sub


		Protected Overrides Function CalcMinHeight() As Integer
			Return Caption.CalcCaptionHeight()
		End Function

	End Class
End Namespace
