﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esame06072015
{
    public class Statua : OperaDarte
    {
        public Statua(string nomeOpera, string nomeAutore, int id, DateTime dataRealizzazione, Sala sala, Tipologia tipo)
            :base(nomeOpera, nomeAutore, id, dataRealizzazione, sala)
        {
            this.TipoOpera = tipo;
        }

        public override Tipologia TipoOpera
        {
            get
            {
                return TipoOpera;
            }

            set
            {
                if(value == Tipologia.STATUA)
                {
                    TipoOpera = value;
                }
                else
                {
                    throw new FormatException("This type is invalid");
                }
            }
        }
    }
}
