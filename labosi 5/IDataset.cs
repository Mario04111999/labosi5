﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_5
{
    interface IDataset
    {

        ReadOnlyCollection<List<string>> GetData();
    }
}
