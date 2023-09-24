using Microsoft.AspNetCore.DataProtection;

namespace CinemaCritique.Security
{
    public class MovieDataProtector 
    {
        private readonly IDataProtector dataProtector;

        public MovieDataProtector(IDataProtector dataProtector)
        {
            this.dataProtector = dataProtector;
        }

        public string Encrypt(string id)
        {
            return dataProtector.Protect(id);
        }

        public int Decrypt(string id)
        {
            var decryptedString = dataProtector.Unprotect(id);
            return int.Parse(decryptedString);
        }
    }
}