using System;
using System.Collections.Generic;
using AbcYazilim.OnMuhasebe.BankaHesaplar;
using AbcYazilim.OnMuhasebe.Depolar;
using AbcYazilim.OnMuhasebe.Kasalar;
using AbcYazilim.OnMuhasebe.Makbuzlar;
using AbcYazilim.OnMuhasebe.Parametreler;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbcYazilim.OnMuhasebe.Subeler;

public class Sube : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    
    public ICollection<BankaHesap> BankaHesaplar { get; set; }
    public ICollection<Depo> Depolar { get; set; }
    public ICollection<Kasa> Kasalar { get; set; }
    public ICollection<Makbuz> Makbuzlar{ get; set; }
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }
    public ICollection<FirmaParametre> FirmaParametreler { get; set; }

}