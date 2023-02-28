using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterfaces.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }

        public Installment Installment { get; set; }

        public Contract(int number, DateTime date, Installment installment)
        {
            Number = number;
            Date = date;
            Installment = installment;
        }

        //public double TotalValue()
        //{
        //    return
        //}

    }
}
