using MSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class SharedView : GenericModule
    {
        public SharedView()
        {
            HeaderText("SharedView @info.Mode");
            ViewModelProperty<string>("Mode");
        }
    }
}
