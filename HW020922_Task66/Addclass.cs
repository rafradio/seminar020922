using System;

namespace SumFromMtoN
{
    class InitialSettings : Program66
    {
        public InitialSettings()
        {
            this.Initsets(0);
            this.SumExec();


        }
        public void Initsets(int iType)
        {
            if (iType < 2)
            {
                string[] dataType = {"N", "M"};
                Console.Write($"Введите пожалуйста целое число для {dataType[iType]}: ");
                string enterUser = Console.ReadLine();
                if (int.TryParse(enterUser, out int number))
                {
                    switch (iType)
                    {
                        case 0:
                            this.digitN = number;
                            break;
                        case 1:
                            this.digitM = number;
                            break;
                    }
                    iType += 1;
                }
                else
                {
                    Console.WriteLine("Вы ввели не число. Повторите!");
                }
                this.Initsets(iType);
            }
            if (this.digitN > this.digitM)
            {
                int inter = this.digitN;
                this.digitN = this.digitM;
                this.digitM = inter;
            }
            return;
        }
        public void SumExec()
        {
            
            int FindSum(int n)
            {
                if (n <this.digitM) return n + FindSum(n + 1);
                return n;
            }
            Console.WriteLine($"Сумма: {FindSum(this.digitN)}");

        }
    }
}