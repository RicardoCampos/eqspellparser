﻿using System;


namespace EQSpellParser
{
    public enum SpellClasses
    {
        WAR = 1, CLR, PAL, RNG, SHD, DRU, MNK, BRD, ROG, SHM, NEC, WIZ, MAG, ENC, BST, BER
    }

    public enum SpellClassesLong
    {
        Warrior = 1, Cleric, Paladin, Ranger, ShadowKnight, Druid, Monk, Bard, Rogue, Shaman,
        Necro, Wizard, Mage, Enchanter, Beastlord, Berserker
    }

    [Flags]
    public enum SpellClassesMask
    {
        WAR = 1, CLR = 2, PAL = 4, RNG = 8, SHD = 16, DRU = 32, MNK = 64, BRD = 128, ROG = 256,
        SHM = 512, NEC = 1024, WIZ = 2048, MAG = 4096, ENC = 8192, BST = 16384, BER = 32768,
        ALL = 65535
    }

    [Flags]
    public enum SpellClassesMaskLong
    {
        Warrior = 1, Cleric = 2, Paladin = 4, Ranger = 8, ShadowKnight = 16, Druid = 32, Monk = 64, Bard = 128, Rogue = 256,
        Shaman = 512, Necro = 1024, Wizard = 2048, Mage = 4096, Enchanter = 8192, Beastlord = 16384, Berserker = 32768,
        ALL = 65535
    }

