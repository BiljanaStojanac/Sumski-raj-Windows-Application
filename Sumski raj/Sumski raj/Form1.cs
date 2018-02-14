using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
using static System.Net.Mime.MediaTypeNames;



namespace Sumski_raj
{
    public partial class Form1 : Form
    {
       

        public object DataTime { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtEspresso.Text = "0";
            txtCappuccino.Text = "0";
            txtKiselaVoda.Text = "0";
            txtRosaVoda.Text = "0";
            txtCocaCola.Text = "0";
            txtPivo.Text = "0";
            txtFanta.Text = "0";
            txtNext.Text = "0";
            txtPileciBatak.Text = "0";
            txtPaste.Text = "0";
            txtMesano.Text = "0";
            txtTikvice.Text = "0";
            txtPljeskavica.Text = "0";
            txtPiletina.Text = "0";
            txtBiftek.Text = "0";
            txtFile.Text = "0";
            txtQueen.Text = "0";
            txtNocciola.Text = "0";
            txtCappuccinoCake.Text = "0";
            txtSweet.Text = "0";
            txtNugat.Text = "0";
            txtMama.Text = "0";
            txtCrispy.Text = "0";
            txtMoscow.Text = "0";
            lblCostCake.Text = "0";
            lblCostDrink.Text = "0";
            lblCostFood.Text = "0";
            txtEspresso.Enabled= false;
            txtCappuccino.Enabled = false;
            txtKiselaVoda.Enabled = false;
            txtRosaVoda.Enabled = false;
            txtCocaCola.Enabled = false;
            txtPivo.Enabled = false;
            txtFanta.Enabled = false;
            txtNext.Enabled = false;
            txtPileciBatak.Enabled = false;
            txtPaste.Enabled = false;
            txtMesano.Enabled = false;
            txtTikvice.Enabled = false;
            txtPljeskavica.Enabled = false;
            txtPiletina.Enabled = false;
            txtBiftek.Enabled = false;
            txtFile.Enabled = false;
            txtQueen.Enabled = false;
            txtNocciola.Enabled = false;
            txtCappuccinoCake.Enabled = false;
            txtSweet.Enabled = false;
            txtNugat.Enabled = false;
            txtMama.Enabled = false;
            txtCrispy.Enabled = false;
            txtMoscow.Enabled = false;

            chkEspresso.Checked = false;
            chkCappuccino.Checked = false;
            chkKiselaVoda.Checked = false;
            chkRosaVoda.Checked = false;
            chkCocaCola.Checked = false;
            chkPivo.Checked = false;
            chkFanta.Checked = false;
            chkNext.Checked = false;
            chkPileciBatak.Checked = false;
            chkPaste.Checked = false;
            chkMesanoMeso.Checked = false;
            chkPunjeneTikvice.Checked = false;
            chkGurmanskaPljeskavica.Checked = false;
            chkPiletinaSaPrelivom.Checked = false;
            chkBiftekNaGrilu.Checked = false;
            chkSvinjskiFile.Checked = false;
            chkQueenChocolate.Checked = false;
            chkNocciola.Checked = false;
            chkCappuccinoCake.Checked = false;
            chkSweetForest.Checked = false;
            chkNugat.Checked = false;
            chkMamaMia.Checked = false;
            chkCrispyCake.Checked = false;
            chkMoscow.Checked = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "0";
            txtCappuccino.Text = "0";
            txtKiselaVoda.Text = "0";
            txtRosaVoda.Text = "0";
            txtCocaCola.Text = "0";
            txtPivo.Text = "0";
            txtFanta.Text = "0";
            txtNext.Text = "0";
            txtPileciBatak.Text = "0";
            txtPaste.Text = "0";
            txtMesano.Text = "0";
            txtTikvice.Text = "0";
            txtPljeskavica.Text = "0";
            txtPiletina.Text = "0";
            txtBiftek.Text = "0";
            txtFile.Text = "0";
            txtQueen.Text = "0";
            txtNocciola.Text = "0";
            txtCappuccinoCake.Text = "0";
            txtSweet.Text = "0";
            txtNugat.Text = "0";
            txtMama.Text = "0";
            txtCrispy.Text = "0";
            txtMoscow.Text = "0";
            lblCostCake.Text = "0";
            lblCostDrink.Text = "0";
            lblCostFood.Text = "0";
            lblTotal.Text = "0";

