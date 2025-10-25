using BugStore.Domain.Commands.Customer.Delete;
using MediatR;

namespace BugStore.Domain.Commands.Customer.Delete;

public class Handler : IRequestHandler<DeleteRequest, DeleteResponse>
{
    public async Task<DeleteResponse> Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        return new DeleteResponse();
    }
}