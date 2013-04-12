﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBejeweled.Pokemon
{
    public class TotodileToken : PokemonToken
    {
        public TotodileToken()
        {
            firstEvolution = typeof(CroconawToken);
            secondEvolution = typeof(FeraligatorToken);
        }
    }
}