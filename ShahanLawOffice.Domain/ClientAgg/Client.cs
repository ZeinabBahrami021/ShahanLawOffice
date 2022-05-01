using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahanLawOffice.Domain.ClientAgg
{
    //کلاس موکل
    internal class Client
    {
        //آی دی
        public int ID { get; set; }

        //شماره تماس
        public string Phone { get; set; }

        //آدرس
        public string Address { get; set; }

        //ایمیل
        public string Email { get; set; }
         
    }
}
