namespace UserTicketService.Ticket.Interfaces;

/// <summary>
/// Interface for ticket service.
/// </summary>
/// <remarks>
/// This interface is used to get the ticket price.
/// </remarks>
public interface ITicketService 
{
  /// <summary>
  /// Get the price of a ticket.
  /// </summary>
  /// <param name="ticketId"></param>
  /// <returns></returns>
  int GetTicketPrice(int ticketId);
}