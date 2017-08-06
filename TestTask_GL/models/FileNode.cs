using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_GL.models
{
    [Serializable]
    public class FileNode : Node
    {
        public string FullName { get; set; }
        public List<byte> Data { get; set; }
        public FileNode(FileInfo file)
        {
            this.FullName = file.FullName;
            var stream = file.Open(FileMode.Open,FileAccess.Read,FileShare.None);
            this.Data = new List<byte>(10000);
            for(int i =0;i<file.Length;++i)
            {
                this.Data.Add((byte)stream.ReadByte());
            }
            stream.Close();
        }
        public override string ToString()
        {
            return "file - "+ this.FullName;
        }
        public void Deserialize(string path)
        {
            FileInfo fi = new FileInfo(path + @"\"+this.FullName.Substring(this.FullName.LastIndexOf(@"\")));
            FileStream stream = fi.Create();
            foreach(var item in this.Data)
            {
                stream.WriteByte(item);
            }
            stream.Close();
        }
    }
}
