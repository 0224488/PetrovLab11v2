using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStructura
{
    public struct L11
    {
        public double ValB { get; set; }
        private double valK; // Вводим проверку, поскольку k не должен быть равен 0

        public double ValK
        {
            get
            {
                return valK;
            }
            set
            {
                if (value != 0)
                {
                    valK = value;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Коэффициент k не может быть равен 0");
                }
            }
        }

        public L11(double ValK, double ValB)
        {
            valK = ValK;
            this.ValB = ValB;
        }

        public void Root()
        {

            Console.WriteLine("Результат вычислений: x = {0:f5}", (-ValB) / ValK);
        }

    }
}
