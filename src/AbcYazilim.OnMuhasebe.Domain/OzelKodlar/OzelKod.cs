using System;
using System.Collections;
using System.Collections.Generic;
using AbcYazilim.OnMuhasebe.BankaHesaplar;
using AbcYazilim.OnMuhasebe.Bankalar;
using AbcYazilim.OnMuhasebe.BankaSubeler;
using AbcYazilim.OnMuhasebe.Birimler;
using AbcYazilim.OnMuhasebe.Cariler;
using AbcYazilim.OnMuhasebe.Depolar;
using AbcYazilim.OnMuhasebe.Faturalar;
using AbcYazilim.OnMuhasebe.Hizmetler;
using AbcYazilim.OnMuhasebe.Kasalar;
using AbcYazilim.OnMuhasebe.Makbuzlar;
using AbcYazilim.OnMuhasebe.Masraflar;
using AbcYazilim.OnMuhasebe.Stoklar;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbcYazilim.OnMuhasebe.OzelKodlar;

public class OzelKod : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public OzelKodTuru KodTuru { get; set; }
    public KartTuru KartTuru { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public ICollection<BankaHesap> OzelKod1BankaHesaplar { get; set; }
    public ICollection<BankaHesap> OzelKod2BankaHesaplar { get; set; }
    public ICollection<Banka> OzelKod1Bankalar { get; set; }
    public ICollection<Banka> OzelKod2Bankalar { get; set; }
    public ICollection<BankaSube> OzelKod1BankaSubeler { get; set; }
    public ICollection<BankaSube> OzelKod2BankaSubeler { get; set; }
    public ICollection<Birim> OzelKod1Birimler{ get; set; }
    public ICollection<Birim> OzelKod2Birimler { get; set; }
    public ICollection<Cari> OzelKod1Cariler{ get; set; }
    public ICollection<Cari> OzelKod2Cariler { get; set; }
    public ICollection<Depo> OzelKod1Depolar{ get; set; }
    public ICollection<Depo> OzelKod2Depolar { get; set; }
    public ICollection<Fatura> OzelKod1Faturalar{ get; set; }
    public ICollection<Fatura> OzelKod2Faturalar { get; set; }
    public ICollection<Hizmet> OzelKod1Hizmetler{ get; set; }
    public ICollection<Hizmet> OzelKod2Hizmetler { get; set; }
    public ICollection<Kasa> OzelKod1Kasalar{ get; set; }
    public ICollection<Kasa> OzelKod2Kasalar { get; set; }
    public ICollection<Makbuz> OzelKod1Makbuzlar{ get; set; }
    public ICollection<Makbuz> OzelKod2Makbuzlar { get; set; }
    public ICollection<Masraf> OzelKod1Masraflar{ get; set; }
    public ICollection<Masraf> OzelKod2Masraflar { get; set; }
    public ICollection<Stok> OzelKod1Stoklar{ get; set; }
    public ICollection<Stok> OzelKod2Stoklar { get; set; }
}