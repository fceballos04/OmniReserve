using OmniReserve.Application.Common.Interfaces;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Infrastructure.Persistence.Repositories;

public class RoomRepository : IRoomRepository
{
    private static readonly Dictionary<Guid, Room> _rooms = new();

    public Task AddAsync(Room room)
    {
        return Task.CompletedTask;
    }

    public Task<Room?> GetByIdAsync(Guid id)
    {
        return Task.FromResult(room);
    }
}