namespace Core.Utilities.Security.JWT
{
    //appsettings.json daki okuduğumuz değerleri atayacağım nesneleri tanımlıyoruz.
    public class TokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
