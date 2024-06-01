using RamenGo.Communication.Responses;
using RamenGo.Exceptions;

namespace RamenGo.Application.UseCases.Broths;
public class GetAllBrothsUseCase
{
    public List<ResponseGetAllBrothsJson> Execute(string apiKey)
    {
        Validate(apiKey);

        return [
            new ResponseGetAllBrothsJson()
            {
                Id = "1",
                Name = "Salt",
                Description = "Broth description",
                ImageActive = "Broth Image Active",
                ImageInactive = "Broth Image Inactive",
                Price = 10,
            },
            new ResponseGetAllBrothsJson()
            {
                Id = "2",
                Name = "Salt",
                Description = "Broth description",
                ImageActive = "Broth Image Active",
                ImageInactive = "Broth Image Inactive",
                Price = 11,
            },

       ];
    }

    private void Validate(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
            throw new ApiKeyMissingException("x-api-key header missing");
    }
}
