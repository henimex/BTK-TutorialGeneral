using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dort = new DortIslem(2, 3);
            //dort.Topla(5, 6);
            //dort.Topla2();

            var type = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7);
            Console.WriteLine(dortIslem.Topla(4,5));
            Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 98, 6);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));

            //Gerçek hayatta nerde kullanılacagına dair en ufak fikrim yok.

            
            var methodlar = type.GetMethods();
            foreach (var method in methodlar)
            {
                Console.WriteLine("Method : {0}", method.Name);
                Console.WriteLine("ReturnType : {0}", method.ReturnType);
            }

            //methodInfo.GetCustomAttributes();

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem()
        {
            
        }

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Çarpma İşlemi")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string çarpmaIşlemi)
        {
            
        }
    }
}
