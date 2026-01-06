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



class Result
{

    /*
     * Complete the 'isNonTrivialRotation' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts the following parameters:
     *  1. STRING s1
     *  2. STRING s2
     */

private static bool EasyCSCheck(string s1, string s2){
    return (s1 + s1).Contains(s2);    
}
private static bool BruteForceCSCheck(string s1, string s2){
    char[] s1Array = s1.ToCharArray();
        char[] s2Array = s2.ToCharArray();
            
        for(int i = 0 ;i<=s1Array.Length;i++){
            
            char valueCarried=s1Array[s1Array.Length-1];
            for(int j=s1Array.Length-1;j>0;j--){
                s1Array[j]=s1Array[j-1];
            }
            s1Array[0]=valueCarried;
            string result = new string(s1Array);
            if(result==s2){
                return true;
            }
        }
        return false;
    }

    public static bool isNonTrivialRotation(string s1, string s2)
    {
        if(String.IsNullOrEmpty(s1)||String.IsNullOrEmpty(s2)|| String.Equals (s1,s2)){ 
            return false;
        }
        return EasyCSCheck(s1,s2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This program checks for a non identical strings rotated. If one of them is the rotation it will return true");
        Console.WriteLine("Write a text");
        string s1 = Console.ReadLine();

        Console.WriteLine("Write any text or a text rotated");
        string s2 = Console.ReadLine();

        bool result = Result.isNonTrivialRotation(s1, s2);

        Console.WriteLine((result ? 1 : 0));
    }
}
