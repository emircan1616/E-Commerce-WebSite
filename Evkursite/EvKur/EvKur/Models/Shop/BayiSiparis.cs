using EvKur.Models.Factory;

namespace EvKur.Models.Shop
{
    public class BayiSiparis:BaseOptions
    {
        public string SiparisAdi { get; set; }
        public int SiparisMiktari { get; set; }
        public bool SiparisDurumu { get; set; }
        public int? tedarikciId { get; set; }
        public Tedarikci? tedarikci { get; set; }
        public int? BayiId { get; set; }
        public Bayii? Bayi { get; set; }
    }
}
