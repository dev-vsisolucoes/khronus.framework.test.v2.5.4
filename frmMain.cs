using Khronus.Framework.Integration.Omie.PedidoVendaProduto;
using Khronus.Framework.Sped.NFes;
using Khronus.Framework.Sped.NFes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Khronus.Framework.Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NFesManager nfesManager = NFesManager.GetInstance();
            nfesManager.OutPut = Application.StartupPath;

            TNFes nfes = new TNFes();

            TNFesReqEnvioLoteRps reqEnvioLoteRps = new TNFesReqEnvioLoteRps();

            TNFesReqEnvioLoteRpsCabecalho cabecalho = new TNFesReqEnvioLoteRpsCabecalho();
            cabecalho.CodCidade = "7145";
            cabecalho.CpfCnpjRemetente = "03531116000145";
            cabecalho.RazaoSocialRemetente = "EMPRESA MODELO";
            cabecalho.Transacao = "";
            cabecalho.DtInicio = "08/11/2020";
            cabecalho.DtFim = "08/11/2020";
            cabecalho.QtdRPS = "1";
            cabecalho.ValorTotalServicos = "820,00";
            cabecalho.ValorTotalDeducoes = "0,00";
            cabecalho.Versao = "1";
            cabecalho.MetodoEnvio = "ws";

            reqEnvioLoteRps.Cabecalho = cabecalho;

            TNFesReqEnvioLoteRpsLote lote = new TNFesReqEnvioLoteRpsLote();
            lote.Id = "lote1ABCDZ";

            TNFesReqEnvioLoteRpsLoteRps rps = new TNFesReqEnvioLoteRpsLoteRps();
            rps.Id = "rps1";

            lote.Rps = rps;

            reqEnvioLoteRps.Lote = lote;

            nfes.ReqEnvioLoteRps = reqEnvioLoteRps;

            NFesRet ret = nfesManager.Create(nfes);

            MessageBox.Show(String.Format("{0}, {1}", ret.Status, ret.Motivo));
        }
    }
}
