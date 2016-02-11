using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Objects.Cards
  {
  interface IRoleCard : ICard
    {
    Roles Role { get; set; }
    }
  }
