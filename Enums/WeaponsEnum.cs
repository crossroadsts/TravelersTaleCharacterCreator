using System.ComponentModel.DataAnnotations;

namespace TravelersTaleCharacterCreator;

public enum WeaponsEnum
{
    [Display(Name="Longsword")]
    Longsword = 1,
    [Display(Name="Greatsword")]
    Greatsword = 2,
    [Display(Name="Gunblade")]
    Gunblade = 3,
    [Display(Name="Split Lance")]
    SplitLance = 4,
    [Display(Name="Shortsword")]
    Shortsword = 5,
    [Display(Name="Battle Axe")]
    BattleAxe = 6,
    [Display(Name="Great Axe")]
    GreatAxe = 7,
    [Display(Name="Scythe")]
    Scythe = 8,
    [Display(Name="Spear")]
    Spear = 9,
    [Display(Name="Halberd")]
    Halberd = 10,
    [Display(Name="Cudgel")]
    Cudgel = 11,
    [Display(Name="Mace")]
    Mace = 12,
    [Display(Name="Kohlebo")]
    Kohlebo = 13,
    [Display(Name="Great Hammer")]
    GreatHammer = 14,
    [Display(Name="Dagger")]
    Dagger = 15,
    [Display(Name="Chakram")]
    Chakram = 16,
    [Display(Name="Bow")]
    Bow = 17,
    [Display(Name="Revolver")]
    Revolver = 18,
    [Display(Name="Gatling Gauntlet")]
    GatlingGauntlet = 19,
    [Display(Name="Bolt Action Rifle")]
    BoltActionRifle = 20,
    [Display(Name="Retractable Wire")]
    RetractableWire = 21,
    [Display(Name="Chain")]
    Chain = 22,
    [Display(Name="Rope Dart")]
    RopeDart = 23,
}