Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IValidatorService" in both code and config file together.
<ServiceContract()>
Public Interface IValidatorService

    <OperationContract()>
    Function DoValidate(ByVal input As Integer)

End Interface
