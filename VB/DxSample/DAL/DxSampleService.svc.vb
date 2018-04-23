Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports System.Text
Imports DxSample.DAL.BO

Namespace DxSample.DAL
	<ServiceContract(Namespace := "DxSample"), AspNetCompatibilityRequirements(RequirementsMode := AspNetCompatibilityRequirementsMode.Allowed)> _
	Public Class DxSampleService
		' This method returns hard coded data for the sake of simplicity
		' In real applications, WCF service operations usually connect to the SQL database and return real data
		<OperationContract, WebGet> _
		Public Function GetSales() As Sale()
			Return New Sale() { New Sale() With {.Day = "Monday", .OrangesSold = 3}, New Sale() With {.Day = "Tuesday", .OrangesSold = 2}, New Sale() With {.Day = "Wednesday", .OrangesSold = 3}, New Sale() With {.Day = "Thursday", .OrangesSold = 4}, New Sale() With {.Day = "Friday", .OrangesSold = 6}, New Sale() With {.Day = "Saturday", .OrangesSold = 11}, New Sale() With {.Day = "Sunday", .OrangesSold = 4} }
		End Function
	End Class
End Namespace
