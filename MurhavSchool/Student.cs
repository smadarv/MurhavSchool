using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurhavSchool
{
    class Student
    {
        // תכונות
        private string name;
        private string id;
        private int grade1;
        private int grade2;
        private int grade3;

        public Student(string n, string id, int grade1, int g2, int g3) //  פעולה בונה - בנאי - Constractor
        {
            this.name = n;
            this.id = id;
            this.grade1 = grade1;
            this.grade2 = g2;
            this.grade3 = g3;
        }
        public double Avg()  // פעולה פנימית המחזירה את ממוצע התלמיד
        {
            return (double)(this.grade1 + this.grade2 + this.grade3) / 3;
        }

        //public void Print() // פעולה פנימית המדפיסה את פרטי התלמיד
        //{

        //  // Console.WriteLine("name={0}\n id={1}\n g1={2}\n g2={3}\n g3={4}", this.name, this.id, this.grade1, this.grade2, this.grade3);

        //    Console.WriteLine($"name={this.name}\n id={this.id}\n g1={this.grade1}\n g2={this.grade2}\n g3={ this.grade3}"  );
        //}

        public override string ToString()
        {

            return $"name={this.name}\n id={this.id}\n g1={this.grade1}\n g2={this.grade2}\n g3={ this.grade3}";
        }

        public string GetName()
        {
            return this.name;
        }
        public int GetGrade1()
        {
            return this.grade1;
        }

        public void SetGrade1(int g1)
        {
            this.grade1 = g1;
        }

    }
}
