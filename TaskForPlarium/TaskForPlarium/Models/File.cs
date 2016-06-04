using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForPlarium.Models
{
    class File
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        string dateCreate;
        public string DateCreate { get { return dateCreate; } set { dateCreate = value; } }
        string dateModificate;
        public string DateModificate { get { return dateModificate; } set { dateModificate = value; } }
        string dateLastAccess;
        public string DateLastAccess { get { return dateLastAccess; } set { dateLastAccess = value; } }
        string atribute;
        public string Atribute { get { return atribute; } set { atribute = value; } }
        string owner;
        public string Owner { get { return owner; } set { owner = value; } }
        string access;
        public string Access { get { return access; } set { access = value; } }
        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

    }
}
