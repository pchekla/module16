using UserTicketService.Ticket.Services;
using NUnit.Framework;

namespace UserTicketService.Tests;

[TestFixture]
public class TicketServiceTests 
{
  // This test checks if the GetTicketPrice method returns a price greater than 0 for an existing ticket with ID 1.
  [Test]
  public void GetTicketPriceMustReturnExistingPrice() 
  {
    var ticketServiceTest = new TicketService();
    Assert.That(ticketServiceTest.GetTicketPrice(1), Is.GreaterThan(0));
  }

  // This test checks if the GetTicketPrice method throws a TicketNotFoundException for a non-existing ticket with ID 100.
  [Test]
  public void GetTicketPriceMustThrowException() 
  {
    var ticketServiceTest = new TicketService();
    Assert.Throws < TicketNotFoundException > (() => ticketServiceTest.GetTicketPrice(100));
  }

}
