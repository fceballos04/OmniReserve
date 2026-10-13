using MediatR;
using OmniReserve.Application.Common.Interfaces;

namespace OmniReserve.Application.Reservations.Queries.GetReservationDetails;

public class GetReservationDetailsQueryHandler : IRequestHandler<GetReservationDetailsQuery, ReservationDetailsDto>
{
    private readonly IReservationRepository _reservationRepository;

    public GetReservationDetailsQueryHandler(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }
}