﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBejeweled.Pokemon;

namespace PokemonBejeweled
{
    public class PokemonGrid
    {
        private PokemonToken[,] pokemon;
        private PokemonToken[,] pokemonOld;
        private int gamePlayScore;
        private int pokemonGridSize = 8;


        public PokemonGrid()
        {
            pokemon = new PokemonToken[pokemonGridSize, pokemonGridSize];
            pokemonOld = new PokemonToken[pokemonGridSize, pokemonGridSize];
            gamePlayScore = 0;
        }

        public object getPokemonGrid()
        {
            throw new NotImplementedException();
        }

        private void updateBoardAlgorithm()
        {
        }

       
    }
}
