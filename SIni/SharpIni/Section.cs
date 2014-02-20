using System;
using System.Collections.Generic;
using System.Text;

namespace SIni.SharpIni
{
    class Section
    {
        private struct Key
        {
            public String name;
            public String val;
        };

        private String name = null;
        private List<Key> keys = new List<Key>();

        public Section(String name)
        {
            if (name.Length > 0) {
                if (!name[0].Equals('['))               { name = name.Insert(0, "["); }
                if (!name[name.Length-1].Equals(']')) { name = name.Insert(name.Length, "]"); }
                

                this.name = name;
            }
        }

        public void CreateKey(String name, String val)
        {
            Key k;
            k.name = name;
            k.val = val;
            keys.Add(k);
        }

        public List<Key> Keys
        {
            get
            {
                return keys;
            }

            set
            {
                this.keys = value;
            }
        }

        public override string ToString()
        {
            String sec = "";
            sec += name + '\n';

            for (int i = 0; i < keys.Count; i++)
                sec += (keys[i].name + '=' + keys[i].val + '\n');
        
            return sec;
        }
    }
}
