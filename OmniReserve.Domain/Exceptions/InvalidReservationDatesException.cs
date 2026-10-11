namespace OmniReserve.Domain.Exceptions;

public class InvalidReservationDatesException : DomainException
{
    public InvalidReservationDatesException() 
        : base("La fecha de Check-out no puede ser la misma o antes que la fecha de Check-in.")
    {
    }
}