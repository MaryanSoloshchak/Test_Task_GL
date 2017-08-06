using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_GL.models
{
    class DirectorySerializer
    {
        public void Serialize(string pathWhatSerialize, string pathWhereSerialize)
        {
           
            DirectoryNode node = new DirectoryNode(pathWhatSerialize);
            FileInfo file = new FileInfo(pathWhereSerialize);
            FileStream stream = file.Create();
            BinaryFormatter writer = new BinaryFormatter();
            writer.Serialize(stream, node);

            MessageBox.Show("Directory was succesfully serialized into - " + pathWhereSerialize);
            
            stream.Close();
        }
        public void Deserialize(string pathWhatDeserialize, string pathWhereDeserialize)
        {
            FileInfo file = new FileInfo(pathWhatDeserialize);
            FileStream stream = file.Open(FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            DirectoryNode node = (DirectoryNode)formatter.Deserialize(stream);
            stream.Close();
            node.Deserialize(pathWhereDeserialize);
            MessageBox.Show("Directory was succesfully deserialized into - " + pathWhereDeserialize);
        }
    }
}
