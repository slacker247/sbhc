using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothieInterface
{
    public class ReferenceAttribute : Attribute
    {
        protected String m_Value = "";

        public ReferenceAttribute(String value)
        {
            m_Value = value;
        }

        public String Reference
        {
            get
            {
                return m_Value;
            }
            set
            {
                m_Value = value;
            }
        }
    }
}
