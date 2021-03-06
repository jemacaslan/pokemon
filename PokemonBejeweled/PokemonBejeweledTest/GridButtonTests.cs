﻿using System;
using NUnit.Framework;
using PokemonBejeweled;
using Rhino.Mocks;

namespace PokemonBejeweledTest
{
    [TestFixture]
    class GridButtonTests
    {
        private GameState _gameState = new GameState();
        private GridButton _gridButton;

        [Test]
        [STAThread]
        public void GridButton_RowSetCorrectly()
        {
            int row = 4;
            _gridButton = new GridButton(_gameState, row, 0);
            Assert.AreEqual(row, _gridButton.Row);
        }

        [Test]
        [STAThread]
        public void GridButton_ColSetCorrectly()
        {
            int col = 4;
            _gridButton = new GridButton(_gameState, 0, col);
            Assert.AreEqual(col, _gridButton.Column);
        }
    }
}
