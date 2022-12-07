using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    public class Book
    {
        private static int _counter;

        private double _price;
        public string Name { get; set; }
        public string AuthorName { get; set; }

        public int PageCount { get; set; } 

        public double Price { get {return this._price;}
            set
            {
                if (value>0&&value<100000)
                {
                    this._price = value;
                }
            } 
        }

        public string Code { get; set; }

        static Book()
        {
            _counter=0;
        }

        public Book(string name, string surname, double price)
        {
            this.Name = name;
            this.AuthorName = surname;
            this.Price = price;
            this.Code = MakeCode(name);
        }

        private string MakeCode(string name)
        {
            string AB = "";
            if (name[0]==' ')
            {
                AB +=name[0];
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i]==' ')
                {
                    AB += name[i + 1];
                }
            }
            _counter++;
            return AB.ToUpper()+"-"+_counter;
        }


    }
}
