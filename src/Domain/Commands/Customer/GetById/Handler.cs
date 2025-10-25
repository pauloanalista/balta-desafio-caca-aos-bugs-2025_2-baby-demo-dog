using MediatR;

namespace BugStore.Domain.Commands.Customer.GetById;

public class Handler : IRequestHandler<GetByIdRequest, GetByIdResponse>
{
    public async Task<GetByIdResponse> Handle(GetByIdRequest request, CancellationToken cancellationToken)
    {
        return new GetByIdResponse();
    }
}