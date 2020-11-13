using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using com.sotisolutions.khronus.dfe.nfe;
using com.sotisolutions.khronus.dfe;
using com.sotisolutions.khronus.dfe.nfe.model;
using com.sotisolutions.khronus.cert;
using System.Data.SqlClient;

namespace Test
{
    public partial class frmNFe : Form
    {
        private NFeManager nfeManager;
        //private SqlConnection connection;

        public frmNFe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connection = new SqlConnection(@"Data Source=SERVER-GAT;Initial Catalog=GAT;Persist Security Info=True;User ID=sa;Password=gat@2016@;Connect Timeout=120;Max Pool Size=1000;Pooling=True");
            //connection.Open();

            //textBox1.Text = Khronus.Framework.Test.Properties.Settings.Default.CERTIFICADO;
            //textBox2.Text = Khronus.Framework.Test.Properties.Settings.Default.SENHA;
            //comboBox1.SelectedIndex = NumberUtilities.parseInt(Khronus.Framework.Test.Properties.Settings.Default.AMBIENTE) - 1;
            //textBox3.Text = Khronus.Framework.Test.Properties.Settings.Default.GERAR_EM;

            init();
        }

        private void init()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione a NFe";
            openFileDialog1.Filter = "*.xml|*.xml";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //nfeManager.PathOutPut = "c:\\temp";

                DFeRet ret = nfeManager.createDANFe(openFileDialog1.FileName, DFeCommon.PrintDestination.TO_WINDOW);

                MessageBox.Show(ret.xMotivo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Title = "Selecione logotipo";
            //openFileDialog1.Filter = "*.png|*.png|*.jpg|*.jpg|*.gif|*.gif";
            //openFileDialog1.FileName = String.Empty;

            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    //nfeManager.Logo = openFileDialog1.FileName;
            //}

            //openFileDialog1.Title = "Selecione a CCe";
            //openFileDialog1.Filter = "*.xml|*.xml";

            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    DFeRet ret = nfeManager.CreateDACCe(openFileDialog1.FileName);

            //    MessageBox.Show(ret.xMotivo);
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DFeRet ret = nfeManager.correct("35170703697421000292550020000001051000001050", "teste de carta de correcao", 1);

            MessageBox.Show(ret.xMotivo);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Title = "Selecione a NFe";
            //openFileDialog1.Filter = "*.xml|*.xml";

            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    //DFeRet ret = nfeManager.ReQueryNFe("35140671602569000175550010000045781000045781");
            //    DFeRet ret = nfeManager.reQueryNFe(openFileDialog1.FileName);

            //    MessageBox.Show(ret.cStat + " " + ret.xMotivo);
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DFeRet ret = nfeManager.discard(11632, 11632, 1, "Falha da numeracao no sistema");

            MessageBox.Show(ret.xMotivo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM VEAU WHERE VEAU_CODIGO=@VEAU_CODIGO", connection);

            //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_CHNFE", textBox4.Text));

            //command.ExecuteNonQuery();

            DFeRet ret = nfeManager.cancel("35180403697421000292550020000001101000001107", "135180281577495", "No emitida de forma errada");

            MessageBox.Show(ret.xMotivo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("FriendlyName={0}\nSubject={1}\nVersion={2}\nExpirationDate={3}",
                nfeManager.Certificate.FriendlyName,
                nfeManager.Certificate.Subject,
                nfeManager.Certificate.Version,
                nfeManager.Certificate.ExpirationDate));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Title = "Selecione a NFe";
            //openFileDialog1.Filter = "*.xml|*.xml";

            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    nfeManager.PathOutPut = "c:\\temp";

            //    DFeRet ret = nfeManager.CreateDANFe(openFileDialog1.FileName, PrintDestination.TO_FILE, true);

            //    MessageBox.Show(ret.xMotivo);
            //}
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //new com.sotisolutions.khronus.Test().test();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            init();

            openFileDialog1.Title = "Selecione a NFe";
            openFileDialog1.Filter = "*.xml|*.xml";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DFeRet ret = nfeManager.send(openFileDialog1.FileName);

                //SqlCommand command = new SqlCommand("UPDATE VEAU SET " +
                //    "VEAU_PROTNFE_INFPROT_TPAMB=@VEAU_PROTNFE_INFPROT_TPAMB, " +
                //    "VEAU_PROTNFE_INFPROT_VERAPLIC=@VEAU_PROTNFE_INFPROT_VERAPLIC, " +
                //    "VEAU_PROTNFE_INFPROT_DHRECBTO=@VEAU_PROTNFE_INFPROT_DHRECBTO, " +
                //    "VEAU_PROTNFE_INFPROT_NPROT=@VEAU_PROTNFE_INFPROT_NPROT, " +
                //    "VEAU_PROTNFE_INFPROT_DIGVAL=@VEAU_PROTNFE_INFPROT_DIGVAL, " +
                //    "VEAU_PROTNFE_INFPROT_CSTAT=@VEAU_PROTNFE_INFPROT_CSTAT, " +
                //    "VEAU_PROTNFE_INFPROT_XMOTIVO=@VEAU_PROTNFE_INFPROT_XMOTIVO, " +
                //    "VEAU_STATUS=@VEAU_STATUS " +
                //    "WHERE VEAU_PROTNFE_INFPROT_CHNFE=@VEAU_PROTNFE_INFPROT_CHNFE"
                //    , connection);

                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_TPAMB", ret.tpAmb));
                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_VERAPLIC", ret.verAplic));
                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_DHRECBTO", ret.dhRecbto));
                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_NPROT", ret.nProt));
                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_DIGVAL", ret.digVal));
                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_CSTAT", ret.cStat));
                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_XMOTIVO", ret.xMotivo));
                //command.Parameters.Add(new SqlParameter("VEAU_STATUS", ret.cStat.Equals("100") ? "FI" : "PR"));
                //command.Parameters.Add(new SqlParameter("VEAU_PROTNFE_INFPROT_CHNFE", ret.chNFe));

                //command.ExecuteNonQuery();

                MessageBox.Show(ret.xMotivo);

                saveProperties();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione o certificado";
            openFileDialog1.Filter = "*.*|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //nfeManager.Certificate = new Certificate(openFileDialog1.FileName, "123456");
                //nfeManager.Certificate = new Certificate(@"D:\Meus Arquivos\Projetos\khronus-framework\v2.0.1\cert\CERT.pfx", "TSR2018");
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void frmNFe_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveProperties();

            //connection.Close();
        }

        private void saveProperties()
        {
            //Khronus.Framework.Test.Properties.Settings.Default.CERTIFICADO = textBox1.Text;
            //Khronus.Framework.Test.Properties.Settings.Default.SENHA = textBox2.Text;
            //Khronus.Framework.Test.Properties.Settings.Default.AMBIENTE = StringUtilities.toString(comboBox1.SelectedIndex+1);
            //Khronus.Framework.Test.Properties.Settings.Default.GERAR_EM = textBox3.Text;

            //Khronus.Framework.Test.Properties.Settings.Default.Save();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            init();

            saveProperties();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            nfeManager.OutPut = Application.StartupPath;

            openFileDialog1.Filter = "*.txt|*txt";
            openFileDialog1.FileName = String.Empty;

            openFileDialog1.ShowDialog();

            DFeRet ret = nfeManager.create(openFileDialog1.FileName);

            MessageBox.Show(ret.xMotivo);
        }
    }
}
