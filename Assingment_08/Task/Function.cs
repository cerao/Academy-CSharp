using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    static class Function
    {
        public static void PrintTransportType()
        {
            var TransportTypeSize = Enum.GetNames(typeof(TransportType)).Length;
            for (int i = 0; i < TransportTypeSize; i++)
            {
                Console.WriteLine($"{Enum.GetNames(typeof(TransportType)).GetValue(i)} -  {i + 1}");
            }
        }
        public static void PrintTransport(params int[] TransportIndex)
        {
            int index;
            foreach( int transport in TransportIndex)
            {
                if(Enum.GetNames(typeof(Transport)).Length >= transport)
                {
                    index = transport;
                    Console.WriteLine($"{Enum.GetNames(typeof(Transport)).GetValue(transport)} -  {index}");
                }
              
            }
        }
        public static void PrintTransportOne(int TransportIndex)
        {
            switch (TransportIndex)
            {
                case 1:
                    PrintTransport((int)Transport.Beteer, (int)Transport.Tank);
               
                    break;
                case 2:
                    PrintTransport((int)Transport.Jeep, (int)Transport.Sedan);
                   
                    break;
                case 3:
                    PrintTransport((int)Transport.Beteer, (int)Transport.Tank);
                    break;
                case 4:
                    PrintTransport((int)Transport.Motorcycle, (int)Transport.Formula1);
                    break;
            }
        }
        public static bool InputTransportType(out int TransportIndex)
        {
            
            string IputNumber = Console.ReadLine();
            if (int.TryParse(IputNumber, out TransportIndex) && TransportIndex > 0 && TransportIndex <= Enum.GetNames(typeof(TransportType)).Length)
            {
                return true;
            }

            TransportIndex = -1;
            return false;
        }
        public static bool InputTransport(int Index,out int ReturnIndex) 
        {
            bool Return = false;
            string IputNumber = Console.ReadLine();
            if(int.TryParse(IputNumber, out ReturnIndex))
            {
                switch (Index)
                {
                    case 1:
                        Console.WriteLine("Choose transport and input transport index");

                        if (ReturnIndex == (int)Transport.Beteer || ReturnIndex == (int)Transport.Tank)
                        {
                            Return = true;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Choose transport and input transport index");

                        if (ReturnIndex == (int)Transport.Jeep || ReturnIndex == (int)Transport.Sedan)
                        {
                            Return = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Choose transport and input transport index");

                        if (ReturnIndex == (int)Transport.Beteer || ReturnIndex == (int)Transport.Tank)
                        {
                            Return = true;
                        }
                        break;
                    case 4:
                        if (ReturnIndex == (int)Transport.Motorcycle || ReturnIndex == (int)Transport.Formula1)
                        {
                            Return = true;
                        }
                        break;
                }
            }
            

            return Return;
        }
    }
    
}
