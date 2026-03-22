using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW_OpreaAndreea_1059D
{
    public partial class Form1 : Form
    {  List<Magazin> listaMagazine = new List<Magazin>();
       List<Raion> listaRaioaneCurente = new List<Raion>();
       List<Produs> listaProduse = new List<Produs>();
        private Font printFont;
        private PrintPreviewDialog printPreviewDialog1;
        public PrintDocument pd;
        PageSetupDialog PageSetupDialog1 = new PageSetupDialog();

        StreamReader streamToPrint = null;
        Bitmap bitmap;
        PrintDialog PrintDialog1 = new PrintDialog();
        public Form1()
        {
            InitializeComponent();
            this.printPreviewDialog1 = new PrintPreviewDialog();

            Magazin m1 = new Magazin("Carrefour Alexandria", "Soseaua Alexandria");
            Magazin m2 = new Magazin("Mega Image Cobalcescu", "Strada Cobalcescu");

            Raion raion1_1 = new Raion("Gradinarit"); //r1
            Raion raion1_2 = new Raion("Legume"); //r2

            Raion raion2_1 = new Raion("Fructe"); //r3
            Raion raion2_2 = new Raion("Dulciuri"); //r4
            Raion raion2_3 = new Raion("Sucuri"); //r5

            Produs p1_1 = new Produs("Ghiveci Ficus", 32.99, 10);
            Produs p1_2 = new Produs("Bulb Lalea", 2.99, 110);

            Produs p2_1 = new Produs("Castravete", 3.99, 34);

            Produs p3_1 = new Produs("Mere Golden", 4.59, 20);
            Produs p3_2 = new Produs("Capsuni", 1.99, 110);
            Produs p3_3 = new Produs("Pere", 5.99, 14);

            Produs p4_1 = new Produs("Ciocolata Milka", 15.99, 19);

            Produs p5_1 = new Produs("Fanta", 7.89, 100);
            Produs p5_2 = new Produs("Coca_Cola ZERO", 8.99, 200);


            m1.listaRaioane.Add(raion1_1);
            m1.listaRaioane.Add(raion2_1);

            m2.listaRaioane.Add(raion2_1);
            m2.listaRaioane.Add(raion2_2);
            m2.listaRaioane.Add(raion2_3);



            raion1_1.listaProduse.Add(p1_1);
            raion1_1.listaProduse.Add(p1_2);

            raion1_2.listaProduse.Add(p2_1);

            raion2_1.listaProduse.Add(p3_1);
            raion2_1.listaProduse.Add(p3_2);
            raion2_1.listaProduse.Add(p3_3);

            raion2_2.listaProduse.Add(p4_1);

            raion2_3.listaProduse.Add(p5_1);
            raion2_3.listaProduse.Add(p5_2);

            listaProduse.Add(p1_1);
            listaProduse.Add(p1_2);
            listaProduse.Add(p2_1);
            listaProduse.Add(p3_1);
            listaProduse.Add(p3_2);
            listaProduse.Add(p3_3);
            listaProduse.Add(p4_1);
            listaProduse.Add(p5_1);
            listaProduse.Add(p5_2);


            listaMagazine.Add(m1);
            listaMagazine.Add(m2);

            ListViewItem itm1 = new ListViewItem(new string[]
            {
                m1.nume, m1.locatie
            });
            itm1.Tag = m1;
            lvMagazine.Items.Add(itm1);
            lvMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ListViewItem itm2 = new ListViewItem(new string[]
            {
                m2.nume, m2.locatie
            });
            itm2.Tag = m2;
            lvMagazine.Items.Add(itm2);

            lvMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void lvMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMagazine.SelectedItems.Count > 0)
            {
                lvProduse.Items.Clear();
                int index = lvMagazine.SelectedIndices[0];
                Magazin magazinSelectat = listaMagazine[index];

                listaRaioaneCurente = magazinSelectat.listaRaioane;
                lvRaioane.Items.Clear();

                foreach ( Raion r in magazinSelectat.listaRaioane)
                {
                    ListViewItem itm = new ListViewItem(new string[]
                    {
                        r.nume
                    }) ;
                    itm.Tag = r;
                    lvRaioane.Items.Add(itm);
                    
                }
                lvRaioane.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvRaioane.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void lvRaioane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRaioane.SelectedItems.Count > 0)
            {
                int index = lvRaioane.SelectedIndices[0];
                Raion raionSelectat = listaRaioaneCurente[index];

                lvProduse.Items.Clear();

                foreach (Produs p in raionSelectat.listaProduse)
                {
                    ListViewItem itm = new ListViewItem(new string[]
                    {
                        p.denumire, p.pret.ToString(), p.stoc.ToString()
                    }) ;
                    itm.Tag = p;
                    lvProduse.Items.Add(itm);
                    
                }
                lvProduse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvProduse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnMagazin_Click(object sender, EventArgs e)
        {
            Magazin magazin = null;
            FormMagazin formMagazin = new FormMagazin(magazin);
            if(formMagazin.ShowDialog() == DialogResult.OK )
            {
                magazin = formMagazin.mlocal;
                listaMagazine.Add(magazin);
                ListViewItem lv = lvMagazine.Items.Add(magazin.nume);

                lv.SubItems.Add(magazin.locatie);
                lv.Tag = magazin;
            }
        }

        private void btnRaion_Click(object sender, EventArgs e)
        {
            Raion raion = null;
            FormRaion formRaion = new FormRaion(listaMagazine, raion);
            if(formRaion.ShowDialog() == DialogResult.OK )
            {
                

                if (lvMagazine.SelectedItems.Count > 0)
                {
                    lvRaioane.Items.Clear();
                    Magazin magazinSelectat = (Magazin)lvMagazine.SelectedItems[0].Tag;
                    foreach (Raion r in magazinSelectat.listaRaioane)
                    {
                        ListViewItem itm = new ListViewItem(r.nume);
                        itm.Tag = r;
                        lvRaioane.Items.Add(itm);
                    }
                    lvRaioane.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvRaioane.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void btnProdus_Click(object sender, EventArgs e)
        {
            Produs produs = new Produs();
            FormProdus formProdus = new FormProdus(listaMagazine);
            if (formProdus.ShowDialog() == DialogResult.OK )
            {
                if(lvRaioane.SelectedItems.Count > 0)
                {
                    Raion raionSelectat = (Raion)lvRaioane.SelectedItems[0].Tag;
                    lvProduse.Items.Clear();
                    foreach (Produs p in raionSelectat.listaProduse)
                    {
                        ListViewItem itm = new ListViewItem(new string[]
                        {
                    p.denumire, p.pret.ToString(), p.stoc.ToString()
                        });
                        itm.Tag = p;
                        lvProduse.Items.Add(itm);
                        listaProduse.Add(p);
                    }
                    lvProduse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvProduse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void salveazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fișiere XML(.XML)|*.xml";
            saveFile.CheckPathExists = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                TextWriter fisier = new StreamWriter(saveFile.FileName);
                XmlSerializer xmlSerializator = new XmlSerializer(typeof(List<Magazin>));
                List<Magazin> lista = new List<Magazin>();

                foreach (ListViewItem item in lvMagazine.Items)
                {
                    lista.Add((Magazin)item.Tag);
                }

                xmlSerializator.Serialize(fisier, lista);
                fisier.Close();

                MessageBox.Show("Datele au fost salvate in fisierul XML.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deschideXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fișiere XML (.xml)|*.xml";
            openFile.CheckFileExists = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializator = new XmlSerializer(typeof(List<Magazin>));
                FileStream fisier = File.OpenRead(openFile.FileName);
                List<Magazin> listaDeschisa;

                listaDeschisa = (List<Magazin>)xmlSerializator.Deserialize(fisier);
                fisier.Close();

                listaMagazine.Clear();        
                lvMagazine.Items.Clear();    

                foreach (Magazin m in listaDeschisa)
                {
                    listaMagazine.Add(m);
                    ListViewItem itm = new ListViewItem(new string[] { m.nume, m.locatie });
                    itm.Tag = m;
                    lvMagazine.Items.Add(itm);
                }

                MessageBox.Show("Datele au fost incarcate din fisier XML.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMagazin_Click(sender, e);
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMagazine.SelectedItems.Count>0)
            {
                ListViewItem lv = lvMagazine.SelectedItems[0];
                Magazin magazin = (Magazin)lv.Tag;

      
                FormMagazin formMagazin = new FormMagazin(magazin);
                if (formMagazin.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = magazin.nume;
                    lv.SubItems[1].Text = magazin.locatie;
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvMagazine.SelectedItems.Count > 0)
            {
                ListViewItem item = lvMagazine.SelectedItems[0];
                Magazin magazin = (Magazin)item.Tag;

                listaMagazine.Remove(magazin);
                lvMagazine.Items.Remove(item);
                
                lvRaioane.Items.Clear();
                lvProduse.Items.Clear();

                listaRaioaneCurente.Clear();
            }
        }

        private void contextMenuStripMagazin_Opening(object sender, CancelEventArgs e)
        {
            if (lvMagazine.SelectedItems.Count > 0)
            {
                stergeToolStripMenuItem.Enabled = true;
                editeazaToolStripMenuItem.Enabled = true;
            }
            else
            {
                stergeToolStripMenuItem.Enabled = false;
                editeazaToolStripMenuItem.Enabled = false;
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnRaion_Click(sender, e);
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvRaioane.SelectedItems.Count > 0)
            {
                ListViewItem item = lvRaioane.SelectedItems[0];
                Raion raion = (Raion)item.Tag;

                listaRaioaneCurente.Remove(raion);
                lvRaioane.Items.Remove(item);

               
                lvProduse.Items.Clear();

                
            }
        }

        private void editeazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvRaioane.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvRaioane.SelectedItems[0];
                Raion raion = (Raion)lv.Tag;


                FormRaion formMagazin = new FormRaion(listaMagazine, raion);
                if (formMagazin.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = raion.nume;
                    
                }
            }
        }

        private void contextMenuStripRaion_Opening(object sender, CancelEventArgs e)
        {
            if (lvRaioane.SelectedItems.Count > 0)
            {
                stergeToolStripMenuItem1.Enabled = true;
                editeazaToolStripMenuItem1.Enabled = true;
            }
            else
            {
                stergeToolStripMenuItem1.Enabled = false;
                editeazaToolStripMenuItem1.Enabled = false;
            }
        }

        private void adaugaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnProdus_Click(sender, e);
        }

        private void stergeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(lvProduse.SelectedItems.Count > 0)
            {
                lvProduse.SelectedItems[0].Remove();
            }
        }

        private void editeazaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvProduse.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvProduse.SelectedItems[0];
                Produs produs= (Produs)lv.Tag;


                FormProdus formProdus = new FormProdus(listaMagazine);
                formProdus.SeteazaProdusPentruEditare(produs);
                if (formProdus.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = produs.denumire;
                    lv.SubItems[1].Text = produs.pret.ToString();
                    lv.SubItems[2].Text = produs.stoc.ToString();
                }
            }
        }

        private void btnPopuleaza_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            foreach (ListViewItem itemRaion in lvRaioane.Items)
            {
                Raion raion = (Raion)itemRaion.Tag;
                TreeNode nodRaion = new TreeNode(raion.nume);

                foreach (Produs produs in raion.listaProduse)
                {
                    TreeNode nodProdus = new TreeNode(produs.denumire + " - " + + produs.stoc + " buc - " + produs.pret + " lei" );
                    nodProdus.Tag = produs;
                    nodRaion.Nodes.Add(nodProdus);
                }

                nodRaion.Expand(); 
                treeView1.Nodes.Add(nodRaion);
            }

            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle zona = e.ClipRectangle;
            g.Clear(Color.White);

            List<float> sume = new List<float>();
            List<string> numeRaioane = new List<string>();

            foreach (ListViewItem item in lvRaioane.Items)
            {
                Raion r = (Raion)item.Tag;
                float suma = 0;
                foreach (Produs p in r.listaProduse)
                {
                    suma += (float)(p.pret * p.stoc);
                }
                sume.Add(suma);
                numeRaioane.Add(r.nume);
            }

            if (sume.Count == 0)
                return;

            float latimeBara = 40;
            float spatiuIntreBare = 30;
            float valoareMax = sume.Max();
            float hMax = zona.Height - 50; 
            float xStart = 50;

            Font font = new Font("Arial", 9);
            Brush brushText = Brushes.Black;
            Brush brushBar = Brushes.CornflowerBlue;
            Pen penBare = Pens.Black;

            for (int i = 0; i < sume.Count; i++)
            {
                float hBar = (sume[i] / valoareMax) * hMax;
                float x = xStart + i * (latimeBara + spatiuIntreBare);
                float y = zona.Bottom - hBar - 20;

                RectangleF bara = new RectangleF(x, y, latimeBara, hBar);
                g.FillRectangle(brushBar, bara);
                g.DrawRectangle(penBare, x, y, latimeBara, hBar);

                string denumire = numeRaioane[i];
                SizeF dim = g.MeasureString(denumire, font);
                g.DrawString(denumire, font, brushText, x + (latimeBara - dim.Width) / 2, zona.Bottom - 20);

                string val = $"{sume[i]:0} lei";
                SizeF valSize = g.MeasureString(val, font);
                g.DrawString(val, font, brushText, x + (latimeBara - valSize.Width) / 2, y - 15);
            }
        }

        private void iesireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void incarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                streamToPrint = new StreamReader("C:\\Users\\Catalina\\Downloads\\PrintV2 2025\\fisier2.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            lvMagazine.Items.Clear(); 
            lvRaioane.Items.Clear();
            lvProduse.Items.Clear();
            listaMagazine.Clear();
            string linie_txt;

            while ((linie_txt = streamToPrint.ReadLine()) != null)
            {
                string[] parts = linie_txt.Split(';');
                if (parts.Length == 2)
                {
                    string numeMagazin = parts[0];
                    string oras = parts[1];
                    

                    Magazin m = new Magazin(numeMagazin, oras);
                    listaMagazine.Add(m);
                    ListViewItem item = new ListViewItem(parts[0]);      
                    item.SubItems.Add(parts[1]);
                    item.Tag = m;
                    lvMagazine.Items.Add(item);

                }
            }

            streamToPrint.Close();
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {

            String linie_txt = "Text de scris in document";

            SolidBrush pns = new SolidBrush(Color.BlueViolet);

            //ev.Graphics.FillRectangle(Brushes.Red, new Rectangle(200, 200, 100, 100));

            float x = 150.0F; float y = 150.0F;

            ev.Graphics.DrawString(linie_txt, printFont, pns, x, y);

            ev.HasMorePages = true;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 10;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            linie_txt = null;

            linesPerPage = ev.MarginBounds.Height /
                printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage && ((linie_txt = streamToPrint.ReadLine())
                != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(linie_txt, printFont, Brushes.Black,
                    leftMargin, yPos, new StringFormat());
                count++;
            }


            if (linie_txt != null)
                ev.HasMorePages = true;
            else ev.HasMorePages = false;

        }

        private void PrintPage2(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pd = new PrintDocument();
            printFont = new Font("Arial", 16);
            try { streamToPrint = new StreamReader("C:\\Users\\Catalina\\Downloads\\PrintV2 2025\\fisier2.txt"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            this.pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            printPreviewDialog1.Document = pd;

            printPreviewDialog1.ShowDialog();
            streamToPrint.Close();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try { streamToPrint = new StreamReader("C:\\Users\\Catalina\\Downloads\\PrintV2 2025\\fisier2.txt"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            try
            {
                printFont = new Font("Arial", 12);
                pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(this.PrintPage);

                PageSetupDialog1.PageSettings =
                    new System.Drawing.Printing.PageSettings();

                PageSetupDialog1.PrinterSettings =
                    new System.Drawing.Printing.PrinterSettings();

                PageSetupDialog1.ShowNetwork = true;

                DialogResult result = PageSetupDialog1.ShowDialog();

                pd.DefaultPageSettings = PageSetupDialog1.PageSettings;
                pd.Print();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            streamToPrint.Close();
        }

        private void CapturaEcran()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDinEcranToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage2);
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printCuPrintDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapturaEcran();
            pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage2);
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = pd;

            DialogResult result = PrintDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void lvProduse_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvProduse.SelectedItems.Count > 0)
            {
                ListViewItem item = lvProduse.SelectedItems[0];
                lvProduse.DoDragDrop(item, DragDropEffects.Move);
            }
        }

        private void lvCos_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lvCos_DragDrop(object sender, DragEventArgs e)
        {

            ListViewItem itemProdus = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            
            Produs produsDragat = (Produs)itemProdus.Tag;

            using (FormCantitate formCantitate = new FormCantitate(produsDragat.stoc))
            {
                if (formCantitate.ShowDialog() == DialogResult.OK)
                {
                    int cantitateAleasa = formCantitate.cantitatePrimita;
                    itemProdus.SubItems[2].Text = produsDragat.stoc.ToString();
                    if (cantitateAleasa > 0 && cantitateAleasa <= produsDragat.stoc)
                    {
                        
                        produsDragat.stoc -= cantitateAleasa;

                        if(produsDragat.stoc==0)
                        {
                            lvProduse.Items.Remove(itemProdus);
                        }
                        else
                        {
                            itemProdus.SubItems[2].Text = produsDragat.stoc.ToString();

                        }
                        

                       
                        ListViewItem itemExistent = null;
                        foreach (ListViewItem itm in lvCos.Items)
                        {
                            Produs p = (Produs)itm.Tag;
                            if (p.denumire == produsDragat.denumire)
                            {
                                itemExistent = itm;
                                break;
                            }
                        }

                        if (itemExistent != null)
                        {
                            
                            Produs pCos = (Produs)itemExistent.Tag;
                            pCos.stoc += cantitateAleasa;
                            itemExistent.SubItems[2].Text = pCos.stoc.ToString();
                        }
                        else
                        {
                           
                            Produs produsCos = new Produs(produsDragat.denumire, produsDragat.pret, cantitateAleasa);
                            ListViewItem itemCos = new ListViewItem(produsCos.denumire);
                            itemCos.SubItems.Add(produsCos.pret.ToString("F2"));
                            itemCos.SubItems.Add(produsCos.stoc.ToString());
                            itemCos.Tag = produsCos;
                            lvCos.Items.Add(itemCos);
                        }
                        btnPopuleaza.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Cantitate invalida sau stoc insuficient.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

