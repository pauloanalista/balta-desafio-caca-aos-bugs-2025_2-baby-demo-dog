using MediatR;

namespace BugStore.Domain.Commands.Customer.Delete;

public class DeleteRequest : IRequest<DeleteResponse>
{
    public DeleteRequest(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}