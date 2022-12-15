using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq.Expressions;

namespace virtualPathfinder
{
    internal class playingField
    {
        public enum squareTypes
        {
            empty, grunction, small, medium, large
                //we use this enumerator to make it easier for us to know what each type of junction a square is. We can convert this into an integer so it's easier
                //to work with when we want to do pathfinding. For example, empty=0, grunction=1, so on.
        };
        public struct squareData 
        {
            public int xVal, yVal;
            public squareTypes type;
            
        };


        int[] startingPosition = new int[2]; //create a new "vector".
        public static int squareSide = 25; //create the "side" of the square. This makes it easier to change how big the field is.
        public static squareData[,] fieldSquares = new squareData[squareSide, squareSide];

       public static void Main(String[] args) 
        {
           for(int i = 0; i < squareSide; i++) //vertical
            { 
                for(int j = 0; j < squareSide; j++) 
                {
                    fieldSquares[i, j].xVal = j; fieldSquares[i, j].yVal = i; //assign each square the correct coordinates.
                   
                    if (j % 2 == 0) //just doing this to test.
                        fieldSquares[i, j].type = squareTypes.large;
                   
                    Console.Write(string.Concat(" ",(int)fieldSquares[i,j].type, "|")); //displays the 2d array.
                }

                Console.WriteLine();
            }
        }
    }
}
