namespace e_agenda.Dominio.ModuloTarefa
{
    [Serializable]
    public class ItemTarefa
    {
        public string descricao;

        public bool estaConcluido;

        public ItemTarefa()
        {
        }
        public ItemTarefa(string descricao)
        {
            this.descricao = descricao;
            this.estaConcluido = false;
        }

        public void ConcluirItem()
        {
            estaConcluido = true;
        }

        public void TornarInconcluido()
        {
            estaConcluido = false;
        }
    }
}
