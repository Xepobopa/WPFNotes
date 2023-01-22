using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Labels
{
    public class Label
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        protected Label(int id, string name)
        {
            Id = id;
            Name = name;
        }
        private Label()
        {}
    }
}
