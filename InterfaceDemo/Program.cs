using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new SimpleWorker(),
                new Robot(),
                new Manager()
            };

            foreach (var w in workers)
            {
                w.Work();
            }

            IEat[] eat = new IEat[2]
            {
                new Manager(),
                new SimpleWorker()
            };

            foreach (var e in eat)
            {
                e.Eat();
            }

            ISalary[] salary = new ISalary[2]
            {
                new Manager(),
                new SimpleWorker()
            };

            foreach (var s in salary)
            {
                s.GetSalary();
            }

            IMaintaince[] maintaince = new IMaintaince[1]
            {
                new Robot()
            };

            //or

            IMaintaince mntc = new Robot();

            foreach (var m in maintaince)
            {
                m.Maintaince();
            }

            mntc.Maintaince();
        }

        interface IWorker
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }

        interface IMaintaince
        {
            void Maintaince();
        }

        class SimpleWorker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }


        }

        class Robot : IWorker, IMaintaince
        {
            public void Maintaince()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
