Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace DxSample
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.ClientScript.IsStartupScriptRegistered(Me.GetType(), "main")) Then
				Me.ClientScript.RegisterStartupScript(Me.GetType(), "main", "<script type=""text/javascript"" src=""Scripts/Default.js""></script>")
			End If
		End Sub
	End Class
End Namespace
