using Newtonsoft.Json.Linq;
using OAuth_Login.Login.OAuth.Naver;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace LoginClient.OAuth
{
    public class COAuth_Naver : COAuth
	{
		/// <summary>
		/// 사용할 브라우저 컨트롤
		/// </summary>
		private WebBrowser m_webAuth;
        //public List<Man> men = new List<Man>();
        public string re1, re2, re3, re4, re5, re6;

		public COAuth_Naver(WebBrowser wbAuth)
		{
			this.m_webAuth = wbAuth;
			this.Reset();
		}

		protected override void Reset()
		{
			base.ClientID = "bgok9b2Lx49zDKt7bKtz";
			base.ClientSecret = "X81J2dBin5";
			base.RedirectURL = "https://giphy.com/gifs/interactive-xUbVzuNjpWe0E/tile";

            base.RedirectURL_uri = new Uri(this.RedirectURL);

			//확인용 키 생성
			base.State = (new Random()).Next().ToString();
			base.AuthToken = "";

			//인증요청용 전체 URL(쿼리 포함) 생성
			NameValueCollection listAuthURL_QueryString = HttpUtility.ParseQueryString(string.Empty);
			listAuthURL_QueryString["response_type"] = "code";
			listAuthURL_QueryString["client_id"] = base.ClientID;
			listAuthURL_QueryString["redirect_uri"] = base.RedirectURL;
			listAuthURL_QueryString["state"] = base.State;

			base.AuthURL = "https://nid.naver.com/oauth2.0/authorize?" + listAuthURL_QueryString.ToString();

			//이벤트 연결
			this.m_webAuth.DocumentCompleted -= wbAuth_DocumentCompleted;
			this.m_webAuth.DocumentCompleted += wbAuth_DocumentCompleted;
		}

		private void wbAuth_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
            //키가 넘어오는 페이지인지 확인한다.
            if ((base.RedirectURL_uri.Host == this.m_webAuth.Url.Host) && (base.RedirectURL_uri.LocalPath == this.m_webAuth.Url.LocalPath))
            {
                //인증키가 넘어온 페이지
                //쿼리갯수를 확인한다.
                NameValueCollection query = HttpUtility.ParseQueryString(this.m_webAuth.Url.Query);

                if (2 == query.Count)
                {
                    //인증용 쿼리다.
                    if (query["state"].ToString() == this.State)
                    {
                        //확인용 키가 일치 한다.
                        base.AuthToken = query["code"].ToString();
                        base.OnOAuth_Authentication_Result_Call(string.Format("code : {0} \n state : {1}", base.AuthToken, base.State));
                    }
                }
            }
        }//end wbAuth_DocumentCompleted

		/// <summary>
		/// 인증을 시작합니다.
		/// </summary>
        /// 
		public override void StartAuth()
		{
			//외부로 요청 주소를 보냄
			base.OnOAuth_RequestURL_Create_Call(base.AuthURL);

            //인증 시작
            //new Thread(ExecuteInForeground).Start() ;
            string aaa = base.AuthURL;
            this.m_webAuth.Navigate(new Uri(base.AuthURL));
		}

		public void ReponseGet()
		{
			WebClient webClient;
			Stream stream;
			JToken token;

			//1. 로그인된 코드를 이용하여 엑세스 토큰을 받아옵니다.			
			string sAccessToken_Url = "https://nid.naver.com/oauth2.0/token";

			//쿼리 세팅
			webClient = new WebClient();
            webClient.QueryString.Add("client_id", this.ClientID);
            webClient.QueryString.Add("client_secret", this.ClientSecret);
            webClient.QueryString.Add("grant_type", "authorization_code");
            webClient.QueryString.Add("state", this.State);
            webClient.QueryString.Add("code", this.AuthToken);
           
            //요청
            stream = webClient.OpenRead(sAccessToken_Url);
			//결과 받기
            token = JObject.Parse(new StreamReader(stream).ReadToEnd());
			//Json 파싱
			string access_token = token.SelectToken("access_token").ToString();
			string refresh_token = token.SelectToken("refresh_token").ToString();
			string token_type = token.SelectToken("token_type").ToString();
			string expires_in = token.SelectToken("expires_in").ToString();

            //요청 URL
			string sListCategoryApiUri = "https://openapi.naver.com/v1/nid/me";
			webClient = new WebClient(); 
            webClient.Headers.Add("Authorization", "Bearer " + access_token);
			//요청
			stream = webClient.OpenRead(sListCategoryApiUri);
			//결과 받기
			string responseJSON2 = new StreamReader(stream).ReadToEnd();
            JObject obj = JObject.Parse(responseJSON2);
            re1 = obj.SelectToken("response").SelectToken("name").ToString(); // 이름
            re2 = obj.SelectToken("response").SelectToken("nickname").ToString(); // 닉네임
            re3 = obj.SelectToken("response").SelectToken("email").ToString(); // 이메일
            re4 = obj.SelectToken("response").SelectToken("birthday").ToString();// 생일
            re5 = obj.SelectToken("response").SelectToken("age").ToString();// 연령대
            re6 = obj.SelectToken("response").SelectToken("gender").ToString();// 성별
            //men.Add(new Man(re1, re2, re3, re4, re5, re6));
            // Database Insert!!

            //결과 출력
            base.OndgOAuth_Output_Call(re2);
        }

        private void ExecuteInForeground()
        {
            this.m_webAuth.Navigate(new Uri(base.AuthURL));
        }
    }
}
