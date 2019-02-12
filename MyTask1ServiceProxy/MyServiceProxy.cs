using System.ServiceModel;
using MyTask1ServiceLib;

namespace MyTask1ServiceProxy
{
    public class MyServiceProxy : ClientBase<IGreetingService>, IGreetingService
    {
        public string SayHello(string Name)
        {
            //Call base to do funtion
            return base.Channel.SayHello(Name);
        }
        public string TodayProgram(string Name)
        {
            return base.Channel.TodayProgram(Name);
        }
    }
}