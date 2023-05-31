using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMuveletek
{
    public class Kifejezes
    {
        int operandusBal;
        string muvelet;
        int operandusJobb;
        private string sor;

        /*
        public Kifejezes(string scvSor) 
            : this(int.Parse(scvSor.Split()[0]), scvSor.Split()[1], int.Parse(scvSor.Split()[2]))
        {
        }*/
        
        public Kifejezes(string scvSor)
        {
            var mezok = scvSor.Split();
            this.operandusBal = int.Parse(mezok[0]);
            this.muvelet = mezok[1];
            this.operandusJobb = int.Parse(mezok[2]);
        }
        
        public Kifejezes(int operandusBal, string muvelet, int operandusJobb)
        {
            this.operandusBal = operandusBal;
            this.muvelet = muvelet;
            this.operandusJobb = operandusJobb;
        }

        public int OperandusBal { get => operandusBal; }
        public string Muvelet { get => muvelet; }
        public int OperandusJobb { get => operandusJobb; }
    }
}