    public enum SpellEffect
    {
        Current_HP = 0,
        AC = 1,
        ATK = 2,
        Movement_Speed = 3,
        STR = 4,
        DEX = 5,
        AGI = 6,
        STA = 7,
        WIS = 8,
        INT = 9,
        CHA = 10,
        Melee_Haste = 11,
        Unstable_Invis = 12,
        See_Invis = 13,
        Enduring_Breath = 14,
        Current_Mana_Repeating = 15,
        Pacify = 18,
        Blind = 20,
        Stun = 21,
        Charm = 22,
        Fear = 23,
        Bind = 25,
        Gate = 26,
        Dispel = 27,
        Mesmerize = 31,
        Summon_Item = 32,
        Summon_Pet = 33,
        Disease_Counter = 35,
        Poison_Counter = 36,
        Twincast_Blocker = 39,
        Invulnerability = 40,
        Shadowstep = 42,
        Delayed_Heal_Marker = 44,
        Fire_Resist = 46,
        Cold_Resist = 47,
        Poison_Resist = 48,
        Disease_Resist = 49,
        Magic_Resist = 50,
        Rune = 55,
        Levitate = 57,
        Illusion = 58,
        Damage_Shield = 59,
        Identify = 61,
        Memory_Blur = 63,
        Stun_Spin = 64,
        Reclaim_Pet = 68,
        Summon_Skeleton_Pet = 71,
        Feign_Death = 74,
        Current_HP_Non_Repeating = 79,
        Resurrect = 81,
        Summon_Player = 82,
        Teleport = 83,
        Melee_Proc = 85,
        Assist_Radius = 86,
        Evacuate = 88,
        Max_HP = 69,
        Summon_Corpse = 91,
        Hate = 92,
        Silence = 96,
        Max_Mana = 97,
        Melee_Haste_v2 = 98,
        Root = 99,
        Current_HP_Repeating = 100,
        Donals_Heal = 101,
        Translocate = 104,
        All_Resists = 111,
        Summon_Mount = 113,
        Hate_Mod = 114,
        Curse_Counter = 116,
        Melee_Haste_v3 = 119,
        Spell_Damage_Focus = 124,
        Healing_Focus = 125,
        Haste_Focus = 127,
        Duration_Focus = 128,
        Hate_Mod_Spells = 130,
        Mana_Cost_Focus = 132,
        Current_HP_Percent = 147,
        Stacking_Blocker = 148,
        Divine_Intervention_With_Heal = 150,
        Suspend_Pet = 151,
        Summon_Swarm_Pet = 152,
        Dispel_Detrimental = 154,
        Reflect_Spell = 158,
        Spell_Rune = 161,
        Melee_Rune = 162,
        Absorb_Hits = 163,
        Melee_Mitigation = 168,
        Critical_Hit_Chance = 169,
        Critical_Nuke_Damage = 170,
        Crippling_Blow_Chance = 171,
        Avoid_Melee_Chance = 172,
        Riposte_Chance = 173,
        Dodge_Chance = 174,
        Parry_Chance = 175,
        Lifetap_From_Weapon = 178,
        Spell_Resist_Chance = 180, // sanctification
        Weapon_Delay = 182,
        Hit_Chance = 184,
        Hit_Damage = 185,
        Min_Hit_Damage = 186,
        Block_Chance = 188,
        Endurance_Repeating = 189,
        Hate_Repeating = 192,
        Skill_Attack = 193,
        Cancel_All_Aggro = 194,
        Stun_Resist_Chance = 195,
        Taunt = 199,
        Proc_Rate = 200,
        Rampage = 205,
        AE_Taunt = 206,
        AE_Attack = 211,
        Frenzied_Devastation = 212,
        Slay_Undead = 219,
        Weapon_Damage_Bonus = 220,
        Back_Block_Chance = 222,
        Double_Riposte_Skill = 223,
        Additional_Riposte_Skill = 224,
        Double_Attack_Skill = 225,
        Persistent_Casting_AA = 229, // cast through stun
        Divine_Intervention = 232,
        Reclaim_Pet_v2 = 241,
        Lung_Capacity = 246,
        Frontal_Backstab_Chance = 252,
        Frontal_Backstab_Min_Damage = 253,
        Shroud_Of_Stealth = 256,
        Triple_Backstab_Chance = 258,
        Combat_Stability = 259, // ac soft cap. AA and a few shaman spells
        No_Fizzle = 265,
        Song_Range = 270,
        Innate_Movement_Speed = 271, // AA
        Flurry = 279,
        Critical_DoT_Chance = 273,
        Critical_Heal_Chance = 274,
        Double_Special_Attack_Chance = 283, // monk specials
        Spell_Damage_Bonus = 286,
        Dragon_Punch_Knockback = 288,
        Movement_Speed_Cap = 290,
        Purify = 291,
        Frontal_Stun_Resist_Chance = 293, // AA
        Critical_Nuke_Chance = 294,
        Spell_Damage_Taken = 296,
        Ranged_Damage = 301,
        Base_Spell_Damage = 303,
        Avoid_Riposte_Chance = 304,
        Damage_Shield_Taken = 305,
        Teleport_To_Bind = 309,
        Invis = 314,
        Critical_HoT_Chance = 319,
        Shield_Block = 320,
        Targets_Target_Hate = 321,
        Gate_to_Home_City = 322,
        Defensive_Proc = 323,
        Blood_Magic = 324,
        Crit_Hit_Damage = 330,
        Summon_To_Corpse = 332,
        Block_Matching_Spell = 335,
        XP_Gain_Mod = 337,
        Spell_Proc = 339,
        Interrupt_Casting = 343,
        Shield_Equip_Hate_Mod = 349, // AA
        Mana_Burn = 350,
        Summon_Aura = 351,
        Aura_Slots = 353,
        Silence_With_Limits = 357,
        Current_Mana = 358,
        Cast_On_Death = 361,
        Triple_Attack = 364,
        Cast_On_Killshot = 365,
        Group_Shielding = 366,
        Corruption_Counter = 369,
        Corruption_Resist = 370,
        Melee_Delay = 371,
        Foraging_Skill_Cap = 372,
        Cast_Always_On_Fade = 373,
        Cast_With_Chance = 374,
        Crit_DoT_Damage = 375,
        Fling = 376,
        Cast_If_Not_Cured = 377,
        Resist_Other_Effect = 378,
        Directional_Shadowstep = 379,
        PushBackUp = 380,
        Fling_To_Self = 381,
        Inhibit_Effect = 382,
        Cast_On_Spell = 383,
        Fling_To_Target = 384,
        Limit_Group = 385,
        Cast_On_Curer = 386,
        Cast_On_Cured = 387,
        Summon_All_Corpses = 388,
        Reset_Recast_Timer = 389,
        Lockout_Recast_Timer = 390,
        Limit_Max_Mana = 391,
        Healing_Bonus = 392,
        Healing_Taken_Pct = 393,
        Healing_Taken = 394,
        Crit_Incoming_Heal_Chance = 395,
        Base_Healing = 396,
        Pet_Melee_Mitigation = 397,
        Pet_Duration = 398,
        Twincast_Chance = 399,
        Heal_From_Mana = 400,
        Ignite_Mana = 401,
        Ignite_Endurance = 402,
        Limit_Spell_Class = 403,
        Limit_Spell_Subclass = 404,
        Staff_Block_Chance = 405,
        Cast_On_Max_Hits = 406,
        Cap_HP = 408,
        Cap_Mana = 409,
        Cap_End = 410,
        Limit_Player_Class = 411,
        Limit_Race = 412,
        Song_Effectiveness = 413,
        Limit_Casting_Skill = 414,
        Limit_Item_Class = 415,
        AC_v2 = 416,
        Current_Mana_Repeating_v2 = 417,
        Weapon_Damage_Bonus_v2 = 418,
        Max_Hits_Counter = 421,
        Limit_Max_Hits_Min = 422,
        Limit_Max_Hits_Type = 423,
        Gravitate = 424,
        Fly = 425,
        Teleport_to_Caster_Anchor = 437,
        Teleport_to_Player_Anchor = 438,
        Lock_Aggro = 444,
        Buff_Blocker_A = 446,
        Buff_Blocker_B = 447,
        Buff_Blocker_C = 448,
        Buff_Blocker_D = 449,
        Absorb_DoT_Damage = 450,
        Absorb_Melee_Damage = 451,
        Absorb_Spell_Damage = 452,
        Resource_Tap = 457,
        Faction_Hit = 458,
        Hit_Damage_v2 = 459,
        Repeat_Melee_Round_Chance = 471,
        Pet_Crit_Hit_Damage = 474,
        Crit_Hit_Damage_NonStacking = 496
    }

