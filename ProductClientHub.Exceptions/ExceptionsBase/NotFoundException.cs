using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public class NotFoundException : ProductClientHubException
    {
        public NotFoundException(string errorMensage) : base(errorMensage)
        {
        }

        public override List<string> GetErrors() => [Message];

        public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.NotFound;
    }
}
