namespace Strategy
{
    class ShieldDefencestrategy : IDefenceStrategy
    {
        public void Defence()
        {
            Console.WriteLine("I have shield. You cant touch me hahahaha");
        }
    }
}