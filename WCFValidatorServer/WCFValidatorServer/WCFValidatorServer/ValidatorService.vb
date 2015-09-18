' NOTE: You can use the "Rename" command on the context menu to change the class name "ValidatorService" in both code and config file together.
Public Class ValidatorService
    Implements IValidatorService

    Function DoValidate(ByVal input As Integer) Implements IValidatorService.DoValidate
        Dim mainForm As Form1 = System.Windows.Forms.Application.OpenForms(0)
        If input = 1 Then
            mainForm.setLabel("True")
            Return ("True")
        End If
        Return "False"
    End Function

End Class
