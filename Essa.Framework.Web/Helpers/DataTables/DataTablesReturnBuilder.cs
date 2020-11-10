namespace Essa.Framework.Web.Helpers.DataTables
{
    using Essa.Framework.Util;
    using global::DataTables.AspNet.Core;
    using global::DataTables.AspNet.Mvc5;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web.Mvc;
    using static Essa.Framework.Web.Helpers.DataTables.DataTablesUtil;


    public static class DataTablesUtil
    {
        public enum TipoFiltro
        {
            Contem,
            Igual,
            Customizado,

            MaiorOuIgual,
            MenorOuIgual
        }
    }

    public class DataTablesReturnBuilder<T>
    {
        private int _qtdeTotal;
        private IQueryable<T> _listaFiltrada;
        private readonly IDataTablesRequest _request;


        public DataTablesReturnBuilder(IQueryable<T> lista, IDataTablesRequest request)
        {

            _qtdeTotal = lista.Count();

            _listaFiltrada = lista;

            _request = request;
        }

        public DataTablesReturnBuilder<T> AddFiltro(Expression<Func<T, bool>> filtro)
        {
            _listaFiltrada = _listaFiltrada.Where(filtro);
            return this;
        }

        public IQueryable<T> RetornaConsulta()
        {
            return _listaFiltrada;
        }




        public DataTablesReturnBuilder<T> AddFiltro<TParam>(string nomeFiltro, TipoFiltro tipoFiltro)
        {
            if (_request.AdditionalParameters.ContainsKey(nomeFiltro))
                AddFiltro(nomeFiltro, tipoFiltro, _request.Get<TParam>(nomeFiltro));

            return this;
        }

        public DataTablesReturnBuilder<T> AddFiltro<TParam>(string nomeFiltro, TipoFiltro tipoFiltro, Func<TParam, bool> condicaoParaAplicarOFiltro)
        {
            if (_request.AdditionalParameters.ContainsKey(nomeFiltro))
                if (condicaoParaAplicarOFiltro(_request.Get<TParam>(nomeFiltro)))
                    return AddFiltro(nomeFiltro, tipoFiltro, _request.Get<TParam>(nomeFiltro));

            return this;
        }

        public DataTablesReturnBuilder<T> AddFiltro<TParam>(string nomeFiltro, string nomecoluna, TipoFiltro tipoFiltro, Func<TParam, bool> condicaoParaAplicarOFiltro)
        {
            if (_request.AdditionalParameters.ContainsKey(nomeFiltro))
                if (condicaoParaAplicarOFiltro(_request.Get<TParam>(nomeFiltro)))
                    return AddFiltro(nomecoluna, tipoFiltro, _request.Get<TParam>(nomeFiltro));

            return this;
        }

        private DataTablesReturnBuilder<T> AddFiltro<TParam>(string nomeColuna, TipoFiltro tipoFiltro, TParam valor)
        {
            string sql = "";

            if (typeof(TParam) == typeof(DateTime) || typeof(TParam) == typeof(DateTime?))
                sql += $"{nomeColuna} {Operador(tipoFiltro)} DateTime({valor:yyyy, MM, dd, HH, mm, ss})";
            else
                switch (tipoFiltro)
                {
                    case TipoFiltro.Contem:
                        sql = $"{nomeColuna}.contains(\"{valor}\")";
                        break;
                    default:
                        sql += $"{nomeColuna} {Operador(tipoFiltro)} {ProcessaValor(valor.ToString())}";
                        break;
                }

            _listaFiltrada = _listaFiltrada.Where(sql);

            return this;
        }

        public DataTablesReturnBuilder<T> AddFiltro<TParam>(string nomeFiltro, Func<TParam, Expression<Func<T, bool>>> filtro)
        {
            if (_request.AdditionalParameters.ContainsKey(nomeFiltro))
            {
                var d = _request.Get<TParam>(nomeFiltro);
                var x = filtro(d);
                _listaFiltrada = _listaFiltrada.Where(x);
            }

            return this;
        }




        string Operador(TipoFiltro tipoFiltro)
        {
            switch (tipoFiltro)
            {
                case TipoFiltro.Igual:
                    return "=";
                case TipoFiltro.MaiorOuIgual:
                    return ">=";
                case TipoFiltro.MenorOuIgual:
                    return "<= ";
                default:
                    throw new Exception();
            }
        }


        public DataTablesJsonResult ToReturn<TResult>(Func<T, TResult> select, IDictionary<string, object> additionalParameters = null)
        {
            var qtdeFiltrado = _listaFiltrada.Count();

            var sortColumm = _request.Columns.FirstOrDefault(x => x.Sort != null);
            if (sortColumm != null)
            {
                if (sortColumm.Sort.Direction == SortDirection.Descending)
                    _listaFiltrada = _listaFiltrada.OrderBy(sortColumm.Name + " desc");
                else
                    _listaFiltrada = _listaFiltrada.OrderBy(sortColumm.Name);

                _listaFiltrada = _listaFiltrada.Skip(_request.Start);

                if (_request.Length > 0)
                    _listaFiltrada = _listaFiltrada.Take(_request.Length);
            }

            var listaFinal = _listaFiltrada.ToList().Select(select);

            var response = DataTablesResponse.Create(_request, _qtdeTotal, qtdeFiltrado, listaFinal, additionalParameters);
            return new DataTablesJsonResult(response, JsonRequestBehavior.AllowGet);
        }


        private string ProcessaValor(string valor)
        {
            int n;
            if (valor.Contains("DateTime") || int.TryParse(valor, out n))
                return valor;
            else
                return "\"" + valor + "\"";
        }
    }
}
