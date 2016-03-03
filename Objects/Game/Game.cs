using Bang_.Actions;
using Bang_.Objects.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects.Game
  {
  class Game : IGameHelper
    {
    //int is the identifier of the player, starts from 1 (should be sheriff)
    SortedList<int, IPlayer> Players { get; set; }
    Stack<IWorldCard> WorldCard { get; set; }
    Stack<IPlayCard> DrawPile { get; set; }
    Stack<IPlayCard> DiscardPile { get; set; }

    ITurnActions GameActions { get; set; }

    public EndTurnDelegate EndTurnDelegate { get; set; }

    public ChoosePlayerDelegate ChoosePlayerDelegate { get; set; }

    public DrawCardsDelegate DrawCardsDelegate { get; set; }

    private int m_turn = 1;
    private int m_round = 1;

    public Game()
      {
      EndTurnDelegate = PrepareNextTurn;
      DrawCardsDelegate = DrawCard;
      ChoosePlayerDelegate = ChoosePlayer;
      }

    public bool SetupGameWorld()
      {
      return SetupPlayers() && SetupRoles() && SetupCharacters() && SetupDrawPile() && SetupWorldCard();
      }

    public void StartGame() 
      {
      var current_player = Players.Values[m_turn];
      current_player.GetActions().StartTurn();
      }


    private void PrepareNextTurn()
      {
      //check stuff
      NextTurn();
      }

    private void NextTurn()
      {
      m_round++;
      m_turn++;
      if (m_turn > Players.Count())
        m_turn = 1;



      var current_player = Players.Values[m_turn];



      if(HasGameEnded())
        {
        //end game
        }

      if (current_player.CurrentLifePoints > 0)
        current_player.GetActions().StartTurn();
      else
        PrepareNextTurn();
      }

    private IList<IPlayCard> DrawCard(int number)
      {
      IList<IPlayCard> newcards = new List<IPlayCard>();
      for(int i = 0; i < number; ++i)
        {
        newcards.Add(DrawPile.Pop());
        }
      return newcards;
      }

    private IPlayer ChoosePlayer(int number)
      {
      return Players[number];
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
