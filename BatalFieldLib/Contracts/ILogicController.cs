﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalFieldLib.Contracts
{
    public interface ILogicController
    {
        int GetMine(IGameObject battleField, int row, int col);
        void FieldUpdate(int row, int col, int n, IGameObject battleField);
        bool EndOfGameCheck(int fieldSize, IGameObject battleField);
    }
}