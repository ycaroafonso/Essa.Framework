﻿namespace NFeDownload.Download
{
    public class Produto
    {
        public Produto()
        {
            IPI_pIpi = "0";
            IPI_vIpi = "0";
            IPI_vBC = "0";            
            pICMS = "0";
        }

        public string Num { get; set; }
        public string Descricao { get; set; }
        public string Qtd { get; set; }
        public string UnidadeComercial { get; set; }
        public string Valor { get; set; }

        public string CodigoProduto { get; set; }
        public string CodigoNCM { get; set; }
        public string CodigoExDaTipi { get; set; }
        public string CFOP { get; set; }
        public string OutrasDespesasAcessorias { get; set; }
        public string ValorDesconto { get; set; }
        public string ValorTotalFrete { get; set; }
        public string ValorSeguro { get; set; }

        public string IndicadorComposicaoValorTotalNFe { get; set; }

        public string CodigoEANComercial { get; set; }        
        public string QuantidadeComercial { get; set; }
        
        public string CodigoEANTributavel { get; set; }
        public string UnidadeTributavel { get; set; }
        public string QuantidadeTributavel { get; set; }

        public string ValorUnitarioComercializacao { get; set; }
        public string ValorUnitarioTributacao { get; set; }
        
        public string NumeroPedidoDeCompra { get; set; }
        public string ItemPedidoCompra { get; set; }
        public string ValorAproximadoTributos { get; set; }
        public string NumeroFCI { get; set; }

        public string OrigemMercadoria { get; set; }
        public string TributacaoICMS { get; set; }
        public string modBC { get; set; }
        public string vBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string ValorICMSDesoneracao { get; set; }

        public string PIS_CST { get; set; }
        public string COFINS_CST { get; set; }

        public string IPI_CST { get; set; }
        public string cEnq { get; set; }
        public string IPI_vBC { get; set; }
        public string IPI_pIpi { get; set; }
        public string IPI_vIpi { get; set; }

        public string nDI { get; set; }
        public string dDI { get; set; }
        public string xLocDesemb { get; set; }
        public string UFDesemb { get; set; }
        public string dDesemb { get; set; }
        public string cExportador { get; set; }
        public string nAdicao { get; set; }
        public string nSeqAdic { get; set; }
        public string cFabricante { get; set; }
    }
}
