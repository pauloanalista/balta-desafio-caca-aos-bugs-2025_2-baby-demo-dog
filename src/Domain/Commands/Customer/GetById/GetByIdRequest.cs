using MediatR;
using System.Net;

namespace BugStore.Domain.Commands.Customer.GetById;

public class GetByIdRequest : IRequest<GetByIdResponse>
{
    public GetByIdRequest(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}