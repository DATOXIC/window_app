using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace window_app
{
    internal interface MutualFunc
    {
        bool Insert();
        bool Update();
        bool Delete(int id);
        DataTable GetData(SqlCommand command);
    }
}
