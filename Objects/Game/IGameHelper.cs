using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects.Game
  {
  public delegate void EndTurnDelegate();
  public delegate IPlayer ChoosePlayerDelegate(IPlayer i_chooser);
  interface IGameHelper
    {
    }
  }
