using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Project
{
    internal class CSV
    {   
        string savedata;
        public string sort;
        public string path = @"D:\OOP\EMS_Project\Data.csv";
        public bool csvfile(List<EMSData>Adddata)
        {
            foreach (EMSData data in Adddata)
            {

                
                savedata = data.Name + "," + data.Age + "," + data.branch + "," + data.symptom + "," + data.Drugallergy + "," + data.day + "," + data.T + "," + data.BP + "," + data.P + "," + data.RR + "," + data.O2Sat + "," + data.EMRCode + ","+"\n";

            }
            try
            {
                File.AppendAllText(path, savedata);

                return true;

            }
            catch 
            { return false; }
        }
        
    }
}
