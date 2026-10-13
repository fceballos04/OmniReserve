using OmniReserve.Domain.Entities;

namespace OmniReserve.Application.Common.Interfaces;

public interface IRoomRepository
{
    Task AddAsync(Room room);
    
    // Nueva firma
    Task<Room?> SearchByNumberAsync(string roomNumber);
}