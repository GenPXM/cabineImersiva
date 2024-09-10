namespace CabineImersivaApi.Models
{
    public class DataAtendimento
    {
        public int Id { get; set; }
        public int CabineId {  get; set; }
        public int OrgaoId { get; set; }
        public int ServicoId { get; set; }
        public DateTime CabineData { get; set; }

    }
}
