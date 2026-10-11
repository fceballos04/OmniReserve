using MediatR;

namespace OmniReserve.Application.Rooms.Queries.GetRoomById;

public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomResponseDto>
{
    public Task<RoomResponseDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
    {
        var response = new RoomResponseDto(
            request.RoomId, 
        );

        return Task.FromResult();
    }
}