 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth_Login.Login.OAuth.Naver
{
    public class Man 
    {
        public Dictionary<string, string> manInfo = new Dictionary<string, string>();
        //public string name; // 10자 이내로 구성된 문자열
        //public string nickname; // 20자 이내로 구성된 문자열
        //public string email; // 이메일 규격의 문자열
        //public string birthday; // 월-일 (MM-DD) 형태의 문자열
        //public string age; // 연령 구간에 따라 0-9 / ~ / 60- 으로 표현된 문자열
        //public string gender; // M/F (남성/여성) 으로 표된 문자

        public Man()
        {

        }
        public Man(string name, string nickname, string email, string birth, string age, string gender)
        {
            manInfo.Add("name", name);
            manInfo.Add("nickname", nickname);
            manInfo.Add("email", email);
            manInfo.Add("birthday", birth);
            manInfo.Add("age", age);
            manInfo.Add("gender", gender);
        }
    }
}
