using System;
using System.Collections;
using System.Collections.Generic;
using AbcYazilim.OnMuhasebe.Faturalar;
using AbcYazilim.OnMuhasebe.Makbuzlar;
using AbcYazilim.OnMuhasebe.Parametreler;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbcYazilim.OnMuhasebe.Donemler;

public class Donem : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public ICollection<Fatura> Faturalar { get; set; }
    public ICollection<Makbuz> Makbuzlar { get; set; }
    public ICollection<FirmaParametre> FirmaParametreler { get; set; }
}