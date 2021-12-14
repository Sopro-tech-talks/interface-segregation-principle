using System.Threading.Tasks;

namespace Shared
{
    public interface ICocktail<in TAddIngredient, TIngredientResponse> where TAddIngredient : IIngredient where TIngredientResponse : IIngredientResponse
    {
        Task<TIngredientResponse> AddIngredient(TAddIngredient ingredient);
    }
}