using System;
using AbcYazilim.OnMuhasebe.Cariler;
using AbcYazilim.OnMuhasebe.Donemler;
using AbcYazilim.OnMuhasebe.OzelKodlar;
using AbcYazilim.OnMuhasebe.Subeler;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbcYazilim.OnMuhasebe.Faturalar;

public class Fatura : FullAuditedAggregateRoot<Guid>
{
    public FaturaTuru FaturaTuru { get; set; }
    public string FaturaNo { get; set; }
    public DateTime Tarih { get; set; }
    public decimal BrutTutar { get; set; }
    public decimal IndirimTutar { get; set; }
    public decimal KdvHaricTutar { get; set; }
    public decimal KdvTutar { get; set; }
    public decimal NetTutar { get; set; }
    public int HareketSayisi { get; set; }
    public Guid CariId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public Cari Cari { get; set; }
    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }
    public Sube Sube { get; set; }
    public Donem Donem { get; set; }
}