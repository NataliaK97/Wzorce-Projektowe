using System;

using System.Collections.Generic;


namespace singleton
{
    public class Lista
    {
        protected static Lista instance = null;
        protected List<int> listaa = new List<int>();


        public static Lista GetInstance()
        {
            if (instance == null)
            {
                instance = new Lista();
            }
            return instance;
        }


        public void addElement(int element)
        {
            listaa.Add(element);
        }


        public void removeElement(int index)
        {
            listaa.RemoveAt(index);
        }


        public void show()
        {
            Console.Write("\n");
            foreach (object element in listaa)
                Console.Write(element + "; ");
        }


        public int howMany()
        {
            return listaa.Count;
        }

    }


    class Programme
    {
        static void Main(string[] args)
        {
            Lista lista01 = Lista.GetInstance();
            lista01.addElement(2);
            lista01.addElement(3);
            lista01.addElement(0);
            lista01.show();

            Lista lista02 = Lista.GetInstance();
            lista01.removeElement(2);
            lista02.show();

            Console.ReadLine();
        }
    }

}