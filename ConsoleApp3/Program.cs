using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lopcon lc = new Lopcon();
            CanDo cd = (CanDo)lc;
            //Lopcon lc = new Lopcon();
            lc.Phuongthucthongthuong();
            lc.PhuongthucAbstract();
            cd.CanDo();
            cd.CanShut();
            lc.CanDo();
            //lc.CanShut();
            Console.ReadLine();
        }
    }
    public abstract class Loptruutuong
    {
        public int a;
        public string b;
        public double c;
        public void Phuongthucthongthuong()
        {
            a = 1;
            b = "Hello";
            c = 1.25;
            Console.WriteLine("a={0} b={1} c={2}",a,b,c);
        }
        public abstract void PhuongthucAbstract();
    }
    interface CanDo
    {
        void CanDo();
        void CanShut();
    }
    public class Lopcon:Loptruutuong,CanDo
    {
        public override void PhuongthucAbstract()
        {
            Console.WriteLine("PhuongthucAbstract da duoc override");
        }
        //Explicit implementation interface
        void CanDo.CanShut()
        {
            Console.WriteLine("Phuongthuc CanShut cua interface");
        }
        //Implicit implementation interface
        public void CanDo()
        {
            Console.WriteLine("Phuongthuc CanDo cua interface");
        }
    }
}
