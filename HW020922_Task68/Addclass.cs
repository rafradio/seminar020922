using System;

namespace AccermannMN
{
    class InitialSettings : Program68
    {
        public InitialSettings()
        {
            this.Initsets(0);
            int result = this.AccExec(this.digitN, this.digitM);
            Console.WriteLine($"Функция Аккермана равна: {result}");


        }
        public void Initsets(int iType)
        {
            if (iType < 2)
            {
                string[] dataType = {"M", "N"};
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

            return;
        }
        public int AccExec(int n, int m)
        {
            if (n == 0) 
            {
                return m + 1;
            }
            else 
            {
                if ((n > 0) && (m == 0)) return AccExec(n - 1, 1);
                else return AccExec(n - 1, AccExec(n, m - 1));
            }
        }
    }
}