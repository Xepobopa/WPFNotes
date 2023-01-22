using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Labels
{
    internal class HighPriorityLabel : Label
    {
        public HighPriorityLabel(int id) : base(id, nameof(HighPriorityLabel))
        {
        }
    }
}
