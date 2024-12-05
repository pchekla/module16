using UserTicketService.Ticket.Services;
using NUnit.Framework;

namespace UserTicketService.Tests;

[TestFixture]
public class TicketServiceTests
{
    private TicketService _ticketService;

    [SetUp]
    public void Setup()
    {
        _ticketService = new TicketService();
    }

    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void GetTicketPrice_ReturnsPriceForValidTicket(int ticketId)
    {
        var price = _ticketService.GetTicketPrice(ticketId);
        Assert.That(price, Is.GreaterThan(0));
    }

    [Test]
    [TestCase(100)]
    [TestCase(-1)]
    [TestCase(0)]
    public void GetTicketPrice_ThrowsExceptionForInvalidTicket(int ticketId)
    {
        Assert.Throws<TicketNotFoundException>(() => _ticketService.GetTicketPrice(ticketId));
    }
}