    public enum SpellSkill
    {
        Hit = -1, // weapons/archery/backstab/frenzy/kick/etc..
        _1H_Blunt = 0,
        _1H_Slash = 1,
        _2H_Blunt = 2,
        _2H_Slash = 3,
        Abjuration = 4,
        Alteration = 5,
        Apply_Poison = 6,
        Archery = 7,
        Backstab = 8,
        Bind_Wound = 9,
        Bash = 10,
        Block = 11,
        Brass = 12,
        Channeling = 13,
        Conjuration = 14,
        Defense = 15,
        Disarm = 16,
        Disarm_Traps = 17,
        Divination = 18,
        Dodge = 19,
        Double_Attack = 20,
        Dragon_Punch = 21,
        Dual_Wield = 22,
        Eagle_Strike = 23,
        Evocation = 24,
        Feign_Death = 25,
        Flying_Kick = 26,
        Forage = 27,
        Hand_to_Hand = 28,
        Hide = 29,
        Kick = 30,
        Meditate = 31,
        Mend = 32,
        Offense = 33,
        Parry = 34,
        Pick_Lock = 35,
        _1H_Pierce = 36,
        Riposte = 37,
        Round_Kick = 38,
        Safe_Fall = 39,
        Sense_Heading = 40,
        Singing = 41,
        Sneak = 42,
        Specialize_Abjure = 43,
        Specialize_Alteration = 44,
        Specialize_Conjuration = 45,
        Specialize_Divination = 46,
        Specialize_Evocation = 47,
        Pick_Pockets = 48,
        Stringed = 49,
        Swimming = 50,
        Throwing = 51,
        Tiger_Claw = 52,
        Tracking = 53,
        Wind = 54,
        Fishing = 55,
        Poison_Making = 56,
        Tinkering = 57,
        Research = 58,
        Alchemy = 59,
        Baking = 60,
        Tailoring = 61,
        Sense_Traps = 62,
        Blacksmithing = 63,
        Fletching = 64,
        Brewing = 65,
        Alcohol_Tolerance = 66,
        Begging = 67,
        Jewelry_Making = 68,
        Pottery = 69,
        Percusion = 70,
        Intimidation = 71,
        Berserking = 72,
        Taunt = 73,
        Frenzy = 74,
        Remove_Trap = 75,
        Triple_Attack = 76,
        _2H_Pierce = 77,
        Melee = 98, // generic melee hit that doesn't get scaled up like weapon skills 
        Harm_Touch = 105,
        Lay_Hands = 107,
        Slam = 111,
        Inspect_Chest = 114,
        Open_Chest = 115,
        Reveal_Trap_Chest = 116
    }

    public enum SpellSkillCap
    {
        Base_Stats = -1,
        STR = 0,
        STA = 1,
        AGI = 2,
        DEX = 3,
        WIS = 4,
        INT = 5,
        CHA = 6,
        Magic_Resist = 7,
        Cold_Resist = 8,
        Fire_Resist = 9,
        Poison_Resist = 10,
        Disease_Resist = 11
    }

    public enum SpellResist
    {
        Sanctification = -1, // This doesn't appear in the RESISTTYPE field but spells will be modified to this value if RESISTTYPE=0 and NO_RESIST 
        Unresistable = 0, // Unresistable except for SPA 180
        Magic = 1,
        Fire = 2,
        Cold = 3,
        Poison = 4,
        Disease = 5,
        Lowest = 6, // Chromatic/lowest
        Average = 7, // Prismatic/average
        Physical = 8,
        Corruption = 9
    }

    public enum SpellBodyType
    {
        Humanoid = 1,
        Werewolf = 2,
        Undead = 3,
        Giant = 4,
        Golem = 5,
        Extraplanar = 6,
        UndeadPet = 8,
        Raid_Giant = 9,
        Vampire = 12,
        Atenha_Ra = 13,
        Greater_Akheva = 14,
        Khati_Sha = 15,
        Seru = 16,
        Draz_Nurakk = 18,
        Zek = 19,
        Luggald = 20,
        Animal = 21,
        Insect = 22,
        Elemental = 24,
        Plant = 25,
        Dragon = 26,
        Summoned = 28,
        Familiar = 31,
        Muramite = 34
    }

    // https://github.com/EQEmu/Server/blob/06dfba3c81fd8617f6e5838ec447d01c6def1819/common/races.h
    public enum SpellRaceType
    {
        Human = 1,
        Barbarian = 2,
        Erudite = 3,
        Wood_Elf = 4,
        High_Elf = 5,
        Dark_Elf = 6,
        Half_Elf = 7,
        Dwarf = 8,
        Troll = 9,
        Ogre = 10,
        Halfling = 11,
        Gnome = 12,
        Gnoll = 39,
        Lizard_Man = 51,
        Grimling = 202,
        Shissar = 217,
        Akheva = 230,
        Seru = 236,
        Kyv = 409,
        Drake = 432,
        Sporali = 456,
        Vampire = 466, // mayong related
        Minotaur = 574,
        Wereorc = 579,
        Wyvern = 581,
    }

