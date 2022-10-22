using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace SecondTask
{
    class ClassRoom
    {
        Pupil[] NumPupil;
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            NumPupil = new Pupil[] { pupil1, pupil2, pupil3, pupil4 };
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            NumPupil = new Pupil[] { pupil1, pupil2, pupil3 };
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            NumPupil = new Pupil[] { pupil1, pupil2 };
        }

        public void Study()
        {
            Console.WriteLine("Study");
            foreach (Pupil pupil in NumPupil)
            {
                pupil.Study();
            }
        }

        public void Read()
        {
            Console.WriteLine("Read");
            foreach (Pupil pupil in NumPupil)
            {
                pupil.Read();
            }
        }

        public void Write()
        {
            Console.WriteLine("Write");
            foreach (Pupil pupil in NumPupil)
            {
                pupil.Write();
            }
        }

        public void Relax()
        {
            Console.WriteLine("Relax");
            foreach (Pupil pupil in NumPupil)
            {
                pupil.Relax();
            }
        }
    }

    class Pupil
    {
        private string pupil;

        public virtual void Study()
        {
            Console.WriteLine("Study");
        }

        public virtual void Read()
        {
            Console.WriteLine("Read");
        }

        public virtual void Write()
        {
            Console.WriteLine("Write");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Relax");
        }

        public string name
        {
            get { return pupil; }
            set { pupil = value; }
        }

        public Pupil(string pupil)
        {
            name = pupil;
        }
    }

    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string pupil) : base(pupil)
        { }

        public override void Study()
        {
            Console.WriteLine($"{name} study excelent");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} read excelent");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} write excelent");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} relax excelent");
        }
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string pupil) : base(pupil)
        { }

        public override void Study()
        {
            Console.WriteLine($"{name} study good");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} read good");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} write good");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} relax good");
        }
    }

    class BadPupil : Pupil
    {
        public BadPupil(string pupil) : base(pupil)
        { }

        public override void Study()
        {
            Console.WriteLine($"{name} study bad");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} read bad");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} write bad");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} relax bad");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            ClassRoom CR = new ClassRoom(new ExcelentPupil("Ілля"), new GoodPupil("Андрій"), new BadPupil("Максим"));
            CR.Study();
            CR.Read();
            CR.Write();
            CR.Relax();
            Console.ReadLine();
        }
    }
}