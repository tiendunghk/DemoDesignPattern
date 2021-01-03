using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class File : IFile
    {
        private String name;
        private float size;
        public File(String name, float size)
        {
            this.name = name;
            this.size = size;
        }
        public string getName()
        {
            return this.name;
        }

        public float getSize()
        {
            return this.size;
        }
    }
}
