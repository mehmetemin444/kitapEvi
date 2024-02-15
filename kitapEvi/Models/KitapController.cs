namespace kitapEvi.Models
{
    public class KitapController
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        List<KitapController> KitapControllers = new List<KitapController>();
    }
}
