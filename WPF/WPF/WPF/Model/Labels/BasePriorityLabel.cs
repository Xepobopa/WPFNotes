using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Labels
{
    internal class BasePriorityLabel : Label
    {

        public BasePriorityLabel(int id) : base(id, nameof(BasePriorityLabel))
        {
        }
    }
}
