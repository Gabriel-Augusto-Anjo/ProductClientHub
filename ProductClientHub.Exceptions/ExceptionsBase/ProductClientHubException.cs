using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public abstract class ProductClientHubException : SystemException
    {
        public ProductClientHubException(string errorMensage) : base(errorMensage)
        {
            
        }

        public abstract List<string> GetErrors();

        public abstract HttpStatusCode GetHttpStatusCode();
    }
}
