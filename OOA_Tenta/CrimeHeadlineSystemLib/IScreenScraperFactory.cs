using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystemLib
{
    public interface IScreenScraperFactory
    {
        IScreenScraperService CreateFactory(string type);
    }
}
