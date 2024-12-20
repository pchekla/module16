using UserTicketService.Ticket.Interfaces;

namespace UserTicketService.Ticket.Services;
/// <summary>
/// Service for ticket operations.
/// </summary>
public class TicketService: ITicketService 
{
   /// <summary>
   /// Get the price of a ticket.
   /// </summary>
   /// <param name="ticketId"></param>
   /// <returns></returns>
   /// <exception cref="TicketNotFoundException"></exception>
   public int GetTicketPrice(int ticketId) 
   {
      var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
      return (ticket is null) ?
         throw new TicketNotFoundException(): ticket.Price;
   }
   /// <summary>
   /// Fake data for tickets.
   /// </summary>
   private IEnumerable < Ticket > FakeBaseData 
   {
      get {
         return new List < Ticket > 
         {
            new Ticket(1, "Москва - Санкт-Петербург", 3500),
            new Ticket(2, "Челябинск - Магадан", 3500),
            new Ticket(3, "Норильск - Уфа", 3500)
         };
      }
   }
}