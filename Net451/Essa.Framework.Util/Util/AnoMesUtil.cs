﻿namespace Alfazema.Framework.Util.Util
{
    using Alfazema.Framework.Util.Extensions;
    using System;


    public class AnoMesUtil
    {
        private int _ano, _mes, _anomes;

        public int AnoMes
        {
            get
            {
                return _anomes;
            }
            set
            {
                _ano = value.ToString().Substring(0, 4).ToInt32();
                _mes = value.ToString().Substring(4).ToInt32();
                _anomes = value;
            }
        }

        public int Ano
        {
            get
            {
                return _ano;
            }
            set
            {
                _ano = value;
                AnoMes = _ano * 100 + _mes;
            }
        }

        public int Mes
        {
            get
            {
                return _mes;
            }
            set
            {
                _mes = value;
                AnoMes = _ano * 100 + _mes;
            }
        }



        public AnoMesUtil(int anomes)
        {
            AnoMes = anomes;
        }

        public int AddMes(int qtdeMeses)
        {
            AnoMes = ToDateTime(1).AddMonths(qtdeMeses).ToAnoMes();
            return AnoMes;
        }


        public DateTime ToDateTime(int dia = 1)
        {
            return new DateTime(Ano, Mes, dia);
        }

        public string ToStringFormatado()
        {
            return string.Format("{0}/{1:00}", Ano, Mes);
        }
    }
}
