using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.ValueObject
{
    public class TaiKhoan
    {
        private string acc;
        private string pass;
        public string Acc
        {
            get { return acc; }
            set { acc = value; }
        }

      

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

    }
}
