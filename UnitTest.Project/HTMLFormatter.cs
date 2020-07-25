using System;
using System.Collections.Generic;
using System.Text;

namespace UnitProject
{
    public class HTMLFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}
