using AppClassLibraryDomain.model;
using System.ComponentModel;

namespace WindowsForms
{
    public class FormBase : Form
    {
        public FormBase() : base() { }
        public SistemaEnum? Sistema
        {
            get
            {
                foreach (var field in typeof(SistemaEnum).GetFields())
                {
                    if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                        if (attribute.Description == AppDomain.CurrentDomain.FriendlyName.Split('.')[0])
                            return (SistemaEnum)field.GetValue(null);
                        else if (field.Name == AppDomain.CurrentDomain.FriendlyName.Split('.')[0])
                            return (SistemaEnum)field.GetValue(null);
                }
                return null;
            }
        }
    }
}
