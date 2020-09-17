using System.Collections.Generic;

namespace msg_board.Models
{
  public class HomeMessageVM
  {
    public Message PostMessage { get; set; }
    public IEnumerable<Message> Messages { get; set; }
  }
}