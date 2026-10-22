namespace Modeller;

// Stok kartı: işletmenin elinde tuttuğu yedek parça.
public class Parca
{
    public string Id { get; set; } = "";
    public string Ad { get; set; } = "";
    public string Kod { get; set; } = "";

    // Müşteriye yansıtılan satış fiyatı.
    public decimal BirimFiyat { get; set; }

    // Kart düzenlenirken değişmez; yalnızca stok girişi ve servis kaydında kullanım ile değişir.
    public int StokAdedi { get; set; }

    // Stok bu sayıya ya da altına inerse parça kırmızı gösterilir.
    public int KritikSeviye { get; set; }
}
