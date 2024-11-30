namespace UserTicketService.Ticket;

/// <summary>
/// Ticket class.
/// </summary>
public class Ticket 
{
  /// <summary>
  /// Ticket id.
  /// </summary>
  public int Id { get; }

  /// <summary>
  /// Ticket description.
  /// </summary>
  public string Description { get; }

  /// <summary>
  /// Ticket price.
  /// </summary>
  public int Price { get; }

  /// <summary>
  /// Constructor for the ticket.
  /// </summary>
  /// <param name="id"></param>
  /// <param name="description"></param>
  /// <param name="price"></param>
  public Ticket(int id, string description, int price) 
  {
    this.Id = id;
    this.Description = description;
    this.Price = price;
  }
}