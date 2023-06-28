



using System;
using System.Xml.Linq;
using Task;


Vehicle vehicle;




Console.WriteLine("Choose transport type and input transport index");
Function.PrintTransportType();
if (Function.InputTransportType(out int TransportTypeIndex))
{
    Console.WriteLine("Choose transport and input transport index");
    Function.PrintTransportOne(TransportTypeIndex);
    if (Function.InputTransport(TransportTypeIndex, out int TransportIndex))
    {
        TransportType type = (TransportType)TransportTypeIndex;
        switch (TransportIndex)
        {
            case 1:
                vehicle = new Tank(type);
                break;

            case 2:
                vehicle = new Beteer(type);
                break;

            case 3:
                vehicle = new Sedan(type);
                break;

            case 4:
                vehicle = new Jeep(type);
                break;

            case 5:
                vehicle = new Bus(type);
                break;
            case 6:
                vehicle = new Tram(type);
                break;

            case 7:
                vehicle = new Formula1(type);
                break;

            case 8:
                vehicle = new Motorcycle(type);
                break;

        }


    }

}






