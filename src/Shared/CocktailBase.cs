using System.Collections.Generic;

namespace Shared
{
    public abstract class CocktailBase
    {
        protected List<IIngredient> Ingredients { get; set; }
        protected CocktailBase()
        {

            Ingredients = new List<IIngredient>();
        }
    }
}