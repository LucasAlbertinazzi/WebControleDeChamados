using static SiteWebChamados.Data.Home;

namespace SiteWebChamados.Data
{
    public class HomeService
    {

        #region 01 - Informações do Usuário

        public Task<List<InfoCardUser>> GetInfoCardUserAsync()
        {
            List<InfoCardUser> infoCardUsers = new()
            {
                new InfoCardUser(){ Usuario = "Paulo", QtdChamados = "17", QtdNvos = "10", QtdPlay = "1", QtdPause = "2", QtdConcluido = "3", QtdRevisando = "1", QtdCancelado = "0"  },
                new InfoCardUser(){ Usuario = "Lucas", QtdChamados = "25", QtdNvos = "15", QtdPlay = "1", QtdPause = "5", QtdConcluido = "2", QtdRevisando = "1", QtdCancelado = "1" },
                new InfoCardUser(){ Usuario = "Ana Paula", QtdChamados = "15", QtdNvos = "5", QtdPlay = "1", QtdPause = "5", QtdConcluido = "1", QtdRevisando = "2", QtdCancelado = "1" },
                new InfoCardUser(){ Usuario = "Leonardo", QtdChamados = "30", QtdNvos = "12", QtdPlay = "1", QtdPause = "8", QtdConcluido = "5", QtdRevisando = "3", QtdCancelado = "2" },
                new InfoCardUser(){ Usuario = "Marcos", QtdChamados = "8", QtdNvos = "2", QtdPlay = "1", QtdPause = "2", QtdConcluido = "1", QtdRevisando = "1", QtdCancelado = "1" },
                new InfoCardUser(){ Usuario = "Ryan", QtdChamados = "5", QtdNvos = "2", QtdPlay = "1", QtdPause = "0", QtdConcluido = "2", QtdRevisando = "0", QtdCancelado = "0" },
                new InfoCardUser(){ Usuario = "Éder", QtdChamados = "22", QtdNvos = "8", QtdPlay = "1", QtdPause = "1", QtdConcluido = "8", QtdRevisando = "3", QtdCancelado = "1" },
            };

            return Task.FromResult(infoCardUsers);

        }

        #endregion

        #region 02 - Informações do Card

        private List<InfoCard> infoCard = new()
        {
            new InfoCard(){ UsuarioAbre = "José", Prioridade = "Blue", Data = DateTime.Now.Date.ToShortDateString(), Tempo = "---", NChamado = "00001" },
            new InfoCard(){ UsuarioAbre = "Maria", Prioridade = "Red", Data = DateTime.Now.Date.ToShortDateString(), Tempo = "---", NChamado = "00002" },
            new InfoCard(){ UsuarioAbre = "Ana", Prioridade = "Red", Data = DateTime.Now.Date.ToShortDateString(), Tempo = "---", NChamado = "00003" },
            new InfoCard(){ UsuarioAbre = "Claudio", Prioridade = "Red", Data = DateTime.Now.Date.ToShortDateString(), Tempo = "---", NChamado = "00004" },
            new InfoCard(){ UsuarioAbre = "Joana", Prioridade = "Red", Data = DateTime.Now.Date.ToShortDateString(), Tempo = "---", NChamado = "00005" },
            new InfoCard(){ UsuarioAbre = "Amanda", Prioridade = "Red", Data = DateTime.Now.Date.ToShortDateString(), Tempo = "---", NChamado = "00006" },
        };

        #endregion

        #region 03 - Definição do DropZone

        public Task<List<DropItem>> GetDropItemAsync()
        {
            List<DropItem> _items = new()
                {
                    new DropItem(){ Name = "Item 1", Selector = "Chamados" },
                    new DropItem(){ Name = "Item 2", Selector = "Chamados" },
                    new DropItem(){ Name = "Item 3", Selector = "Chamados" },
                    new DropItem(){ Name = "Item 4", Selector = "Chamados" },
                    new DropItem(){ Name = "Item 5", Selector = "Chamados" },
                    new DropItem(){ Name = "Item 6", Selector = "Chamados" },
                };

            return Task.FromResult(_items);
        }

        #endregion

    }
}
