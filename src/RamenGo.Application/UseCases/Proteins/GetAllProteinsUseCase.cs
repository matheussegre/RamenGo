using RamenGo.Communication.Responses;
using RamenGo.Exceptions;

namespace RamenGo.Application.UseCases.Proteins;
public class GetAllProteinsUseCase
{
    public List<ResponseGetAllProteinsJson> Execute(string apiKey)
    {
        Validate(apiKey);

        return [
            new ResponseGetAllProteinsJson()
            {
                Id = "1",
                Name = "Chasu",
                Description = "Protein description",
                ImageActive = "Protein Image Active",
                ImageInactive = "Protein Image Inactive",
                Price = 12,
            },
            new ResponseGetAllProteinsJson()
            {
                Id = "2",
                Name = "Chasu",
                Description = "Protein description",
                ImageActive = "Protein Image Active",
                ImageInactive = "Protein Image Inactive",
                Price = 12,
            },
        ];
    }

    private void Validate(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
            throw new ApiKeyMissingException("x-api-key header missing");
    }
}
