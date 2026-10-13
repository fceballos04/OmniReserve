using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using OmniReserve.Application.Common.Exceptions;

namespace OmniReserve.Api.Middlewares;

public class GlobalExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalExceptionHandlingMiddleware> _loger;

    public GlobalExceptionHandlingMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _loger = loger;
    }

    public async Task InvokeAsync(HttpContext contexts)
    {
        try
        {
            await _next(contexts);
        }
        catch (Exception)
        {
            _logger.LogError("Ocurrió una excepción no manejada.");
            await HandleExceptionAsync(context);
        }
    }