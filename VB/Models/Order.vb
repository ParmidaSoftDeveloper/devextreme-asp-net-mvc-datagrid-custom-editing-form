Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DevExtremeMvcAppGridTest.Models
	Public Class Order
		Private privateOrderID As Integer
		Public Property OrderID() As Integer
			Get
				Return privateOrderID
			End Get
			Set(ByVal value As Integer)
				privateOrderID = value
			End Set
		End Property
		Private privateOrderDate As DateTime
		Public Property OrderDate() As DateTime
			Get
				Return privateOrderDate
			End Get
			Set(ByVal value As DateTime)
				privateOrderDate = value
			End Set
		End Property
		Private privateCustomerID As String
		Public Property CustomerID() As String
			Get
				Return privateCustomerID
			End Get
			Set(ByVal value As String)
				privateCustomerID = value
			End Set
		End Property
		Private privateCustomerName As String
		Public Property CustomerName() As String
			Get
				Return privateCustomerName
			End Get
			Set(ByVal value As String)
				privateCustomerName = value
			End Set
		End Property
		Private privateShipCountry As String
		Public Property ShipCountry() As String
			Get
				Return privateShipCountry
			End Get
			Set(ByVal value As String)
				privateShipCountry = value
			End Set
		End Property
		Private privateShipCity As String
		Public Property ShipCity() As String
			Get
				Return privateShipCity
			End Get
			Set(ByVal value As String)
				privateShipCity = value
			End Set
		End Property
	End Class
End Namespace
