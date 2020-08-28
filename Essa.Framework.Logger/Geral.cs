﻿namespace Essa.Framework.Logger
{
    using Serilog;
    using Serilog.Events;


    public static class Geral
    {
        public static Serilog.Core.Logger Log(string nomePrograma = "", string diretoriolog = "")
        {
            string arquivolog = diretoriolog;
#if DEBUG
            arquivolog += @"DEBUG\";
#endif

            return new LoggerConfiguration()
.MinimumLevel.Debug()
.MinimumLevel.Override("Microsoft", LogEventLevel.Information)
.Enrich.FromLogContext()
.WriteTo.Console()
.WriteTo.File($"{arquivolog}log_{nomePrograma}_", rollingInterval: RollingInterval.Day)
.CreateLogger();
        }
    }
}