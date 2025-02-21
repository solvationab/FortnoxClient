using System;
using Refit;
using System.Reflection;

namespace FortnoxClient.UrlParameterFormatters
{
    public class FortnoxUrlParameterFormatter : IUrlParameterFormatter
    {
        public string Format(object value, ICustomAttributeProvider attributeProvider, Type type)
        {
            if (value is DateTime date)
            {
                return date.ToString("yyyy-MM-dd");
            }

            return value?.ToString();
        }
    }
}
