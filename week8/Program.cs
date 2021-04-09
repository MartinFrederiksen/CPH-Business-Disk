using System;

namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*

            p = [
                X € { 1... },
                Y € {?},
                Z € {?, 7...17}
            ]

            { 1, 2, 3 } ⊆ { 1, 2, 3, 4}     5 <= 7
            { 1, 2, 3, 4 } ⊈ { 1, 2, 3 }    7 </= 5 (7 > 5)
            {1, 2, 3} ⊈ { 1, 2, 3 }         ?

            Max: { 1, 2, 3, 4 }
            Min: { 2, 3 }

            Top: U
            Bund: Ø

            { P } C { Q }

            analyse(C, P) -> S

            S ⪯ Q

            */

            /*
            public static void main(String[] args) {
                State P = new XState(...); // precondition
                State Q = new XState(...); // postcondition
                SyntaxtTree C = new XSyntaxTree(...) // commands / code / program
                State S = C.analyse(P);
                if (S.subStateOf(Q))
                {
                    System.out.println("Hurra!");
                }
                else
                {
                    System.out.println("Øv!");
                }
            }
            */


        }
    }
}
