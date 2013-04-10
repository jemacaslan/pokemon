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
        public static int gridSize = 8;
        public int GamePlayScore { get; set; }
        private PokemonToken[,] _pokemon = new PokemonToken[gridSize, gridSize];
        public PokemonToken[,] Pokemon
        {
            get
            {
                return _pokemon;
            }
            set
            {
                copyGrid(value, _pokemon);
            }
        }

        public PokemonGrid()
        {
            Pokemon = new PokemonToken[gridSize, gridSize];
            GamePlayScore = 0;
        }

        public void pullDownTokens()
        {
        }

        public void addNewTokens()
        {
        }

        public Boolean isValidMove(int row1, int col1, int row2, int col2)
        {
            return false;
        }

        public PokemonToken updateMovedToken(int row, int col)
        {
            return null;
        }

        public void updateBoard()
        {
            PokemonToken[,] newPokemon = new PokemonToken[gridSize, gridSize];
            copyGrid(_pokemon, newPokemon);
            markColumnsOfSameTokenAsNull(newPokemon);
            markRowsOfSameTokenAsNull(newPokemon);
            copyGrid(newPokemon, _pokemon);
            pullDownTokens();
            addNewTokens();
        }

        private void markRowsOfSameTokenAsNull(PokemonToken[,] newPokemon)
        {
            int numberOfSameTokens;
            PokemonToken currentToken;
            for (int row = 0; row < gridSize; row++)
            {
                currentToken = _pokemon[row, 0];
                numberOfSameTokens = 1;
                for (int col = 1; col < gridSize; col++)
                {
                    if (currentToken.GetType() == _pokemon[row, col].GetType())
                    {
                        numberOfSameTokens++;
                    }
                    else if (3 <= numberOfSameTokens)
                    {
                        while (numberOfSameTokens > 0)
                        {
                            newPokemon[row, col - numberOfSameTokens] = null;
                            numberOfSameTokens--;
                        }
                    }
                    else
                    {
                        currentToken = _pokemon[row, col];
                    }
                }
                if (3 <= numberOfSameTokens)
                {
                    while (numberOfSameTokens > 0)
                    {
                        newPokemon[row, gridSize - numberOfSameTokens] = null;
                        numberOfSameTokens--;
                    }
                }
            }
        }

        private void markColumnsOfSameTokenAsNull(PokemonToken[,] newPokemon)
        {
            int numberOfSameTokens;
            PokemonToken currentToken;
            for (int col = 0; col < gridSize; col++)
            {
                currentToken = _pokemon[0, col];
                numberOfSameTokens = 1;
                for (int row = 1; row < gridSize; row++)
                {
                    if (currentToken.GetType() == _pokemon[row, col].GetType())
                    {
                        numberOfSameTokens++;
                    }
                    else if (3 <= numberOfSameTokens)
                    {
                        while (numberOfSameTokens > 0)
                        {
                            newPokemon[row - numberOfSameTokens, col] = null;
                            numberOfSameTokens--;
                        }
                    }
                    else
                    {
                        currentToken = _pokemon[row, col];
                    }
                }
                if (3 <= numberOfSameTokens)
                {
                    while (numberOfSameTokens > 0)
                    {
                        newPokemon[gridSize - numberOfSameTokens, col] = null;
                        numberOfSameTokens--;
                    }
                }
            }
        }

        public static void copyGrid(PokemonToken[,] gridToCopy, PokemonToken[,] gridDestination)
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    gridDestination[row, col] = gridToCopy[row, col];
                }
            }
        }
    }
}
