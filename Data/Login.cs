using System.ComponentModel.DataAnnotations;

namespace SiteWebChamados.Data
{
    public class Login
    {
        public class Credencial
        {
            [Required]
            public string? Usuario { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string? Senha { get; set; }
        }
    }
}
