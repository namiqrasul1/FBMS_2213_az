using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{

    public enum StateType
    {
        Electro,
        Gasoline
    }

    public class Car
    {
        public StateType State { get; set; } = StateType.Electro;


        public void Drive(int speed)
        {
            State = speed < 40 ? StateType.Electro : StateType.Gasoline;
            if(State == StateType.Electro)
                Console.WriteLine("With ElectroMotor");
            else if(State == StateType.Gasoline)
                Console.WriteLine("With GasolineMotor");
        }
    }
}
