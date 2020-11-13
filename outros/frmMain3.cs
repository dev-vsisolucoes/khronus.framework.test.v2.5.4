using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.sotisolutions.khronus.cert;
using com.sotisolutions.khronus.dfe.cfe;
using com.sotisolutions.khronus.dfe;
using System.IO;
using com.sotisolutions.khronus.dfe.nfe.model;
using com.sotisolutions.khronus.dfe.nfe;
using com.sotisolutions.khronus.framework.dfe.cte;
using com.sotisolutions.khronus.framework.dfe.cte.model;
using com.sotisolutions.khronus.dfe.cfe.model;
using Khronus.Framework.MDFe;
using com.sotisolutions.khronus;
using com.sotisolutions.khronus.framework.dfe.mdfe;
using com.sotisolutions.khronus.dfe.cce;
using Khronus.Framework.Util;
using Khronus.Framework.Integration.Cobranca;
using com.sotisolutions.khronus.minify;
using Khronus.Framework.Integration.Cobranca.Itau.Model;
using Khronus.Framework.File;
using com.sotisolutions.khronus.framework.dfe.mdfe.model;
using Khronus.Framework.Integration.Omie;
using Khronus.Framework.Integration.Omie.ConsultaEstoque;

namespace Khronus.Framework.Test
{
    public partial class frmMain3 : Form
    {
        private CCeManager managerCCe;
        private NFeManager managerNFCe;
        private NFeManager managerNFe;
        private CTeManager managerCTe = new CTeManager();
        private MDFeManager managerMDFe = new MDFeManager();

