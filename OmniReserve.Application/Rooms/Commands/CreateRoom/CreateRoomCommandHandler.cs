using MediatR;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Application.Rooms.Commands.CreateRoom;

public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Guid>
{
    public Task<Guid> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
    {
        // Se instancia la entidad de dominio con las reglas dictadas en el constructor
        var room = new Room(request.RoomNumber, request.Type, request.PricePerNight);
    }
}