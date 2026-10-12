using MediatR;
using Microsoft.AspNetCore.Mvc;
using OmniReserve.Application.Rooms.Commands.CreateRoom;

namespace OmniReserve.Api.Controllers;

[ApiController]
[Route("api/[controllers]")]
public class RoomsControllers : Controllerbase
{
    public readonly ISenders _senders;
}