using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class QuoterSE : IQuotService
    {
        public string GetQuot()
        {
            return "Ropa inte hej förän björnen är skjuten";
        } 
    }
}