using OmniReserve.Domain.Entities;

namespace OmniReserve.Application.Common.Interfaces;

public interface IRoomRepository
{
    Task AddAsync(Room room);
    
    // Nueva firma
    Task<Room?> GetByIdAsync(Guid id);
    Task<Room?> SearchByNumberAsync(string roomNumber);
    Task<List<Room>> GetRoomsByTypeRawAsync(string roomType);

}