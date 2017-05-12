using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    public struct ContactInfo
    {
        public string telephone;
        public string website;
        public string email;
    }
    [Serializable]
    public struct tempDataToSave
    {
        public string name;
        public string website;
        public string telephone;
        public string mail;
    }
    public class Utilities
    {
        public static void SendLinesToTextFile(string path, List<string> lines)
        {
            try
            {
                StreamWriter sw;
                if (!File.Exists(path))
                {
                    sw = File.CreateText(path);
                }
                else
                {
                    int extraName = 1;
                    while (File.Exists(path + extraName))
                    {
                        extraName++;
                    }
                    sw = File.CreateText(path + extraName);
                }

                foreach (var line in lines)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void SerializeEstablishmentData(string name, string website, string telephone, string mail)
        {
            tempDataToSave toSerialize = new tempDataToSave();
            toSerialize.name = name;
            toSerialize.website = website;
            toSerialize.telephone = telephone;
            toSerialize.mail = mail;

            // Serializes data
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("EstablishmentData.bin", FileMode.Create,
                FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, toSerialize);
            stream.Close();
        }
        public static void LoadSavedEstablishment()
        {
            // Deserializes data
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("EstablishmentData.bin", FileMode.Open,
                FileAccess.Read, FileShare.Read);
            tempDataToSave toDeserialize = (tempDataToSave)formatter.Deserialize(stream);
            stream.Close();
            Establishment.Save(toDeserialize.name, toDeserialize.website, toDeserialize.telephone, toDeserialize.mail);
        }
    }
}
