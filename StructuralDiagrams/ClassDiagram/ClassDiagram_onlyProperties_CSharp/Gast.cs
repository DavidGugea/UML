using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram_onlyProperties_CSharp
{
    public class Gast
    {
        // "Class Variables" - or "static" variables in C#. They must be underlined in UML
        public static readonly double MIN = 200;
        public static string status = "König";
        
        // "Instance Variables" - They don't have to be underlined in UML and they are not static, they differ from instance to instance
        private double geldbetrag { get; set; }
        internal bool hunger = true;
        protected string[] freunde = new string[10];
        public char[] alphabet = new char[26];


        public bool freundeEinladen => geldbetrag > MIN;

        public Gast()
        {
            for(int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
        }
    }
}
