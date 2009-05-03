using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AppSMS.Settings
{
    //структура для хранения сохраняемой в файл инфы
    public struct Options
    {
        public string key_fname;
        public string left_init_dir;
        public string right_init_dir;
        public string prefix;
        public string key_size;
        public string pwd_file_enc;
        public string def_name_fcont;
    }

    /// <summary>
    /// Класс для сериализации объекта в xml-файл 
    /// </summary>
    public class ManageSetting
    {
        //Лишаем возможности создавать объекты этого класса
        private ManageSetting()
        {

        }

        public static string path_to_set_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "keys.key");

        private static string Cached_Pwd = string.Empty;

        public static bool CreateSettings(object o)
        {
            bool res = false;
            try
            {
                XmlSerializer myXmlSer = new XmlSerializer(o.GetType());
                using (StreamWriter myWriter = new StreamWriter(path_to_set_file))
                {
                    myXmlSer.Serialize(myWriter, o);
                    myWriter.Close();
                }
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                res = false;
            }
            //XmlSerializer myXmlSer = new XmlSerializer(o.GetType());
            //StreamWriter myWriter = new StreamWriter(path_to_set_file);
            //myXmlSer.Serialize(myWriter, o);
            //myWriter.Close();
            return res;
        }

        public static bool LoadSettings(ref Options o)
        {
            bool res = false;
            try
            {
                XmlSerializer myXmlSer = new XmlSerializer(typeof(Options));
                using (FileStream mySet = new FileStream(path_to_set_file, FileMode.Open))
                {
                    o = (Options)myXmlSer.Deserialize(mySet);
                    mySet.Close();
                }

                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                res = false;
            }
            return res;
            //XmlSerializer myXmlSer = new XmlSerializer(typeof(Options));
            //FileStream mySet = new FileStream(path_to_set_file, FileMode.Open);
            //o = (Options)myXmlSer.Deserialize(mySet);
            //mySet.Close();
        }
    }
}
