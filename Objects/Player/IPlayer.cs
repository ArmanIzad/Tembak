using Bang_.Objects.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects
  {
  public interface IPlayer
    {
    int Id { get; set; }
    int Name { get; set; }
    int CurrentLifePoints { get; set; }
    IList<ICard> Hand { get; set; }
    IList<ICard> Table { get; set; }
    Tuple<ICharacterCard, ICharacterCard> Character { get; set; }
    IRoleCard Role { get; set; }
    IPlayerActions Actions { get; set; }
    }
  }
