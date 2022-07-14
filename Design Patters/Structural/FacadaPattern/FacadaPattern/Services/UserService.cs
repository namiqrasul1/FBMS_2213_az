using FacadaPattern.Models.BaseClasses;
using FacadaPattern.Models.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadaPattern.Services
{
    public abstract class UserService
    {
        public static UserProcessResult SearchUser(User user)
        {
            return UserProcessResult.Succes;
        }
    }
}
