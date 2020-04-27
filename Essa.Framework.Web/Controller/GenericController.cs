namespace Essa.Framework.Web.Controller
{
    using DataTables.AspNet.Core;
    using DataTables.AspNet.Mvc5;
    using Essa.Framework.Util;
    using Framework.Util.Extensions;
    using Framework.Util.Models.Controller;
    using Helpers.JqGrid;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Web.Mvc;

    public interface IGenericController<T>
        where T : class
    {

    }



    public class GenericController : Controller
    {
        protected List<string> Erro
        {
            get
            {
                if (TempData["Erro"] == null) TempData["Erro"] = new List<string>();
                return (List<string>)TempData["Erro"];
            }
            set
            {
                TempData["Erro"] = value;
            }
        }

        public enum SituacaoEnum
        {
            OK,
            ERRO,
        }


        /// <summary>
        /// Retorna um json no padrão do IResultModel com o exception
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="behavior"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        protected internal JsonResult Json(Exception exception, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet, object parametros = null)
        {
            return base.Json(new ResultModel { Situacao = "ERRO", Mensagem = exception.ToMensagemErro(), Parametros = parametros }, behavior);
        }


        /// <summary>
        /// Retorna um json no padrão do IResultModel com o exception
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="behavior"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        protected internal JsonResult Json(DbEntityValidationException exception, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet, object parametros = null)
        {
            return base.Json(new ResultModel { Situacao = "ERRO", Mensagem = exception.ToMensagemErro(), Parametros = parametros }, behavior);
        }

        protected internal JsonResult Json(DbUpdateException exception, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet, object parametros = null)
        {
            return base.Json(new ResultModel { Situacao = "ERRO", Mensagem = exception.ToMensagemErro(), Parametros = parametros }, behavior);
        }


        /// <summary>
        /// Retorna um json no padrão do IResultModel
        /// </summary>
        /// <param name="situacao"></param>
        /// <param name="behavior"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        protected internal JsonResult Json(SituacaoEnum situacao, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet, object parametros = null)
        {
            return base.Json(new ResultModel { Situacao = situacao.ToString(), Parametros = parametros }, behavior);
        }

        /// <summary>
        /// Retorna um json no padrão do IResultModel
        /// </summary>
        /// <param name="retorno"></param>
        /// <param name="behavior"></param>
        /// <returns></returns>
        protected internal JsonResult Json(SituacaoEnum situacao, object parametros)
        {
            return Json(situacao, JsonRequestBehavior.DenyGet, parametros);
        }

        protected internal JsonResult Json(Func<CustomJsonBuilder, CustomJsonBuilder> controllerBuilder, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet)
        {
            return Json(controllerBuilder(new CustomJsonBuilder(new ResultModel(), ModelState)).IResultModel, behavior);
        }



        /// <summary>
        /// Retorna um json no padrão do JqGrid
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <param name="gridSettings"></param>
        /// <param name="behavior"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        protected internal JsonResult JqGrid<T>(IQueryable<T> lista, GridSettings gridSettings, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet)
        {
            return Json(lista.ToJqGrid(gridSettings).ToReturn(), behavior);
        }



        protected internal JsonResult Json(SituacaoEnum situacao, string mensagem, JsonRequestBehavior behavior, object parametros)
        {
            return base.Json(new ResultModel { Situacao = situacao.ToString(), Mensagem = mensagem, Parametros = parametros }, behavior);
        }







        protected internal JsonResult View(object view, Func<CustomJsonBuilder, CustomJsonBuilder> controllerBuilder, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet)
        {
            return Json(controllerBuilder(new CustomJsonBuilder(new ResultModel(), ModelState)).IResultModel, behavior);
        }



        protected FileContentResult PDF(byte[] arq)
        {
            return File(arq, "application/PDF");
        }
        protected FileContentResult XLS(byte[] arq)
        {
            return File(arq, "application/vnd.ms-excel");
        }






        protected internal JsonResult DataTables(IDataTablesRequest request, IQueryable data, IQueryable filteredData, IEnumerable lista)
        {
            var response = DataTablesResponse.Create(request, data.Count(), filteredData.Count(), lista);
            return new DataTablesJsonResult(response, JsonRequestBehavior.AllowGet);
        }

        protected internal JsonResult DataTables(IDataTablesRequest request, IQueryable data)
        {
            var response = DataTablesResponse.Create(request, data.Count(), data.Count(), data);
            return new DataTablesJsonResult(response, JsonRequestBehavior.AllowGet);
        }



    }
}
