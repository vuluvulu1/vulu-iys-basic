namespace Modeller;

// Ana sayfadaki sayılar.
public class Ozet
{
    public int AcikIsSayisi { get; set; }
    public int TeslimBekleyenSayisi { get; set; }
    public int BugunAcilanSayisi { get; set; }
    public int KritikStokSayisi { get; set; }
    public decimal OdenmemisTutar { get; set; }
}

// Seçilen tarih aralığında açılan kayıtların dökümü.
public class Rapor
{
    public int AcilanIs { get; set; }
    public int TamamlananIs { get; set; }
    public int IptalEdilenIs { get; set; }
    public decimal ToplamTutar { get; set; }
    public decimal TahsilEdilen { get; set; }
    public List<TeknisyenSatiri> Teknisyenler { get; set; } = [];
    public List<ParcaSatiri> EnCokKullanilanParcalar { get; set; } = [];
}

public class TeknisyenSatiri
{
    public string TeknisyenAdi { get; set; } = "";
    public int IsSayisi { get; set; }
    public decimal Tutar { get; set; }
}

public class ParcaSatiri
{
    public string ParcaAdi { get; set; } = "";
    public int Adet { get; set; }
}
