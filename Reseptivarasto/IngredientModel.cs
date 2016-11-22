using System;

namespace Reseptivarasto
{
    public class IngredientModel
    {
        public string IngredientName { get; set; }
        public string IngredientAmount { get; set; }
        public Guid IngredientGuid { get; set; }

        public string IngredientNameReturn { get { return m_IngredientNameReturn; } set { m_IngredientNameReturn = IngredientListString(); } }
        private string m_IngredientNameReturn;

        public IngredientModel()
        {
            IngredientGuid = Guid.NewGuid();
        }

        public IngredientModel(string name, string amount)
        {
            IngredientName = name;
            IngredientAmount = amount;
            IngredientGuid = Guid.NewGuid();
        }

        public string IngredientListString ()
        {
            return string.Format("{0} - {1}", IngredientName, IngredientAmount);
        }
    }
}
