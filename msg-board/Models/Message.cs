using System.ComponentModel.DataAnnotations;

namespace msg_board.Models
{
  /// <summary>
  /// The Catagory that is used to seperate a product into a 
  /// specific genre
  /// </summary>
  public class Message
  {
    /// <summary>
    /// Catagory's unique ID
    /// </summary>
    /// <value></value>
    [Required]
    public int ID { get; set; }
    /// <summary>
    /// Name of the catagory (eg. Furniture)
    /// </summary>
    /// <value></value>
    [Required]
    public string MessageText { get; set; }
  }
}