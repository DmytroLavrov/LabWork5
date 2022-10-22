using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdTask
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Документ відкритий");
        }

        public virtual void EditDocument()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Правка документа доступна у версії Про");
        }

        public virtual void SaveDocument()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Збереження документа доступне у версії Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Документ збережений в новому форматі");
        }
    }
    
    class Program
    {
        static void Main()
        {
            DocumentWorker worker = new DocumentWorker();
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Введіть ключ доступу:");
            string product_key = Console.ReadLine();
            int key = Convert.ToInt32(product_key);

            switch (key)
            {
                case 11223344:
                    DocumentWorker pro = new ProDocumentWorker();
                    Console.WriteLine("Вітаємо! Ви отримали версію ПРО.");
                    break;
                case 22334455:
                    ProDocumentWorker expert = new ExpertDocumentWorker();
                    Console.WriteLine("Вітаємо! Ви отримали версію Експерт.");
                    break;
                default:
                    Console.WriteLine("Ключ доступу - неправильний. Ви отримали безкоштовну версію.");
                    break;
            }

            Console.ReadLine();
        }
    }
}