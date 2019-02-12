using MyTask1ServiceProxy;

namespace MyTask1ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyServiceProxy proxy = new MyServiceProxy();
            proxy.SayHello("Syed");
            proxy.TodayProgram("Syed");
        }
    }
}
