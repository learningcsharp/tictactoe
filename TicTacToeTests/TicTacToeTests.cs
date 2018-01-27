using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Tests
{
    [TestClass()]
    public class TicTacToeTests
    {
        /// <summary>
        /// This is a quick test to make sure we never return a null board. We will be printing this to the screen.
        /// We do not care what it looks like from a unit test, that's what QA is for :)
        /// But we do know that pass null to Console.WriteLine() will not end well for our gamers.
        /// </summary>
        [TestMethod()]
        public void DisplayBoardIsNeverNullTest()
        {
            // Arrange
            //Nada!

            // Act
            string board = TicTacToe.CreateDisplayBoard();

            // Assert
            Assert.IsNotNull(board);
        }
    }
}