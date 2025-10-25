using MediatR;

namespace BugStore.Application.Domain.Commands.Customer.Update;

public class Handler : IRequestHandler<UpdateRequest, UpdateResponse>
{
    public async Task<UpdateResponse> Handle(UpdateRequest request, CancellationToken cancellationToken)
    {
        return new UpdateResponse();
    }
}