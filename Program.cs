using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Matrixprogram
{
    class Program
    {

        static int l, m, Row, Col;
        static int r, c, k, i, j;

       static int f, K;

       static int[,] mat = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

        // Complete the matrixRotation function below.
        static void matrixRotation(int l, int m, int Row, int Col)
        {

            int si, sj, i, j, t, f;
            si = l;
            sj = m;

            t = mat[l,m];

            for (i = l + 1; i <= Row; i++)
            {
                f = mat[i,m];
                mat[i,m] = t;
                t = f;
            }
            l++;
            for (i = m + 1; i <= Col; i++)
            {
                f = mat[Row,i];
                mat[Row,i] = t;
                t = f;
            }
            m++;
            if (l - 1 < Row)
            {
                for (i = Row - 1; i >= l - 1; i--)
                {
                    f = mat[i,Col];
                    mat[i,Col] = t;
                    t = f;
                }
            }
            Col--;
            if (m - 1 < Col)
            {
                for (i = Col; i >= m; i--)
                {
                    f = mat[l - 1,i];
                    mat[l - 1,i] = t;
                    t = f;
                }
            }
            Row--;
            mat[si,sj] = t;
            
        }


        static void Main(string[] args)
        {

            
         

            l = 0;
            m = 0;
            Row = 3;
            Col = 3;
            k = 1;
            while (l < Row && m < Col)
            {
                int rot = 2 * (Row - l) + 2 * (Col - m);
                f = k % rot;
                for (i = 1; i <= f; i++)
                {
                    matrixRotation(l, m, Row, Col);
                }
                l++;
                m++;
                Row--;
                Col--;
            }

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                   

                    Console.Write(mat[i , j]);
                }
                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}
