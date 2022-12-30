using System.Data;
using AbcYazilim.OnMuhasebe.Bankalar;
using AbcYazilim.OnMuhasebe.BankaSubeler;
using AbcYazilim.OnMuhasebe.Consts;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbcYazilim.OnMuhasebe.Configurations;

public static class OnMuhasebeDbContextModelBuilderExtenisons
{
    public static void Configure(this ModelBuilder builder)
    {
        builder.Entity<Banka>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "BankaSubeler", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            #region Properties

            #endregion

            #region Indexes
 
            #endregion

            #region Relations

            #endregion
        });
    }

    public static void ConfigureBanka(this ModelBuilder builder)
    {
        builder.Entity<Banka>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Bankalar", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            #region Properties

            b.Property(x => x.Kod)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxKodLenght);

            b.Property(x => x.Ad)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAdLenght);

            b.Property(x => x.OzelKod1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.OzelKod2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Aciklama)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAciklamaLenght);

            b.Property(x => x.Durum)
                .HasColumnType(SqlDbType.Bit.ToString());

            #endregion

            #region Indexes

            b.HasIndex(x => x.Kod);

            #endregion

            #region Relations

            b.HasOne(x => x.OzelKod1)
                .WithMany(x => x.OzelKod1Bankalar)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.OzelKod2)
                .WithMany(x => x.OzelKod2Bankalar)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion
        });
    }

    public static void ConfigureBankaSubeler(this ModelBuilder builder)
    {
        builder.Entity<BankaSube>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "BankaSubeler", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            #region Properties

            b.Property(x => x.Kod)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxKodLenght);

            b.Property(x => x.Ad)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAdLenght);

            b.Property(x => x.BankaId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Aciklama)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAciklamaLenght);

            b.Property(x => x.OzelKod1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.OzelKod2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Durum)
                .HasColumnType(SqlDbType.Bit.ToString());

            #endregion

            #region Indexes
            b.HasIndex(x => x.Kod);
            #endregion

            #region Relations

            b.HasOne(x => x.Banka)
                .WithMany(x => x.BankaSubeler)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.OzelKod1)
                .WithMany(x => x.OzelKod1BankaSubeler)
                .OnDelete(DeleteBehavior.NoAction);
            
            b.HasOne(x => x.OzelKod2)
                .WithMany(x => x.OzelKod2BankaSubeler)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion
        });
    }
    
    public static void ConfigureBankaHesaplar(this ModelBuilder builder)
    {
        builder.Entity<Banka>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "BankaHesaplar", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            #region Properties

            #endregion

            #region Indexes
 
            #endregion

            #region Relations

            #endregion
        });
    }
}