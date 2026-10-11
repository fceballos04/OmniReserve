using FluentValidation;
using MediatR;
using ValidationException = OmniReserve.Application.Common.Exceptions.ValidationException;

namespace OmniReserve.Application.Common.Behaviors;

public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IEnumerable<IValidator<TRequest>> _validator;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validator)
    {
        _validator = validator;
    }
}