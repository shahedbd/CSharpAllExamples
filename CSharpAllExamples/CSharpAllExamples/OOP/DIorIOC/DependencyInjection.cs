using System;

namespace CSharpAllExamples.OOP.DIorIOC
{
    public class DependencyInjection
    {
    }

    public interface IEngine
    {
        void Start();
    }

    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Started...........");
        }
    }


    class Car
    {
        private readonly IEngine _engine;
        public Car(IEngine engine)
        {
            _engine = engine;
        }



        public static void RunCode()
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterType<Generator>().As<IGenerator>();
            //builder.RegisterType<Engine>().As<IEngine>();
            //builder.RegisterType<Car>().As<ICar>();
            //var container = builder.Build();


            //var car = resolver.Resolve<ICar>();
            //car.Start();
        }


    }


}
