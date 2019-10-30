using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.Bll.Generic
{
    public interface ISearcheable<T>
    {
        List<T> Search(bool all);
    }
}