    public enum SpellTarget
    {
        Line_of_Sight = 1,
        Caster_AE = 2,
        Caster_Group = 3,
        Caster_PB = 4,
        Single = 5,
        Self = 6,
        Target_AE = 8,
        Animal = 9,
        Undead = 10,
        Summoned = 11,
        Lifetap = 13,
        Pet = 14,
        Corpse = 15,
        Plant = 16,
        Old_Giants = 17,
        Old_Dragons = 18,
        Target_AE_Lifetap = 20,
        Target_AE_Undead = 24,
        Target_AE_Summoned = 25,
        Hatelist = 32,
        Hatelist2 = 33,
        Chest = 34,
        Special_Muramites = 35, // bane for Ingenuity group trial in MPG
        Caster_PB_Players = 36,
        Caster_PB_NPC = 37,
        Pet2 = 38,
        No_Pets = 39, // single/group/ae ?
        Caster_AE_Players = 40, // bard AE hits all players
        Target_Group = 41,
        Directional_AE = 42,
        Frontal_AE = 44,
        Single_In_Group = 43,
        Target_Ring_AE = 45,
        Targets_Target = 46,
        Pet_Owner = 47,
        Target_AE_No_Players_Pets = 50 // blanket of forgetfullness. beneficial, AE mem blur, with max targets
    }

    // these are found as type 39 in the dbstr file
    public enum SpellTargetRestrict
    {
        Caster = 3, // (any NPC with mana) guess
        Not_On_Horse = 5, // guess
        Animal_or_Humanoid = 100,
        Dragon = 101,
        Animal_or_Insect = 102,
        Animal = 104,
        Plant = 105,
        Giant = 106,
        Not_Animal_or_Humanoid = 108,
        Bixie = 109,
        Harpy = 110,
        Gnoll = 111,
        Sporali = 112,
        Kobald = 113,
        Shade = 114,
        Drakkin = 115,
        Animal_or_Plant = 117,
        Summoned = 118,
        Fire_Pet = 119,
        Undead = 120,
        Living = 121,
        Fairy = 122,
        Humanoid = 123,
        Undead_HP_Less_Than_10_Percent = 124,
        Clockwork_HP_Less_Than_45_Percent = 125,
        Wisp_HP_Less_Than_10_Percent = 126,
        Melee_Class_Except_Bard = 127,
        Pure_Melee_Class = 128,
        Pure_Caster_Class = 129,
        Hybrid_Class = 130,
        Warrior = 131,
        Cleric = 132,
        Paladin = 133,
        Ranger = 134,
        ShadowKnight = 135,
        Druid = 136,
        Monk = 137,
        Bard = 138,
        Rogue = 139,
        Shaman = 140,
        Necro = 141,
        Wizard = 142,
        Mage = 143,
        Enchanter = 144,
        Beastlord = 145,
        Berserker = 146,
        Not_Raid_Boss = 190,
        Raid_Boss = 191,
        HP_Above_75_Percent = 201,
        HP_Less_Than_20_Percent = 203, // dupe of 504
        HP_Less_Than_50_Percent = 204,
        HP_Less_Than_75_Percent = 205,
        Not_In_Combat = 216,
        At_Least_1_Pet_On_Hatelist = 221,
        At_Least_2_Pets_On_Hatelist = 222,
        At_Least_3_Pets_On_Hatelist = 223,
        At_Least_4_Pets_On_Hatelist = 224,
        At_Least_5_Pets_On_Hatelist = 225,
        At_Least_6_Pets_On_Hatelist = 226,
        At_Least_7_Pets_On_Hatelist = 227,
        At_Least_8_Pets_On_Hatelist = 228,
        At_Least_9_Pets_On_Hatelist = 229,
        At_Least_10_Pets_On_Hatelist = 230,
        At_Least_11_Pets_On_Hatelist = 231,
        At_Least_12_Pets_On_Hatelist = 232,
        At_Least_13_Pets_On_Hatelist = 233,
        At_Least_14_Pets_On_Hatelist = 234,
        At_Least_15_Pets_On_Hatelist = 235,
        At_Least_16_Pets_On_Hatelist = 236,
        At_Least_17_Pets_On_Hatelist = 237,
        At_Least_18_Pets_On_Hatelist = 238,
        At_Least_19_Pets_On_Hatelist = 239,
        At_Least_20_Pets_On_Hatelist = 240,
        HP_Less_Than_35_Percent = 250, // duple of 507
        Between_1_To_2_Pets_On_Hatelist = 260,
        Between_3_To_5_Pets_On_Hatelist = 261,
        Between_6_To_9_Pets_On_Hatelist = 262,
        Between_10_To_14_Pets_On_Hatelist = 263,
        More_Than_14_Pets_On_Hatelist = 264,
        Chain_Plate_Classes = 304,
        HP_Between_5_and_9_Percent = 350,
        HP_Between_10_and_14_Percent = 351,
        HP_Between_15_and_19_Percent = 352,
        HP_Between_20_and_24_Percent = 353,
        HP_Between_25_and_29_Percent = 354,
        HP_Between_30_and_34_Percent = 355,
        HP_Between_30_and_39_Percent = 356,
        HP_Between_40_and_44_Percent = 357,
        HP_Between_40_and_49_Percent = 358,
        HP_Between_50_and_54_Percent = 359,
        HP_Between_50_and_59_Percent = 360,
        HP_Between_5_and_15_Percent = 398,
        HP_Between_15_and_25_Percent = 399,
        HP_Between_1_and_25_Percent = 400,
        HP_Between_25_and_35_Percent = 401,
        HP_Between_35_and_45_Percent = 402,
        HP_Between_45_and_55_Percent = 403,
        HP_Between_55_and_65_Percent = 404,
        HP_Between_65_and_75_Percent = 405,
        HP_Between_75_and_85_Percent = 406,
        HP_Between_85_and_95_Percent = 407,
        HP_Above_45_Percent = 408,
        HP_Above_55_Percent = 409,
        HP_Above_99_Percent = 412,
        Mana_Above_10_Percent = 429,
        //Has_Mana = 412, // guess based on Suppressive Strike
        HP_Below_5_Percent = 501,
        HP_Below_10_Percent = 502,
        HP_Below_15_Percent = 503,
        HP_Below_20_Percent = 504,
        HP_Below_25_Percent = 505,
        HP_Below_30_Percent = 506,
        HP_Below_35_Percent = 507,
        HP_Below_40_Percent = 508,
        HP_Below_45_Percent = 509,
        HP_Below_50_Percent = 510,
        HP_Below_55_Percent = 511,
        HP_Below_60_Percent = 512,
        HP_Below_65_Percent = 513,
        HP_Below_70_Percent = 514,
        HP_Below_75_Percent = 515,
        HP_Below_80_Percent = 516,
        HP_Below_85_Percent = 517,
        HP_Below_90_Percent = 518,
        HP_Below_95_Percent = 519,
        Mana_Below_X_Percent = 521, // 5?
        End_Below_40_Percent = 522,
        Mana_Below_40_Percent = 523,
        HP_Above_20_Percent = 524,
        Humanoid2 = 601,
        Werewolf2 = 602,
        Undead2 = 603, // vampiric too? Celestial Contravention Strike
        Giants2 = 604,
        Constructs2 = 605,
        Extraplanar = 606,
        Summoned2 = 607,
        UndeadPet = 608,
        KaelGiant = 609,
        Coldain = 610,
        Summoned3 = 624,
        Warders = 628,
        VeeshanDragon = 630,
        Not_Undead_Or_Summoned = 635,
        Not_Plant = 636,
        Not_Player = 700,
        Not_Pet = 701,
        Level_Above_42 = 800,
        Treant = 815,
        Bixie2 = 816,
        Scarecrow = 817,
        Vampire_or_Undead = 818,
        Not_Vampire_or_Undead = 819,
        Knight_Hybrid_Melee_Classes = 820,
        Warrior_Caster_Priest_Classes = 821,
        End_Below_21_Percent = 825,
        End_Below_25_Percent = 826,
        End_Below_29_Percent = 827,
        Regular_Server = 836,
        Progression_Server = 837,

