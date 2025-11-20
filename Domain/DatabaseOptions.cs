using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DatabaseOptions
    {
#if DEBUG
        public const string DatabaseConnectionString = @"Data Source=CARACUIANUMIHAI\MSSQLSERVERPAD;Initial Catalog=PostMaker;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Command Timeout=0";
#endif
#if RELEASE
        public const string DatabaseConnectionString = @"Server=tcp:padserver.database.windows.net,1433;Initial Catalog=PostMaker;Persist Security Info=False;User ID=pad;Password=UTMti221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
#endif
    }
}
