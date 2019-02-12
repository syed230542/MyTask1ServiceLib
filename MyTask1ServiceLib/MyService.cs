using System;
using System.ServiceModel;

namespace MyTask1ServiceLib
{
    [ServiceContract]
    public interface IGreetingService
    {
        [OperationContract]
        string SayHello(string Name);

        [OperationContract]
        string TodayProgram(string Name);
    }
    public class GreetingService : IGreetingService
    {
        public string SayHello(string Name)
        {
            if (DateTime.Now.Hour < 12)
            {
                return $"Good Morning {Name}!";
            }
            else if (DateTime.Now.Hour < 17)
            {
                return $"Good Afternoon {Name}!";
            }
            else
            {
                return $"Good Evening {Name}!";
            }
        }

        public string TodayProgram(string Name)
        {
            var today = DateTime.Now.DayOfWeek;
            if (today == DayOfWeek.Sunday || today == DayOfWeek.Saturday)
            {
                return $"Hi {Name}... Happy Weekend!";
            }
            else
            {
                return $"Hi {Name}... Enjoy Working day!";
            }
        }
    }
}
