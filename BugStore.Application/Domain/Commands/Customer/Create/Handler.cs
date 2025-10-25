using MediatR;

namespace BugStore.Application.Domain.Commands.Customer.Create;

public class Handler : IRequestHandler<CreateRequest, CreateResponse>
{
    public async Task<CreateResponse> Handle(CreateRequest request, CancellationToken cancellationToken)
    {
        return new CreateResponse();
    }
}