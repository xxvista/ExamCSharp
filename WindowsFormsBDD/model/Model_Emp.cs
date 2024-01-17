using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBDD
{
    public class Model_Emp
    {
        string nomEmp;
        string prenomEmp;
        DateTime dnEmp;
        string IdStr;
        char sexeEmp;

        public string NomEmp { get => nomEmp; set => nomEmp = value; }
        public string PrenomEmp { get => prenomEmp; set => prenomEmp = value; }
        public DateTime DnEmp { get => dnEmp; set => dnEmp = value; }
        public string Mat { get => IdStr; set => IdStr = value; }
        public char SexeEmp { get => sexeEmp; set => sexeEmp = value; }




        public Model_Emp(string nomEmp, string prenomEmp, DateTime dnEmp, string idStr, char sexeEmp)
        {
            this.nomEmp = nomEmp;
            this.prenomEmp = prenomEmp;
            this.dnEmp = dnEmp;
            this.sexeEmp = sexeEmp;
            IdStr = idStr;
        }

       
    }
}
