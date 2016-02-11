using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang_.Actions
  {
  interface ITurnActions
    {
    void PreTurn();
    void StartTurn();
    void DrawPhase();
    void Play();
    void EndTurn();
    void PostTurn();
    }
  }
