using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahanLawOffice.Domain.ClientAgg
{
    //کلاسی برای موکل حقیقی
    internal class RealClient : Client
    {
        //آی دی
        public new int ID { get; set; }

        //نام.
        public string FirstName { get; set; }

        //نام خانوادگی
        public string LastName { get; set; }

        //نام پدر
        public string FathertName { get; set; }

        //کدملی
        public int NationalCode { get; set; }
        //تاریخ تولد
        public DateTime BirthDate { get; set; }

        //جنسیت
        public Boolean Gender { get; set; }




    }
}
