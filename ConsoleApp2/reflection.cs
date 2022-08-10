using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Reflection
    {
        public object returnClass(Dictionary<string, string> input, object theclass)
        {
            foreach (PropertyInfo prop in theclass.GetType().GetProperties())
            {
                if (input.ContainsKey(prop.Name))
                {
                    if (prop.PropertyType == typeof(bool))
                    {
                        bool value = input[prop.Name].Equals("true") ? true : false;
                        prop.SetValue(theclass, Convert.ToBoolean(value), null);
                    }
                }
            }
            return theclass;
        }
    }
}
