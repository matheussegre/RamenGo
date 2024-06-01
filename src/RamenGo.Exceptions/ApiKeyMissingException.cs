namespace RamenGo.Exceptions;
public class ApiKeyMissingException : RamenGoException
{
    public ApiKeyMissingException(string message) : base(message)
    {
    }
}
