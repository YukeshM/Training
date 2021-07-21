using System;
using System.Text;

namespace Domain
{
    public class DomainClass
    {
        public string FindString(StringBuilder stringBuilder, string text)
        {
            string result = stringBuilder.ToString();
            if (result.Contains(text))
            {
                return "The given sub string is in the string.";
            }
            else
            {
                throw new Exception("The given sub string is not found in the string.");
            }
        }
    }
}
