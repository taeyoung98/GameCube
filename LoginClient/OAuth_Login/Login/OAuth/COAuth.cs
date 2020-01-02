using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginClient.OAuth
{
    #region 외부에 연결할 델리게이트
    /// <summary>
    /// 인증용 리퀘스트 URL생성이 완료되었다.
    /// </summary>
    /// <param name="sRequestURL"></param>
    public delegate void dgOAuth_RequestURL_Create(string sRequestURL);
	/// <summary>
	/// 인증키가 넘어왔다.
	/// </summary>
	/// <param name="sResultString"></param>
	public delegate void dgOAuth_Authentication_Result(string sResultString);
	
	/// <summary>
	/// 그외 아웃풋 창에 표시할 내용을 전달한다.
	/// </summary>
	/// <param name="sOutputString"></param>
	public delegate void dgOAuth_Output(string sOutputString);
	#endregion

	public class COAuth
	{

        #region 연결할 이벤트
        /// <summary>
        /// 인증용 리퀘스트 생성완료
        /// </summary>
        public event dgOAuth_RequestURL_Create OnOAuth_RequestURL_Create;
		protected void OnOAuth_RequestURL_Create_Call(string sRequestURL)
		{
			this.OnOAuth_RequestURL_Create(sRequestURL);
        }
		/// <summary>
		/// 인증키가 넘어옴
		/// </summary>
		public event dgOAuth_Authentication_Result OnOAuth_Authentication_Result;
		protected void OnOAuth_Authentication_Result_Call(string sResultString)
		{
			this.OnOAuth_Authentication_Result(sResultString);
		}

		/// <summary>
		/// 아웃풋창에 표시할 내용
		/// </summary>
		public event dgOAuth_Output OndgOAuth_Output;
		protected void OndgOAuth_Output_Call(string sOutputString)
		{
			this.OndgOAuth_Output(sOutputString);
		}
		#endregion

		protected string State;

		protected string AuthURL;
		protected string ClientID;
		protected string ClientSecret;
		protected string RedirectURL;
		protected Uri RedirectURL_uri;

		protected string AuthToken;

		protected virtual void Reset()
		{
			this.AuthURL = "";
			this.ClientID = "";
			this.ClientSecret = "";
			this.RedirectURL = "";
			this.RedirectURL_uri = new Uri(this.RedirectURL);

			this.AuthToken = "";
        }

		public virtual void StartAuth()
		{

		}
    }
}