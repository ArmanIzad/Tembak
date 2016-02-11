using Bang_.Actions;
using Bang_.Objects.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects
  {
  class Game
    {
    SortedList<int, IPlayer> Players { get; set; }
    Stack<IWorldCard> WorldCard { get; set; }
    IList<IPlayCard> DrawPile { get; set; }
    IList<IPlayCard> DiscardPile { get; set; }

    ITurnActions GameActions { get; set; }

    public bool SetupGameWorld()
      {
      return SetupPlayers() && SetupRoles() && SetupCharacters() && SetupDrawPile() && SetupWorldCard();
      }

    public void StartGame()
      {
      int turn = 1; 
      //game loop
      while(!HasGameEnded())
        {
        int player_turn = 1;
        while(player_turn <= Players.Count)
          {
          var current_player = Players.Values[player_turn];
          player_turn++;
          if (current_player.CurrentLifePoints == 0)
            continue;

          GameActions.PreTurn();
          GameActions.StartTurn();
          GameActions.DrawPhase();
          GameActions.Play();
          GameActions.EndTurn();
          GameActions.PostTurn();
          }

        turn++;
        }
      }

    //game ends when sheriff is dead or all outlaws and renegades are dead
    private bool HasGameEnded()
      {
      var isSheriffDead = Players.Where(x => (x.Value.Role.Role == Roles.Sheriff)).Any(x => x.Value.CurrentLifePoints == 0);
      var areTheBadGuysDead = Players.Where(x => (x.Value.Role.Role == Roles.Outlaw) || (x.Value.Role.Role == Roles.Renegade)).All(x => x.Value.CurrentLifePoints == 0);
      return isSheriffDead || areTheBadGuysDead;
      }

    private bool SetupPlayers()
      {
      return true;
      }

    private bool SetupRoles()
      {
      return true;
      }

    private bool SetupCharacters()
      {
      return true;
      }
    private bool SetupDrawPile()
      {
      return true;
      }
    private bool SetupWorldCard()
      {
      return true;
      }
    }
  }
