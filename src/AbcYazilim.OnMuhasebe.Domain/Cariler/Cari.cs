using System;
using System.Collections;
using System.Collections.Generic;
using AbcYazilim.OnMuhasebe.Faturalar;
using AbcYazilim.OnMuhasebe.Makbuzlar;
using AbcYazilim.OnMuhasebe.OzelKodlar;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbcYazilim.OnMuhasebe.Cariler;

public class Cari : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string VergiDairesi { get; set; }
    public string VergiNo { get; set; }
    public string Telefon { get; set; }
    public string Adres { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    
    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }

    public ICollection<Fatura> Faturalar { get; set; }
    public ICollection<Makbuz> Makbuzlar { get; set; }
}