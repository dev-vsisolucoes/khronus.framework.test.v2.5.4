using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Text;
using MessagingToolkit.QRCode;
using com.sotisolutions.khronus.dal;
using Khronus.Framework.Test;
using MessagingToolkit.QRCode.Codec;
using com.sotisolutions.khronus.smtp;
using Khronus.Framework.Util;

namespace Test
{
    public partial class frmMain2 : Form
    {
        //Font printFont;
        StreamReader streamToPrint;

        public frmMain2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmNFe().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal value = 10M;

            MessageBox.Show(NumberUtilities.format(value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(StringUtilities.center("Projis Sistemas de Informação Ltda", 45));
                sb.AppendLine(StringUtilities.center("CNPJ.: 00.445.335/0001-13 - IE.: 253037107", 45));
                sb.AppendLine("");
                sb.AppendLine(StringUtilities.center("DANFE NFCe - Documento Auxiliar", 45));
                sb.AppendLine(StringUtilities.center("da Nota Fiscal Eletrônica de Consumidor Final", 45));
                sb.AppendLine(StringUtilities.center("Não permite o aproveitamento de crédito do ICMS", 45));
                sb.AppendLine("");
                sb.AppendLine(StringUtilities.repeat('-', 45));
                sb.AppendLine(
                        StringUtilities.left("Código    ", 10) + " " +
                        StringUtilities.left("Descrição ", 10) + " " +
                        StringUtilities.left("Qtd.      ", 10) + " " +
                        StringUtilities.left("Und.      ", 10) + " " +
                        StringUtilities.left("Vlr.Unit. ", 10) + " " +
                        StringUtilities.left("Desc.     ", 10) + " " +
                        StringUtilities.left("Vlr.Total ", 10)
                    );
                sb.AppendLine(StringUtilities.repeat('-', 45));
 
                sb.AppendLine(
                        StringUtilities.left("1         ", 10) + " " +
                        StringUtilities.left("PRODUTO TESTE 1", 10) + " " +
                        StringUtilities.right(StringUtilities.repeat('\0', 20) + "1,00", 10) + " " +
                        StringUtilities.left("UND", 10) + " " +
                        StringUtilities.right(StringUtilities.repeat('\0', 20) + "1,00", 10) + " " +
                        StringUtilities.right(StringUtilities.repeat('\0', 20) + "1,00", 10)
                    );

                sb.AppendLine(StringUtilities.repeat('-', 45));
                sb.AppendLine(StringUtilities.left("Qtd. Total de Itens" + StringUtilities.repeat('\0', 35), 35) + StringUtilities.right("2", 10) );
                sb.AppendLine(StringUtilities.left("Valor Total de Venda R$" + StringUtilities.repeat('\0', 35), 35) + StringUtilities.right("20,00", 10));
                
                sb.AppendLine(StringUtilities.left("Dinheiro " + StringUtilities.repeat('\0', 35), 35) + StringUtilities.right("20,00", 10));
                
                sb.AppendLine(StringUtilities.repeat('-', 45));
                sb.AppendLine(StringUtilities.left("Vlr. Aprox. Tributos R$0,00(0,00%) Fonte: IBPT" + StringUtilities.repeat('\0', 45), 45));
                sb.AppendLine(StringUtilities.repeat('-', 45));

                sb.AppendLine(StringUtilities.center("EMITIDA EM AMBIENTE DE HOMOLOGAÇÃO - SEM VALOR FISCAL", 45));
                sb.AppendLine(StringUtilities.center("Número: 000.015.007 - Série 1", 45));
                sb.AppendLine(StringUtilities.center("Emissão: 14/04/2014 15:12:52 - Via Consumidor", 45));
                sb.AppendLine(StringUtilities.center("Consulte pela Chave de Acesso em:", 45));
                sb.AppendLine(StringUtilities.center("https://www.homologacao.nfce.fazenda.sp.gov.br/...", 45));
                sb.AppendLine(StringUtilities.center("CHAVE DE ACESSO", 45));
                sb.AppendLine(StringUtilities.center("35160207209613000182650010000000191000000190", 45));
                sb.AppendLine(StringUtilities.center("CONSUMIDOR NÃO IDENTIFICADO", 45));

                sb.AppendLine("");

                sb.AppendLine(StringUtilities.center("Consulta via leitor de QR Code", 45));
                //sb.AppendLine("");
                //sb.AppendLine("");
                sb.AppendLine("QRCODE");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine(StringUtilities.center("Protocolo de Autorização: 135160000019175 20/02/2016 10:36:09", 45));
                sb.AppendLine(StringUtilities.center("Emitido por....", 45));

                streamToPrint = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString())));
                
