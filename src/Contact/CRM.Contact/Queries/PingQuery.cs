using CRM.Contact.V1;
using MediatR;

namespace CRM.Contact.Queries
{
    public class PingQuery : IRequest<PongReply>
    {

    }
}