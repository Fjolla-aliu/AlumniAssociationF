namespace AlumniAssociationF.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }   
        public string Password { get; set; }    
    }

    public class RegisterViewModel
    {
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string DataLindjes { get; set; }
        public string NumriTelefonit { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
