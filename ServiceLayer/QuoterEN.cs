using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class QuoterEN : IQuotService
    {
        public string GetQuot()
        {
            return "Better Safe Then Sorry";
        } 
    }
}
