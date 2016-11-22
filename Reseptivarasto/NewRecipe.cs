using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Reseptivarasto
{
    public partial class NewRecipe : Form
    {
        private ReseptiModel m;

        public NewRecipe()
        {
            InitializeComponent();
            m = new ReseptiModel();
        }

        //Lisää ainesosa
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox2.Text)){
                MessageBox.Show("Anna ainesosan nimi");
                return;
            }
            // Ainesosan määrä on mahdollista jättää tyhjäksi
            listBox1.Items.Add(string.Format("{0} - {1}", textBox2.Text, textBox3.Text));

            var d = new IngredientModel();
            d.IngredientName = textBox2.Text;
            d.IngredientAmount = textBox3.Text;
            m.IngredientModels.Add(d);
        }

        //Tallenna resepti
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)){
                MessageBox.Show("Anna reseptin nimi");
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text)){
                MessageBox.Show("Anna reseptin valmistusohje");
                return;
            }

            AddRecipe();
        }

        private void AddRecipe()
        {
            //Lisää arvot modeliin
            m.RecipeName = textBox1.Text;
            m.RecipeString = textBox4.Text;

            XmlSerializer xs = new XmlSerializer(typeof(ReseptiModel));
            SaveFileDialog s = new SaveFileDialog();
            s.InitialDirectory = Application.StartupPath;
            s.Filter = "XML Files|*.xml";
            Stream stream;

            if (s.ShowDialog() == DialogResult.OK){
                try{
                    if ((stream = s.OpenFile()) != null){
                        using (stream){
                            xs.Serialize(stream, m);
                        }
                    }
                }
                catch (Exception heh){
                    throw new Exception(heh.Message);
                }
            }
            MessageBox.Show("Resepti tallennettu!");
        }
    }
}