            chkEspresso.Checked = false;
            chkCappuccino.Checked = false;
            chkKiselaVoda.Checked = false;
            chkRosaVoda.Checked = false;
            chkCocaCola.Checked = false;
            chkPivo.Checked = false;
            chkFanta.Checked = false;
            chkNext.Checked = false;
            chkPileciBatak.Checked = false;
            chkPaste.Checked = false;
            chkMesanoMeso.Checked = false;
            chkPunjeneTikvice.Checked = false;
            chkGurmanskaPljeskavica.Checked = false;
            chkPiletinaSaPrelivom.Checked = false;
            chkBiftekNaGrilu.Checked = false;
            chkSvinjskiFile.Checked = false;
            chkQueenChocolate.Checked = false;
            chkNocciola.Checked = false;
            chkCappuccinoCake.Checked = false;
            chkSweetForest.Checked = false;
            chkNugat.Checked = false;
            chkMamaMia.Checked = false;
            chkCrispyCake.Checked = false;
            chkMoscow.Checked = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCostCake_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
            }
            if (chkEspresso.Checked == false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccino.Enabled = true;
            }
            if (chkCappuccino.Checked == false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void chkKiselaVoda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiselaVoda.Checked == true)
            {
                txtKiselaVoda.Enabled = true;
            }
            if (chkKiselaVoda.Checked == false)
            {
                txtKiselaVoda.Enabled = false;
                txtKiselaVoda.Text = "0";
            }
        }

