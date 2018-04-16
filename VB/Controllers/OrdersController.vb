Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports DevExtremeMvcAppGridTest.Models
Imports DevExtreme.AspNet.Data
Imports DevExtreme.AspNet.Mvc
Imports System.Net.Http.Formatting

Namespace DevExtremeMvcAppGridTest.Controllers
    Public Class OrdersController
        Inherits ApiController
        <HttpGet>
        Public Function [Get](ByVal loadOptions As DataSourceLoadOptions) As HttpResponseMessage
            Dim list = SampleData.Orders
            Return Request.CreateResponse(DataSourceLoader.Load(list, loadOptions))
        End Function
        <HttpPut>
        Public Function [Put](ByVal form As FormDataCollection) As HttpResponseMessage
            Return Request.CreateResponse(HttpStatusCode.Created)
        End Function
    End Class
End Namespace