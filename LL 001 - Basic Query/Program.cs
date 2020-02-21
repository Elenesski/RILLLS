using System;
using System.Diagnostics;
using System.Linq;
using DogExample;

namespace ConsoleApp1 {
    class Program {
        static void Main(
            string[] args ) {
            
            new DogBreedLL001().Result().ToList().ForEach( DOGBREED => { Console.WriteLine( DOGBREED.ToString() );} );
            
            
        }
    }
}