Imports Microsoft.VisualBasic
Imports System
Namespace DxSample.DAL.BO
	Public Class Sale
		Private privateDay As String
		Public Property Day() As String
			Get
				Return privateDay
			End Get
			Set(ByVal value As String)
				privateDay = value
			End Set
		End Property
		Private privateOrangesSold As Integer
		Public Property OrangesSold() As Integer
			Get
				Return privateOrangesSold
			End Get
			Set(ByVal value As Integer)
				privateOrangesSold = value
			End Set
		End Property
	End Class
End Namespace