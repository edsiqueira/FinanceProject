using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Enum
{
    public static class EnumTranslate
    {
        public static int GetEnum(string ramoAtividade)
        {
            switch (ramoAtividade)
            {
                case "Energia":
                    return 3;
                case "TVNet":
                    return 2;
                case "Telemovel":
                    return 1;
                default:
                    return 0;
            }
        }

        public static Dictionary<int, string> GetId(System.Enum enumerator) 
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();

            foreach (var item in enumerator.GetType().GetEnumValues())
            {
                dic.Add((int)item, item.ToString());
            }
            return dic;
        }
    }
}
