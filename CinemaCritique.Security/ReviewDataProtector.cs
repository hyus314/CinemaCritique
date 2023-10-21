using Microsoft.AspNetCore.DataProtection;

namespace CinemaCritique.Security
{
    public class ReviewDataProtector
    {
        private readonly IDataProtector dataProtector;

        public ReviewDataProtector(IDataProtector dataProtector)
        {
            this.dataProtector = dataProtector;
        }

        public string Encrypt(int id)
        {
            return dataProtector.Protect(id.ToString());
        }

        public int Decrypt(string id)
        {
            var decryptedString = dataProtector.Unprotect(id);
            return int.Parse(decryptedString);
        }
    }
}
