using System.Threading;
using System.Threading.Tasks;
using Square.Core.Models;

namespace Square.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}