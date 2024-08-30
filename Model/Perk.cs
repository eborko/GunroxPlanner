namespace GunroxPlanner.Model;

public class Perk
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int RequiredLevel { get; set; }
    
    public IList<int>? RequiredPerks { get; set; }

    public int? FeatureInsight { get; set; }
    
    public int? Hp { get; set; }
    public int? HpRegeneration { get; set; }
    
    public int? SkillMedKit { get; set; }
    public int? RequiredSkillMedKit { get; set; }
    public int? FeatureCureOther { get; set; }
    
    public int? SkillMelee { get; set; }
    public int? RequiredSkillMelee { get; set; }
    public int? FeatureKnockOut { get; set; }
    
    public int? SkillPistol { get; set; }
    public int? RequiredSkillPistol { get; set; }
    public int? FeatureDistancePistol { get; set; }
    public int? FeatureSwitchWeaponAp { get; set; }

    public int? SkillShotgun { get; set; }
    public int? RequiredSkillShotgun { get; set; }
    
    public int? ApCommon { get; set; }
    public int? ApMove { get; set; }
    
    public int? MaxStuffWeight { get; set; }

    public int? SkillSubmachineGun { get; set; }
    public int? RequiredSkillSubmachineGun { get; set; }

    public int? SkillAssaultRifle { get; set; }
    public int? RequiredSkillAssaultRifle { get; set; }

    public int? ViewRadius { get; set; }

    public int? SkillSniperRifle { get; set; }
    public int? RequiredSkillSniperRifle { get; set; }
    public int? FeatureRadiusOptic { get; set; }

    public int? SkillGrenade { get; set; }
    public int? RequiredSkillGrenade { get; set; }
    public int? FeatureGrenadeAutoUse { get; set; }
    public int? FeatureGrenadeInventory { get; set; }
    
    public int? SkillTrap { get; set; }
    public int? RequiredSkillTrap { get; set; }
    public int? FeatureTrapAutoUse { get; set; }
    public int? FeatureTrapAp { get; set; }
    public int? ViewPower { get; set; }

    public int? SkillRocketLauncher { get; set; }
    public int? RequiredSkillRocketLauncher { get; set; }
    public int? FeatureRpgRange { get; set; }
    
    public string? UnlockSkill { get; set; }

    public int? SkillHeavyGun { get; set; }
    public int? RequiredSkillHeavyGun { get; set; }
    public int? MiniGunAccuracy { get; set; }
    public int? FeatureMiniGunCritical { get; set; }

    public double? ResistanceCriticalPower { get; set; }
    public double? ResistanceSplash { get; set; }
    public double? ResistanceDamage { get; set; }
    public double? ResistancePoison { get; set; }
    public double? ResistanceShock { get; set; }
    public double? ResistanceBlind { get; set; }
    public int? FeatureDefense { get; set; }
    public int? FeatureResistApPoison { get; set; }

    public double? CriticalChance { get; set; }
    public double? CriticalPower { get; set; }

    public int? MaxStuffCount { get; set; }
}