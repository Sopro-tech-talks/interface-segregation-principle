using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shared
{
    public abstract class CocktailBase : ICocktail<IIngredient, IngredientResponse>
    {
        protected List<IIngredient> Ingredients { get; set; }
        protected CocktailBase()
        {

            Ingredients = new List<IIngredient>();
        }

        public Task<IngredientResponse> AddIngredient(IIngredient ingredient)
        {
            Ingredients.Add(ingredient);
            return Task.FromResult(new IngredientResponse { Name = $"Added {ingredient.Amount} of {ingredient.Name}" });
        }
    }
}