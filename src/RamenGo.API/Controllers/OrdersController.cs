using Microsoft.AspNetCore.Mvc;
using RamenGo.Application.UseCases.Orders;
using RamenGo.Communication.Request;
using RamenGo.Communication.Response.Order;
using RamenGo.Communication.Responses;
using RamenGo.Exceptions;

namespace RamenGo.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseOrderJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status403Forbidden)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status500InternalServerError)]
    public IActionResult PlaceOrder(
        [FromHeader] string apiKey,
        [FromBody] RequestOrderJson request)
    {
        try
        {
            var useCase = new RegisterOrdersUseCase();

            var response = useCase.Execute(apiKey, request);

            return Created(string.Empty, response);
        }
        catch (ErrorOnValidationException ex) { return StatusCode(StatusCodes.Status400BadRequest, ex.Message); }
        catch (ApiKeyMissingException ex) { return StatusCode(StatusCodes.Status403Forbidden, ex.Message); }
        catch { return StatusCode(StatusCodes.Status500InternalServerError, "could not place order"); }
    }
}

