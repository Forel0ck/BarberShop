using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Classes
{
    public class Salary
    {
        public static double Summ(List<string> LislistServices)
        {
            double summ = 0;

            foreach (var item in listServices)
            {
                summ = summ + Convert.ToDouble(context.Services.ToList().Where(i => i.IdServices == item).FirstOrDefault().Cost);
            }

            var res = summ * 0.3 * 0.87;
        }
    }
}
