using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    abstract public class Vehicle
    {
        private TransportType _TransportType { get; set; }
        public Vehicle(TransportType name)
        {
            _TransportType = name;
        }
        public void PrintTransport()
        {
            switch (_TransportType)
            {
                case TransportType.Combat:
                    Console.WriteLine($"{Transport.Tank} {Transport.Beteer}");
                    break;
                case TransportType.Consumer:
                    Console.WriteLine($"{Transport.Jeep} {Transport.Sedan}");
                    break;
                case TransportType.Public:
                    Console.WriteLine($"{Transport.Tram} {Transport.Bus}");
                    break;
                case TransportType.Sport:
                    Console.WriteLine($"{Transport.Formula1} {Transport.Motorcycle}");
                    break;
                default:
                    break;
            }
        }
        abstract public void PrintName();
        abstract public void Speed();
    }

    public class Beteer : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private string _weapon;
        public Beteer(TransportType name) :base(name)
        {
            _transportName = Transport.Beteer;
            _speed = 70;
            _weapon = "50 mm";
        }

        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }
        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public  void weapon()
        {
            Console.WriteLine($"weapon have {_weapon}");
        }
    }
    public class Tank : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private string _weapon;
        public Tank(TransportType name) : base(name)
        {
            _transportName = Transport.Tank;
            _speed = 40;
            _weapon = "80 mm";
        }

        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }
        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public void weapon()
        {
            Console.WriteLine($"weapon have {_weapon}");
        }
    }
     public class Jeep : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private int _passenger;
        public jeep(TransportType name) : base(name)
        {
            _transportName = Transport.Jeep;
            _speed = 240;
            _passenger = 5;
        }
        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }
        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public void Passenger()
        {
            Console.WriteLine($"Speed = {_passenger}");
        }

    }
    public class Sedan : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private int _passenger;
        public Sedan(TransportType name) : base(name)
        {
            _transportName = Transport.Sedan;
            _speed = 350;
            _passenger = 2;
        }
        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }
        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public void Passenger()
        {
            Console.WriteLine($"Speed = {_passenger}");
        }

    }
    public class Tram : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private int _passenger;
        public Tram(TransportType name) : base(name)
        {
            _transportName = Transport.Tram;
            _speed = 60;
            _passenger = 170;
        }
        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }
        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public void Passenger()
        {
            Console.WriteLine($"Speed = {_passenger}");
        }

    }
    public class Bus : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private int _passenger;
        public Bus(TransportType name) : base(name)
        {
            _transportName = Transport.Bus;
            _speed = 100;
            _passenger = 70;
        }
        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }
        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public void Passenger()
        {
            Console.WriteLine($"Speed = {_passenger}");
        }

    }
    public class Formula1 : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private int _passenger;
        public Formula1(TransportType name) : base(name)
        {
            _transportName = Transport.Formula1;
            _speed = 400;
            _passenger = 1;
        }
        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }
        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public void Passenger()
        {
            Console.WriteLine($"Speed = {_passenger}");
        }

    }
    public class Motorcycle : Vehicle
    {
        private Transport _transportName;
        private int _speed;
        private int _passenger;
        public Motorcycle(TransportType name) : base(name)
        {
            _transportName = Transport.Motorcycle;
            _speed = 300;
            _passenger = 1;
        }

        public override void PrintName()
        {
            Console.WriteLine($"Transport Name is {_transportName}");
        }

        public override void Speed()
        {
            Console.WriteLine($"Speed = {_speed}");
        }
        public void Passenger()
        {
            Console.WriteLine($"Speed = {_passenger}");
        }

    }
}
