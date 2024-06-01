using Microsoft.AspNetCore.Mvc;
using RamenGo.Application.UseCases.Broths;
using RamenGo.Application.UseCases.Proteins;
using RamenGo.Communication.Request;
using RamenGo.Communication.Responses;
using RamenGo.Exceptions;

namespace RamenGo.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OptionsController : ControllerBase
{
    [HttpGet("Broths")]
    [ProducesResponseType(typeof(ResponseGetAllBrothsJson),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson),StatusCodes.Status403Forbidden)]
    public IActionResult GetBroths([FromHeader] string apiKey)
    {
        try
        {
            var useCase = new GetAllBrothsUseCase();

            var response = useCase.Execute(apiKey);

            return Ok(response);
        }
        catch (ApiKeyMissingException ex) { return StatusCode(StatusCodes.Status403Forbidden, ex.Message); }
    }

    [HttpGet("Proteins")]
    [ProducesResponseType(typeof(ResponseGetAllProteinsJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status403Forbidden)]
    public IActionResult GetProteins([FromHeader] string apiKey)
    {
        try
        {
            var useCase = new GetAllProteinsUseCase();

            var response = useCase.Execute(apiKey);

            return Ok(response);
        }
        catch (ApiKeyMissingException ex) { return StatusCode(StatusCodes.Status403Forbidden, ex.Message); }
    }
}
