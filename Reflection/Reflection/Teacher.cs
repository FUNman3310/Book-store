using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Teacher
    {
        private int _id;
        public string Reshad;
        public string Name { get; set; }

        public byte Age { get; set; }
        public int Id { get { return _id; } set { _id = value; } }

        public void ShowInfo()
        {
            Console.WriteLine( "Hello teacher");
        }

    }
}
