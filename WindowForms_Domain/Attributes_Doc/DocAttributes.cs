using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForms_Domain.Attributes_Doc
{
    /// <summary>
    /// Класс отвечающий за методанные для свойств класса 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DocAttributes : Attribute
    {
        public string DocName { get; set; } 
        public DocAttributes(string name) { this.DocName = name; }
    }
}
