using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HangMan;

namespace HangMan.Models
{
    public class Words
    {
        private static List<string> _words = new List<string> {};

        public static void InitializeList()
        {
            _words.Add("dog");
            _words.Add("cat");
        }
        public string GetWord()
        {
            return _words[0];
        }
    }
}