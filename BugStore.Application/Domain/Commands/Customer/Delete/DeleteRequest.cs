using MediatR;

namespace BugStore.Application.Domain.Commands.Customer.Delete;

public class DeleteRequest : IRequest<DeleteResponse>
{
    public DeleteRequest(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}