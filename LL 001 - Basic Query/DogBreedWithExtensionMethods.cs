using System.Collections.Generic;
using System.Linq;

namespace DogExample {

    public class DogBreed {
        
        private float _Price;
        private string _BreedName;

        public bool isPriceLessThanOrEqual( float aPrice ) {
            return _Price <= aPrice ;
        }
        
        public bool isPriceGreaterThanOrEqual( float aPrice ) {
            return _Price >= aPrice ;
        }


        public string PreferredSort() {
            return _BreedName;
        }		

        public static IEnumerable<DogBreed> DogBreedLL001Result() {
                return DogExampleListSource()
                    .PriceGreaterThanEqual( 200 )
                    .PriceLessThanEqual( 400 )
                    .OrderByPreferred();
        }
    }
    
    public static class DogBreedExtensions {

        public static IEnumerable<DogBreed> PriceLessThanEqual( this IEnumerable<DogBreed> aList , float aPrice ) {
            return aList.Where( DOG => DOG.isLessThanOrEqualTo( aPrice ) );
        }

        public static IEnumerable<DogBreed> PriceGreaterThanEqual( this IEnumerable<DogBreed> aList , float aPrice ) {
            return aList.Where( DOG => DOG.isGreaterThanOrEqualTo( aPrice ) );
        }

        public static IEnumerable<DogBreed> OrderByPreferred( this IEnumerable<DogBreed> aList ) {
            return aList.OrderBy( DOG => DOG.PreferredSort() );
        }
    }
   
}
