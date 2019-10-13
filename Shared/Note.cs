using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [Serializable]
    public class Note
    {
        private string id;
        private string title;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
    }
}
