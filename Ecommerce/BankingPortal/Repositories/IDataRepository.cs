﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingPortal.Repositories { 
 public interface IDataRepository<T>
{
    bool Serialize(string filename, List<T> products);
    List<T> Deserialize(string filename);
}
}
