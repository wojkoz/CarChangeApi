using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;
using CarChangeApi.Contracts.Requests;

namespace CarChangeApi.Pipes
{
    public class UserIdPipe<TIn, TOut> : IPipelineBehavior<TIn, TOut>
    {
        private readonly HttpContext httpContext;

        public UserIdPipe(IHttpContextAccessor accessor)
        {
            httpContext = accessor.HttpContext;
        }

        public Task<TOut> Handle(TIn request, CancellationToken cancellationToken, RequestHandlerDelegate<TOut> next)
        {
            var userId = httpContext.User.Claims.
                FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier))
                .Value;

            if(request is BaseRequest baseRequest)
            {
                baseRequest.UserId = userId;
            }

            return next();
        }
    }
}
