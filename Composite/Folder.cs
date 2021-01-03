using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Folder : IFile
    {
        protected List<IFile> files = new List<IFile>();
        protected String name;
        protected float size;
        public Folder(String name)
        {
            this.name = name;
            this.size = 0;
        }
        public string getName()
        {
            return this.name;
        }

        public float getSize()
        {
            foreach (IFile file in this.files)
            {
                this.size += file.getSize();
            }
            return this.size;
        }
        public void addFile(IFile file)
        {
            files.Add(file);
        }

        public void removeFile(IFile file)
        {
            files.Remove(file);
        }
    }
}
