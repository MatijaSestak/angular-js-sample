﻿using System.Collections.Generic;

namespace AngularJsSample.Common
{
    public interface IRepository<T,TKey>
    {
        List<T> FindAll();
        T FindBy(TKey key);
        TKey Add(T item);
        bool Delete(T item);
        T Save(T item);
    }
}