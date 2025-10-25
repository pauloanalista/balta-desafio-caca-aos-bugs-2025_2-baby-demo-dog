using MediatR;

namespace BugStore.Domain.Commands.Customer.Get;

public class Handler : IRequestHandler<GetRequest, GetResponse>
{
    public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
    {
        return new GetResponse();
    }
}