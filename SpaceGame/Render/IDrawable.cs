﻿using SpaceGame.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Render
{
    interface IDrawable
    {
        void Draw(Transform objectTransorm, Camera viewer);
    }
}
