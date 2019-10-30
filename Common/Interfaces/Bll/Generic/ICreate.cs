using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.Bll.Generic
{
    public interface ICreate<T>
    {
        T Create(T Entity);
    }
}