using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo.Encapsulation
{
    internal struct PhoneNotebook
    {
        #region Attributes
        private string[]? names;
        private int[]? numbers;
        private int size;
        #endregion

        #region Constructor
        public PhoneNotebook(int noteSize)
        {
            size = noteSize;
            names = new string[size];
            numbers = new int[size];
        }
        #endregion
        #region Property
        public int Size { 
            get { return size; }
        }
        #endregion
        #region Methods
        public void AddNewPerson(int position, string name,int number)
        {
            if (names is not null && numbers is not null)
            {
                if (position <size && position >0)
                {
                    names[position] = name;
                    numbers[position] = number;
                }
            }
        }
        #endregion
        #region Getter Setter
        //Getter
        public int GetNumber(string name)
        {

            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }

        //Setter
        public void setNumber(string name, int newNumber)
        {

            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = newNumber;
                    return;
                    }
                    //break;
                }
            }
        }
        #endregion
        #region Indexer
        public int this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            return;
                        }
                        //break;
                    }
                }
            }
        }
        #endregion
    }
}
