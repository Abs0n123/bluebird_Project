﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace bluebirdProject
{
    class Globaal
    {
        public static OleDbConnection Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    data source = ..\..\..\BluebirdDB.accdb ; Persist Security Info=False;");
    }
}
