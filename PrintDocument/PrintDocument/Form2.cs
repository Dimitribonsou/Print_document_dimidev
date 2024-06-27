using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;//librerie pour impression
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form2 : Form
    {
       public string Date,name,Section,Gender,Class;//variable permettant de recuper les valeurs des champs dans le formulaire 1
        public  Image img = null;
        public Form2()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }
        //Fonction permettant d'imprimer
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
           getprintarea(pnl);//Dessinner le conteneur d'affichage
            printPreviewDialog1.Document = printDocument1;//affichage de l'apercu
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);//impression du document
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memorying;
        private void  getprintarea(Panel pnl)
        {
            memorying=new Bitmap(pnl.Width,pnl.Height);
            pnl.DrawToBitmap(memorying,new Rectangle(0,0,pnl.Width,pnl.Height));
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          toolTip1.SetToolTip(pictureBox1, "print");
        }
        //Recuperation des valeur entrer dans le formulaire 1
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBoxPhoto.Image = img;
            labelDate.Text = Date;
            labelName.Text = name;
            labelsection.Text = Section;
            labelclass.Text = Class;
            labelgender.Text = Gender;
        }
        //Fonction permettant d'imprimer la page
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)//bouton permettant l'impression
        {
            Print(this.panelPrint);
        }
    }
}
