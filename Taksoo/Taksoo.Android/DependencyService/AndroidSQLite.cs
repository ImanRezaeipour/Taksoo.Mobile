using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Taksoo.Droid.DependencyService;
using Taksoo.IDependencyService;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidSqLite))]
namespace Taksoo.Droid.DependencyService
{
    public class AndroidSqLite :  ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Taksoo.db3";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, sqliteFilename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
        
    }
}