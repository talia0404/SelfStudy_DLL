using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudy_DLL
{
    internal class Module
    {
        private string StartDate1;
        private string Name1;
        private string Code1;
        private double Credits1;
        private double Hours1;
        private String ModDate1;
        private int Weeks1;
        private double SelfStudyHours1;

        public Module()
        {
           
        }

        public Module(string startDate1, string name1, string code1, double credits1, double hours1, string modDate1, int weeks1, double selfStudyHours1)
        {
            StartDate1 = startDate1;
            Name1 = name1;
            Code1 = code1;
            Credits1 = credits1;
            Hours1 = hours1;
            ModDate1 = modDate1;
            Weeks1 = weeks1;
            SelfStudyHours1 = selfStudyHours1;
        }

        public string StartDate11 { get => StartDate1; set => StartDate1 = value; }
        public string Name11 { get => Name1; set => Name1 = value; }
        public string Code11 { get => Code1; set => Code1 = value; }
        public double Credits11 { get => Credits1; set => Credits1 = value; }
        public double Hours11 { get => Hours1; set => Hours1 = value; }
        public string ModDate11 { get => ModDate1; set => ModDate1 = value; }
        public int Weeks11 { get => Weeks1; set => Weeks1 = value; }
        public double SelfStudyHours11 { get => SelfStudyHours1; set => SelfStudyHours1 = value; }
    }
}
