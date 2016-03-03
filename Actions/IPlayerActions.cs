using Bang_.Objects.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects
  {
  public interface IPlayerActions
    {
    void StartTurn();
    void UseAbility();
    void SwapRole();
    void PlayCard(IPlayCard i_card_played, IPlayCard i_secondary_card = null);
    IPlayCard Respond(IPlayCard i_card_to_respond_to);
    IList<IPlayCard> Discard(int number, bool i_is_random);
    void RemoveCard(IPlayCard i_card_to_remove);
    void LoseLife(int i_life_points);
    void GainLife(int i_life_points);
    //Reveal your role when life is 0
    IRoleCard Reveal();
    //Draw from player
    IPlayCard Draw(IPlayer player);
    IList<IPlayCard> Draw(int number);
    //Check for hearts or other shapes
    bool Check();
    void EndTurn();
    }
  }
