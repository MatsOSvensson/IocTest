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
    public class QuotFactory : IQuotFactory
    {
        readonly string language;

        public QuotFactory(string language)
        {
            this.language = language;
        }

        public IQuotService GetQuotService()
        {
            if (language.Equals("EN"))
            {
                return new QuoterEN();
            }
            else if (language.Equals("SE"))
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
