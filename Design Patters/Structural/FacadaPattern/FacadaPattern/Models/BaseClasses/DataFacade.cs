using FacadaPattern.Models.SubClasses;
using FacadaPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadaPattern.Models.BaseClasses
{
    public class DataFacade
    {
        public User User { get; set; }

        public bool Remember = false;


        public UserProcessResult Login(User user)
        {
            UserService.SearchUser(user);

            // Perfect Code

            EmailService.Send("Secure code : 1234");

            return UserProcessResult.Succes;


        }

    }
}
