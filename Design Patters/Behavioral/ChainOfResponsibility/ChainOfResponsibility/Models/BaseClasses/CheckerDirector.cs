using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models.SubClasses;
using FacadaPattern.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models.BaseClasses
{
    public class CheckerDirector
    {
        public ICheckerBuilder Builder { get; set; }

        public void MakeHumanChecker(Human human)
        {
            UsernameChecker usernameChecker = new();
            PasswordChecker passwordChecker = new();
            EmailChecker emailChecker = new();

            usernameChecker.Next =  passwordChecker;
            passwordChecker.Next = emailChecker;

            usernameChecker.Check(human);


        }


    }
}
