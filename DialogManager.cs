using System;

namespace Calculator
{
    class DialogManager
    {
        private CalcManager calc;
        public DialogManager(){
            calc
        }
        
        public void AddDialog(){
            Console.Writeline("Enter num");
            Console.Writeline("a=");
            double a =double.Parse(Console.ReadLine());
            Console.Writeline("b=");
            double b =double.Parse(Console.ReadLine());
            double res= _calc.add(a,b);
            Console.Writeline($"\n>{a}+{b}= {res}");
        }

        public void SubDialog(){
            Console.Writeline("Enter num");
            Console.Writeline("a=");
            double a =double.Parse(Console.ReadLine());
            Console.Writeline("b=");
            double b =double.Parse(Console.ReadLine());
            double res= _calc.sub(a,b);
            Console.Writeline($"\n>{a}-{b}= {res}");
        }

        public void MulDialog(){
            Console.Writeline("Enter num");
            Console.Writeline("a=");
            double a =double.Parse(Console.ReadLine());
            Console.Writeline("b=");
            double b =double.Parse(Console.ReadLine());
            double res= _calc.sub(a,b);
            Console.Writeline($"\n>{a}*{b}= {res}");
        }

        public void DivDialog(){
            Console.Writeline("Enter num");
            Console.Writeline("a=");
            double a =double.Parse(Console.ReadLine());
            Console.Writeline("b=");
            double b =double.Parse(Console.ReadLine());
            double res= _calc.div(a,b);
            Console.Writeline($"\n>{a}/{b}= {res}");
        }
    }
}