using RamenGo.Communication.Request;
using RamenGo.Communication.Response.Order;
using RamenGo.Exceptions;

namespace RamenGo.Application.UseCases.Orders;
public class RegisterOrdersUseCase
{
    public ResponseOrderJson Execute(string apiKey, RequestOrderJson request)
    {
        Validate(apiKey, request);

        return new ResponseOrderJson();
    }

    private void Validate(string apiKey, RequestOrderJson request)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
            throw new ApiKeyMissingException("x-api-key header missing");

        if (string.IsNullOrWhiteSpace(request.ProteinId) || string.IsNullOrWhiteSpace(request.BrothId))
            throw new ErrorOnValidationException("both brothId and proteinId are required");

    }
}
