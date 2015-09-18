Imports WCFValidatorClient.ValidatorService
Imports System.ServiceModel

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("ip") = "192.168.88.88"
        Return View()
    End Function
    <HttpPost()>
    Function Index(ByVal input As Integer, Optional ByVal ip As String = "") As ActionResult
        Dim service As ValidatorServiceClient
        service = New ValidatorServiceClient()
        Dim message As String
        Try
            If Not String.IsNullOrEmpty(ip) Then
                service.Endpoint.Address = New EndpointAddress("http://" + ip + ":8732/Design_Time_Addresses/WCFValidatorServer/ValidatorService/")
            End If
            message = service.DoValidate(input)
        Catch ex As Exception
            message = ex.Message
        End Try
        ViewData("Message") = message
        ViewData("input") = input
        ViewData("ip") = ip
        Return View()
    End Function
End Class
