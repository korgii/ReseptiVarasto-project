using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Reseptivarasto
{
    [XmlRoot("ReseptiModel")]
    public class ReseptiModel
    {
        [XmlElement("RecipeID")]
        public Guid RecipeID { get; set; }
        [XmlElement("RecipeName")]
        public string RecipeName { get; set; }
        [XmlElement("RecipeString")]
        public string RecipeString { get; set; }
        //[XmlElement("SerializableDicitonary")]
        //public List<SerializableDictionary<string, string>> m_Ingredients;
        public List<IngredientModel> IngredientModels { get; set; }


        public ReseptiModel()
        {
            //m_Ingredients = new List<SerializableDictionary<string, string>>();
            IngredientModels = new List<IngredientModel>();
            RecipeID = Guid.NewGuid();
        }
    }
}
