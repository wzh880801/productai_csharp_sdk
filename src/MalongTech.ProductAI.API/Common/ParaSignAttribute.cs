using System;

namespace MalongTech.ProductAI.API
{
    public class ParaSignAttribute : System.Attribute
    {
        public string Name { get; set; }

        public bool IsNeedUrlEncode { get; set; }

        public ParaSignAttribute()
        {

        }

        public ParaSignAttribute(string name, bool isNeedUrlEncode = false)
        {
            this.Name = name;
            this.IsNeedUrlEncode = isNeedUrlEncode;
        }
    }
}