using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects.Cards
  {
  public interface IPlayCard : ICard
    {
    CardData.PlayCardType CardType { get; set; }
    CardData.Suits Suit { get; set; }

    //number? forgot

    bool NeedATarget { get; set; }
    }
  }
