    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExamples
{
    class Program
    {
        public static void ser()
        {
            FileStream fs = new FileStream(@"F:\c# labs\week 4\complex\data.der", FileMode.Create, FileAccess.Write);
            Complex s = new Complex();
            BinaryFormatter bf = new BinaryFormatter();
            


            try
            {
                bf.Serialize(fs, 0);

            }
            catch(Exception e)
            {
                
            {
                    Console.WriteLine(e.Message);
                }  }
            finally
            {
                fs.Close();
            }
            Console.WriteLine("FINISHED");
            }
        static void deser()
        {
            FileStream fs = new FileStream(@"F:\c# labs\week 4\complex\data.der", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            try {
                Complex s = (Complex)bf.Deserialize(fs);
                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }


        }


        static void Main(string[] args)
        {

            ser();
            deser();
            Console.ReadKey();
        }
    }
}