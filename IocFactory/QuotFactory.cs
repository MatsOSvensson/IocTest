using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using ServiceLayer;

namespace IocFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class Factory
    {
        public static IQuotService GetQuotService()
        {
            return QuotFactory.Create("EN");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class QuotFactory
    {
        public static IQuotService Create(string lang)
        {
            if (lang.Equals("EN"))
            {
                return new QuoterEN();
            }
            else if (lang.Equals("SE"))
            {
                return new QuoterSE();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
