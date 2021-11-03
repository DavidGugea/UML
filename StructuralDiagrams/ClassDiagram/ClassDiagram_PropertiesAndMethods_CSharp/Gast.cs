using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram_PropertiesAndMethods_CSharp
{
    public class Gast
    {
        // PROPERTIES //////////////////////////////////////////////////

        // "Class Variables" - or "static" variables in C#. They must be underlined in UML
        public static readonly double MIN = 200;
        public static string status = "König";

        // "Instance Variables" - They don't have to be underlined in UML and they are not static, they differ from instance to instance
        internal bool hunger = true;
        protected string[] freunde = new string[10];
        public char[] alphabet = new char[26];


        public bool freundeEinladen => _Geldbetrag > MIN;

        public Gast()
        {
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
        }

        // METHODS //////////////////////////////////////////////////

        private double _Geldbetrag;
        public double Geldbetrag
        {
            get => this._Geldbetrag;
            set
            {
                if(value > 0){
                    this._Geldbetrag = value;
                }
            }
        }

        public static string geMINAsString() => MIN.ToString();

        public void SetFreund(string Freund, int pos)
        {
            if(pos >= 0 && pos <= 9)
            {
                freunde[pos] = Freund;
            }
        }
        public string getBesterFreund()
        {
            return freunde[0];
        }
        public string[] getFreunde()
        {
            return freunde;
        }
        public string getAlpabet(int start, int end)
        {
            StringBuilder temp = new StringBuilder();
            for(int i = start; i <= end; i++)
            {
                temp.Append(alphabet[i]);
            }

            return temp.ToString();
        }

        public Gericht bestellt(Menuepunkt menupunkt)
        {
            // The logic of the code doesn't matter, only the structure does.
            return new Gericht();
        }
        public Gericht bestellt(int nummer)
        {
            return new Gericht();
        }
        
        public double zahlt(double d)
        {
            return d;
        }
    }
}
