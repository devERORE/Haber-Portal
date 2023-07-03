function KategoriEkle()
{
    Kategori = new Object();
    Kategori.Adi = $("#kategoriAdi").val();
    Kategori.Url = $("#kategoriUrl").val();
    Kategori.Aktif = $("#kategoriAktif").is(":checked");
    alert(Kategori.Adi + Kategori.Url + Kategori.Aktif);
}