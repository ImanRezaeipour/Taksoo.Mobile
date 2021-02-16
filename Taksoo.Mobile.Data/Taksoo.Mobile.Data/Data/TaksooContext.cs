using Taksoo.Mobile.Data.Model;
using SQLite;
using Xamarin.Forms;

namespace Taksoo.Mobile.Data.Data
{
    public class TaksooContext
    {
       public readonly SQLiteConnection Database;
        public TaksooContext(SQLiteConnection sqLiteConnection)
        {
            Database = sqLiteConnection;
            Database.CreateTable<User>();
        }
    }
}
