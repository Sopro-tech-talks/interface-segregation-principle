using System.Linq;
using Shared;
using Shouldly;
using Xunit;

namespace Testing
{
    public class LongIslandCocktailShould
    {
        [Fact]
        public void BeOfCocktailType()
        {
            //Arrange
            var cocktail = new LongIslandCocktail();

            //Act

            //Assert
            Assert.IsAssignableFrom<ICocktail<IIngredient, IngredientResponse>>(cocktail);
        }

        [Theory]
        [ClassData(typeof(IngredientsTestData))]
        public void ContainAtLeastOneIngredient(IIngredient ingredient)
        {
            //Arrange
            var cocktail = new LongIslandCocktail();

            //Act
            cocktail.AddIngredient(ingredient);
            
            //Assert
            cocktail.AllIngredients.Count.ShouldBeGreaterThan(0);
            cocktail.AllIngredients.Count.ShouldBeGreaterThanOrEqualTo(1);
            cocktail.AllIngredients.ShouldContain(n => n is IIngredient);
        }

        [Fact]
        public void ContainsAllIngredients()
        {
            //Arrange
            var cocktail = new LongIslandCocktail();
            var testData = new IngredientsTestData();

            //Act
            foreach (var ingredientsData in testData)
            {
                var ingredient = ingredientsData.First() as IIngredient;
                cocktail.AddIngredient(ingredient);
            }
           

            //Assert
            cocktail.AllIngredients.Count.ShouldBeGreaterThan(0);
            cocktail.AllIngredients.Count.ShouldBe(7);
            cocktail.AllIngredients.ShouldContain(n => n.GetType() == typeof(Vodka));
            cocktail.AllIngredients.ShouldContain(n => n.GetType() == typeof(Tequila));
            cocktail.AllIngredients.ShouldContain(n => n.GetType() == typeof(Rum));
            cocktail.AllIngredients.ShouldContain(n => n.GetType() == typeof(DryGin));
            cocktail.AllIngredients.ShouldContain(n => n.GetType() == typeof(Liquer));
            cocktail.AllIngredients.ShouldContain(n => n.GetType() == typeof(Cola));
            cocktail.AllIngredients.ShouldContain(n => n.GetType() == typeof(LimeJuice));
        }

    }
}