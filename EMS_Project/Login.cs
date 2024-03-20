using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Project
{
    internal class Login
    {
        public string Username = "J";
        public int Password = 97 ;

        // ตั้งค่าชื่อรหัสหน้าform1
        public bool checkUser(string username , int password )
        {
            if (username==Username &&  password==Password)
            {
                return true;
    
            }
            return false ;
        }
    }
}
