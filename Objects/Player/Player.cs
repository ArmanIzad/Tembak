using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bang_.Objects.Cards;
using Bang_.Objects.Game;

namespace Bang_.Objects.Player
  {
  public class Player : IPlayer, IPlayerActions
    {
    private int _id;
    private string _name;
    private int _currentLifePoints;
    private IList<ICard> _hand = new List<ICard>();
    private IList<ICard> _table = new List<ICard>();
    private Tuple<ICharacterCard, ICharacterCard> _character;// = new Tuple<ICharacterCard, ICharacterCard>();
    private IRoleCard _role;
    private IGameHelper _helper;

    public Tuple<ICharacterCard, ICharacterCard> Character
      {
      get
        {
        return _character;
        }

      set
        {
        _character = value;
        }
      }

    public int CurrentLifePoints
      {
      get
        {
        return _currentLifePoints;
        }

      set
        {
        _currentLifePoints = value;
        }
      }

    public IList<ICard> Hand
      {
      get
        {
        return _hand;
        }

      set
        {
        _hand = value;
        }
      }

    public int Id
      {
      get
        {
        return _id;
        }

      set
        {
        _id = value;
        }
      }

    public string Name
      {
      get
        {
        return _name;
        }

      set
        {
        _name = value;
        }
      }

    public IRoleCard Role
      {
      get
        {
        return _role;
        }

      set
        {
        _role = value;
        }
      }

    public IList<ICard> Table
      {
      get
        {
        return _table;
        }

      set
        {
        _table = value;
        }
      }

    public int MaximumLifePoints
      {
      get;

      set;
      }

    public Player(int id, string name, IRoleCard role, Tuple<ICharacterCard, ICharacterCard> character, IGameHelper helper)
      {
      _id = id;
      _name = name;
      _role = role;
      _character = character;
      _helper = helper;

      MaximumLifePoints = _character.Item1.MaxLife;
      if (role.Role == Roles.Sheriff)
        MaximumLifePoints += 1;
      }

    public void StartTurn()
      {
      throw new NotImplementedException();
      }

    public void UseAbility()
      {
      throw new NotImplementedException();
      }

    public void SwapRole()
      {
      throw new NotImplementedException();
      }

    public void PlayCard(IPlayCard i_card_played, IPlayCard i_secondary_card = null)
      {
      throw new NotImplementedException();
      }

    public IPlayCard Respond(IPlayCard i_card_to_respond_to)
      {
      throw new NotImplementedException();
      }

    public IList<IPlayCard> Discard(int number, bool i_is_random)
      {
      throw new NotImplementedException();
      }

    public void RemoveCard(IPlayCard i_card_to_remove)
      {
      throw new NotImplementedException();
      }

    public void LoseLife(int i_life_points)
      {
      CurrentLifePoints -= i_life_points;
      }

    public void GainLife(int i_life_points)
      {
      if (CurrentLifePoints + i_life_points <= MaximumLifePoints)
        CurrentLifePoints += i_life_points;
      }

    public IRoleCard Reveal()
      {
      throw new NotImplementedException();
      }

    public IPlayCard Draw(IPlayer player)
      {
      throw new NotImplementedException();
      }

    public IList<IPlayCard> Draw(int number)
      {
      return _helper.DrawCardsDelegate(number);
      }

    public bool Check()
      {
      throw new NotImplementedException();
      }

    public void EndTurn()
      {
      throw new NotImplementedException();
      }

    public IPlayerActions GetActions()
      {
      return this;
      }
    }
  }
