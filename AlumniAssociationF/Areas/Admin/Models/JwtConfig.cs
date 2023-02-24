namespace AlumniAssociationF.Areas.Admin.Models
{
    public class JwtConfig
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int AccessTokenExpirationDays { get; set; }
    }
}
