using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Reseptivarasto.Models;

namespace Reseptivarasto
{
    public partial class ModifyRecipe : Form
    {
        public ReseptiModel ReseptiModel { get { return m_ReseptiModel; } set { m_ReseptiModel = value; } }
        private ReseptiModel m_ReseptiModel;

        public string FilePath { get; set; }

        public ModifyRecipe(string filePath)
        {
            InitializeComponent();
            FilePath = filePath;
            Shown += ModifyRecipe_Shown;
        }

        private void ModifyRecipe_Shown(object sender, EventArgs e)
        {
            textBox1.Text = ReseptiModel.RecipeName;
            textBox4.Text = ReseptiModel.RecipeString;

            listBox1.DisplayMember = "IngredientNameReturn";
            listBox1.ValueMember = "IngredientGuid";

            foreach (var asd in ReseptiModel.IngredientModels){        
                listBox1.Items.Add(new IngredientModel{
                        IngredientName = asd.IngredientName,
                        IngredientAmount = asd.IngredientAmount,
                        IngredientGuid = asd.IngredientGuid,
                        IngredientNameReturn = asd.IngredientNameReturn
                    });
            }
        }

        //Tallenna resepti
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)){
                MessageBox.Show("Anna reseptin nimi");
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text)){
                MessageBox.Show("Anna reseptin valmistusohje");
                return;
            }

            SaveRecipe();
        }

        private void SaveRecipe()
        {
            //Lisää arvot modeliin
            ReseptiModel.RecipeName = textBox1.Text;
            ReseptiModel.RecipeString = textBox4.Text;

            XmlSerializer xs = new XmlSerializer(typeof(ReseptiModel));
            SaveFileDialog s = new SaveFileDialog();
            s.InitialDirectory = Application.StartupPath;
            s.Filter = "XML Files|*.xml";

            File.Delete(FilePath);
            FileStream stream = new FileStream(FilePath, FileMode.Create);
            xs.Serialize(stream, ReseptiModel);
            stream.Close();

            MessageBox.Show("Resepti tallennettu!");
        }

        //Lisää ainesosa
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text)){
                MessageBox.Show("Anna ainesosan nimi");
                return;
            }
            // Ainesosan määrä on mahdollista jättää tyhjäksi
            listBox1.Items.Add(string.Format("{0} - {1}", textBox2.Text, textBox3.Text));

            var d = new IngredientModel();
            d.IngredientName = textBox2.Text;
            d.IngredientAmount = textBox3.Text;
            ReseptiModel.IngredientModels.Add(d);
        }

        //Poista ainesosa
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null){

                var h = listBox1.SelectedItem as IngredientModel;
                var s = ReseptiModel.IngredientModels.Find(p => p.IngredientGuid == h.IngredientGuid);
                if (s != null){
                    ReseptiModel.IngredientModels.Remove(s);
                }

                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
