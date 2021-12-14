using System.Collections;
using System.Collections.Generic;
using Shared;

namespace Testing
{
    public class IngredientsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Vodka { Name = "Vodka", Amount = "50ml" } };
            yield return new object[] { new DryGin { Name = "Dry Gin", Amount = "50ml" } };
            yield return new object[] { new Tequila { Name = "Tequila", Amount = "50ml" } };
            yield return new object[] { new Rum { Name = "Rum", Amount = "50ml" } };
            yield return new object[] { new Liquer { Name = "Rum", Amount = "50ml" } };
            yield return new object[] { new LimeJuice { Name = "Rum", Amount = "100ml" } };
            yield return new object[] { new Cola { Name = "Rum", Amount = "500ml" } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
