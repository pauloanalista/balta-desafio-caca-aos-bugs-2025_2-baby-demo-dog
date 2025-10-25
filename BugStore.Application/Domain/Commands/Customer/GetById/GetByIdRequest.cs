using MediatR;
using System.Net;

namespace BugStore.Application.Domain.Commands.Customer.GetById;

public class GetByIdRequest : IRequest<GetByIdResponse>
{
    public GetByIdRequest(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}