using System.Collections.Generic;

namespace SE.WebFrontEnd.Configs
{
    public class Language
    {
        public static string Current { get; set; } = "en_US";
        public string Code { get; set; }
        public List<NameValue> Value { get; set; }
    }
}