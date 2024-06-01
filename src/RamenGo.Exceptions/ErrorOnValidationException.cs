namespace RamenGo.Exceptions;
public class ErrorOnValidationException : RamenGoException
{
    public ErrorOnValidationException(string message) : base(message)
    {
       
    }
}
