namespace UserTicketService.Ticket.Services;

/// <summary>
/// Exception thrown when a ticket is not found.
/// </summary>
public class TicketNotFoundException: Exception 
{
    public TicketNotFoundException() 
    : base("Ticket not found.") {}

}