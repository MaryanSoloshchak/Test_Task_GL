using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_GL.models
{
    [Serializable]
    public class DirectoryNode : Node
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public DirectoryNode(string fullName)
        {
            this.FullName = fullName;
            DirectoryInfo di = new DirectoryInfo(this.FullName);
            this.Name = di.Name;
            foreach (var item in di.EnumerateDirectories())
            {
                this.nodes.Add(new DirectoryNode(item.FullName));
            }
            foreach (var item in di.EnumerateFiles())
            {
                this.nodes.Add(new FileNode(item));
            }
        }
        public override string ToString()
        {
            return "folder - " + this.FullName;
        }
        public void Deserialize(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach(dynamic item in this.nodes)
            {
                if (item is DirectoryNode)
                {
                    di.CreateSubdirectory(item.Name);
                    item.Deserialize(path + @"\" + item.Name);
                }
                else
                {
                    if (item is FileNode)
                    {
                        item.Deserialize(path);
                    }
                }
            }
        }
    }
}
