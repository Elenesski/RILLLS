using System.Collections.Generic;
using System.Linq;

namespace DogExample {

    public class DogBreed {

        private float _Price;
        private string _BreedName;

        public DogBreed(
            string aBreedName
            , float aPrice ) {
            
            _BreedName = aBreedName;
            _Price = aPrice;
        }

        public override string ToString() {
            return "$" + _Price.ToString( "F2" ) + " " + _BreedName;
        }

        public bool isPriceLessThanOrEqual( float aPrice ) {
            return _Price <= aPrice ;
        }
        
        public bool isPriceGreaterThanOrEqual( float aPrice ) {
            return _Price >= aPrice ;
        }

        public string PreferredSort() {
            return _BreedName;
        }
    }
    

	
    public class DogBreedLL001 {

        private IEnumerable<DogBreed> DogExampleListSource() {
            yield return new DogBreed( "Poodle" , 375 );
            yield return new DogBreed( "Beagle" , 195 );
            yield return new DogBreed( "Pug" , 180 );
            yield return new DogBreed( "Pomeranian" , 450 );
            yield return new DogBreed( "Golden Retriever" , 450 );
            yield return new DogBreed( "Rottweiler" , 19.95f );
            yield return new DogBreed( "German Shepherd" , 325 );
            yield return new DogBreed( "Shiba Inu" , 480 );
            yield return new DogBreed( "Bulldog" , 350 );
        }

        public IEnumerable<DogBreed> Result() {
            return DogExampleListSource()
                .Where( DB => DB.isPriceGreaterThanOrEqual( 200 ) && DB.isPriceLessThanOrEqual( 400 ) ) 
                .OrderBy( DB => DB.PreferredSort() );
        }
        
        
    }
    
    // new DogBreedLL001().Result().ToList().ForEach( DOGBREED => { Console.WriteLine( DOGBREED.ToString() );} );
    //
    //         $350.00 Bulldog
    //         $325.00 German Shepherd
    //         $375.00 Poodle        

    
}

