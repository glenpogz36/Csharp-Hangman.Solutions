using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HangMan;

namespace HangMan.Models
{
    public class HangMan
    {
        private char _letter;
        private int _life;
        private bool _isTrue;

        
        public HangMan(int life, char letter, bool isTrue)
        {
            _life = life;
            _letter = letter;
            _isTrue = isTrue;
        }

        public int GetLife()
        {
            return _life;
        }

        public void SetLife(int life)
        {
            _life = life;
        }

        public char GetLetter()
        {
            return _letter;
        }

        public void SetLetter(char letter)
        {
            _letter = letter;
        }

        public bool GetCorrect()
        {
            return _isTrue;
        }

        public void SetCorrect(bool truth)
        {
            _isTrue = truth;
        }
    }
}
