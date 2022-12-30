using System;
using System.Collections;
using System.Collections.Generic;
using AbcYazilim.OnMuhasebe.Bankalar;
using AbcYazilim.OnMuhasebe.Hizmetler;
using AbcYazilim.OnMuhasebe.Masraflar;
using AbcYazilim.OnMuhasebe.OzelKodlar;
using AbcYazilim.OnMuhasebe.Stoklar;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbcYazilim.OnMuhasebe.Birimler;

public class Birim : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    
    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }

    public ICollection<Hizmet> Hizmetler { get; set; }
    public ICollection<Masraf> Masraflar { get; set; }
    public ICollection<Stok> Stoklar { get; set; }
}