                try
                {
                    PrintDocument pd = new PrintDocument();

                    //pd.PrinterSettings.PrinterName = "Mecaf Perfecta_A";
                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage1);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pd_PrintPage1(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 8;
            int count = 0;
            float leftMargin = 3; // ev.MarginBounds.Left;
            float topMargin = 5; // ev.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Courier New", 7);

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            Bitmap logo = (Bitmap)Image.FromFile(@"C:\prosis\img\logo-refriauto.png");
            
            ev.Graphics.DrawImage(logo, 100, yPos, 70, 25);

            count = 5;

            //// Print each line of the file.
            ////while (/*count < linesPerPage &&*/ 
            //while (((line = streamToPrint.ReadLine()) != null))
            //{
            //    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));

            //    if (line.StartsWith("QRCODE"))
            //    {
            //        var bw = new ZXing.BarcodeWriter();
            //        var encOptions = new ZXing.Common.EncodingOptions() { Width = 200, Height = 200, Margin = 0 };
            //        bw.Options = encOptions;
            //        bw.Format = ZXing.BarcodeFormat.QR_CODE;
            //        Bitmap imageQrCode = new Bitmap(bw.Write("https://www.homologacao.nfce.fazenda.sp.gov.br/NFCeConsultaPublica/Paginas/ConsultaQRCode.aspx?chNFe=35160207209613000182650010000000191000000190&nVersao=100&tpAmb=2&dhEmi=323031362d30322d32305431303a33353a35302d30323a3030&vNF=100.00&vICMS=0.00&digVal=55586c7938373833637672394551445570353332776d76336c58303d&cIdToken=000003&cHashQRCode=eebc9c3b9009688a8f668ec5deafd769af7d643b"));

            //        ev.Graphics.DrawImage(imageQrCode, 100, yPos, 150, 150);
            //    }
            //    else
            //    {
            //        ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            //    }

            //    count++;
            //}
            ////count++;

            ////yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));

            ////ev.Graphics.DrawImage(imageQrCode, 10, yPos, 150, 150);

            //// If more lines exist, print another page.
            ///*
            //if (line != null)
            //    ev.HasMorePages = true;
            //else
            //    ev.HasMorePages = false;
            //*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int cols = 48;

                StringBuilder sb = new StringBuilder();
                
                //sb.AppendLine("");
                //sb.AppendLine("{LOGO}");
                sb.AppendLine("{N,8,C}" + "Projis");
                sb.AppendLine("{N,8,C}" + "Projis Sistemas de Informação Ltda");
                sb.AppendLine("{N,8,C}" + "RUA JOSEFA RUBIO BASTIDA, 391");
                sb.AppendLine("{N,8,C}" + "PARQUE VITORIA REGIA SOROCABA-SP CEP 18078-467");
                sb.AppendLine("{N,8,C}" + "CNPJ.: 00.445.335/0001-13 IE.: 253037107");
                sb.AppendLine("{N,8,C}" + StringUtilities.repeat('-', cols));
                sb.AppendLine("{B,8,C}" + "Extrato No. 71038");
                sb.AppendLine("{B,8,C}" + "CUPOM FISCAL ELETRONICO - SAT");
                sb.AppendLine("{N,8,C}" + StringUtilities.repeat('-', cols));
                sb.AppendLine("{N,8,L}" + "CPF./CNPJ. DO CONSUMIDOR: 177.342.228-62");
                sb.AppendLine("{N,8,C}" + StringUtilities.repeat('-', cols));
                sb.AppendLine("{N,8,L}" + "# |COD|DESC|QTD|UN|VL UN R$|(VL TR R$)*|VL IT R$");
                sb.AppendLine("{N,8,C}" + StringUtilities.repeat('-', cols));

                sb.AppendLine("{N,8,L}" + StringUtilities.left("1  13685 SALG DORITOS 167G NACHO" + StringUtilities.repeat(' ', cols), cols));
                sb.AppendLine("{N,8,L}" + StringUtilities.right(StringUtilities.repeat(' ', cols) + "1 UN X 1549,54 (01,21)" + StringUtilities.right(StringUtilities.repeat(' ', 10) + "1549,54", 10), cols));

                sb.AppendLine("{N,8,L}" + StringUtilities.left("2  13685 SALG DORITOS 167G NACHO" + StringUtilities.repeat(' ', cols), cols));
                sb.AppendLine("{N,8,L}" + StringUtilities.right(StringUtilities.repeat(' ', cols) + "10 UN X 549,54 (1,21)" + StringUtilities.right(StringUtilities.repeat(' ', 10) + "1549,54", 10), cols));

                sb.AppendLine("{N,8,L}" + StringUtilities.left("3  13685 SALG DORITOS 167G NACHO" + StringUtilities.repeat(' ', cols), cols));
                sb.AppendLine("{N,8,L}" + StringUtilities.right(StringUtilities.repeat(' ', cols) + "99 UN X 15,54 (10,21)" + StringUtilities.right(StringUtilities.repeat(' ', 10) + "1549,54", 10), cols));

                sb.AppendLine("{N,8,C}" + StringUtilities.repeat('-', cols));
                sb.AppendLine("{B,8,L}" + "TOTAL R$" + StringUtilities.repeat(' ', cols - 18) + StringUtilities.right(StringUtilities.repeat(' ', 10) + "1549,54", 10));
                //sb.AppendLine("{N,7,L}" + "Cartao de Credito" + StringUtilities.repeat(' ', cols - 27) + StringUtilities.right(StringUtilities.repeat(' ', 10) + "1549,54", 10));
                sb.AppendLine("{N,7,L}" + "Cartao de Credito" + StringUtilities.repeat(' ', cols - 20) + StringUtilities.right(StringUtilities.repeat(' ', 10) + "1534249,54", 10));
                sb.AppendLine("{N,6,L}" + "Consulte o QRCode deste extrato atraves do App DeOlhoNaNota");

                sb.AppendLine("{N,8,C}" + StringUtilities.repeat('-', cols));
                sb.AppendLine("{N,8,L}" + "OBSERVAÇÕES DO CONTRIBUINTE");
                sb.AppendLine("{N,7,L}" + "Trib aprox R$ 7,68 Fed, 11,86 Est, 0,00 Mun");
                sb.AppendLine("{N,7,L}" + "Fonte: IBPT/empresometro M2L5P8");
                sb.AppendLine("{N,7,L}" + "FUNC: MARCOS ANTONIO OLIVEIRA TN:2 PDV:2 ATEND:8");
                sb.AppendLine("{N,7,L}" + "*Valor aproximado dos tributos do item");

                sb.AppendLine("{N,8,C}" + StringUtilities.repeat('-', cols));
                sb.AppendLine("{B,8,C}" + "SAT No. 000170921");
                sb.AppendLine("{N,8,C}" + "20/09/2017 - 14:09:06");

                sb.AppendLine("");
                sb.AppendLine("{B,6,C}" + "3517 0910 2926 2600 0172 5900 0170 9212 2475 4888 0575");
                sb.AppendLine("{128CODE}");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("{QRCODE}");

                streamToPrint = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString())));

                try
                {
                    //printFont = new Font("Courier New", 7);
                    
                    //
                    //printFont = new Font("M+ 1m light", 7);
                    //
                    //printFont = new Font(FontFamily., 6, FontStyle.Regular);

                    ////String fontPath = @"C:\Users\Valter Batista\Downloads\M-1m\mplus-1m-light.ttf";
                    //String fontPath = @"C:\Users\Valter Batista\Downloads\Inconsolata-Regular.ttf";
                    
                    //PrivateFontCollection pfc = new PrivateFontCollection();
                    //pfc.AddFontFile(fontPath);

                    ////Carregar a fonte
                    //FontFamily fontFamily = new FontFamily(pfc.Families.First().Name, pfc);
                    
                    //printFont = new Font(fontFamily.Name, 7);


                    //float dpi = 128; // Dots Per Inch

                    PrintDocument pd = new PrintDocument();
                    //pd.SetResolution(dpi, dpi);
                    
                    //pd.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
                    //pd.PrinterSettings.PrinterName = "Foxit Reader PDF Printer";
                    pd.PrinterSettings.PrinterName = "ELGIN i9(USB)";
                    //pd.PrinterSettings.PrinterResolutions
                    //pd.DefaultPageSettings.PrinterResolution.X = 100;
                    //pd.DefaultPageSettings.PrinterResolution.Y = 100;
                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage2);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pd_PrintPage2(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            int yPos = 0;
            int count = 1;
            int leftMargin = 3; // ev.MarginBounds.Left;
            int topMargin = 3; // ev.MarginBounds.Top;
            string line = null;

            //Font printFont = new Font("Lucida Console", 7);
            //printFont = new Font("Letter Gothic Std", 7);
            //Font printFont = new Font("MS Gothic", 8);
            Font printFont = new Font("MS Gothic", 8);

            // Calculate the number of lines per page.
            //linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            
            //Impressao do logo
            //

            //

            //count = 5;

            //yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));

            // Print each line of the file.
            while (((line = streamToPrint.ReadLine()) != null))
            {
                //yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));

                //RectangleF rect = new RectangleF(leftMargin, yPos, 280f, 100f);

                if (line.StartsWith("{LOGO}"))
                {
                    //Bitmap logo = (Bitmap)Image.FromFile(@"C:\prosis\img\logo-refriauto.png");

                    //ev.Graphics.DrawImage(logo, leftMargin+5, yPos+11, 50, 25);
                }
                else if (line.StartsWith("{128CODE}"))
                {
                    BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();

                    Bitmap bitmap = (Bitmap)barcode.Encode(BarcodeLib.TYPE.CODE128, "35170910292626000172590001709212247548880575", Color.Black, Color.White, 280, 30);

                    ev.Graphics.DrawImage(bitmap, new Rectangle(leftMargin, yPos, 280, 30));
                }
                else if (line.StartsWith("{QRCODE}"))
                {
                    //var bw = new ZXing.BarcodeWriter();
                    //var encOptions = new ZXing.Common.EncodingOptions() { Width = 150, Height = 150, Margin = 0 };
                    //bw.Options = encOptions;
                    //bw.Format = ZXing.BarcodeFormat.QR_CODE;
                    //Bitmap imageQrCode = new Bitmap(bw.Write("https://www.homologacao.nfce.fazenda.sp.gov.br/NFCeConsultaPublica/Paginas/ConsultaQRCode.aspx?chNFe=35160207209613000182650010000000191000000190&nVersao=100&tpAmb=2&dhEmi=323031362d30322d32305431303a33353a35302d30323a3030&vNF=100.00&vICMS=0.00&digVal=55586c7938373833637672394551445570353332776d76336c58303d&cIdToken=000003&cHashQRCode=eebc9c3b9009688a8f668ec5deafd769af7d643b"));

                    //ev.Graphics.DrawImage(imageQrCode, new Rectangle(70, yPos, 150, 150));

                    QRCodeEncoder qrCodecEncoder = new QRCodeEncoder();
                    qrCodecEncoder.QRCodeBackgroundColor = System.Drawing.Color.White;
                    qrCodecEncoder.QRCodeForegroundColor = System.Drawing.Color.Black;
                    //qrCodecEncoder.CharacterSet = "UTF-8";
                    qrCodecEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    qrCodecEncoder.QRCodeScale = 6;
                    qrCodecEncoder.QRCodeVersion = 0;
                    qrCodecEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                    
                    Image imageQRCode;
                    //string a ser gerada
                    String dados = "35170910292626000172590001709212247548880575";
                    imageQRCode = qrCodecEncoder.Encode(dados);
                    //picQrCode.Image = imageQRCode;
                    //ev.Graphics.DrawImage(imageQRCode, new Rectangle(leftMargin, yPos, (int)convertCmToPoint(0.5), (int)convertCmToPoint(0.5)));
                    ev.Graphics.DrawImage(imageQRCode, new Rectangle(leftMargin + 80, yPos, 100, 100));
                }
                else
                {
                    //String s0 = StringUtilities.subString(line, 0, 4).Replace("{", "").Replace("}", "");

                    //String n = s0

                    //String s1 = StringUtilities.subString(line, 4);
                    //if (line.StartsWith("{B8}"))
                    //{
                    //    printFont = new Font("MS Gothic", 8, FontStyle.Bold);
                    //}
                    //else
                    //{
                    //   printFont = new Font("MS Gothic", 8, FontStyle.Regular);
                    //}

                    //line = line.Replace("{B}", "");


                    StringFormat format = new StringFormat();

                    if (line.StartsWith("{"))
                    {
                        int pos = line.IndexOf("}");

                        String ini0 = line.Substring(0, pos+1);

                        String ini1 = ini0.Replace("{", "").Replace("}", "");
                        
                        String[] ini2 = ini1.Split(',');

                        String style = ini2[0];
                        int size = NumberUtilities.parseInt(ini2[1]);
                        String align = ini2[2];

                        if (style.Equals("B"))
                        {
                            printFont = new Font("MS Gothic", size, FontStyle.Bold);
                        }
                        else
                        {
                            printFont = new Font("MS Gothic", size, FontStyle.Regular);
                        }

                        StringAlignment a;

                        if (align.Equals("C"))
                        {
                            a = StringAlignment.Center;
                        }
                        else if (align.Equals("L"))
                        {
                            a = StringAlignment.Near;
                        }
                        else
                        {
                            a = StringAlignment.Far;
                        }

                        format.LineAlignment= a;
                        format.Alignment = a;


                        line = line.Replace(ini0, "");

                        //yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));

                        Rectangle rect = new Rectangle(leftMargin, yPos, 280, 12);

                        //ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                        ev.Graphics.DrawString(line, printFont, Brushes.Black, rect, format);
                    }
                    else
                    {
                        //yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));

                        Rectangle rect = new Rectangle(leftMargin, yPos, 280, 12);

                        //ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                        ev.Graphics.DrawString(line, printFont, Brushes.Black, rect, new StringFormat());
                    }
                    
                    //ev.Graphics.DrawString(
                    //    line,
                    //    printFont,
                    //    Brushes.Black,
                    //    rect,
                    //    new StringFormat());
                }

                count++;

                //yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                //yPos = rect.Height + (count * printFont.GetHeight(ev.Graphics));

                yPos += 12; // (int)printFont.GetHeight(ev.Graphics);
            }
            
            //count++;

            //yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));


            //ev.Graphics.DrawString(
            //    "# | COD | DESC | QTD | UN | VL UN R$ | (VL TR R$)*| VL ITEM R$", 
            //    printFont, 
            //    Brushes.Black, 
            //    new RectangleF(leftMargin, yPos, 200f, 100f),
            //    new StringFormat());


            // If more lines exist, print another page.
            /*
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
            */
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Set the paper size based upon the selection in the combo box.
            //if (comboPaperSize.SelectedIndex != -1)
            //{
            //    printDoc.DefaultPageSettings.PaperSize =
            //        printDoc.PrinterSettings.PaperSizes[comboPaperSize.SelectedIndex];
            //}

            //// Set the paper source based upon the selection in the combo box.
            //if (comboPaperSource.SelectedIndex != -1)
            //{
            //    printDoc.DefaultPageSettings.PaperSource =
            //        printDoc.PrinterSettings.PaperSources[comboPaperSource.SelectedIndex];
            //}

            //// Set the printer resolution based upon the selection in the combo box.
            //if (comboPrintResolution.SelectedIndex != -1)
            //{
            //    printDoc.DefaultPageSettings.PrinterResolution =
            //        printDoc.PrinterSettings.PrinterResolutions[comboPrintResolution.SelectedIndex];
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.To = "valter.batista@sotisolutions.com";
            mail.From = "adm@endocompany.com.br";
            mail.Subject = "teste";
            mail.Body = "teste de envio de email sobre a SSL";

            //KhronusReturn ret = MailUtilities.send("email-ssl.com.br", "adm@endocompany.com.br", "k070213r", 587, true, mail); //funciona
            KhronusReturn ret = MailUtilities.send("email-ssl.com.br", "adm@endocompany.com.br", "k070213r", 587, false, mail); 

            MessageBox.Show(ret.Message);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.From = txtDe.Text;
            mail.To = txtPara.Text;
            //mail.Bcc = "valter.batista@sotisolutions.com"; 
            mail.Subject = txtAssunto.Text;
            mail.Body = txtCorpo.Text;

            //mail.AttachmentList.Add(@"D:\desenvolvimento_old\analise de sistemas\nfe\documentacao\NT_2016_002_v1.51.pdf");

            //KhronusReturn ret = MailUtilities.send("smtp.gmail.com", "valtersotisolutions@gmail.com", "fev@030277@", 587, true, mail);
            KhronusReturn ret = MailUtilities.send(txtSmtp.Text, txtUsuario.Text, txtSenha.Text, NumberUtilities.parseInt(txtPorta.Text), chkSsl.Checked, mail);

            MessageBox.Show(ret.Status + " " + ret.Message);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataAccessLayerManager dao = DataAccessLayerManager.getInstance();
            dao.ConnectionString = "server=mysql06-farm56.kinghost.net;port=3306;database=sotisolutions01;uid=sotisolutions01;pwd=fev030277";
            dao.ConnectionProvider = DataAccessLayerManager.ConnectionProviders.MYSQL;
            dao.ConnectionOutput = Application.StartupPath + "\\sql.log";

            DataTable dataTable = dao.GetListBySelect("SELECT * FROM baaj");

            dataGridView1.DataSource = dataTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataAccessLayerManager dao = DataAccessLayerManager.getInstance();
            dao.ConnectionString = "server=mysql06-farm56.kinghost.net;port=3306;database=sotisolutions01;uid=sotisolutions01;pwd=sotisolutions01";
            dao.ConnectionProvider = DataAccessLayerManager.ConnectionProviders.MYSQL;
            dao.ConnectionOutput = Application.StartupPath + "\\sql.log";

            //ParceiroBO parceiroBO = dao.find<ParceiroBO>(new Object[,] {
            //    {"BAAJ_COD_FILIAL", 14 }, {"BAAJ_PADRAO", true}
            //});
            ParceiroBO parceiroBO = dao.Find<ParceiroBO>(new Object[,] {
                {"BAAJ_EMAIL", "nfe@alutal.com.br"}
            });

            MessageBox.Show(String.Format("Nome={0}\nCNPJ\\CPF={1}", parceiroBO.BAAJ_NOME_FANT, parceiroBO.BAAJ_CNPJ_CPF_ID));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataAccessLayerManager dao = DataAccessLayerManager.getInstance();
            dao.ConnectionString = "server=mysql06-farm56.kinghost.net;port=3306;database=sotisolutions01;uid=sotisolutions01;pwd=sotisolutions01";
            dao.ConnectionProvider = DataAccessLayerManager.ConnectionProviders.MYSQL;
            dao.ConnectionOutput = Application.StartupPath + "\\sql.log";

            ParceiroBO parceiroBO = dao.Find<ParceiroBO>(new Object[] {14, 1 });

            MessageBox.Show(String.Format("Nome={0}\nCNPJ\\CPF={1}", parceiroBO.BAAJ_NOME_FANT, parceiroBO.BAAJ_CNPJ_CPF_ID));
        }

        private double convertPointToCm(double pnt){
            return pnt * 0.03527778;
        }

        private double convertCmToPoint(double cm){
            return cm * 28.34646;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
