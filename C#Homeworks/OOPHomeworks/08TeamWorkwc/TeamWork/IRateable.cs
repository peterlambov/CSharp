﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamWork
{
    interface IRateable
    {
        T Index<T>(params object[] searchKey);
    }
}