        Humanoid_Level_84_Max = 842,
        Humanoid_Level_86_Max = 843,
        Humanoid_Level_88_Max = 844,

        Has_Crystallized_Flame_Buff = 845,
        Has_Incendiary_Ooze_Buff = 846,

        Level_90_Max = 860,
        Level_92_Max = 861,
        Level_94_Max = 862,
        Level_95_Max = 863,
        Level_97_Max = 864,
        Level_99_Max = 865,
        Level_100_Max = 869,
        Level_102_Max = 870,
        Level_104_Max = 871,

        Between_Level_1_and_75 = 1000,
        Between_Level_76_and_85 = 1001,
        Between_Level_86_and_95 = 1002,
        Between_Level_96_and_105 = 1003,
        HP_Less_Than_80_Percent = 1004,

        Level_Above_34 = 1474,

        In_Two_Handed_Stance = 2000,
        In_Dual_Wield_Handed_Stance = 2001,
        In_Shield_Stance = 2002,
        Not_In_Two_Handed_Stance = 2010,
        Not_In_Dual_Wield_Handed_Stance = 2011,
        Not_In_Shield_Stance = 2012,

        No_Shroud_of_Prayer_Buff = 32339,

        Mana_Below_20_Percent = 38311,
        Mana_Above_50_Percent = 38312,

        Completed_Achievement_Legendary_Answerer = 39281,
        Missing_Achievement_Legendary_Answerer = 42280,

        Caster_Priest_Classes = 49529,

        No_Furious_Rampage_Buff = 49612,
        // melee classes must be below 30% endurance and classes that use mana must be below 30% mana
        Melee_Class_End_Below_30_Percent_or_Mana_Class_Mana_Below_30_Percent = 49573,
        Mana_Below_30_Percent = 49809,

        No_Harmonious_Precision_Buff = 50003,
        No_Harmonious_Expanse_Buff = 50009
    }

    public enum SpellZoneRestrict
    {
        None = 0,
        Outdoors = 1,
        Indoors = 2
    }

