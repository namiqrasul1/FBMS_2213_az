



using Memento;
using StatePattern;

//Storage st = new();

//st.Append("Chichak, aramiza qayit!");
//st.Save();

//st.Append("Qambar, burdasan?");
//st.Save();

//st.Append("Xalid, Butun fikrin burda olsun!");
//st.Save();

//try
//{
//    while (true)
//    {
//        st.Undo();
//        st.Show();
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}


Car car = new();

for (int i = 20; i < 100; i++)
{
    car.Drive(i);
    Thread.Sleep(200);
}
