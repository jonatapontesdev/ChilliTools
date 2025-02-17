using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JPRagTools.Utils;
using System.Drawing;
using System.Windows.Input;

namespace JPRagTools.Model
{
    internal class BuffContainer
    {
        public GroupBox container { get; set; }
        public List<Buff> skills { get; set; }

        public BuffContainer(GroupBox p, List<Buff> skills)
        {
            this.skills = skills;
            this.container = p;
        }
    }
}
