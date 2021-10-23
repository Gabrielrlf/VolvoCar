﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoCar.Infra.Service.Interface
{
    interface IService<T> where T : class
    {
        IQueryable<T> List();
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);

    }
}
