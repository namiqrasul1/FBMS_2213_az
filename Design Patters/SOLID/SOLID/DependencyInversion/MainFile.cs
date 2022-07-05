using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Polymorphism;
//Database db = new NoSql();

//db.Add();
//db.Delete();

//db.Update();

//Database[] databases = new Database[4]
//{
//    new Database(),
//    new Oracle(),
//    new MsSql(),
//    new NoSql()
//};

//foreach (var db in databases)
//{
//    db.Add();
//}


var app = new Application(new MsSql());

app.DoSomething();


