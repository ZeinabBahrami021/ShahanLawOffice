using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahanLawOffice.Domain.ClientAgg
{
    //کلاسی برای موکل حقوقی 
    internal class LegalClient : Client
    {
        //آی دی
        public int LegaClientlID { get; set; }

        //نام شرکت
        public string CompanyName { get; set; }

        //شناسه ملی
        public int NationalID { get; set; }

        //شماره ثبت
        public int RegisterationNumber { get; set; }

        //نام مدیرعامل
        public string NameOfManagingDirector { get; set; }
    }
}
