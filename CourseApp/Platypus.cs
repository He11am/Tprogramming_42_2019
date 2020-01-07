using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    interface IFlight
    {
        void Move();

        // move
    }

    public class Plane : IFlight
    {
        public string name; // имя
        public string mk; // модель
        public int weight; // вес
        public string type; // тип самолета

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} \n Mk: {mk} \n Weight: {weight} \n Type: {type} \n ");
        }

        public void Move()
        { }
    }

    public class LitePlane : Plane
    {

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} \n Mk: {mk} \n Weight: {weight} \n Type: {type} \n ");
            Console.WriteLine("I'm a little plane");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Plane boeing = new Plane();
            boeing.name = "Boeing";
            boeing.mk = "777";
            boeing.weight = 16500;
            boeing.type = "passanger";

            boeing.GetInfo();



            Plane airbus = new Plane();
            airbus.name = "Airbus";
            airbus.mk = "A400M Atlas";
            airbus.weight = 76500;
            airbus.type = "military";

            airbus.GetInfo();

            LitePlane litePlane = new LitePlane();
            litePlane.name = "Cessna";
            litePlane.mk = "172";
            litePlane.weight = 736;
            litePlane.type = "passanger";

            litePlane.GetInfo();

            Console.ReadKey();
        }
    }
}