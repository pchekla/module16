using UserTicketService.Ticket.Interfaces;
using Moq;
using NUnit.Framework;
using UserTicketService.Ticket;

namespace UserTicketService.Tests;

public class TicketPriceTests 
{
  [Test]
  // Этот тест проверяет, что метод MakeTicketPrice возвращает правильную цену билета для заданного идентификатора билета.
  public void TicketPriceMustReturnNotNullableTicket() 
  {
    var mockTicketService = new Mock < ITicketService > ();
    mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
    mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
    mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

    var ticketPriceTest = new TicketPrice(mockTicketService.Object);
    Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
  }
  [Test]
  [TestCase(1, 100)]
  [TestCase(2, 500)]
  [TestCase(3, 7800)]
  public void MakeTicketPrice_ReturnsCorrectPrice(int ticketId, int expectedPrice)
  {
      var mockTicketService = new Mock<ITicketService>();
      mockTicketService.Setup(p => p.GetTicketPrice(ticketId)).Returns(expectedPrice);

      var ticketPrice = new TicketPrice(mockTicketService.Object);

      Assert.Equals(expectedPrice, ticketPrice.MakeTicketPrice(ticketId));
  }
}
