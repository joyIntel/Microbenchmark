using System;
using System.Threading;


namespace Microbenchmark
{
    class Program
    {
        
    const int NUM_ITERS_CONCAT = 10;
    const int NUM_ITERS = 5000;

    public static String s1 = "11234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s2 = "21234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s3 = "31234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s4 = "41234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s5 = "51234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s6 = "61234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s7 = "71234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s8 = "81234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s9 = "91234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s10 = "01234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    static void A()
    {
        string str = null;

        for (long i = 0; i < NUM_ITERS; i++)
        {
            for (int j = 0; j < NUM_ITERS_CONCAT; j++)
            {
                str += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
            }

            str = "";
            
        }	
			Console.WriteLine("A");            
    }
	
	static void B()
    {	
	
	string str = null;
	for (long i = 0; i < NUM_ITERS; i++)
        {
            for (int j = 0; j < NUM_ITERS_CONCAT; j++)
            {
                str += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10 
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
            }

            str = "";
            
        }	
        Thread.Sleep(100);
        Console.WriteLine('B');
    }
	
	static void C()
    {	
	string str = null;
		for (long i = 0; i < NUM_ITERS; i++)
        {
            for (int j = 0; j < NUM_ITERS_CONCAT; j++)
            {
                str += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
		    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
            }

            str = "";
            
        }	
        Thread.Sleep(100);
        Console.WriteLine('C');
    }

	static void D()
    {	
	
		string[,] array2D1 = new string[,] { { "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" }};
        string[,] array2D2 = new string[,] { { "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" }};
		string[,] array2D3 = new string[,] { { "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" }};
        string[,] array2D4 = new string[,] { { "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" }};
		string[,] array2D5 = new string[,] { { "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" }};
        string[,] array2D6 = new string[,] { { "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" },{ "one", "two" }, { "three", "four" },{ "five", "six" }};
                                   
		string str = null;
		for (long i = 0; i < NUM_ITERS; i++)
        {
            for (int j = 0; j < NUM_ITERS_CONCAT; j++)
            {
                str += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10                    
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
            }

            str = "";
            
        }	
        Thread.Sleep(100);
        Console.WriteLine('D');
    }

	static void E()
    {	
		int[,] array2D1 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};
		int[,] array2D2 = new int[,] { { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};
		int[,] array2D3 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};
		int[,] array2D4 = new int[,] { { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};
		int[,] array2D5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};
		int[,] array2D6 = new int[,] { { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};
		int[,] array2D7 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};
		int[,] array2D8 = new int[,] { { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 } ,{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 },{ 3, 4 }, { 5, 6 }, { 7, 8 }};

		string str = null;
		for (long i = 0; i < NUM_ITERS; i++)
        {
            for (int j = 0; j < NUM_ITERS_CONCAT; j++)
            {
                str += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10                    
                    + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
            }

            str = "";
            
        }	
        Thread.Sleep(100);
        Console.WriteLine('E');
    }

	
	public static void Main(string[] p_args)
    {
		Thread thread1 = new Thread(new ThreadStart(A));
        	Thread thread2 = new Thread(new ThreadStart(B));
		Thread thread3 = new Thread(new ThreadStart(C));
        	Thread thread4 = new Thread(new ThreadStart(D));
		Thread thread5 = new Thread(new ThreadStart(E));        
        	thread1.Start();
        	thread2.Start();
		thread3.Start();
        	thread4.Start();
		thread5.Start();        
        	thread1.Join();
        	thread2.Join();
		thread3.Join();
        	thread4.Join();
		thread5.Join();
        
	}
    }
}
