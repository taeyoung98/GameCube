using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginClient.Utility
{
	public class CHttp
	{
		public string QueryCreate(Dictionary<string, string> listData)
		{
			StringBuilder sbReturn = new StringBuilder();

			//맨앞의 쿼리시작 문자(?)추가
			sbReturn.Append("?");

			string[] sKeys = listData.Keys.ToArray();
            for(int i = 0; i < listData.Count; ++i )
			{
				sbReturn.Append(sKeys[i]);
				sbReturn.Append("=");
				sbReturn.Append(listData[sKeys[i]]);
				if(i < listData.Count - 1)
				{
					sbReturn.Append("&");
				}
				
			}

			return sbReturn.ToString();
		}
	}
}
