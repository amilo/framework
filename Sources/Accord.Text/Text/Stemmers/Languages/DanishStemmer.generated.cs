// This file was generated automatically by the Snowball to C# compiler

#pragma warning disable 0164
#pragma warning disable 0162

namespace Accord.MachineLearning.Text.Stemmers
{
    using System;
    using System.Text;
    
    ///<summary>
    ///  This class was automatically generated by a Snowball to C# compiler 
    ///  It implements the stemming algorithm defined by a snowball script.
    ///</summary>
    /// 
    [System.CodeDom.Compiler.GeneratedCode("Snowball", "1.0.0")]
    public partial class DanishStemmer : StemmerBase
    {
        private int I_x;
        private int I_p1;
        private StringBuilder S_ch = new StringBuilder();

        private static string g_v = "aeiouy\u00E6\u00E5\u00F8";
        private static string g_s_ending = "abcdfghjklmnoprtvyz\u00E5";
        private readonly Among[] a_0;
        private readonly Among[] a_1;
        private readonly Among[] a_2;

        /// <summary>
        ///   Initializes a new instance of the <see cref="DanishStemmer"/> class.
        /// </summary>
        /// 
        public DanishStemmer()
        {
            a_0 = new[] 
            {
                new Among("hed", -1, 1),
                new Among("ethed", 0, 1),
                new Among("ered", -1, 1),
                new Among("e", -1, 1),
                new Among("erede", 3, 1),
                new Among("ende", 3, 1),
                new Among("erende", 5, 1),
                new Among("ene", 3, 1),
                new Among("erne", 3, 1),
                new Among("ere", 3, 1),
                new Among("en", -1, 1),
                new Among("heden", 10, 1),
                new Among("eren", 10, 1),
                new Among("er", -1, 1),
                new Among("heder", 13, 1),
                new Among("erer", 13, 1),
                new Among("s", -1, 2),
                new Among("heds", 16, 1),
                new Among("es", 16, 1),
                new Among("endes", 18, 1),
                new Among("erendes", 19, 1),
                new Among("enes", 18, 1),
                new Among("ernes", 18, 1),
                new Among("eres", 18, 1),
                new Among("ens", 16, 1),
                new Among("hedens", 24, 1),
                new Among("erens", 24, 1),
                new Among("ers", 16, 1),
                new Among("ets", 16, 1),
                new Among("erets", 28, 1),
                new Among("et", -1, 1),
                new Among("eret", 30, 1)
            };

            a_1 = new[] 
            {
                new Among("gd", -1, -1),
                new Among("dt", -1, -1),
                new Among("gt", -1, -1),
                new Among("kt", -1, -1)
            };

            a_2 = new[] 
            {
                new Among("ig", -1, 1),
                new Among("lig", 0, 1),
                new Among("elig", 1, 1),
                new Among("els", -1, 1),
                new Among("l\u00F8st", -1, 2)
            };

        }



        private int r_mark_regions()
        {
            // (, line 29
            I_p1 = limit;
            // test, line 33
            {
                int c1 = cursor;
                // (, line 33
                // hop, line 33
                {
                    int ret = cursor + 3;
                    if (0 > ret || ret > limit)
                    {
                        return 0;
                    }
                    cursor = ret;
                }
                // setmark x, line 33
                I_x = cursor;
                cursor = c1;
            }
            if (out_grouping(g_v, 97, 248, true) < 0)
            {
                return 0;
            }
 /* goto */            {
                /* gopast */ 
                int ret = in_grouping(g_v, 97, 248, true);
                if (ret < 0)
                {
                    return 0;
                }

                cursor += ret;
            }
            // setmark p1, line 34
            I_p1 = cursor;
            // try, line 35
            // (, line 35
            if (!(I_p1 < I_x))
            {
                goto lab0;
            }
            I_p1 = I_x;
        lab0: ; 

            return 1;
        }

        private int r_main_suffix()
        {
            int among_var;
            // (, line 40
            // setlimit, line 41
            int c1 = limit - cursor;
            // tomark, line 41
            if (cursor < I_p1)
            {
                return 0;
            }
            cursor = I_p1;
            int c2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - c1;
            // (, line 41
            // [, line 41
            ket = cursor;
            // substring, line 41
            among_var = find_among_b(a_0);
            if (among_var == 0)
            {
                {
                    limit_backward = c2;
                    return 0;
                }
            }
            // ], line 41
            bra = cursor;
            limit_backward = c2;
            switch (among_var) 
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    // (, line 48
                    // delete, line 48
                    slice_del();
                    break;
                case 2:
                    // (, line 50
                    if (in_grouping_b(g_s_ending, 97, 229, false) != 0)
                    {
                        return 0;
                    }
                    // delete, line 50
                    slice_del();
                    break;
            }

            return 1;
        }

