﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanelaBD
{
    internal class Objeto
    {
        public string Nome { get; }
        public CheckBox CbPonto { get; }
        public CheckBox CbReta { get; }
        public int CordX { get; }
        public int CordY { get; }
        public int CordZ { get; }


        public Objeto(string nome, CheckBox cbPonto, CheckBox cbReta, int cordX, int cordY, int cordZ)
        {
            Nome = nome;
            CbPonto = cbPonto;
            CbReta = cbReta;
            CordX = cordX;
            CordY = cordY;
            CordZ = cordZ;

        }

        public override string ToString()
        {
            if (CbPonto.Checked == false & CbReta.Checked == true)
            {
                return "Objeto=" + Nome + ", tipo= Reta" + ", Cord=" + CordX + "," + CordY + "," + CordZ;
            }
            else {
                return "Objeto=" + Nome + ", tipo= Ponto" + ", Cord=" + CordX + "," + CordY + "," + CordZ;
            }
        }
    }
}
