using static SiteWebChamados.Data.Login;

namespace SiteWebChamados.Data
{
    public class LoginService
    {
        public Task<List<Credencial>> GetCredenciais()
        {
            List<Credencial> infoUser = new()
            {
                new Credencial(){ Usuario = "Lucas", Senha = "0123456789" },
            };

            return Task.FromResult(infoUser);
        }
    }
}
