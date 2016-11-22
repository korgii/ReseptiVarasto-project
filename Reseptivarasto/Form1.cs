using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Reseptivarasto
{
    public partial class Form1 : Form
    {
        public ReseptiModel ReseptiModel { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void uusiReseptiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecipe n = new NewRecipe();
            n.Show();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selaaReseptejäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream stream;
            OpenFileDialog o;
            OpenFileStream(out stream, out o);

            XmlSerializer serializer = new XmlSerializer(typeof(ReseptiModel));

            if (o.ShowDialog() == DialogResult.OK)
            {
                try{
                    if ((stream = (FileStream)o.OpenFile()) != null){
                        using (stream){
                            ReseptiModel = (ReseptiModel)serializer.Deserialize(stream);
                            ApplyVariables();
                        }
                    }
                }
                catch (Exception eih){              
                    throw new Exception(eih.Message);
                }
            }
        }

        public void ApplyVariables()
        {
            label1.Text = string.Empty;
            textBox1.Text = string.Empty;
            listBox1.Items.Clear();

            label1.Text = ReseptiModel.RecipeName;
            
            List<string> temp = new List<string>();
            foreach(var asd in ReseptiModel.IngredientModels){
                //temp.Add(string.Join(" - ", asd.Select(x => x.Key + " " + x.Value).ToArray()));
                temp.Add(string.Format("{0} - {1}", asd.IngredientName, asd.IngredientAmount));
            }

            temp.ForEach(r => listBox1.Items.Add(r));
            textBox1.Text = ReseptiModel.RecipeString;
        }

        private void muokkaaReseptiäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream stream;
            OpenFileDialog oFileDialog;
            OpenFileStream(out stream, out oFileDialog);

            XmlSerializer serializer = new XmlSerializer(typeof(ReseptiModel));

            if (oFileDialog.ShowDialog() == DialogResult.OK){
                try{
                    if ((stream = (FileStream)oFileDialog.OpenFile()) != null){
                        using (stream){
                            ModifyRecipe modify = new ModifyRecipe(stream.Name);
                            modify.ReseptiModel = (ReseptiModel)serializer.Deserialize(stream);
                            modify.Show();
                        }
                    }
                }
                catch (Exception eih){
                    throw new Exception(eih.Message);
                }
            }
        }

        public void OpenFileStream(out FileStream s, out OpenFileDialog o)
        {
            s = null;
            o = new OpenFileDialog();
            o.InitialDirectory = Application.StartupPath;
            o.Filter = "XML Files|*.xml";
        }
    }
}
