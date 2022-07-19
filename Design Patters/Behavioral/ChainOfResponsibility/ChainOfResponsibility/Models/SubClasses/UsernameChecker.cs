using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models.BaseClasses;
using FacadaPattern.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models.SubClasses
{
    public class UsernameChecker : BaseChecker
    {
        public override void Check(object request)
        {
            if (request is Human human)
            {
                if (!string.IsNullOrWhiteSpace(human.Username))
                    Next.Check(request);
            }
        }
    }
}
