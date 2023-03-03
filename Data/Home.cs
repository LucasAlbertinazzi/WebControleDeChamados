namespace SiteWebChamados.Data
{
    public class Home
    {
        #region 01 - Classes de Usuários

        public class InfoCardUser
        {
            public string? Usuario { get; init; }
            public string? QtdChamados { get; set; }
            public string? QtdNvos { get; set; }
            public string? QtdPlay { get; set; }
            public string? QtdPause { get; set; }
            public string? QtdRevisando { get; set; }
            public string? QtdConcluido { get; set; }
            public string? QtdCancelado { get; set; }
        }

        #endregion

        #region 02 - Classes de Informações dos Cards

        public class InfoCard
        {
            public string? Usuario { get; init; }
            public string? QtdChamados { get; set; }
            public string? UsuarioAbre { get; init; }
            public string? Prioridade { get; set; }
            public string? Data { get; set; }
            public string? Tempo { get; set; }
            public string? NChamado { get; set; }
        }

        #endregion

        #region 03 - Classes de Definições dos Cards

        public class DropItem
        {
            public string? Name { get; init; }
            public string? Selector { get; set; }
        }

        #endregion
    }
}
