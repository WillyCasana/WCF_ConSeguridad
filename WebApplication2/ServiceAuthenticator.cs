using System.Configuration;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;

namespace WebApplication2
{
    public class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new SecurityTokenException("Username and password required");
            }

            if (!(userName == ConfigurationManager.AppSettings["AVeryBigSum_User"] && password == ConfigurationManager.AppSettings["AVeryBigSum_Pass"]))
            {
                throw new FaultException(string.Format("Wrong username ({0}) or password ", userName));
            }
        }
    }
}