using BugStore.Domain.Commands.Customer.Create;
using BugStore.Domain.Commands.Customer.Delete;
using BugStore.Domain.Commands.Customer.Get;
using BugStore.Domain.Commands.Customer.GetById;
using BugStore.Domain.Commands.Customer.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BugStore.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("/v1/customers")]
        public async Task<IActionResult> ListarArtigo()
        {
            try
            {
                var request = new GetRequest();
                var result = await _mediator.Send(request, CancellationToken.None);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("/v1/customers/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            try
            {
                var request = new GetByIdRequest(id);
                var result = await _mediator.Send(request, CancellationToken.None);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/v1/customers")]
        public async Task<IActionResult> Create([FromBody] CreateRequest request)
        {
            try
            {
                var result = await _mediator.Send(request, CancellationToken.None);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("/v1/customers/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody]UpdateRequest request)
        {
            try
            {
                var result = await _mediator.Send(request, CancellationToken.None);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("/v1/customers/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                var request = new DeleteRequest(id);
                var result = await _mediator.Send(request, CancellationToken.None);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