        private void chkRosaVoda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRosaVoda.Checked == true)
            {
                txtRosaVoda.Enabled = true;
            }
            if (chkRosaVoda.Checked == false)
            {
                txtRosaVoda.Enabled = false;
                txtRosaVoda.Text = "0";
            }
        }

        private void chkCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCocaCola.Checked == true)
            {
                txtCocaCola.Enabled = true;
            }
            if (chkCocaCola.Checked == false)
            {
                txtCocaCola.Enabled = false;
                txtCocaCola.Text = "0";
            }
        }

        private void chkPivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPivo.Checked == true)
            {
                txtPivo.Enabled = true;
            }
            if (chkPivo.Checked == false)
            {
                txtPivo.Enabled = false;
                txtPivo.Text = "0";
            }
        }

        private void chkFanta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFanta.Checked == true)
            {
                txtFanta.Enabled = true;
            }
            if (chkFanta.Checked == false)
            {
                txtFanta.Enabled = false;
                txtFanta.Text = "0";
            }
        }

        private void chkNext_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNext.Checked == true)
            {
               txtNext.Enabled = true;
            }
            if (chkNext.Checked == false)
            {
                txtNext.Enabled = false;
                txtNext.Text = "0";
            }
        }

        private void chkPileciBatak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPileciBatak.Checked == true)
            {
                txtPileciBatak.Enabled = true;
            }
            if (chkPileciBatak.Checked == false)
            {
                txtPileciBatak.Enabled = false;
                txtPileciBatak.Text = "0";
            }
        }

        private void chkPaste_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaste.Checked == true)
            {
                txtPaste.Enabled = true;
            }
            if (chkPaste.Checked == false)
            {
                txtPaste.Enabled = false;
                txtPaste.Text = "0";

            }
        }

        private void chkMesanoMeso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMesanoMeso.Checked == true)
            {
                txtMesano.Enabled = true;
            }
            if (chkMesanoMeso.Checked == false)
            {
                txtMesano.Enabled = false;
                txtMesano.Text = "0";
            }
        }

        private void chkPunjeneTikvice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPunjeneTikvice.Checked == true)
            {
                txtTikvice.Enabled = true;
            }
            if (chkPunjeneTikvice.Checked == false)
            {
                txtTikvice.Enabled = false;
                txtTikvice.Text = "0";
            }
        }

        private void chkGurmanskaPljeskavica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGurmanskaPljeskavica.Checked == true)
            {
                txtPljeskavica.Enabled = true;
            }
            if (chkGurmanskaPljeskavica.Checked == false)
            {
                txtPljeskavica.Enabled = false;
                txtPljeskavica.Text = "0";
            }
        }

        private void chkPiletinaSaPrelivom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPiletinaSaPrelivom.Checked == true)
            {
                txtPiletina.Enabled = true;
            }
            if (chkPiletinaSaPrelivom.Checked == false)
            {
                txtPiletina.Enabled = false;
                txtPiletina.Text = "0";
            }
        }

        private void chkBiftekNaGrilu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBiftekNaGrilu.Checked == true)
            {
                txtBiftek.Enabled = true;
            }
            if (chkBiftekNaGrilu.Checked == false)
            {
                txtBiftek.Enabled = false;
                txtBiftek.Text = "0";
            }
        }

        private void chkSvinjskiFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSvinjskiFile.Checked == true)
            {
                txtFile.Enabled = true;
            }
            if (chkSvinjskiFile.Checked == false)
            {
                txtFile.Enabled = false;
                txtFile.Text = "0";
            }
        }

        private void chkQueenChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueenChocolate.Checked == true)
            {
                txtQueen.Enabled = true;
            }
            if (chkQueenChocolate.Checked == false)
            {
                txtQueen.Enabled = false;
                txtQueen.Text = "0";
            }
        }

        private void chkNocciola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocciola.Checked == true)
            {
                txtNocciola.Enabled = true;
            }
            if (chkNocciola.Checked == false)
            {
                txtNocciola.Enabled = false;
                txtNocciola.Text = "0";
            }
        }

        private void chkCappuccinoCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccinoCake.Checked == true)
            {
                txtCappuccinoCake.Enabled = true;
            }
            if (chkCappuccinoCake.Checked == false)
            {
                txtCappuccinoCake.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void chkSweetForest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSweetForest.Checked == true)
            {
                txtSweet.Enabled = true;
            }
            if (chkSweetForest.Checked == false)
            {
                txtSweet.Enabled = false;
                txtSweet.Text = "0";
            }
        }

        private void chkNugat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNugat.Checked == true)
            {
                txtNugat.Enabled = true;
            }
            if (chkNugat.Checked == false)
            {
                txtNugat.Enabled = false;
                txtNugat.Text = "0";

            }
        }

       

        private void chkCrispyCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrispyCake.Checked == true)
            {
                txtCrispy.Enabled = true;
            }
            if (chkCrispyCake.Checked == false)
            {
                txtCrispy.Enabled = false;
                txtCrispy.Text = "0";
            }
        }

        private void chkMoscow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMoscow.Checked == true)
            {
                txtMoscow.Enabled = true;
            }
            if (chkMoscow.Checked == false)
            {
                txtMoscow.Enabled = false;
                txtMoscow.Text = "0";
            }
        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void chkMamaMia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMamaMia.Checked == true)
            {
                txtMama.Enabled = true;
            }
            if (chkMamaMia.Checked == false)
            {
                txtMama.Enabled = false;
                txtMama.Text = "0";
            }
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = "";
            txtCappuccino.Focus();
        }

        private void txtKiselaVoda_Click(object sender, EventArgs e)
        {
            txtKiselaVoda.Text = "";
            txtKiselaVoda.Focus();
        }

        private void txtRosaVoda_Click(object sender, EventArgs e)
        {
            txtRosaVoda.Text = "";
            txtRosaVoda.Focus();
        }

        private void txtCocaCola_Click(object sender, EventArgs e)
        {
            txtCocaCola.Text = "";
            txtCocaCola.Focus();
        }

        private void txtPivo_Click(object sender, EventArgs e)
        {
            txtPivo.Text = "";
            txtPivo.Focus();
        }

        private void txtFanta_Click(object sender, EventArgs e)
        {
            txtFanta.Text = "";
            txtFanta.Focus();
        }

        private void txtNext_Click(object sender, EventArgs e)
        {
            txtNext.Text = "";
            txtNext.Focus();
        }

        private void txtPileciBatak_Click(object sender, EventArgs e)
        {
            txtPileciBatak.Text = "";
            txtPileciBatak.Focus();

        }

        private void txtPaste_Click(object sender, EventArgs e)
        {
            txtPaste.Text = "";
            txtPaste.Focus();
        }

        private void txtMesano_Click(object sender, EventArgs e)
        {
            txtMesano.Text = "";
            txtMesano.Focus();

        }

        private void txtTikvice_Click(object sender, EventArgs e)
        {
            txtTikvice.Text = "";
            txtTikvice.Focus();
        }

        private void txtPljeskavica_Click(object sender, EventArgs e)
        {
            txtPljeskavica.Text = "";
            txtPljeskavica.Focus();

        }

        private void txtPiletina_Click(object sender, EventArgs e)
        {
            txtPiletina.Text = "";
            txtPiletina.Focus();
        }

        private void txtBiftek_Click(object sender, EventArgs e)
        {
            txtBiftek.Text = "";
            txtBiftek.Focus();
        }

        private void txtFile_Click(object sender, EventArgs e)
        {
            txtFile.Text = "";
            txtFile.Focus();
        }

        private void txtQueen_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQueen_Click(object sender, EventArgs e)
        {
            txtQueen.Text = "";
            txtQueen.Focus();


        }

        private void txtNocciola_Click(object sender, EventArgs e)
        {
            txtNocciola.Text = "";
            txtNocciola.Focus();
        }

        private void txtCappuccinoCake_Click(object sender, EventArgs e)
        {
            txtCappuccinoCake.Text = "";
            txtCappuccinoCake.Focus();
        }

        private void txtSweet_Click(object sender, EventArgs e)
        {
            txtSweet.Text = "";
            txtSweet.Focus();
        }

        private void txtNugat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNugat_Click(object sender, EventArgs e)
        {
            txtNugat.Text = "";
            txtNugat.Focus();
        }

        private void txtMama_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtMama_Click(object sender, EventArgs e)
        {
            txtMama.Text = "";
            txtMama.Focus();
        }

        private void txtCrispy_Click(object sender, EventArgs e)
        {
            txtCrispy.Text = "";
            txtCrispy.Focus();
        }

        private void txtMoscow_Click(object sender, EventArgs e)
        {
            txtMoscow.Text = "";
            txtMoscow.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        private void button2_Click(object sender, EventArgs e)
        {
            rtfRiciept.Clear();

            rtfRiciept.AppendText(Environment.NewLine);
            rtfRiciept.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRiciept.AppendText("\t" + "Etno restoran Šumski raj" + Environment.NewLine);
            rtfRiciept.AppendText("------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtfRiciept.AppendText("Espresso \t\t\t\t\t " + txtEspresso.Text + Environment.NewLine);
            rtfRiciept.AppendText("Cappucino \t\t\t\t\t " + txtCappuccino.Text + Environment.NewLine);
            rtfRiciept.AppendText("Kisela voda \t\t\t\t\t " + txtKiselaVoda.Text + Environment.NewLine);
            rtfRiciept.AppendText("Rosa voda \t\t\t\t\t " + txtRosaVoda.Text + Environment.NewLine);
            rtfRiciept.AppendText("Coca Cola \t\t\t\t\t " + txtCocaCola.Text + Environment.NewLine);
            rtfRiciept.AppendText("Pivo \t\t \t\t\t\t " + txtPivo.Text + Environment.NewLine);
            rtfRiciept.AppendText("Fanta \t\t \t\t\t\t " + txtFanta.Text + Environment.NewLine);
            rtfRiciept.AppendText("Next sokovi \t \t\t\t\t " + txtNext.Text + Environment.NewLine);

            rtfRiciept.AppendText("Pileći batak \t\t\t\t\t " + txtPileciBatak.Text + Environment.NewLine);
            rtfRiciept.AppendText("Paste \t\t\t\t\t\t " + txtPaste.Text + Environment.NewLine);
            rtfRiciept.AppendText("Mešano meso \t\t\t\t\t " + txtMesano.Text + Environment.NewLine);
            rtfRiciept.AppendText("Punjene tikvice \t\t\t\t\t " + txtTikvice.Text + Environment.NewLine);
            rtfRiciept.AppendText("Gurmanske pljeskavice \t \t\t\t " + txtPljeskavica.Text + Environment.NewLine);
            rtfRiciept.AppendText("Piletina sa prelivom \t\t\t\t " + txtPiletina.Text + Environment.NewLine);
            rtfRiciept.AppendText("Biftek na grilu \t\t\t\t\t " + txtBiftek.Text + Environment.NewLine);
            rtfRiciept.AppendText("Svinjski file \t\t\t\t\t " + txtFile.Text + Environment.NewLine);

            rtfRiciept.AppendText("Queen chocolate \t\t\t\t " + txtQueen.Text + Environment.NewLine);
            rtfRiciept.AppendText("Nocciola \t\t\t\t\t " + txtNocciola.Text + Environment.NewLine);
            rtfRiciept.AppendText("Cappuccino cake \t\t\t\t " + txtCappuccino.Text + Environment.NewLine);
            rtfRiciept.AppendText("Sweet forest \t\t\t\t\t " + txtSweet.Text + Environment.NewLine);
            rtfRiciept.AppendText("Nugat \t\t\t\t \t\t " + txtNugat.Text + Environment.NewLine);
            rtfRiciept.AppendText("Mama mia \t\t\t\t\t " + txtMama.Text + Environment.NewLine);
            rtfRiciept.AppendText("Crispy cake \t\t\t\t\t " + txtCrispy.Text + Environment.NewLine);
            rtfRiciept.AppendText("Moscow \t \t\t\t\t " + txtMoscow.Text + Environment.NewLine);
            rtfRiciept.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
            rtfRiciept.AppendText("Total \t\t " + lblTotal.Text + Environment.NewLine);
          
            rtfRiciept.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfRiciept.AppendText(lblTime.Text + "\t\t\t" + lblDate.Text);



        }



        private void rtfRiciept_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfRiciept.Text, new Font("Arial",14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton1_Click(object sender, EventArgs e)
        {
            rtfRiciept.Clear();
        }

        private void cutToolStripButton1_Click(object sender, EventArgs e)
        {
            rtfRiciept.Cut();
        }

        private void copyToolStripButton1_Click(object sender, EventArgs e)
        {
            rtfRiciept.Copy();
        }

        private void pasteToolStripButton1_Click(object sender, EventArgs e)
        {
            rtfRiciept.Paste();
        }

        private void openToolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfRiciept.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);

        }

        private void saveToolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfRiciept.Text);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double espresso, cappuccino, kisela, rosa, cola, pivo, fanta, next;
                double pbatak,paste,mesano,tikvice,pljeskavica,ppreliv,biftek,file;
            double queen, nocciola, ccake, sweet, nugat, mama, crispy, moscow;

            espresso = 120;
            cappuccino = 120;
            kisela = 100;
            rosa = 80;
            cola = 150;
            pivo = 180;
            fanta = 150;
            next = 200;
            pbatak = 700;
            paste = 750;
            mesano = 1500;
            tikvice = 600;
            pljeskavica = 650;
            ppreliv = 750;
            biftek = 850;
            file = 800;
            queen = 200;
            nocciola = 250;
            ccake = 180;
            sweet = 150;
            nugat = 210;
            mama = 250;
            crispy = 190;
            moscow = 230;

            double espresso_cal = Convert.ToDouble(txtEspresso.Text) ;
            double cappuccino_cal = Convert.ToDouble(txtCappuccino.Text) ;
            double kisela_cal = Convert.ToDouble(txtKiselaVoda.Text) ;
            double rosa_cal = Convert.ToDouble(txtRosaVoda.Text) ;
            double cola_cal = Convert.ToDouble(txtCocaCola.Text) ;
            double pivo_cal = Convert.ToDouble(txtPivo.Text) ;
            double fanta_cal = Convert.ToDouble(txtFanta.Text) ;
            double next_cal = Convert.ToDouble(txtNext.Text) ;
            double pbatak_cal = Convert.ToDouble(txtPileciBatak.Text) ;
            double paste_cal = Convert.ToDouble(txtPaste.Text) ;
            double mesano_cal = Convert.ToDouble(txtMesano.Text) ;
            double tikvice_cal = Convert.ToDouble(txtTikvice.Text) ;
            double pljeskavica_cal = Convert.ToDouble(txtPljeskavica.Text) ;
            double ppreliv_cal = Convert.ToDouble(txtPiletina.Text) ;
            double biftek_cal = Convert.ToDouble(txtBiftek.Text) ;
            double file_cal = Convert.ToDouble(txtFile.Text) ;
            double queen_cal = Convert.ToDouble(txtQueen.Text) ;
            double nocciola_cal = Convert.ToDouble(txtNocciola.Text) ;
            double ccake_cal = Convert.ToDouble(txtCappuccinoCake.Text) ;
            double sweet_cal = Convert.ToDouble(txtSweet.Text) ;
            double nugat_cal = Convert.ToDouble(txtNugat.Text) ;
            double mama_cal = Convert.ToDouble(txtMama.Text) ;
            double crispy_cal = Convert.ToDouble(txtCrispy.Text) ;
            double moscow_cal = Convert.ToDouble(txtMoscow.Text) ;

            Restoran Restoran = new Restoran(espresso_cal,  cappuccino_cal,  kisela_cal, rosa_cal,  cola_cal,  pivo_cal,
         fanta_cal,  next_cal,  pbatak_cal,  paste_cal, mesano_cal,  tikvice_cal,  pljeskavica_cal,
         ppreliv_cal,  biftek_cal,  file_cal,  queen_cal,  nocciola_cal,  ccake_cal,  sweet_cal, nugat_cal,
        mama_cal,  crispy_cal, moscow_cal);

            double cenaPica = (espresso_cal * espresso) + (cappuccino_cal * cappuccino) + (kisela_cal * kisela) + (rosa_cal * rosa) + (cola_cal * cola) + (pivo_cal * pivo) + (fanta_cal * fanta) + (next_cal * next);
            lblCostDrink.Text = Convert.ToString(cenaPica);


             double cenaHrane = (pbatak_cal*pbatak) + (paste_cal*paste) + (mesano_cal*mesano) + (tikvice_cal*tikvice) + (pljeskavica_cal*pljeskavica) + (ppreliv_cal*ppreliv) + (biftek_cal*biftek) + (file_cal*file);
            lblCostFood.Text = Convert.ToString(cenaHrane);
            double cenaDezerta = (queen_cal*queen) + (nocciola_cal*nocciola) + (ccake_cal*ccake) + (sweet_cal*sweet) + (nugat_cal*nugat) + (mama_cal*mama) + (crispy_cal*crispy) + (moscow_cal*moscow);
            lblCostCake.Text = Convert.ToString(cenaDezerta);
            double total = (cenaHrane + cenaPica+cenaDezerta);
            lblTotal.Text = Convert.ToString(total);
            
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPileciBatak_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUplaceno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPovracaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double uplaceno = double.Parse(textBox1.Text);
            double total1 = double.Parse(lblTotal.Text);
            double povracaj = (uplaceno - total1);
            textBox2.Text = Convert.ToString(povracaj);
        }
    }
}
