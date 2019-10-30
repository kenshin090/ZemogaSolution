using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces.Bll.Generic
{
    public interface IRepository<T> : IGet<T>, ICreate<T>, IUpdate<T>, ISearcheable<T>, IDelete
    {
    }
}