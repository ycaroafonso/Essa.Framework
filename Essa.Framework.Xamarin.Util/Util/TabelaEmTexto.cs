namespace Essa.Framework.XamarinUtil.Util
{
    using Essa.Framework.XamarinUtil.Extensions;
    using System;
    using System.Collections.Generic;


    public interface ITabelaEmTextoAddColuna
    {
        List<TabelaEmTextoColuna> Colunas { get; set; }

        ITabelaEmTextoAddColuna AddColuna(string titulo, int qtdecaracteres);
        ITabelaEmTextoAddColuna AddColuna(string titulo);

        string MontaCabecalho();

        void CabecalhoWriteLine();
    }


    public interface ITabelaEmTextoAddLinha
    {
        ITabelaEmTextoAddLinha AddRowCell(int v);
        ITabelaEmTextoAddLinha AddRowCell(string v);
        ITabelaEmTextoAddLinha AddRowCell(bool v);
        string MontaLinha();

        void LinhaWriteLine();
    }



    public class TabelaEmTexto : ITabelaEmTextoAddColuna, ITabelaEmTextoAddLinha
    {
        public List<TabelaEmTextoColuna> Colunas { get; set; } = new List<TabelaEmTextoColuna>();


        public ITabelaEmTextoAddColuna AddColuna(string titulo, int qtdecaracteres)
        {
            Colunas.Add(new TabelaEmTextoColuna
            {
                Titulo = titulo,
                QtdeCaracteres = qtdecaracteres
            });

            return this;
        }

        public ITabelaEmTextoAddColuna AddColuna(string titulo)
        {
            return AddColuna(titulo, titulo.Length);
        }

        public string MontaCabecalho()
        {
            string ret = string.Empty;

            foreach (var item in Colunas)
                ret += item.ToString();

            return ret;
        }
        public void CabecalhoWriteLine()
        {
            Console.WriteLine(MontaCabecalho());
        }



        int indexCol = 0;
        string linha = string.Empty;
        public ITabelaEmTextoAddLinha AddRowCell(int v)
        {
            linha += v.ToString().PadRightComReticencia(Colunas[indexCol++].QtdeCaracteres) + "|";

            return this;
        }
        public ITabelaEmTextoAddLinha AddRowCell(string v)
        {
            linha += v.PadRightComReticencia(Colunas[indexCol++].QtdeCaracteres) + "|";

            return this;
        }
        public ITabelaEmTextoAddLinha AddRowCell(bool v)
        {
            linha += v.ToString().PadRightComReticencia(Colunas[indexCol++].QtdeCaracteres) + "|";

            return this;
        }
        public string MontaLinha()
        {
            try
            {
                return linha;
            }
            finally
            {
                indexCol = 0;
                linha = string.Empty;
            }
        }
        public void LinhaWriteLine()
        {
            Console.WriteLine(MontaLinha());
        }

    }

    public class TabelaEmTextoColuna
    {
        public string Titulo { get; set; }
        public int QtdeCaracteres { get; set; }

        public override string ToString()
        {
            return Titulo.PadRightComReticencia(QtdeCaracteres) + "|";
        }
    }
}
