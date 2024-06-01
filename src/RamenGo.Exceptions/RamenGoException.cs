namespace RamenGo.Exceptions;
public abstract class RamenGoException : SystemException
{
    public RamenGoException(string message) : base(message)
    {

    }
}
