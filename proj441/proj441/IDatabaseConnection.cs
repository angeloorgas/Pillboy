using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace proj441
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
