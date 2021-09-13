using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterRadios
{
    class classServicos
    {
        public int id = 0;
        public String data = "";
        public String modeloRadio = "";
        public string numSerie = "nada";
        public String defeito = "";
        public String solucao = "";


        public void setServicos(int idx, string datax, string mode, string numser, string defeit, string solu)
        {
            this.id = idx;
            this.data = datax;
            this.modeloRadio = mode;
            this.numSerie = numser;
            this.defeito = defeit;
            this.solucao = solu;

        }

        public void setNumSerie(string num)
        {
            this.numSerie = num;
        }
        public string getNumSerie()
        {
            return numSerie;
        }

        static void teste()
        {
            classServicos cs = new classServicos();

        }
    }
}