    // these are found as type 11 in the dbstr file
    public enum SpellIllusion
    {
        Gender_Change = -1,
        Human = 1,
        Barbarian = 2,
        Erudite = 3,
        Wood_Elf = 4,
        High_Elf = 5,
        Dark_Elf = 6,
        Half_Elf = 7,
        Dwarf = 8,
        Troll = 9,
        Ogre = 10,
        Halfling = 11,
        Gnome = 12,
        Old_Aviak = 13,
        Old_Werewolf = 14,
        Old_Brownie = 15,
        Old_Centaur = 16,
        Trakanon = 19,
        Venril_Sathir = 20,
        Old_Evil_Eye = 21,
        Froglok = 27,
        Old_Gargoyle = 29,
        Gelatinous_Cube = 31,
        Old_Gnoll = 39,
        Old_Wolf = 42,
        Black_Spirit_Wolf = (42 << 16) + 1,
        White_Spirit_Wolf = (42 << 16) + 2,
        Old_Bear = 43,
        Polar_Bear = (43 << 16) + 2,
        Freeport_Militia = 44,
        Imp = 46,
        Lizard_Man = 51,
        Old_Drachnid = 57,
        Solusek_Ro = 58,
        Tunare = 62,
        Tiger = 63,
        Mayong = 65,
        Ralos_Zek = 66,
        Elemental = 75,
        Earth_Elemental = 75 << 16,
        Fire_Elemental = (75 << 16) + 1,
        Water_Elemental = (75 << 16) + 2,
        Air_Elemental = (75 << 16) + 3,
        Old_Scarecrow = 82,
        Old_Skeleton = 85,
        Old_Drake = 89,
        Old_Alligator = 91,
        Old_Cazic_Thule = 95,
        Cockatrice = 96,
        Old_Vampire = 98,
        Old_Amygdalan = 99,
        Old_Dervish = 100,
        Tadpole = 102,
        Old_Kedge = 103,
        Mammoth = 107,
        Wasp = 109,
        Mermaid = 110,
        Seahorse = 116,
        Ghost = 118,
        Sabertooth = 119,
        Spirit_Wolf = 120,
        Gorgon = 121,
        Old_Dragon = 122,
        Innoruuk = 123,
        Unicorn = 124,
        Pegasus = 125,
        Djinn = 126,
        Invisible_Man = 127,
        Iksar = 128,
        Vah_Shir = 130,
        Old_Sarnak = 131,
        Old_Drolvarg = 133,
        Mosquito = 134,
        Rhinoceros = 135,
        Xalgoz = 136,
        Kunark_Goblin = 137,
        Yeti = 138,
        Kunark_Giant = 140,
        Nearby_Object = 142,
        Erollisi_Marr = 150,
        Tribunal = 151,
        Bristlebane = 153,
        Tree = 143,
        Old_Iksar_Skeleton = 161,
        Snow_Rabbit = 176,
        Walrus = 177,
        Geonid = 178,
        Coldain = 183,
        Hag = 185,
        Othmir = 190,
        Ulthork = 191,
        Sea_Turtle = 194,
        Shik_Nar = 199,
        Rockhopper = 200,
        Underbulk = 201,
        Grimling = 202,
        Worm = 203,
        Shadel = 205,
        Owlbear = 206,
        Rhino_Beetle = 207,
        Earth_Elemental2 = 209,
        Air_Elemental2 = 210,
        Water_Elemental2 = 211,
        Fire_Elemental2 = 212,
        Thought_Horror = 214,
        Shissar = 217,
        Fungal_Fiend = 218,
        Stonegrabber = 220,
        Zelniak = 222,
        Lightcrawler = 223,
        Shadow = 224,
        Sunflower = 225,
        Sun_Revenant = 226,
        Shrieker = 227,
        Galorian = 228,
        Netherbian = 229,
        Akheva = 230,
        Wretch = 235,
        Guard = 239,
        Arachnid = 326,
        Guktan = 330,
        Troll_Pirate = 331,
        Gnome_Pirate = 338,
        Dark_Elf_Pirate = 339,
        Ogre_Pirate = 340,
        Human_Pirate = 341,
        Erudite_Pirate = 342,
        Froglok_Skeleton = 349,
        Undead_Froglok = 350,
        Scaled_Wolf = 356,
        Vampire = 360,
        Nightrage_Orphan = (360 << 16) + 1,
        Skeleton = 367,
        Drybone_Skeleton = (367 << 16) + 1,
        Frostbone_Skeleton = (367 << 16) + 2,
        Firebone_Skeleton = (367 << 16) + 3,
        Scorched_Skeleton = (367 << 16) + 4,
        Mummy = 368,
        Froglok_Ghost = 371,
        Shade = 373,
        Golem = 374,
        Ice_Golem = (374 << 16) + 1,
        Crystal_Golem = (374 << 16) + 3,
        Jokester = 384,
        Nihil = 385,
        Trusik = 386,
        Hynid = 388,
        Turepta = 389,
        Cragbeast = 390,
        Stonemite = 391,
        Ukun = 392,
        Ikaav = 394,
        Aneuk = 395,
        Kyv = 396,
        Noc = 397,
        Ra_tuk = 398,
        Taneth = 399,
        Huvul = 400,
        Mutna = 401,
        Mastruq = 402,
        Taelosian = 403,
        Mata_Muram = 406,
        Lightning_Warrior = 407,
        Feran = 410,
        Pyrilen = 411,
        Chimera = 412,
        Dragorn = 413,
        Murkglider = 414,
        Rat = 415,
        Bat = 416,
        Gelidran = 417,
        Girplan = 419,
        Crystal_Shard = 425,
        Dervish = 431,
        Drake = 432,
        Goblin = 433,
        Solusek_Goblin = (433 << 16) + 1,
        Dagnor_Goblin = (433 << 16) + 2,
        Valley_Goblin = (433 << 16) + 3,
        Aqua_Goblin = (433 << 16) + 7,
        Goblin_King = (433 << 16) + 8,
        Rallosian_Goblin = (433 << 16) + 11,
        Frost_Goblin = (433 << 16) + 12,
        Kirin = 434,
        Basilisk = 436,
        Puma = 439,
        Domain_Prowler = (439 << 16) + 9,
        Spider = 440,
        Spider_Queen = 441,
        Animated_Statue = 442,
        Lava_Spider = 450,
        Lava_Spider_Queen = 451,
        Dragon_Egg = 445,
        Werewolf = 454,
        White_Werewolf = (454 << 16) + 2,
        Kobold = 455,
        Kobold_King = (455 << 16) + 2,
        Sporali = 456,
        Violet_Sporali = (456 << 16) + 2,
        Azure_Sporali = (456 << 16) + 11,
        Gnomework = 457,
        Orc = 458,
        Bloodmoon_Orc = (458 << 16) + 4,
        Drachnid = 461,
        Drachnid_Cocoon = 462,
        Fungus_Patch = 463,
        Gargoyle = 464,
        Runed_Gargoyle = (464 << 16) + 1,
        Undead_Shiliskin = 467,
        Armored_Shiliskin = (467 << 16) + 5,
        Snake = 468,
        Evil_Eye = 469,
        Minotaur = 470,
        Zombie = 471,
        Clockwork_Boar = 472,
        Fairy = 473,
        Tree_Fairy = (473 << 16) + 1,
        Witheran = 474,
        Air_Elemental3 = 475,
        Earth_Elemental3 = 476,
        Fire_Elemental3 = 477,
        Water_Elemental3 = 478,
        Alligator = 479,
        Bear = 480,
        Wolf = 482,
        Spectre = 485,
        Banshee = 487,
        Banshee2 = 488,
        Bone_Golem = 491,
        Scrykin = 495,
        Treant = 496, // or izon
        Regal_Vampire = 497,
        Floating_Skull = 512,
        Totem = 514,
        Bixie_Drone = 520,
        Bixie_Queen = (520 << 16) + 2,
        Centaur = 521,
        Centaur_Warrior = (521 << 16) + 3,
        Drakkin = 522,
        Gnoll = 524,
        Undead_Gnoll = (524 << 16) + 1,
        Mucktail_Gnoll = (524 << 16) + 2,
        Gnoll_Reaver = (524 << 16) + 3,
        Blackburrow_Gnoll = (524 << 16) + 4,
        Satyr = 529,
        Dragon = 530,
        Hideous_Harpy = 527,
        Goo = 549,
        Aviak = 558,
        Beetle = 559,
        Death_Beetle = (559 << 16) + 1,
        Kedge = 561,
        Kerran = 562,
        Shissar2 = 563,
        Siren = 564,
        Siren_Sorceress = (564 << 16) + 1,
        Plaguebringer = 566,
        Hooded_Plaguebringer = (566 << 16) + 7,
        Brownie = 568,
        Brownie_Noble = (568 << 16) + 2,
        Steam_Suit = 570,
        Embattled_Minotaur = 574,
        Scarecrow = 575,
        Shade2 = 576,
        Steamwork = 577,
        Tyranont = 578,
        Worg = 580,
        Wyvern = 581,
        Elven_Ghost = 587,
        Burynai = 602,
        Dracolich = 604,
        Iksar_Ghost = 605,
        Iksar_Skeleton = 606,
        Mephit = 607,
        Muddite = 608,
        Raptor = 609,
        Sarnak = 610,
        Scorpion = 611,
        Plague_Fly = 612,
        Burning_Nekhon = 614,
        Shadow_Nekhon = (614 << 16) + 1,
        Crystal_Hydra = 615,
        Crystal_Sphere = 616,
        Vitrik = 620,
        Bellikos = 638,
        Cliknar = 643,
        Ant = 644,
        Crystal_Sessiloid = 647,
        Telmira = 653,
        Flood_Telmira = (653 << 16) + 2,
        Morell_Thule = 658,
        Marionette = 659,
        Book_Dervish = 660,
        Topiary_Lion = 661,
        Rotdog = 662,
        Amygdalan = 663,
        Sandman = 664,
        Grandfather_Clock = 665,
        Gingerbread_Man = 666,
        Royal_Guardian = 667,
        Rabbit = 668,
        Gouzah_Rabbit = (668 << 16) + 3,
        Polka_Dot_Rabbit = (668 << 16) + 5,
        Cazic_Thule = 670,
        Selyrah = 686,
        Goral = 687,
        Braxi = 688,
        Kangon = 689,
        Undead_Thelasa = 695,
        Thel_Ereth_Ril = (695 << 16) + 21,
        Swinetor = 696,
        Swinetor_Necro = (696 << 16) + 1,
        Triumvirate = 697,
        Hadal = 698,
        Hadal_Templar = (698 << 16) + 2,
        Alaran_Ghost = 708,
        Holgresh = 715,
        Ratman = 718,
        Fallen_Knight = 719,
        Akhevan = 722,
        Tirun = 734,
        Bixie = 741,
        Bixie_Soldier = (741 << 16) + 2,
        Butterfly = 742,
        Arc_Worker = 766,
        Cursed_Siren = 769,
        Tyrannosaurus = 771,
        Ankylosaurus = 774,
        Thaell_Ew = 785,
        Drolvarg = 843,
    }

