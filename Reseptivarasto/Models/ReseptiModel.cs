using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Reseptivarasto.Models
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
        [XmlElement("IngredientModels")]
        public List<IngredientModel> IngredientModels { get; set; }

        public ReseptiModel()
        {
            IngredientModels = new List<IngredientModel>();
            RecipeID = Guid.NewGuid();
        }
    }
}
