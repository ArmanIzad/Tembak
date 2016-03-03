using Bang_.Objects.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects.Game
  {
  public delegate void EndTurnDelegate();
  public delegate IPlayer ChoosePlayerDelegate(int number);
  public delegate IList<IPlayCard> DrawCardsDelegate(int number);
  public interface IGameHelper
    {

    EndTurnDelegate EndTurnDelegate { get; set; }
    ChoosePlayerDelegate ChoosePlayerDelegate { get; set; }
    DrawCardsDelegate DrawCardsDelegate { get; set; }
    }
  }
