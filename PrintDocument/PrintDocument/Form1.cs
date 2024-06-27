using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form1 : Form
    {
        private string Gender = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UpdloadImage()//Fonction permettant de charger l'image dans le pictureBox
        {
            try
            {
                openFileDialog1.Filter = "JPG FILES(*.jpg)|*.jpg|PNG FILES(*.png)|* .png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureBoxImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Image Upload .\n" + ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
        private void button1_Click(object sender, EventArgs e)//Bouton permettant de charger l'image
        {
            UpdloadImage();
        }

        private void button2_Click(object sender, EventArgs e)//bouton permettant d'afficher l'apercu
        {
            if (rbtnM.Checked)
            {
                Gender = "Male";
            }
            if (rbtnF.Checked)
            {
                Gender = "Female";
            }
            //Transfere des valeurs saisie dans le formulaire 1 dans le formulaire2
            Form2 frm2 = new Form2();
            frm2.img = pictureBoxImage.Image;
            frm2.name = txtName.Text;
            if (comboBoxsection.SelectedIndex == -1)
            {
                frm2.Section = "";
            }
            else
            frm2.Section = comboBoxsection.SelectedItem.ToString();
            if (comboBoxclass.SelectedIndex == -1)
                frm2.Class = "";
            else 
                 frm2.Class = comboBoxclass.SelectedItem.ToString();

            frm2.Gender = Gender;
            frm2.Show();
        }

        private void btnDoc_Click(object sender, EventArgs e)//Bouton permettant de charger un document Pdf
        {
            openFileDialog2.Filter = "PDF FileStyleUriParser(*.pdf)|*.pdf|WORD FILES (*.doc)|*.doc";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)

                pictureBoxDoc.Image = Properties.Resources.livre2;
           txtdoc.Text = openFileDialog2.SafeFileName;
        }
    }
}