        public frmMain3()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {














            //managerNFCe = NFeManager.getInstance();



            ////openFileDialog1.Title = "Selecione o certificado";
            ////openFileDialog1.Filter = "*.*|*.*";

            ////if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            ////{
            ////    nfeManager.Certificate = new Certificate(openFileDialog1.FileName, "123456");
            ////    //nfeManager.Certificate = new Certificate(@"D:\Meus Arquivos\Projetos\khronus-framework\v2.0.1\cert\CERT.pfx", "TSR2018");
            ////}

            ////if (!textBox2.Text.Equals(String.Empty))
            ////{
            ////nfeManager.Certificate = new Certificate(textBox1.Text, textBox2.Text);
            
            ////}






            ////managerNFe.Gmt = "-02:00"; 
            //managerNFe.ShowProgressBar = true;
            //managerNFe.Uf = 35;
            //managerNFe.Enviroment = 1;
            //managerNFe.PathOutPut = Application.StartupPath + "\\nfe";
            //managerNFe.SchemaPath = Application.StartupPath + "\\schemas\\nfe";
            ////managerNFe.schemaNFe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\nfe\nfe_v2.00.xsd";
            ////managerNFe.schemaCancNFe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\nfe\envEventoCancNFe_v1.00.xsd";
            ////managerNFe.schemaEventNFe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\nfe\cancNFe_v2.00.xsd";
            //managerNFe.Cnpj = "07209613000182";
            ////managerNFe.Certificate = @"C:\Google Drive\desenvolvimento\clientes\injel\cert-injel-exp-s(injel12345).pfx";

            //managerNFe.EmailFrom = "valter.batista@sotisolutions.com";
            //managerNFe.EmailSubject = "NFe";
            //managerNFe.EmailBody = "Teste";
            //managerNFe.EmailDisplay = true;

            //managerNFe.SmtpHost = "smtp.sotisolutions.com";
            //managerNFe.SmtpPort = 587;
            //managerNFe.SmtpUsername = "valter.batista@sotisolutions.com";
            //managerNFe.SmtpPassword = "janeiro10@10";



            ////managerNFe.Gmt = "-02:00"; 
            //managerNFCe.ShowProgressBar = true;
            //managerNFCe.Uf = 35;
            //managerNFCe.Enviroment = 2;
            //managerNFCe.PathOutPut = Application.StartupPath + "\\nfce"; //@"F:\Meus Arquivos\SotiSolutions\Projetos\Khronus Framework-Net\nfe\"; // Application.StartupPath;
            //managerNFCe.SchemaPath = Application.StartupPath + "\\schemas\\nfe"; //@"F:\Meus Arquivos\SotiSolutions\Projetos\Khronus Framework-Net\schemas\nfe\";
            ////managerNFe.schemaNFe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\nfe\nfe_v2.00.xsd";
            ////managerNFe.schemaCancNFe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\nfe\envEventoCancNFe_v1.00.xsd";
            ////managerNFe.schemaEventNFe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\nfe\cancNFe_v2.00.xsd";
            //managerNFCe.Cnpj = "07209613000182";

            //managerNFCe.EmailFrom = "valter.batista@sotisolutions.com";
            //managerNFCe.EmailSubject = "NFe";
            //managerNFCe.EmailBody = "Teste";
            //managerNFCe.EmailDisplay = true;

            //managerNFCe.SmtpHost = "smtp.sotisolutions.com";
            //managerNFCe.SmtpPort = 587;
            //managerNFCe.SmtpUsername = "valter.batista@sotisolutions.com";
            //managerNFCe.SmtpPassword = "janeiro10@10";

            ///*
            // * CTe
            // */
            //managerCTe.PathOutPut = Application.StartupPath + "\\cte";
            ////managerCTe.schemaCTe = Application.StartupPath + "\\schemas"; //\\PL_CTe_200";
            //managerCTe.SchemaPath = Application.StartupPath + "\\schemas\\cte";
            ////managerCTe.schemaCancCTe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\PL_CTe_200\eventoCTe_v2.00.xsd";
            ////managerCTe.schemaEventCTe = @"D:\Meus Arquivos\Clientes\SotiSolutions\Projetos\Khronus Framework-Net\schemas\PL_CTe_200\eventoCTe_v2.00.xsd";
            //managerCTe.Enviroment = 2;
            //managerCTe.Uf = 35;
            //managerCTe.Cnpj = "03806784000138"; //"11141236000164"; //"";
            ////managerCTe.CurrentVersion = "2.00";
            //managerCTe.Crt = 1; //3 ;

            //managerCTe.EmailFrom = "valter.batista@sotisolutions.com";
            //managerCTe.EmailSubject = "NFe";
            //managerCTe.EmailBody = "Teste";
            //managerCTe.EmailDisplay = true;

            //managerCTe.SmtpHost = "smtp.sotisolutions.com";
            //managerCTe.SmtpPort = 587;
            //managerCTe.SmtpUsername = "valter.batista@sotisolutions.com";
            //managerCTe.SmtpPassword = "janeiro10@10";

            ////
            ////MDFe
            ////
            //managerMDFe.OutPutPath = Application.StartupPath + "\\mdfe";
            //managerMDFe.SchemaPath = Application.StartupPath + "\\schemas\\mdfe";
            //managerMDFe.Enviroment = 1;
            //managerMDFe.Uf = 35;
            //managerMDFe.Cnpj = "07945649000124"; // "11141236000164";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Certificate cert = new Certificate(null, "bbc1130");
            //Certificate cert = Certificate.GetCertificate(null, "bbc1130");

            //if (cert != null)
            //{
            //    MessageBox.Show(String.Format("Certificate\nType={0}\nSubject={1}\nFriendlyName={2}\nVersion={3}\nExpirationDate={4}\n",
            //        cert.Type,
            //        cert.Subject,
            //        cert.FriendlyName,
            //        cert.Version,
            //        cert.ExpirationDate
            //    ));
            //}
            //else
            //{
            //    MessageBox.Show("Falha ao carregar o certificado");
            //}

            ////cert = new Certificate("c:\\cert.pfx", "bbc1130");
            //cert = Certificate.GetCertificate("c:\\cert.pfx", "bbc1130");

            //if (cert != null)
            //{
            //    MessageBox.Show(String.Format("Certificate\nType={0}\nSubject={1}\nFriendlyName={2}\nVersion={3}\nExpirationDate={4}\n",
            //        cert.Type,
            //        cert.Subject,
            //        cert.FriendlyName,
            //        cert.Version,
            //        cert.ExpirationDate
            //    ));
            //}
            //else
            //{
            //    MessageBox.Show("Falha ao carregar o certificado");
            //}

            ////cert = new Certificate("CN=BRUZA PECAS E SERVICOS AUTOMOTIVOS LTDA EPP:07209613000182, OU=Autenticado por AR Confiamais, OU=RFB e-CNPJ A1, OU=Secretaria da Receita Federal do Brasil - RFB, L=SOROCABA, S=SP, O=ICP-Brasil, C=BR", "bbc1130");
            //cert = Certificate.GetCertificate("CN=BRUZA PECAS E SERVICOS AUTOMOTIVOS LTDA EPP:07209613000182, OU=Autenticado por AR Confiamais, OU=RFB e-CNPJ A1, OU=Secretaria da Receita Federal do Brasil - RFB, L=SOROCABA, S=SP, O=ICP-Brasil, C=BR", "bbc1130");

            //if (cert != null)
            //{
            //    MessageBox.Show(String.Format("Certificate\nType={0}\nSubject={1}\nFriendlyName={2}\nVersion={3}\nExpirationDate={4}\n",
            //        cert.Type,
            //        cert.Subject,
            //        cert.FriendlyName,
            //        cert.Version,
            //        cert.ExpirationDate
            //    ));
            //}
            //else
            //{
            //    MessageBox.Show("Falha ao carregar o certificado");
            //}

            Certificate cert = new Certificate(null, "bbc1130");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CFeManager manager = CFeManager.getInstance();
            manager.LibraryPath = @"c:\SAT\SAT.dll";
            manager.ActivationCode = "1234567890";
            manager.PDV = "001";
            manager.CnpjSH = "13456988000140";
            manager.SignAC = "TiYIrBgJx8JhoXsFOGMIKCXGOpjnvt4VEdyiPU7W8E6CeJKqk8349MX1GdlBd8Za4QnnZqNh+hfF0IGBnpU7L/F9a00iE5+Z4redIi/L3qFqBMMhII8ZhNS7VVLkYVfA8EN0A94+vau+X3GVJL7428TioY8QPvzhfdcgjvc2Qq6GTkSseUi+JFgSIUVFfwcz5jCCyT301adw1hKJEpLzw2GtxcKVV4qEefNyd3d6ruPaq67u8JBT1CMYTlqjq1d6UqhJNODcLFZJpbUwak+yZpNArVlrpBcKoYjtHlrwna8tseBBgR6WVqP2V/AZ48v0oHKJT0CtCRQPmHUq8Yq2JA==";
            
            TCFe cfe = new TCFe();

            TCFeInfCFe infCFe = new TCFeInfCFe();
            infCFe.versaoDadosEnt = "0.07";

            TCFeInfCFeIde ide = new TCFeInfCFeIde();
            //ide.CNPJ = "13456988000140";
            //ide.signAC = "TiYIrBgJx8JhoXsFOGMIKCXGOpjnvt4VEdyiPU7W8E6CeJKqk8349MX1GdlBd8Za4QnnZqNh+hfF0IGBnpU7L/F9a00iE5+Z4redIi/L3qFqBMMhII8ZhNS7VVLkYVfA8EN0A94+vau+X3GVJL7428TioY8QPvzhfdcgjvc2Qq6GTkSseUi+JFgSIUVFfwcz5jCCyT301adw1hKJEpLzw2GtxcKVV4qEefNyd3d6ruPaq67u8JBT1CMYTlqjq1d6UqhJNODcLFZJpbUwak+yZpNArVlrpBcKoYjtHlrwna8tseBBgR6WVqP2V/AZ48v0oHKJT0CtCRQPmHUq8Yq2JA==";
            //ide.numeroCaixa = "001";

            infCFe.ide = ide;

            TCFeInfCFeEmit emit = new TCFeInfCFeEmit();
            //emit.CNPJ = "10189821000171";
            emit.CNPJ = "11111111111111";
            emit.IE = "111111111111";
            emit.IM = "111111111";
            emit.cRegTribISSQN = "1";
            emit.indRatISSQN = "S";

            infCFe.emit = emit;

            TCFeInfCFeDest dest = new TCFeInfCFeDest();
            dest.CNPJ = "13456988000140";
            //dest.CPF = "17734222862";
            dest.xNome = "VALTERLINO BATISTA MACIEL - ME";

            infCFe.dest = dest;

            //
            //
            //
            TCFeInfCFeDet det = new TCFeInfCFeDet();
            det.nItem = "1";

            //
            //
            //
            TCFeInfCFeDetProd prod = new TCFeInfCFeDetProd();
            prod.cProd = "1";
            prod.xProd = "x";
            prod.NCM = "90909090";
            prod.CFOP = "5102";
            prod.uCom = "PC";
            prod.qCom = "1";
            prod.vUnCom = "90,00";
            prod.indRegra = "A";
            prod.vDesc = "0,00";
            prod.vOutro = "0,00";

            det.prod = prod;

            //
            //
            //
            TCFeInfCFeDetImposto imposto = new TCFeInfCFeDetImposto();
            imposto.vItem12741 = "0,00";

            //
            //
            //
            TCFeInfCFeDetImpostoICMS icms = new TCFeInfCFeDetImpostoICMS();
            icms.Orig = "0";
            icms.CST = "60";
            icms.pICMS = "0";

            imposto.ICMS = icms;

            //
            //
            //
            TCFeInfCFeDetImpostoPIS pis = new TCFeInfCFeDetImpostoPIS();
            pis.CST = "49";
            pis.pPIS = "0";

            imposto.PIS = pis;

            //
            //
            //
            TCFeInfCFeDetImpostoCOFINS cofins = new TCFeInfCFeDetImpostoCOFINS();
            cofins.CST = "49";
            cofins.pCOFINS = "0";

            imposto.COFINS = cofins;

            det.imposto = imposto;

            //
            //
            //
            infCFe.det.Add(det);

            //
            //
            //
            TCFeInfCFeTotal total = new TCFeInfCFeTotal();
            total.vCFeLei12741 = "0,00";

            infCFe.total = total;

            //
            //
            //
            TCFeInfCFePgto pgto = new TCFeInfCFePgto();

            TCFeInfCFePgtoMP mp = new TCFeInfCFePgtoMP();
            mp.cMP = "01";
            mp.vMP = "40,00";

            pgto.MP.Add(mp);

            mp = new TCFeInfCFePgtoMP();
            mp.cMP = "02";
            mp.vMP = "30,00";

            pgto.MP.Add(mp);

            mp = new TCFeInfCFePgtoMP();
            mp.cMP = "03";
            mp.vMP = "30,00";

            pgto.MP.Add(mp);

            infCFe.pgto = pgto;

            //
            //
            //
            TCFeInfCFeInfAdic infAdic = new TCFeInfCFeInfAdic();
            infAdic.infCpl = "Voce pagou aproximadamente:R$ 0,20 de impostos federais R$ 0,24 de impostos estaduais R$ 1,97 pelos produto Fonte: IBPT 5oi7eW";

            infCFe.infAdic = infAdic;

            cfe.infCFe = infCFe;

            //
            //
            //
            DFeRet ret = manager.send(cfe);

            if (ret.cStat.Equals("Success"))
            {
                String file = Application.StartupPath + "\\" + ret.chNFe + "-proc.xml";

                System.IO.File.WriteAllText(file, ret.xml);

                //ret = manager.print("Microsoft XPS Document Writer", ret.xml);

                MessageBox.Show(ret.cStat);
            }
            else
            {
                MessageBox.Show(ret.xMotivo);
                MessageBox.Show(ret.xml);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CFeManager manager = CFeManager.getInstance();
            manager.ActivationCode = "1234567890";
            manager.LibraryPath = @"c:\SAT\SAT.dll";

            DFeRet ret = manager.queryStatus();

            MessageBox.Show(ret.xMotivo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CFeManager manager = CFeManager.getInstance();
            manager.ActivationCode = "1234567890";
            manager.LibraryPath = @"c:\SAT\SAT.dll";

            DFeRet ret = manager.queryOperationStatus();

            MessageBox.Show(ret.xMotivo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CFeManager manager = CFeManager.getInstance();
            manager.ActivationCode = "1234567890";
            manager.LibraryPath = @"c:\SAT\SAT.dll";
            manager.PDV = "001";
            manager.CnpjSH = "13456988000140";
            manager.SignAC = "TiYIrBgJx8JhoXsFOGMIKCXGOpjnvt4VEdyiPU7W8E6CeJKqk8349MX1GdlBd8Za4QnnZqNh+hfF0IGBnpU7L/F9a00iE5+Z4redIi/L3qFqBMMhII8ZhNS7VVLkYVfA8EN0A94+vau+X3GVJL7428TioY8QPvzhfdcgjvc2Qq6GTkSseUi+JFgSIUVFfwcz5jCCyT301adw1hKJEpLzw2GtxcKVV4qEefNyd3d6ruPaq67u8JBT1CMYTlqjq1d6UqhJNODcLFZJpbUwak+yZpNArVlrpBcKoYjtHlrwna8tseBBgR6WVqP2V/AZ48v0oHKJT0CtCRQPmHUq8Yq2JA==";

            DFeRet ret = manager.cancel("35190111111111111111591234567890000193050585");

            MessageBox.Show(ret.xMotivo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CFeManager manager = CFeManager.getInstance();

            manager.ActivationCode = "1234567890";
            manager.LibraryPath = @"c:\SAT\SAT.dll";
            manager.PDV = "001";
            manager.CnpjSH = "13456988000140";
            manager.SignAC = "TiYIrBgJx8JhoXsFOGMIKCXGOpjnvt4VEdyiPU7W8E6CeJKqk8349MX1GdlBd8Za4QnnZqNh+hfF0IGBnpU7L/F9a00iE5+Z4redIi/L3qFqBMMhII8ZhNS7VVLkYVfA8EN0A94+vau+X3GVJL7428TioY8QPvzhfdcgjvc2Qq6GTkSseUi+JFgSIUVFfwcz5jCCyT301adw1hKJEpLzw2GtxcKVV4qEefNyd3d6ruPaq67u8JBT1CMYTlqjq1d6UqhJNODcLFZJpbUwak+yZpNArVlrpBcKoYjtHlrwna8tseBBgR6WVqP2V/AZ48v0oHKJT0CtCRQPmHUq8Yq2JA==";

            openFileDialog1.Title = "Selecione a NFe";
            openFileDialog1.Filter = "*.xml|*.xml";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //DFeRet ret = manager.print("Microsoft XPS Document Writer", new FileInfo(openFileDialog1.FileName));
                    DFeRet ret = manager.print(printDialog1.PrinterSettings.PrinterName, new FileInfo(openFileDialog1.FileName));

                    MessageBox.Show(ret.xMotivo);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CFeManager manager = CFeManager.getInstance();

            manager.ActivationCode = "1234567890";
            manager.LibraryPath = @"c:\SAT\SAT.dll";
            manager.PDV = "001";
            manager.CnpjSH = "13456988000140";
            manager.SignAC = "TiYIrBgJx8JhoXsFOGMIKCXGOpjnvt4VEdyiPU7W8E6CeJKqk8349MX1GdlBd8Za4QnnZqNh+hfF0IGBnpU7L/F9a00iE5+Z4redIi/L3qFqBMMhII8ZhNS7VVLkYVfA8EN0A94+vau+X3GVJL7428TioY8QPvzhfdcgjvc2Qq6GTkSseUi+JFgSIUVFfwcz5jCCyT301adw1hKJEpLzw2GtxcKVV4qEefNyd3d6ruPaq67u8JBT1CMYTlqjq1d6UqhJNODcLFZJpbUwak+yZpNArVlrpBcKoYjtHlrwna8tseBBgR6WVqP2V/AZ48v0oHKJT0CtCRQPmHUq8Yq2JA==";

            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //DFeRet ret = manager.print("Microsoft XPS Document Writer", textBox1.Text);
                DFeRet ret = manager.print(printDialog1.PrinterSettings.PrinterName, textBox1.Text);

                MessageBox.Show(ret.xMotivo);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            setupNFeManager();

            TNFeInfNFe infNFe = new TNFeInfNFe();

            //
            // ide
            //
            TNFeInfNFeIde ide = new TNFeInfNFeIde();
            ide.cUF = "35";
            ide.cNF = "00001302";
            ide.natOp = "VENDA DE MERCADORIA";
            ide.mod = "55";
            ide.serie = "1";
            ide.nNF = "1302";
            ide.dhEmi = DateTime.Now.ToString();
            ide.dhSaiEnt = DateTime.Now.ToString();
            ide.tpNF = "1";
            ide.idDest = "1";
            ide.cMunFG = "3552205";
            ide.tpImp = "1";
            ide.tpEmis = "1";
            ide.cDV = "0";
            ide.tpAmb = "1";
            ide.finNFe = "1";
            ide.indFinal = "1";
            ide.indPres = "0";
            ide.procEmi = "0";
            ide.verProc = "3.0.0";

            infNFe.ide = ide;

            //
            // Contingencia
            //
            ide.dhCont = DateTime.Now.ToString();
            ide.xJust = "Teste de contingencia";

            //
            // NFref
            //
            //TNFeInfNFeIdeNFref nfRef = new TNFeInfNFeIdeNFref();
            ////nfRef.refNFe = "35140671602569000175550010000045781000045781";

            //ide.NFref.Add(nfRef);

            //
            // emit
            //
            TNFeInfNFeEmit emit = new TNFeInfNFeEmit();
            emit.CNPJ = "07209613000182";
            emit.xNome = "BRUZA PECAS E SERVICOS AUTOMOTIVOS LTDA";
            emit.xFant = "INJEL";

            TNFeInfNFeEmitEnderEmit enderEmit = new TNFeInfNFeEmitEnderEmit();
            enderEmit.xLgr = "RUA APARECIDA";
            enderEmit.nro = "559";
            enderEmit.xCpl = "";
            enderEmit.xBairro = "VILA SANTANA";
            enderEmit.cMun = "3552205";
            enderEmit.xMun = "SOROCABA";
            enderEmit.UF = "SP";
            enderEmit.CEP = "18095-000";
            enderEmit.cPais = "1058";
            enderEmit.xPais = "BRASIL";
            enderEmit.fone = "";

            emit.IE = "669.361.513.111";
            emit.IEST = "";
            emit.IM = "";
            emit.CNAE = "";
            emit.CRT = "1";

            emit.enderEmit = enderEmit;

            infNFe.emit = emit;

            //
            // dest
            //
            TNFeInfNFeDest dest = new TNFeInfNFeDest();
            //dest.CNPJ = "03697421000292";
            dest.CPF = "17734222862";
            //dest.idEstrangeiro = ""; 
            dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";

            TNFeInfNFeDestEnderDest enderDest = new TNFeInfNFeDestEnderDest();
            enderDest.xLgr = "RUA AGUARIO ANTUNES";
            enderDest.nro = "134";
            enderDest.xBairro = "JD BOM SUCESSO";
            enderDest.xCpl = "";
            enderDest.cMun = "3552205";
            enderDest.xMun = "SOROCABA";
            enderDest.UF = "SP";
            enderDest.CEP = "18095-000";
            enderDest.cPais = "1058";
            enderDest.xPais = "BRASIL";
            enderDest.fone = "";

            dest.indIEDest = "9";
            dest.IE = "";
            dest.email = "valter.batista@sotisolutions.com";

            dest.enderDest = enderDest;

            infNFe.dest = dest;

            //
            // entrega
            //
            //TNFeInfNFeEntrega entrega = new TNFeInfNFeEntrega();
            //entrega.CNPJ = "99999999000191";
            //entrega.xLgr = "RUA JOSE VERSOLATO";
            //entrega.nro = "111";
            //entrega.xBairro = "CENTRO";
            //entrega.xCpl = "";
            //entrega.cMun = "3548708";
            //entrega.xMun = "SAO BERNARDO DO CAMPO";
            //entrega.UF = "SP";

            //infNFe.entrega = entrega;

            //
            // det
            //
            TNFeInfNFeDet det = new TNFeInfNFeDet();

            //
            // prod
            //
            TNFeInfNFeDetProd prod = new TNFeInfNFeDetProd();
            prod.cProd = "1060";
            //prod.cEAN = "7891173023001";
            prod.cEAN = "SEM GTIN";
            prod.xProd = "F16PL";
            prod.NCM = "32091010";
            prod.NVE = "";
            prod.CEST = "2400100";
            prod.indEscala = "";
            prod.CNPJFab = "";
            prod.cBenef = "";
            prod.EXTIPI = "";
            //prod.genero = "";
            prod.CFOP = "5405";
            prod.uCom = "UN";
            prod.qCom = "2";
            prod.vUnCom = "97";
            prod.vProd = "194,00";
            prod.cEANTrib = "";
            prod.uTrib = "UN";
            prod.qTrib = "2";
            prod.vUnTrib = "97";
            prod.vFrete = "6";
            prod.vSeg = "";
            prod.vDesc = "";
            prod.vOutro = "";
            prod.indTot = "1";
            prod.nItemPed = "1";
            det.infAdProd = "";

            det.prod = prod;

            ////
            //// DI
            ////
            //TNFeInfNFeDetProdDI di = new TNFeInfNFeDetProdDI();
            //di.nDI = "12312312";
            //di.dDI = DateTime.Today.ToString();
            //di.xLocDesemb = "aaaa";
            //di.UFDesemb = "aa";
            //di.dDesemb = DateTime.Today.ToString();
            //di.tpViaTransp = "1";
            //di.vAFRMM = "";
            //di.tpIntermedio = "1";
            //di.CNPJ = "";
            //di.UFTerceiro = "";
            //di.cExportador = "123";

            //TNFeInfNFeDetProdDIAdicao adi1 = new TNFeInfNFeDetProdDIAdicao();
            //adi1.nAdicao = "1";
            //adi1.nSeqAdic = "1";
            //adi1.cFabricante = "123";
            //adi1.vDescDI = "123";
            //adi1.nDraw = "123";

            //di.adi.Add(adi1);

            //TNFeInfNFeDetProdDIAdicao adi2 = new TNFeInfNFeDetProdDIAdicao();
            //adi2.nAdicao = "2";
            //adi2.nSeqAdic = "2";
            //adi2.cFabricante = "123";
            //adi2.vDescDI = "123";
            //adi2.nDraw = "123";

            //di.adi.Add(adi2);

            //prod.DI.Add(di);

            //
            // Impostos
            //
            TNFeInfNFeDetImposto imposto = new TNFeInfNFeDetImposto();
            imposto.vTotTrib = "66,19";

            //
            // ICMS
            //
            TNFeInfNFeDetImpostoICMS icms = new TNFeInfNFeDetImpostoICMS();

            //
            // CST=00
            //
            //icms.orig = "0";
            //icms.CST = "00";
            //icms.modBC = "3";
            //icms.vBC = "1100";
            //icms.pICMS = "18";
            //icms.vICMS = "198";
            //icms.pFCP = "2";
            //icms.vFCP = "22";

            //
            // CST=60
            //
            icms.orig = "0";
            //icms.CST = "60";
            icms.CST = "500";
            icms.vBCSTRet = "3,00";
            icms.pST = "2,0000";
            icms.vICMSSubstituto = "20,00";
            icms.vICMSSTRet = "3,54";
            //icms.vICMS = "198";
            //icms.pFCP = "2";
            //icms.vFCP = "22";

            imposto.ICMS = icms;

            ////ICMS00
            ////NFeDetImpostoICMS10 icms = new NFeDetImpostoICMS10();
            ////icms.orig = "0";
            ////icms.CST = "00";
            ////icms.modBC = "3";
            ////icms.vBC = "1100";
            ////icms.pICMS = "18";
            ////icms.vICMS = "198";
            ////icms.pFCP = "2";
            ////icms.vFCP = "22";

            //NFeDetImpostoICMSSN500 icms = new NFeDetImpostoICMSSN500();
            //icms.orig = "0";
            //icms.CSOSN = "500";

            ////icms.pRedBC = "0";

            ////
            //// Simples Nacional
            //// 
            ////icms.orig = "0";
            ////icms.CSOSN = "101";
            ////icms.pCredSN = "3.10";
            ////icms.vCredICMSSN = "25.42";

            ////
            //// Regime Normal
            ////


            ////// Exemplo ICMS 10
            //////icms.CST = "20";
            //////icms.modBC = "3";
            //////icms.vBC = "228";
            //////icms.pRedBC = "80";
            //////icms.pICMS = "12";
            //////icms.vICMS = "27,36";

            /////*
            //// * ST
            //// */
            ////icms.modBCST = "";
            ////icms.pMVAST = "";
            ////icms.pRedBCST = "";
            ////icms.vBCST = "";
            ////icms.pICMSST = "";
            ////icms.vICMSST = "";

            /////*
            //// * Icms Retido
            //// */
            ////icms.motDesICMS = "";
            ////icms.vBCSTRet = "";
            ////icms.vICMSSTRet = "";

            /*
             * Importacao
             */
            //TNFeInfNFeDetImpostoII ii = new TNFeInfNFeDetImpostoII();
            //ii.vBC = "0";
            //ii.vDespAdu = "0";
            //ii.vII = "0";
            //ii.vIOF = "0";

            //imposto.II = ii;

            //
            // IPI
            //
            TNFeInfNFeDetImpostoIPI ipi = new TNFeInfNFeDetImpostoIPI();
            ipi.CST = "53";
            ipi.cEnq = "999";
            //ipi.pIPI = "15";
            //ipi.vBC = "100,00";
            ////ipi.qUnid = "1";
            ////ipi.vUnid = "1";
            //ipi.vIPI = "0,00";

            imposto.IPI = ipi;

            // 
            // PIS
            //
            TNFeInfNFeDetImpostoPIS pis = new TNFeInfNFeDetImpostoPIS();
            pis.CST = "07";
            //pis.vBC = "1100";
            //pis.pPIS = "0,65";
            ////pis.qBCProd = "";
            ////pis.vAliqProd = "";
            //pis.vPIS = "7,15";

            imposto.PIS = pis;

            //
            // COFINS
            //
            TNFeInfNFeDetImpostoCOFINS cofins = new TNFeInfNFeDetImpostoCOFINS();
            cofins.CST = "07";
            //cofins.vBC = "1100";
            //cofins.pCOFINS = "3";
            ////cofins.qBCProd = "";
            ////cofins.vAliqProd = "";
            //cofins.vCOFINS = "33";

            imposto.COFINS = cofins;

            det.imposto = imposto;

            //
            // impostoDevol
            //
            TNFeInfNFeDetImpostoDevol impostoDevol = new TNFeInfNFeDetImpostoDevol();
            impostoDevol.pDevol = "100";

            TNFeInfNFeDetImpostoDevolIPI impostoDevolIPI = new TNFeInfNFeDetImpostoDevolIPI();
            impostoDevolIPI.vIPIDevol = "100,00";

            impostoDevol.IPI = impostoDevolIPI;

            det.impostoDevol = impostoDevol;


            infNFe.det.Add(det);

            // 
            // total
            //
            TNFeInfNFeTotalICMSTot icmsTot = new TNFeInfNFeTotalICMSTot();
            icmsTot.vBC = "0";
            icmsTot.vICMS = "0";
            icmsTot.vFCP = "0";
            icmsTot.vBCST = "";
            icmsTot.vST = "";
            icmsTot.vProd = "194";
            icmsTot.vFrete = "6";
            icmsTot.vSeg = "";
            icmsTot.vDesc = "";
            icmsTot.vII = "";
            icmsTot.vIPI = "";
            icmsTot.vIPIDevol = "100,00"; 
            icmsTot.vPIS = "0";
            icmsTot.vCOFINS = "0";
            icmsTot.vOutro = "";
            icmsTot.vNF = "200";
            icmsTot.vTotTrib = "66,19";

            TNFeInfNFeTotal total = new TNFeInfNFeTotal();
            total.ICMSTot = icmsTot;

            infNFe.total = total;

            //      
            // transp
            //
            TNFeInfNFeTransp transp = new TNFeInfNFeTransp();
            transp.modFrete = "0";

            //
            // transporta
            //
            TNFeInfNFeTranspTransporta transporta = new TNFeInfNFeTranspTransporta();
            transporta.CNPJ = "97528682000141";
            transporta.xNome = "EXPRESSO PEREIRA";
            transporta.IE = "";
            transporta.xEnder = "RUA ABNER PEDROSO DE ALCANTARA, 300, VILA MINEIRAO";
            transporta.xMun = "SOROCABA";
            transporta.UF = "SP";

            transp.transporta = transporta;

            //
            // veicTransp
            //
            TNFeInfNFeTranspVeicTransp veicTransp = new TNFeInfNFeTranspVeicTransp();
            veicTransp.placa = "DPQ6837";
            veicTransp.UF = "SP";
            veicTransp.RNTC = "";

            transp.veicTransp = veicTransp;

            //
            // vol
            //
            TNFeInfNFeTranspVol vol = new TNFeInfNFeTranspVol();
            //vol.qVol = "1";
            //vol.nVol = "0";
            //vol.esp = "VOLUME";
            vol.pesoB = "22000";
            vol.pesoL = "22000";

            transp.vol = vol;

            infNFe.transp = transp;

            //
            // cobr
            //
            TNFeInfNFeCobr cobr = new TNFeInfNFeCobr();

            //
            // fat
            // 
            TNFeInfNFeCobrFat fat = new TNFeInfNFeCobrFat();
            fat.nFat = "1302";
            fat.vOrig = "194";
            fat.vDesc = "0";
            fat.vLiq = "194";

            cobr.fat = fat;

            //
            // dup
            // 
            TNFeInfNFeCobrDup dup = new TNFeInfNFeCobrDup();
            dup.nDup = "001";
            dup.dVenc = "28/05/2019";
            dup.vDup = "194";

            //cobr.dup.Add(dup);

            //dup = new TNFeInfNFeCobrDup();
            //dup.nDup = "12044";
            //dup.dVenc = "17/06/2017";
            //dup.vDup = "100";

            cobr.dup.Add(dup);

            infNFe.cobr = cobr;

            //
            // pag
            //
            TNFeInfNFePag pag = new TNFeInfNFePag();

            TNFeInfNFePagDetPag detPag = new TNFeInfNFePagDetPag();
            detPag.indPag = "1";
            detPag.tPag = "15";
            detPag.vPag = "194";

            pag.vTroco = "0";

            pag.detPag.Add(detPag);

            infNFe.pag = pag;

            //
            // infAdic
            // 
            TNFeInfNFeInfAdic infAdic = new TNFeInfNFeInfAdic();
            infAdic.infCpl = "VALOR APROX TRIBUTOS R$ 66,19 (34,12%) FONTE: IBPT";
            //infAdic.infAdFisco = "CARTAO DE CREDITO EM 6X - 01/01/2017; R$ 100,00 1 PARCELA";

            infNFe.infAdic = infAdic;

            TNFe nfe = new TNFe();
            nfe.infNFe = infNFe;

            DFeRet ret = managerNFe.send(nfe);

            MessageBox.Show(ret.xMotivo);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CTeIde ide = new CTeIde();
            ide.cUF = "35";
            ide.cCT = "11";
            ide.CFOP = "5352";
            ide.natOp = "VENDA";
            ide.mod = "57";
            //ide.forPag = "0";
            ide.serie = "1";
            ide.nCT = "11";
            ide.dhEmi = DateTime.Now.ToString();
            ide.tpImp = "1";
            ide.tpEmis = "1";
            ide.cDV = "";
            ide.tpAmb = "2";
            ide.tpCTe = "0";
            ide.procEmi = "0";
            ide.verProc = "1.0.0";
            ide.indGlobalizado = "";
            ide.cMunEnv = "3552205";
            ide.xMunEnv = "Sorocaba";
            ide.UFEnv = "SP";
            ide.modal = "01";
            ide.tpServ = "0";
            ide.cMunIni = "3552205";
            ide.xMunIni = "Sorocaba";
            ide.UFIni = "SP";
            ide.cMunFim = "3552205";
            ide.xMunFim = "Sorocaba";
            ide.UFFim = "SP";
            ide.retira = "1";
            ide.xDetRetira = "";
            ide.indIEToma = "9";

            //ide.refCTE = "";
            //ide.crt = "1";

            CTeIdeToma3 toma3 = new CTeIdeToma3();
            toma3.toma = "3";

            ide.toma3 = toma3;

            //CTeIdeToma4 toma4 = new CTeIdeToma4();
            //toma4.toma = "";
            //toma4.CNPJ = "";
            //toma4.CPF = "";
            //toma4.IE = "";
            //toma4.xNome = "";
            //toma4.xFant = "";
            //toma4.fone = "";

            //CTeEnder enderToma = new CTeEnder();
            //enderToma.xLgr = "";
            //enderToma.nro = "";
            //enderToma.xCpl = "";
            //enderToma.xBairro = "";
            //enderToma.cMun = "";
            //enderToma.xMun = "";
            //enderToma.CEP = "";
            //enderToma.UF = "";
            //enderToma.cPais = "";
            //enderToma.xPais = "";

            //toma4.enderToma = enderToma;
            //toma4.email = "";

            //ide.toma4 = toma4;

            ide.dhCont = "";
            ide.xJust = "";

            //
            //compl
            //
            CTeCompl compl = new CTeCompl();
            compl.xObs = "Teste";

            //
            //emit
            //
            CTeEmit emit = new CTeEmit();
            emit.CNPJ = "11141236000164";
            emit.xNome = "VDK TRANSPORTES LTDA ME";
            emit.xFant = "VDK TRANSPORTES";
            emit.IE = "669965038116";

            CTeEnder ender = new CTeEnder();
            ender.xLgr = "ANTONIO DE NAPOLI";
            ender.nro = "504";
            ender.xCpl = "";
            ender.xBairro = "PARADA TAIPAS";
            ender.cMun = "3552205";
            ender.xMun = "SAO PAULO";
            ender.UF = "SP";
            ender.CEP = "02987030";
            //ender.cPais = "1058";
            //ender.xPais = "BRASIL";
            ender.fone = "1139284522";

            emit.enderEmit = ender;

            //
            //rem
            //
            CTeRem rem = new CTeRem();
            rem.CNPJ = "71602569000175";
            //rem.CPF = "17734222862";
            rem.IE = "";
            rem.xNome = "VALTERLINO BATISTA MACIEL";
            rem.xFant = "";
            rem.fone = "";

            ender = new CTeEnder();
            ender.xLgr = "RUA SEVERO PEREIRA";
            ender.nro = "35";
            ender.xCpl = "";
            ender.xBairro = "WANNEL VILLE";
            ender.cMun = "3552205";
            ender.xMun = "SOROCABA";
            ender.UF = "SP";
            ender.CEP = "18053540";
            ender.cPais = "1058";
            ender.xPais = "BRASIL";

            rem.enderReme = ender;
            rem.email = "";

            //CTeRemInfNF infNF = new CTeRemInfNF();
            //infNF.mod = "01";
            //infNF.serie = "U";
            //infNF.nDoc = "13387";
            //infNF.dEmi = DateTime.Now.ToString();
            //infNF.vBC = "921.9";
            //infNF.vICMS = "0";
            //infNF.vBCST = "0";
            //infNF.vST = "0";
            //infNF.vProd = "0";
            //infNF.vNF = "921.9";
            //infNF.nCFOP = "6353";

            //rem.infNF.Add(infNF);

            //CTeExped exped = new CTeExped();
            //exped.CNPJ = "71602569000175";
            //exped.CPF = "";
            //exped.IE = "ISENTO";
            //exped.xNome = "ATUAIR INSTRUMENTACAO LTDA";
            //exped.fone = "";

            //ender = new CTeEnder();
            //ender.xLgr = "RUA SEVERO PEREIRA";
            //ender.nro = "35";
            //ender.xCpl = "";
            //ender.xBairro = "WANNEL VILLE";
            //ender.cMun = "3552205";
            //ender.xMun = "SOROCABA";
            //ender.UF = "SP";
            //ender.CEP = "18053540";
            //ender.cPais = "1058";
            //ender.xPais = "BRASIL";

            //exped.enderExped = ender;
            //exped.email = "";

            //CTeReceb receb = new CTeReceb();
            //receb.CNPJ = "71602569000175";
            //receb.CPF = "";
            //receb.IE = "ISENTO";
            //receb.xNome = "ATUAIR INSTRUMENTACAO LTDA";
            //receb.fone = "";

            //ender = new CTeEnder();
            //ender.xLgr = "RUA SEVERO PEREIRA";
            //ender.nro = "35";
            //ender.xCpl = "";
            //ender.xBairro = "WANNEL VILLE";
            //ender.cMun = "3552205";
            //ender.xMun = "SOROCABA";
            //ender.UF = "SP";
            //ender.CEP = "18053540";
            //ender.cPais = "1058";
            //ender.xPais = "BRASIL";

            //receb.enderReceb = ender;
            //receb.email = "";

            //
            //dest
            //
            CTeDest dest = new CTeDest();
            dest.CNPJ = "71602569000175";
            //dest.CPF = "17734222862";
            dest.IE = "";
            dest.xNome = "VALTERLINO BATISTA MACIEL";
            dest.fone = "";

            ender = new CTeEnder();
            ender.xLgr = "RUA SEVERO PEREIRA";
            ender.nro = "35";
            ender.xCpl = "";
            ender.xBairro = "WANNEL VILLE";
            ender.cMun = "3552205";
            ender.xMun = "SOROCABA";
            ender.UF = "SP";
            ender.CEP = "18053540";
            ender.cPais = "1058";
            ender.xPais = "BRASIL";

            dest.enderDest = ender;
            dest.email = "";


            CTeVPrest vPrest = new CTeVPrest();
            vPrest.vTPrest = "50,13";
            vPrest.vRec = "50,13";

            CTeVPrestComp comp = new CTeVPrestComp();
            comp.xNome = "IMPOSTO CLIENTE";
            comp.vComp = "3,51";

            vPrest.Comp.Add(comp);

            //
            //imp
            //
            CTeImp imp = new CTeImp();

            if (managerCTe.Crt != 3)
            {
                //CTeImpICMS icms = new CTeImpICMS();
                CTeImpIcmsICMSSN icms = new CTeImpIcmsICMSSN();
                icms.CST = "90";
                icms.indSN = "1";

                imp.ICMS = icms;
            }
            else
            {
                CTeImpIcmsICMS00 icms = new CTeImpIcmsICMS00();
                icms.CST = "00";
                icms.vBC = "50,13";
                icms.pICMS = "12";
                icms.vICMS = "6,02";

                imp.ICMS = icms;
            }
            //
            //infCTeNorm
            //
            CTeInfCTeNorm infCTeNorm = new CTeInfCTeNorm();

            //
            //infCTeNorm/infCarga
            //
            CTeInfCTeNormInfCarga infCarga = new CTeInfCTeNormInfCarga();

            infCarga.vCarga = "0";
            infCarga.proPred = "DIVERSOS";
            infCarga.xOutCat = "GRANEL";

            //
            //infCTeNorm/infQ
            //
            CTeInfCTeNormInfCargaInfQ infQ = new CTeInfCTeNormInfCargaInfQ();
            infQ.cUnid = "01";
            infQ.tpMed = "PESO BRUTO";
            infQ.qCarga = "1";

            infCarga.infQ.Add(infQ);

            infCTeNorm.infCarga = infCarga;

            //
            //infCTeNorm/infDoc
            //         
            CTeInfCTeNormInfDoc infDoc = new CTeInfCTeNormInfDoc();

            //CTeInfCTeNormInfDocInfNFe infNFe = new CTeInfCTeNormInfDocInfNFe();
            //infNFe.chave = "35171144466266000108550010004476851259860733";

            //infDoc.infNFe.Add(infNFe);

            CTeInfCTeNormInfDocInfNF infNF = new CTeInfCTeNormInfDocInfNF();
            infNF.mod = "01";
            infNF.serie = "U";
            infNF.nDoc = "13387";
            infNF.dEmi = DateTime.Now.ToString();
            infNF.vBC = "0";
            infNF.vICMS = "0";
            infNF.vBCST = "0";
            infNF.vST = "0";
            infNF.vProd = "0";
            infNF.vNF = "0";
            infNF.nCFOP = "6353";

            infDoc.infNF.Add(infNF);

            infCTeNorm.infDoc = infDoc;

            //
            //infCTeNorm/infModal
            //
            CTeInfCTeNormInfModal infModal = new CTeInfCTeNormInfModal();
            infModal.versaoModal = "3.00";

            //
            //infCTeNorm/infModal/rodo
            //
            CTeInfCTeNormInfModalRodo rodo = new CTeInfCTeNormInfModalRodo();
            rodo.RNTRC = "00000000";
            //rodo.dPrev = DateTime.Today.ToString();
            //rodo.lota = "0";

            infModal.rodo = rodo;

            infCTeNorm.infModal = infModal;


            ////
            ////infCTeNorm/seg
            ////
            //CTeInfCTeNormSeg seg = new CTeInfCTeNormSeg();
            //seg.respSeg = "4";
            //seg.xSeg = "PORTO SEGURO";
            //seg.nApol = "1";
            ////seg.nAver = "";
            ////seg.vCarga = "1";

            //infCTeNorm.seg = seg;


            ///*
            // * veic
            // */
            //CTeInfCTeNormInfModalRodoVeic veic = new CTeInfCTeNormInfModalRodoVeic();
            //veic.RENAVAM = "661192563";
            //veic.placa = "KMP6658";
            //veic.tara = "0";
            //veic.capKG = "0";
            //veic.capM3 = "0";
            //veic.tpProp = "T";
            //veic.tpVeic = "0";
            //veic.tpRod = "03";
            //veic.tpCar = "00";
            //veic.UF = "SP";

            //rodo.veic.Add(veic);

            //

            //











            //
            //






            ///*
            // * docAnt
            // */
            //CTeInfCTeNormDocAntEmiDocAntIdDocAntIdDocAntEle idDocAntEle = new CTeInfCTeNormDocAntEmiDocAntIdDocAntIdDocAntEle();
            //idDocAntEle.chave = "35140603806784000138570010000002211000002215";

            //CTeInfCTeNormDocAntEmiDocAntIdDocAnt idDocAnt = new CTeInfCTeNormDocAntEmiDocAntIdDocAnt();
            //idDocAnt.idDocAntEle.Add(idDocAntEle);

            //CTeInfCTeNormDocAntEmiDocAnt emiDocAnt = new CTeInfCTeNormDocAntEmiDocAnt();
            //emiDocAnt.CNPJ = "03806784000138";
            ////emiDocAnt.CPF = "";
            //emiDocAnt.IE = "669373707112";
            //emiDocAnt.UF = "SP";
            //emiDocAnt.xNome = "JORGE KAZUMI GOMI SOROCABA  EPP";

            //emiDocAnt.idDocAnt = idDocAnt;

            //CTeInfCTeNormDocAnt docAnt = new CTeInfCTeNormDocAnt();
            //docAnt.emiDocAnt.Add(emiDocAnt);

            //infCTeNorm.docAnt = docAnt;

            /*
             *
             */
            TCTe cte = new TCTe();
            cte.ide = ide;
            cte.compl = compl;
            cte.emit = emit;
            cte.rem = rem;
            //cte.exped = exped;
            //cte.receb = receb;
            cte.dest = dest;
            cte.vPrest = vPrest;
            cte.imp = imp;
            cte.infCTeNorm = infCTeNorm;

            DFeRet ret = managerCTe.CreateCTe(cte);

            MessageBox.Show(ret.xMotivo);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.xml|*xml";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String xmlFile = openFileDialog1.FileName;

            openFileDialog1.Filter = "*.png|*.png;|*.jpg|*.jpg;*|.gif|*.gif;";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String imgFile = openFileDialog1.FileName;

            managerCTe.CreateDacte(xmlFile, imgFile, true);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ////MDFe mdfe = new MDFe();
            ////com.sotisolutions.khronus.framework.dfe.mdfe.model.MDFe = new MDFe()
            ////MDFe mdfe = new MDFe();

            //MDFeIde ide = new MDFeIde();
            //ide.cUF = "35";
            //ide.tpAmb = "2";
            //ide.tpEmit = "1";
            //ide.mod = "58";
            //ide.serie = "1";
            //ide.nMDF = "5";
            //ide.cMDF = "5";
            //ide.modal = "1";
            //ide.dhEmi = DateTime.Now.ToString();
            //ide.tpEmis = "1";
            //ide.procEmi = "3";
            //ide.verProc = "1.0.7";
            //ide.UFIni = "SP";
            //ide.UFFim = "SP";

            //MDFeIdeInfMunCarrega infMunCarrega = new MDFeIdeInfMunCarrega();
            //infMunCarrega.cMunCarrega = "3552205";
            //infMunCarrega.xMunCarrega = "Sorocaba";

            //ide.infMunCarrega.Add(infMunCarrega);

            ////MDFeIdeInfPercurso infPercurso = new MDFeIdeInfPercurso();
            ////infPercurso.UFPer = "SP";

            ////ide.infPercurso.Add(infPercurso);

            //mdfe.ide = ide;

            //MDFeEmit emit = new MDFeEmit();
            //emit.CNPJ = "03806784000138";
            //emit.xNome = "JORGE KAZUMI GOMI SOROCABA EPP";
            //emit.xFant = "JKG TRANSPORTES";
            //emit.IE = "669373707112";

            //MDFeEnder ender = new MDFeEnder();
            //ender.xLgr = "R PEDRO WURSCHIG";
            //ender.nro = "276";
            //ender.xCpl = "";
            //ender.xBairro = "RETIRO SAO JOAO";
            //ender.cMun = "3552205";
            //ender.xMun = "SOROCABA";
            //ender.UF = "SP";
            //ender.CEP = "18085745";
            //ender.fone = "1532283981";
            //ender.email = "valter.batista@sotisolutions.com";

            //emit.enderEmit = ender;

            //mdfe.emit = emit;

            ///*
            // * infModal
            // */
            //MDFeInfModal infModal = new MDFeInfModal();

            //MDFeInfModalRodo rodo = new MDFeInfModalRodo();
            ////rodo.RNTRC = "02287125";
            ////rodo.CIOT = "000000000001";

            //MDFeInfMDFeInfModalRodoInfANTT infANTT = new MDFeInfMDFeInfModalRodoInfANTT();
            //infANTT.RNTRC = "02287125";

            //MDFeInfMDFeInfModalRodoInfANTTInfContratante infContratante = new MDFeInfMDFeInfModalRodoInfANTTInfContratante();
            //infContratante.CNPJ = "03806784000138";

            //infANTT.infContratante = infContratante;

            //rodo.infANTT = infANTT;

            ///*
            // * VeicTracao
            // */
            //MDFeInfModalRodoVeicTracao veicTracao = new MDFeInfModalRodoVeicTracao();
            //veicTracao.cInt = "000018";
            //veicTracao.placa = "EJV5050";
            //veicTracao.tara = "10020";
            //veicTracao.capKG = "0";
            //veicTracao.capM3 = "0";

            ///*
            // * prop
            // */
            ////MDFeInfModalRodoVeicTracaoProp prop = new MDFeInfModalRodoVeicTracaoProp();
            ////prop.CPF = "17734222862";
            ////prop.RNTRC = "12341234";
            ////prop.xNome = "valter";
            ////prop.IE = "";
            ////prop.UF = "SP";
            ////prop.tpProp = "0";

            ////VeicTracao.prop = prop;

            //MDFeInfModalRodoVeicTracaoCondutor condutor = new MDFeInfModalRodoVeicTracaoCondutor();
            //condutor.xNome = "MARCIO HENRIQUE DA SILVA LIMA";
            //condutor.CPF = "32109248807";

            //veicTracao.condutor.Add(condutor);

            //veicTracao.tpRod = "01";
            //veicTracao.tpCar = "02";
            //veicTracao.UF = "SP";

            //rodo.VeicTracao = veicTracao;

            /////*
            //// * veicReboque
            //// */
            ////for (int x = 0; x < 1; x++)
            ////{
            ////    MDFeInfModalRodoVeicReboque veicReboque = new MDFeInfModalRodoVeicReboque();
            ////    veicReboque.cInt = "12";
            ////    veicReboque.placa = "12";
            ////    veicReboque.tara = "12";
            ////    veicReboque.capKG = "12";
            ////    veicReboque.capM3 = "12";

            ////    MDFeInfModalRodoVeicReboqueProp prop2 = new MDFeInfModalRodoVeicReboqueProp();
            ////    prop2.RNTRC = "12343";

            ////    veicReboque.prop = prop2;

            ////    rodo.veicReboque.Add(veicReboque);
            ////}

            //infModal.rodo = rodo;

            //mdfe.infModal = infModal;

            ///*
            // * infDoc
            // */
            //MDFeInfDoc infDoc = new MDFeInfDoc();

            //MDFeInfDocInfMunDescarga infMunDescarga = new MDFeInfDocInfMunDescarga();
            //infMunDescarga.cMunDescarga = "3552205";
            //infMunDescarga.xMunDescarga = "Sorocaba";

            //MDFeInfDocInfMunDescargaInfCTe infCTe = new MDFeInfDocInfMunDescargaInfCTe();
            //infCTe.chCTe = "35170903806784000138570010000120591000120590";

            //infMunDescarga.infCTe.Add(infCTe);

            //infDoc.InfMunDescarga.Add(infMunDescarga);

            //mdfe.infDoc = infDoc;

            ////
            ////Seg
            ////
            //MDFeInfMDFeSeg seg = new MDFeInfMDFeSeg();

            //MDFeInfMDFeSegInfResp infResp = new MDFeInfMDFeSegInfResp();
            //infResp.respSeg = "1";
            //infResp.CNPJ = "03806784000138";

            //seg.infResp = infResp;

            //MDFeInfMDFeSegInfSeg infSeg = new MDFeInfMDFeSegInfSeg();
            //infSeg.xSeg = "JORGE KAZUMI GOMI SOROCABA EPP";
            //infSeg.CNPJ = "03806784000138";

            //seg.infSeg = infSeg;

            ////seg.nApol = "123";
            ////seg.nAver = "1234";

            //mdfe.seg = seg;

            ////tot
            //MDFeTot tot = new MDFeTot();
            //tot.qCTe = "1";
            //tot.vCarga = "100,00";
            //tot.cUnid = "01";
            //tot.qCarga = "100,00";

            //mdfe.tot = tot;

            ////MDFeLacres lacres = new MDFeLacres();
            ////lacres.nLacre = x.ToString();

            ////mdfe.lacres.Add(lacres);

            ////MDFeInfAdic infAdic = new MDFeInfAdic();
            ////infAdic.infAdFisco = "Teste";
            ////infAdic.infCpl = "Teste2";

            ////mdfe.infAdic = infAdic;

            //DFeRet ret = managerMDFe.CreateMDFe(mdfe);

            //if (ret != null)
            //{
            //    MessageBox.Show(ret.xMotivo);
            //}
            //else
            //{
            //    MessageBox.Show("Falha");
            //}
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.xml|*xml";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            DFeRet ret = managerMDFe.SendMDFe(openFileDialog1.FileName);

            MessageBox.Show(ret.xMotivo);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.xml|*xml";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String xmlFile = openFileDialog1.FileName;

            openFileDialog1.Filter = "*.png|*.png;*.jpg|*.jpg;*.gif|*.gif;";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String imgFile = openFileDialog1.FileName;

            managerMDFe.CreateDamdfe(xmlFile, imgFile, true);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DFeRet ret = managerMDFe.EncerrarMDFe("35170903806784000138580010000020771000020772", "935170017320460", DateTime.Now.ToString(), "35", "3545803");

            MessageBox.Show(ret.xMotivo);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DFeRet ret = managerMDFe.CancelarMDFe("35170903806784000138580010000020771000020772", "935170017320460", "Erro na emissao do manifesto");
            //DFeRet ret = managerMDFe.CancelarMDFe(textBox1.Text, textBox2.Text, textBox3.Text);

            MessageBox.Show(ret.xMotivo);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.css|*.css";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String file = openFileDialog1.FileName;

            //openFileDialog1.Filter = "*.png|*.png;*.jpg|*.jpg;*.gif|*.gif;";
            //openFileDialog1.FileName = String.Empty;

            //openFileDialog1.ShowDialog();

            String imgFile = openFileDialog1.FileName;

            CSSMinify css = new CSSMinify(file);

            MessageBox.Show(css.getModifiedData());
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.js|*.js";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String file = openFileDialog1.FileName;

            //openFileDialog1.Filter = "*.png|*.png;*.jpg|*.jpg;*.gif|*.gif;";
            //openFileDialog1.FileName = String.Empty;

            //openFileDialog1.ShowDialog();

            String imgFile = openFileDialog1.FileName;

            JSMinify css = new JSMinify(file);

            MessageBox.Show(css.getModifiedData());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.php|*.php";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String file = openFileDialog1.FileName;

            //openFileDialog1.Filter = "*.png|*.png;*.jpg|*.jpg;*.gif|*.gif;";
            //openFileDialog1.FileName = String.Empty;

            //openFileDialog1.ShowDialog();

            String imgFile = openFileDialog1.FileName;

            PHPMinify css = new PHPMinify(file);

            MessageBox.Show(css.getModifiedData());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.php|*.php";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            String file = openFileDialog1.FileName;

            //openFileDialog1.Filter = "*.png|*.png;*.jpg|*.jpg;*.gif|*.gif;";
            //openFileDialog1.FileName = String.Empty;

            //openFileDialog1.ShowDialog();

            String imgFile = openFileDialog1.FileName;

            HTMLMinify css = new HTMLMinify(file);

            MessageBox.Show(css.getModifiedData());
        }

        private void button27_Click(object sender, EventArgs e)
        {
            managerNFe.discard(1, 1, 1, "TESTE aslkd hsaoidsayu oidsayu oidysaoidysaoidsa");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                setupNFeManager();

                openFileDialog1.Filter = "*.xml|*xml";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DFeRet ret = managerNFe.send(openFileDialog1.FileName);

                    MessageBox.Show(ret.xMotivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                setupNFeManager();

                openFileDialog1.Filter = "*.xml|*xml";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DFeRet ret = managerNFe.sign(openFileDialog1.FileName);

                    MessageBox.Show(ret.xMotivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    CFeManager manager = CFeManager.getInstance();
        //    manager.ActivationCode = "1234567890";
        //    manager.LibraryPath = @"c:\SAT\SAT.dll";

        //    DFeRet ret = manager.connectSubscription("11111111111111", "13.456.988/0001-40", "TiYIrBgJx8JhoXsFOGMIKCXGOpjnvt4VEdyiPU7W8E6CeJKqk8349MX1GdlBd8Za4QnnZqNh+hfF0IGBnpU7L/F9a00iE5+Z4redIi/L3qFqBMMhII8ZhNS7VVLkYVfA8EN0A94+vau+X3GVJL7428TioY8QPvzhfdcgjvc2Qq6GTkSseUi+JFgSIUVFfwcz5jCCyT301adw1hKJEpLzw2GtxcKVV4qEefNyd3d6ruPaq67u8JBT1CMYTlqjq1d6UqhJNODcLFZJpbUwak+yZpNArVlrpBcKoYjtHlrwna8tseBBgR6WVqP2V/AZ48v0oHKJT0CtCRQPmHUq8Yq2JA==");

        //    MessageBox.Show(ret.xMotivo);
        //}

        private void setupNFeManager()
        {
            try
            {
                managerNFe = NFeManager.getInstance();
                managerNFe.OutPut = Application.StartupPath;
                managerNFe.tpAmb = 1;
                managerNFe.tpEmis = 1;
                managerNFe.cUF = 35;
                //managerNFe.Certificate = new Certificate(@"d:\OneDrive\clientes\injel\documentos\cert-injel-s(injel12345).pfx", "injel12345");
                managerNFe.Certificate = new Certificate(textBox2.Text, textBox3.Text);

                //nfeManager = new Manager(null, null);

                ////nfeManager.Enviroment = comboBox1.SelectedIndex + 1;
                //nfeManager.Enviroment = 1;
                ////nfeManager.OutPut = textBox3.Text;

                Issuer issuer = new Issuer();
                //issuer.Logo = @"d:\OneDrive\desenvolvimento\clientes\microexato\documentos\computador-usado.jpg";
                issuer.CNPJ = "07209613000182";
                issuer.Name = "BRUZA PECAS E SERVICOS AUTOMOTIVOS LTDA";
                issuer.Address = "AVENIDA IRENO DA SILVA VENANCIO";
                issuer.Number = "199";
                issuer.District = "PROTESTANTES";
                issuer.City = "VOTORANTIM";
                issuer.StateCode = "35";
                issuer.State = "SP";
                issuer.ZipCode = "18111-100";
                issuer.Phone = "15 2101-7800";

                managerNFe.Issuer = issuer;


                //managerCCe = CCeManager.getInstance();
                managerCCe = new CCeManager("", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                setupNFeManager();

                openFileDialog1.Filter = "*.xml|*xml";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DFeRet ret = managerNFe.createDANFe(openFileDialog1.FileName);

                    MessageBox.Show(ret.xMotivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                setupNFeManager();

                openFileDialog1.Filter = "*.xml|*xml";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DFeRet ret = managerCCe.createDACCe(openFileDialog1.FileName);

                    MessageBox.Show(ret.xMotivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {

            Object ret = ScriptUtilities.eval("(10+10)*((100-0)/100)");
            
            ret = ScriptUtilities.eval("(10.5+10.9)*((100-0)/100)");

            ret = ScriptUtilities.eval("(10.5+10.9)*((100-80)/100)");

            ret = ScriptUtilities.eval("10m/100m");

            MessageBox.Show(ret.ToString());

            //MessageBox.Show(EvalCode().ToString());
        }

        public decimal EvalCode()
        {
            return 80 / 100;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //String chave = "35190703806784000138570010000183101000183109";
            String chave = "20271";
            
            String oldPathOutPut = managerCTe.PathOutPut;

            managerCTe.PathOutPut = @"D:\OneDrive\Desktop\jkg\XMLAv";

            String protocolo = managerCTe.ConsultaAverbacaoCTe(chave);

            managerCTe.PathOutPut = oldPathOutPut;

            MessageBox.Show(protocolo);

        }

        private void button35_Click(object sender, EventArgs e)
        {
            
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //var htmlContent = String.Format("<body>Hello world: {0}</body>", DateTime.Now);

            byte[] codeBar = CodeBarUtilities.Encode("34196166700000123451101234567880057123457000", BarcodeLib.TYPE.Interleaved2of5);

            FileUtilities.ByteArrayToFile(@"D:\OneDrive\Clientes\microexato\projetos\documentos\cobranca\codebar.jpg", codeBar);

            FileResult fileResult = FileUtilities.Read(@"D:\OneDrive\Clientes\microexato\projetos\documentos\cobranca\boleto-itau-template.html");
            
            if(fileResult.Code.Equals("OK")) 
            {
                var htmlContent = fileResult.Content;
            
                var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            
                var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

                fileResult = FileUtilities.ByteArrayToFile(@"D:\OneDrive\Clientes\microexato\projetos\documentos\cobranca\teste.pdf", pdfBytes);

                MessageBox.Show(fileResult.Content);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            CobrancaManager cobrancaManager = CobrancaManager.getInstance();

            TCobrancaHeader header = new TCobrancaHeader();
            //header.Agencia = "5297";
            //header.Conta = "08181";
            //header.DAC = "1";

            TCobranca cobranca = new TCobranca();
            cobranca.header = header;

            TCobrancaDetail detail = new TCobrancaDetail();
            cobranca.detail.Add(detail);

            TCobrancaTrailer trailer = new TCobrancaTrailer();
            cobranca.trailer = trailer;

            CobrancaResult result = cobrancaManager.create(cobranca);

            //result = cobrancaManager.print(cobranca);

            MessageBox.Show(result.Message.ToString());
        }


        private void button37_Click(object sender, EventArgs e)
        {
            //CobrancaManager cobrancaManager = CobrancaManager.getInstance();

            //Cobranca cobranca = new Cobranca();
            //cobranca.Agencia = "0057";
            //cobranca.Conta = "12345";
            //cobranca.DAC = "7";
            //cobranca.CodigoCarteira = "110";

            //CobrancaHeader header = new CobrancaHeader();
            //cobranca.header = header;

            //CobrancaDetail detail = new CobrancaDetail();
            //detail.NossoNumero = "12345678";
            //detail.Vencimento = "01/05/2002";
            //detail.ValorTitulo = "123,45";
            //cobranca.detail.Add(detail);

            //CobrancaTrailer trailer = new CobrancaTrailer();
            //cobranca.trailer = trailer;

            //CobrancaResult result = cobrancaManager.createCodigoBarras(cobranca);

            //MessageBox.Show(result.Message);

        }

        private void button38_Click(object sender, EventArgs e)
        {
            //FileResult fileResult = FileUtilities.Zip(@"D:\OneDrive\Desktop\teste.zip", @"D:\OneDrive\Desktop\Proposta_Alutal_WO31859_Seconci.pdf");

            //MessageBox.Show(fileResult.Content);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            List<String> arquivos = new List<String>();
            arquivos.Add(@"D:\OneDrive\Desktop\NT2019_001_v1_30 - Regras de Validação.pdf");
            arquivos.Add(@"D:\OneDrive\Desktop\preview.pdf");
            arquivos.Add(@"D:\OneDrive\Desktop\Proposta_Alutal_WO31859_Seconci (1).pdf");
            arquivos.Add(@"D:\OneDrive\Desktop\Proposta_Alutal_WO31859_Seconci.pdf");
            arquivos.Add(@"D:\OneDrive\Desktop\Proposta_Alutal_WO31848_CeramicaPontal.pdf");

            FileResult fileResult = FileUtilities.Zip(@"D:\OneDrive\Desktop\arquivos.zip", arquivos);

            MessageBox.Show(fileResult.Content);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            estoqueMovimentoRequest estoqueMovimentoRequest = new estoqueMovimentoRequest();
            
            OmieManager.GetInstance().GetConsultaEstoque().GetSoapClient().MovimentoEstoque(estoqueMovimentoRequest);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            String date1 = "08/15/2020";
            DateTime? d1 = DateUtilities.parse(date1);
            
            Object date2 = "08/15/2020";
            DateTime? d2 = DateUtilities.parse(date2);

            Object date3 = "15/08/2020";
            DateTime? d3 = DateUtilities.parse(date3);

            Object date4 = "08/15/2020";
            DateTime? d4 = DateUtilities.parse(date4, "MM/dd/yyyy");
        }
    }
}
