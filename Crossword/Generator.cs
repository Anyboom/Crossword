using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossword
{
    class Generator
    {
        public readonly char?[,] Field;

        private List<string> ListOfWords;
        public readonly List<string> ListOfExcessWords;
        public readonly List<string> ListOfUseWords;

        public Generator(string[] listOfWords, int sizeX, int sizeY)
        {
            Field = new char?[sizeX, sizeY];
            ListOfWords = listOfWords.ToList<string>();
            ListOfExcessWords = new List<string>();
            ListOfUseWords = new List<string>();
        }

        public void Generate()
        {
            Random rnd = new Random(Environment.TickCount);

            int tempIndex = rnd.Next(ListOfWords.Count
                 - 1);

            string word = ListOfWords.ElementAt(tempIndex);
            ListOfWords.RemoveAt(tempIndex);

            ListOfUseWords.Add(word);

            for ( int i = 0; i < word.Length && (Field.GetLength(0) / 2) - i > 0; i++ )
            {
                Field[(Field.GetLength(0) / 2) + i, (Field.GetLength(0) / 2)] = word[i];
            }

            while ( true )
            {
                word = ListOfWords.ElementAt(0);
                ListOfWords.RemoveAt(0);

                try
                {
                    for ( int x = 0; x < Field.GetLength(0); x++ )
                    {
                        for ( int y = 0; y < Field.GetLength(1); y++ )
                        {
                            for ( int indexChar = 0; indexChar < word.Length; indexChar++ )
                            {
                                if ( Field[x, y] != word[indexChar] )
                                {
                                    continue;
                                }

                                if ( ListOfUseWords.Contains(word) )
                                {
                                    break;
                                }

                                if ( ((FieldHelper.IsNullCellTop(Field, x, y) && FieldHelper.IsNotNullBottom(Field, x, y)) ||
                                    (FieldHelper.IsNotNullTop(Field, x, y) && FieldHelper.IsNotNullBottom(Field, x, y)) ||
                                    (FieldHelper.IsNotNullTop(Field, x, y) && FieldHelper.IsNullCellBottom(Field, x, y))) &&
                                    (FieldHelper.IsNullCellLeft(Field, x, y) && FieldHelper.IsNullCellRigth(Field, x, y)) )
                                {
                                    bool error = false;

                                    for ( int i = 0; i < word.Length + 1; i++ )
                                    {
                                        if ( i == indexChar )
                                        {
                                            continue;
                                        }

                                        if ( FieldHelper.IsNotNullCell(Field, x - indexChar - 1, y) ||
                                             FieldHelper.IsNotNullTop(Field, x - indexChar - 1, y) ||
                                             FieldHelper.IsNotNullBottom(Field, x - indexChar - 1, y) )
                                        {
                                            error = true;
                                        }

                                        if ( FieldHelper.IsNotNullCell(Field, x - indexChar + i, y) ||
                                             FieldHelper.IsNotNullTop(Field, x - indexChar + i, y) ||
                                             FieldHelper.IsNotNullBottom(Field, x - indexChar + i, y) )
                                        {
                                            error = true;
                                        }
                                    }

                                    if ( error )
                                    {
                                        continue;
                                    }

                                    for ( int i = 0; i < word.Length; i++ )
                                    {
                                        Field[x - indexChar + i, y] = word[i];
                                    }

                                    ListOfUseWords.Add(word);

                                    break;
                                }

                                if ( ((FieldHelper.IsNullCellLeft(Field, x, y) && FieldHelper.IsNotNullRigth(Field, x, y)) ||
                                    (FieldHelper.IsNotNullLeft(Field, x, y) && FieldHelper.IsNotNullRigth(Field, x, y)) ||
                                    (FieldHelper.IsNotNullLeft(Field, x, y) && FieldHelper.IsNullCellRigth(Field, x, y))) &&
                                    (FieldHelper.IsNullCellTop(Field, x, y) && FieldHelper.IsNullCellBottom(Field, x, y)) )
                                {
                                    bool error = false;

                                    for ( int i = 0; i < word.Length + 1; i++ )
                                    {
                                        if ( i == indexChar )
                                        {
                                            continue;
                                        }

                                        if ( FieldHelper.IsNotNullCell(Field, x, y - indexChar - 1) ||
                                             FieldHelper.IsNotNullLeft(Field, x, y - indexChar - 1) ||
                                             FieldHelper.IsNotNullRigth(Field, x, y - indexChar - 1) )
                                        {
                                            error = true;
                                        }

                                        if ( FieldHelper.IsNotNullCell(Field, x, y - indexChar + i) ||
                                             FieldHelper.IsNotNullLeft(Field, x, y - indexChar + i) ||
                                             FieldHelper.IsNotNullRigth(Field, x, y - indexChar + i) )
                                        {
                                            error = true;
                                        }
                                    }

                                    if ( error )
                                    {
                                        continue;
                                    }

                                    for ( int i = 0; i < word.Length; i++ )
                                    {
                                        Field[x, y - indexChar + i] = word[i];
                                    }

                                    ListOfUseWords.Add(word);

                                    break;
                                }
                            }
                        }
                    }
                }
                catch ( IndexOutOfRangeException )
                {
                    ListOfExcessWords.Add(word);
                }

                if(ListOfWords.Count == 0 )
                {
                    break;
                }
            }
        }
    }
}
