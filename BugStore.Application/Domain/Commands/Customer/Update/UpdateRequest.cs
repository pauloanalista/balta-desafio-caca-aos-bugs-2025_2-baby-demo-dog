using MediatR;
using System.Net;

namespace BugStore.Application.Domain.Commands.Customer.Update;

public class UpdateRequest : IRequest<UpdateResponse>
{
    public UpdateRequest(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}