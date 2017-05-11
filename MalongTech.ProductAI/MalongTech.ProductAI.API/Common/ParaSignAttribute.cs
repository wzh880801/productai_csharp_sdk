using System;

namespace MalongTech.ProductAI.API
{
    public class ParaSignAttribute : System.Attribute
    {
        public string Name { get; set; }

        public ParaSignAttribute()
        {

        }

        public ParaSignAttribute(string name)
        {
            this.Name = name;
        }
    }
}