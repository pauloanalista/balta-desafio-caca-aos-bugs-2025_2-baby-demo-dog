using MediatR;

namespace BugStore.Application.Domain.Commands.Customer.Delete;

public class Handler : IRequestHandler<DeleteRequest, DeleteResponse>
{
    public async Task<DeleteResponse> Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        return new DeleteResponse();
    }
}