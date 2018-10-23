using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vuets.Model
{
  public class Hotel
  {
    public Guid Guid;
    public List<Comment> Comments;
    public List<Review> Reviews;
    public String Coordinates;
    public String Name;
  }
}
