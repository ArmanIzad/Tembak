using Bang_.Actions;
using Bang_.Objects.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects.Game
  {
  class Game
    {
    //int is the identifier of the player, starts from 1 (should be sheriff)
    SortedList<int, IPlayer> Players { get; set; }
    Stack<IWorldCard> WorldCard { get; set; }
    IList<IPlayCard> DrawPile { get; set; }
    IList<IPlayCard> DiscardPile { get; set; }

    ITurnActions GameActions { get; set; }

    //delegates
    //public delegate void EndTurnDelegate();

    private int m_turn = 0;
    public bool SetupGameWorld()
      {
      return SetupPlayers() && SetupRoles() && SetupCharacters() && SetupDrawPile() && SetupWorldCard();
      }

    public void StartGame()
      {
      //m_turn = 1;

      var current_player = Players.Values[m_turn];
      //current_player.Actions.StartTurn

      //this doesnt work
      //game loop
      while (!HasGameEnded())
        {
        int player_turn = 1;
        while(player_turn <= Players.Count)
          {
          //var current_player = Players.Values[player_turn];
          //player_turn++;
          //if (current_player.CurrentLifePoints == 0)
          //  continue;

          //GameActions.PreTurn();
          //GameActions.StartTurn();
          //GameActions.DrawPhase();
          //GameActions.Play();
          //GameActions.EndTurn();
          //GameActions.PostTurn();
          }

        m_turn++;
        }
      }

    public void NextTurn()
      {
      m_turn++;
      var current_player = Players.Values[m_turn];
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
