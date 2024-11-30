using UserTicketService.Ticket.Interfaces;

namespace UserTicketService.Ticket;

/// <summary>
/// Ticket price class.
/// </summary>
public class TicketPrice 
{
    /// <summary>
    /// Ticket service.
    /// </summary>
    private readonly ITicketService _ticketService;

    public TicketPrice(ITicketService ticketService) 
    {
        _ticketService = ticketService;
    }

    /// <summary>
    /// Make ticket price.
    /// </summary>
    /// <param name="ticketId"></param>
    /// <returns></returns>
    public int MakeTicketPrice(int ticketId) 
    {
        return _ticketService.GetTicketPrice(ticketId);
    }
}