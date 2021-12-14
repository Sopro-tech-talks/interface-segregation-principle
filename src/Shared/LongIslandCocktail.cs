using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shared
{
    public class LongIslandCocktail : CocktailBase, ICocktail<IIngredient, IngredientResponse>
    {
        public Task<IngredientResponse> AddIngredient(IIngredient ingredient)
        {
            Ingredients.Add(ingredient);
            return Task.FromResult(new IngredientResponse { Name = $"{ingredient.Name} with {ingredient.Amount} has been added" });
        }

        public List<IIngredient> AllIngredients => Ingredients;
    }


    public class Mojito : CocktailBase, ICocktail<IIngredient, IngredientResponse>, INeedGlass, ICharge
    {
        public Task<IngredientResponse> AddIngredient(IIngredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        public Task<Glass> GetGlassAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<double> GetAmountAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task Charge()
        {
            throw new System.NotImplementedException();
        }
    }
}