        private int r_consonant_pair()
        {
            // (, line 54
            // test, line 55
            {
                int c1 = limit - cursor;
                // (, line 55
                // setlimit, line 56
                int c2 = limit - cursor;
                // tomark, line 56
                if (cursor < I_p1)
                {
                    return 0;
                }
                cursor = I_p1;
                int c3 = limit_backward;
                limit_backward = cursor;
                cursor = limit - c2;
                // (, line 56
                // [, line 56
                ket = cursor;
                // substring, line 56
                if (find_among_b(a_1) == 0)
                {
                    {
                        limit_backward = c3;
                        return 0;
                    }
                }
                // ], line 56
                bra = cursor;
                limit_backward = c3;
                cursor = limit - c1;
            }
            // next, line 62
            if (cursor <= limit_backward)
            {
                return 0;
            }
            cursor--;
            // ], line 62
            bra = cursor;
            // delete, line 62
            slice_del();

            return 1;
        }

        private int r_other_suffix()
        {
            int among_var;
            // (, line 65
            // do, line 66
            {
                int c1 = limit - cursor;
                // (, line 66
                // [, line 66
                ket = cursor;
                // literal, line 66
                if (!(eq_s_b("st")))
                {
                    goto lab0;
                }
                // ], line 66
                bra = cursor;
                // literal, line 66
                if (!(eq_s_b("ig")))
                {
                    goto lab0;
                }
                // delete, line 66
                slice_del();
            lab0: ; 
                cursor = limit - c1;
            }
            // setlimit, line 67
            int c2 = limit - cursor;
            // tomark, line 67
            if (cursor < I_p1)
            {
                return 0;
            }
            cursor = I_p1;
            int c3 = limit_backward;
            limit_backward = cursor;
            cursor = limit - c2;
            // (, line 67
            // [, line 67
            ket = cursor;
            // substring, line 67
            among_var = find_among_b(a_2);
            if (among_var == 0)
            {
                {
                    limit_backward = c3;
                    return 0;
                }
            }
            // ], line 67
            bra = cursor;
            limit_backward = c3;
            switch (among_var) 
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    // (, line 70
                    // delete, line 70
                    slice_del();
                    // do, line 70
                    {
                        int c4 = limit - cursor;
                        {
                            // call consonant_pair, line 70
                            int ret = r_consonant_pair();
                            if (ret == 0)
                                goto lab1;
                            else if (ret < 0)
                                return ret;
                        }
                    lab1: ; 
                        cursor = limit - c4;
                    }
                    break;
                case 2:
                    // (, line 72
                    // <-, line 72
                    slice_from("l\u00F8s");
                    break;
            }

            return 1;
        }

        private int r_undouble()
        {
            // (, line 75
            // setlimit, line 76
            int c1 = limit - cursor;
            // tomark, line 76
            if (cursor < I_p1)
            {
                return 0;
            }
            cursor = I_p1;
            int c2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - c1;
            // (, line 76
            // [, line 76
            ket = cursor;
            if (out_grouping_b(g_v, 97, 248, false) != 0)
            {
                {
                    limit_backward = c2;
                    return 0;
                }
            }
            // ], line 76
            bra = cursor;
            // -> ch, line 76
            S_ch = slice_to(S_ch);
            limit_backward = c2;
            // name ch, line 77
            if (!(eq_s_b(S_ch)))
            {
                return 0;
            }
            // delete, line 78
            slice_del();

            return 1;
        }

        private int stem()
        {
            // (, line 82
            // do, line 84
            {
                int c1 = cursor;
                {
                    // call mark_regions, line 84
                    int ret = r_mark_regions();
                    if (ret == 0)
                        goto lab0;
                    else if (ret < 0)
                        return ret;
                }
            lab0: ; 
                cursor = c1;
            }
            // backwards, line 85
            limit_backward = cursor; cursor = limit;
            // (, line 85
            // do, line 86
            {
                int c2 = limit - cursor;
                {
                    // call main_suffix, line 86
                    int ret = r_main_suffix();
                    if (ret == 0)
                        goto lab1;
                    else if (ret < 0)
                        return ret;
                }
            lab1: ; 
                cursor = limit - c2;
            }
            // do, line 87
            {
                int c3 = limit - cursor;
                {
                    // call consonant_pair, line 87
                    int ret = r_consonant_pair();
                    if (ret == 0)
                        goto lab2;
                    else if (ret < 0)
                        return ret;
                }
            lab2: ; 
                cursor = limit - c3;
            }
            // do, line 88
            {
                int c4 = limit - cursor;
                {
                    // call other_suffix, line 88
                    int ret = r_other_suffix();
                    if (ret == 0)
                        goto lab3;
                    else if (ret < 0)
                        return ret;
                }
            lab3: ; 
                cursor = limit - c4;
            }
            // do, line 89
            {
                int c5 = limit - cursor;
                {
                    // call undouble, line 89
                    int ret = r_undouble();
                    if (ret == 0)
                        goto lab4;
                    else if (ret < 0)
                        return ret;
                }
            lab4: ; 
                cursor = limit - c5;
            }
            cursor = limit_backward;

            return 1;
        }

        /// <summary>
        ///   Stems the buffer's contents.
        /// </summary>
        /// 
        protected override bool Process()
        {
            return this.stem() > 0;
        }

    }
}