    public enum SpellFaction
    {
        SoF_SHIP_Workshop = 1178,
        SoD_Kithicor_Good = 1204, // army of light
        SoD_Kithicor_Evil = 1205, // army of obliteration
        SoD_Ancient_Iksar = 1229
    }

    public enum SpellMaxHits
    {
        None = 0,
        Incoming_Hit_Attempts = 1, // incoming melee attempts (prior to success checks)
        Outgoing_Hit_Attempts = 2, // outgoing melee attempts of Skill type (prior to success checks)
        Incoming_Spells = 3,
        Outgoing_Spells = 4,
        Outgoing_Hit_Successes = 5,
        Incoming_Hit_Successes = 6,
        Matching_Spells = 7, // mostly outgoing, sometimes incoming (puratus) matching limits
        Incoming_Hits_Or_Spells = 8,
        Reflected_Spells = 9,
        Defensive_Proc_Casts = 10,
        Offensive_Proc_Casts = 11,
        // 2015-7-22 patch:
        // Damage shield damage is now considered magical non-melee damage; this means that melee guard and melee threshold guard 
        // spell effects will no longer negate damage shield damage. Rune, spell guard, spell threshold guard, and spells that 
        // allow you to absorb damage as mana will continue to block damage shield damage.
        Incoming_Hits_Or_Spells_Or_DS = 13,
        // Type 14 (which these buffs have been updated to use) will only consume charges when the attacker's melee attack 
        // matches the skill that is improved by the buff. This should correct the issue where special attacks are consuming 
        // limited use counters on buffs that improve the standard 7 weapon skills.
        Outgoing_Hits_Affected_By_Buff = 14
    }

