using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Expert.Core
{
    public class ViewLoader
    {
        public static Control RegisterView(string name = null)
        {
            IEnumerable<Type> types = AppDomain.CurrentDomain.GetAssemblies()
                                                             .Where(x => x.GetName().Name.StartsWith("Expert"))
                                                             .SelectMany(x => x.GetTypes());    //target type
            Control view = null;
            foreach (var type in types)
            {
                if (type != null && name != null && type.Name == name)
                {
                    object obj = Activator.CreateInstance(type); // an instance of target type
                    view = (Control)obj;
                    view.Text = view.Name;
                }
            }
            return view;
        }
    }
}
