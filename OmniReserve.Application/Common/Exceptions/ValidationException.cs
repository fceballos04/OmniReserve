using FluentValidation.Results;

namespace OmniReserve.Application.Common.Exceptions;

public class ValidationExceptions : Exceptions
{
    public IDictionary<string, string[]> Error { get; }
}