    public enum SpellTeleport
    {
        Primary_Anchor = 52584,
        Secondary_Anchor = 52585,
        Guild_Anchor = 50874
    }

    // it's hard to stick many spells into a single category, but i think this is only used by SPA 403
    public enum SpellCategory
    {
        Cures = 2,
        Offensive_Damage = 3, // nukes, DoT, AA discs, and spells that cast nukes as a side effect
        Heals = 5,
        Lifetap = 6,
        Transport = 8
    }

    // some common spell reagents 
    public enum SpellReagent
    {
        CLASS_3_Wood_Silver_Tip_Arrow = 8658,
        Tiny_Jade_Inlaid_Coffin = 9962,
        Essence_Emerald = 9963,
        Fire_Beetle_Eye = 10307,
        Black_Pearl = 10012,
        Malachite = 10015,
        Bloodstone = 10019,
        Jasper = 10020,
        Rose_Quartz = 10021,
        Amber = 10022,
        Pearl = 10024,
        Topaz = 10025,
        Cats_Eye_Agate = 10026,
        Peridot = 10028,
        Emerald = 10029,
        Opal = 10030,
        Fire_Opal = 10031,
        Star_Ruby = 10032,
        Sapphire = 10034,
        Ruby = 10035,
        Black_Sapphire = 10036,
        Diamond = 10037,
        Fuligan_Soulstone_of_Innoruuk = 10092,
        Cloudy_Stone_of_Veeshan = 10094,
        Encyclopedia_Necrotheurgia = 11571,
        Plains_Pebble = 12832,
        Hand_Drum = 13000,
        Wooden_Flute = 13001,
        Lute = 13011,
        Horn = 13012,
        Mandolin = 13013,
        Bat_Wing = 13068,
        Snake_Scales = 13070,
        Bone_Chips  = 13073,
        Fish_Scales = 13076,
        Tiny_Dagger = 13080,
        Raw_Diamond = 15981,
        Silver_Bar = 16500,
        Electrum_Bar = 16501,
        Gold_Bar = 16502,
        Platinum_Bar = 16503,
        Poison_Vial = 16965,
        Jade_Inlaid_Coffin = 17355,
        Blue_Diamond = 22503,
        Black_Ceremonial_Coffin = 28880,
        Axe_of_the_Annihilator = 52673,
        Axe_of_the_Eradicator = 52816,
        Axe_of_the_Savage = 57263,
        Lesser_Scrying_Stone = 59654,
        Scrying_Stone = 59655,
        Greater_Scrying_Stone = 59656,
        Purified_Crystal = 59740,
        Basic_Axe_Components = 59933,
        Axe_Components = 59934,
        Balanced_Components = 59935,
        Crafted_Axe_Components = 59936,
        Masterwork_Axe_Components = 59937,
        Axe_of_the_Destroyer = 59998,
        Axe_of_the_Sunderer = 64950,
        Tainted_Axe_of_Hatred = 68809,
        Corroded_Axe = 69010,
        Blunt_Axe = 69011,
        Steel_Axe = 69012,
        Bearded_Axe = 69013,
        Mithril_Axe = 69014,
        Balanced_War_Axe = 69015,
        Bonesplicer_Axe = 69016,
        Fleshtear_Axe = 69017,
        Cold_Steel_Cleaving_Axe = 69018,
        Mithril_Bloodaxe = 69019,
        Rage_Axe = 69020,
        Bloodseekers_Axe = 69021,
        Battlerage_Axe = 69022,
        Deathfury_Axe = 69023,
        Axe_of_the_Brute = 76500,
        Alluring_Flute_of_the_Piper = 87020,
        Axe_of_the_Demolisher = 99780,
    }

    [Flags]
    enum SpellInhibitType
    {
        Buff = 1,
        Worn = 2,
        AA = 4
    }

}