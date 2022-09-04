using System;

namespace PrintFromMtoN
{
    class InitialSettings : Program64
    {
        public InitialSettings()
        {
            this.Initsets(0);
            this.PrintExec();


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
        public void PrintExec()
        {
            string PrintNumber(int n, int m)
            {
                string s = Convert.ToString(n);
                if (n < m) return s = s + ", " + PrintNumber(n + 1, m);
                return s;
            }
            Console.Write($"{PrintNumber(this.digitN, this.digitM)} ");

        }
    }
}