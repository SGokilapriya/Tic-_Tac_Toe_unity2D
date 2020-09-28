using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class editmodetestscript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void editmodetestscriptSimplePasses()
        {
           
        }

        [Test]
        public void ChangeSideToO()
        {
            var playerSide ='X';
            if (playerSide == 'X')
                playerSide = 'O';
            Assert.That('O', Is.EqualTo(playerSide));
        }

        [Test]
        public void ChangeSideToX()
        {
            var playerSide = 'O';
            if (playerSide == 'O')
                playerSide = 'X';
            Assert.That('X', Is.EqualTo(playerSide));
        }

        [Test]
        public void RowWinCheckForX()
        {
            string[] buttonList = new string[] { "X", "X", "X", "X", "X", "X", "X", "X", "X" };
            var count = 0;
            for (int i = 0; i < 9; i = i + 3)
            {
                if ((buttonList[i] == buttonList[i + 1]) && (buttonList[i + 1] == buttonList[i + 2]))
                    ++count;
            }
            Assert.That(3, Is.EqualTo(count));
        }


        [Test]
        public void RowWinCheckForO()
        {
            string[] buttonList = new string[] { "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            var count = 0;
            for (int i = 0; i < 9; i = i + 3)
            {
                if ((buttonList[i] == buttonList[i + 1]) && (buttonList[i + 1] == buttonList[i + 2]))
                    ++count;
            }
            Assert.That(3, Is.EqualTo(count));
        }

        [Test]
        public void ColumnWinCheckForX()
        {
            string[] buttonList = new string[] { "X", "X", "X", "X", "X", "X", "X", "X", "X" };
            var count = 0;
            for (int i = 0; i < 3; i = i ++)
            {
                if ((buttonList[i] == buttonList[i + 3]) && (buttonList[i + 3] == buttonList[i + 6]))
                    ++count;
            }
            Assert.That(3, Is.EqualTo(count));
        }

        [Test]
        public void ColumnWinCheckForO()
        {
            string[] buttonList = new string[] { "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            var count = 0;
            for (int i = 0; i < 3; i = i++)
            {
                if ((buttonList[i] == buttonList[i + 3]) && (buttonList[i + 3] == buttonList[i + 6]))
                    ++count;
            }
            Assert.That(3, Is.EqualTo(count));
        }
        [Test]
        public void RowFirstWinCheckForX()
        {
            string[] buttonList = new string[] { "X", "X", "X", "-", "O", "-", "O", "-", "-" };
            var count = 0;
            for (int i = 0; i < 9; i = i + 3)
            {
                if ((buttonList[i] == buttonList[i + 1]) && (buttonList[i + 1] == buttonList[i + 2]))
                    ++count;
            }
            Assert.That(1, Is.EqualTo(count));
        }
    }
}
