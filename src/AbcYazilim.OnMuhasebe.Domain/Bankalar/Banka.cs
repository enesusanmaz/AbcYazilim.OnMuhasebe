using System;
using System.Collections;
using System.Collections.Generic;
using AbcYazilim.OnMuhasebe.BankaSubeler;
using AbcYazilim.OnMuhasebe.Makbuzlar;
using AbcYazilim.OnMuhasebe.OzelKodlar;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbcYazilim.OnMuhasebe.Bankalar;

public class Banka : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }

    public ICollection<BankaSube> BankaSubeler { get; set; }
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }
}