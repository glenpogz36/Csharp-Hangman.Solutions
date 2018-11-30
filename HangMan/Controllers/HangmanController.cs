using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HangMan.Models;

namespace HangMan.Controllers
{
    public class HangmanController : Controller
    {
        [HttpGet("/hangman")]
        public ActionResult Index()
        {
            Words.InitializeList();
            char letter = "a";
            int life = 6;
            bool isTrue = false;
            HangMan newHangMan = new HangMan(life, letter, isTrue);
            return View();
        }

        [HttpPost("/hangman")]
        public ActionResult Index(string userLetter)
        {
            char letter = userLetter[0];
            string word = Words.GetWord();
            char[] arr = word.ToCharArray();
            HangMan newHangMan = new HangMan(letter);
            foreach(char tempLetter in arr)
            {
                if (tempLetter == letter)
                {
                    hangMan.SetCorrect(true);
                }
            }
            if (hangMan.GetCorrect() == false)
            {
                hangMan.SetLife(hangMan.GetLife() - 1);
            }
            return View();
        }
    }
}
