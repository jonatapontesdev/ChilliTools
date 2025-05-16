﻿using System;
using System.Collections.Generic;
using System.Drawing;
using JPRagTools.Utils;

namespace JPRagTools.Model
{
    internal class Buff
    {
        public String name { get; set; }
        public EffectStatusIDs effectStatusID { get; set; }
        public Bitmap icon { get; set; }

        public Buff(string name, EffectStatusIDs effectStatus, Bitmap icon)
        {
            this.name = name;
            this.effectStatusID = effectStatus;
            this.icon = icon;
        }

        //--------------------- SKILLS ------------------------------

        //Archer Skills
        public static List<Buff> GetArcherSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Concentration", EffectStatusIDs.CONCENTRATION, Resources.JPRagTools.Icons.ac_concentration),
                new Buff("Wind Walk", EffectStatusIDs.WINDWALK, Resources.JPRagTools.Icons.sn_windwalk),
                new Buff("True Sight", EffectStatusIDs.TRUESIGHT, Resources.JPRagTools.Icons.sn_sight),
                new Buff("Ilimitar", EffectStatusIDs.UNLIMIT, Resources.JPRagTools.Icons.Ilimitar),
                new Buff("A Poem of Bragi", EffectStatusIDs.POEMBRAGI, Resources.JPRagTools.Icons.poem_of_bragi),
                new Buff("Windmill Rush", EffectStatusIDs.RUSH_WINDMILL, Resources.JPRagTools.Icons.windmill_rush),
                new Buff("Moonlight Serenade", EffectStatusIDs.MOONLIT_SERENADE, Resources.JPRagTools.Icons.moonlight_serenade),
                new Buff("Frigg's Song", EffectStatusIDs.FRIGG_SONG, Resources.JPRagTools.Icons.friggs_song),
                new Buff("Mystic Symphony", EffectStatusIDs.EFST_MYSTIC_SYMPHONY, Resources.JPRagTools.Icons.mystic_symphony),
                new Buff("Jawaii Serenade", EffectStatusIDs.EFST_JAWAII_SERENADE, Resources.JPRagTools.Icons.jawaii_serenade),
                new Buff("Musical Interlude", EffectStatusIDs.EFST_MUSICAL_INTERLUDE, Resources.JPRagTools.Icons.musical_interlude),
                new Buff("Prontera March", EffectStatusIDs.EFST_PRON_MARCH, Resources.JPRagTools.Icons.prontera_march),
                new Buff("Swing Dance", EffectStatusIDs.EFST_SWING, Resources.JPRagTools.Icons.swing_dance),
                new Buff("Calamity Gale", EffectStatusIDs.EFST_CALAMITYGALE, Resources.JPRagTools.Icons.calamity_gale),
                new Buff("Fear Breeze", EffectStatusIDs.EFST_FEARBREEZE, Resources.JPRagTools.Icons.fear_breeze),
            };

            return skills;
        }

        //Swordsman Skills
        public static List<Buff> GetSwordmanSkill()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Endure", EffectStatusIDs.ENDURE, Resources.JPRagTools.Icons.sm_endure),
                new Buff("Auto Beserk", EffectStatusIDs.AUTOBERSERK, Resources.JPRagTools.Icons.sm_autoberserk),
                new Buff("Guard", EffectStatusIDs.AUTOGUARD, Resources.JPRagTools.Icons.cr_autoguard),
                new Buff("Shield Reflection", EffectStatusIDs.REFLECTSHIELD, Resources.JPRagTools.Icons.cr_reflectshield),
                new Buff("Spear Quicken", EffectStatusIDs.SPEARQUICKEN, Resources.JPRagTools.Icons.cr_spearquicken),
                new Buff("Defending Aura", EffectStatusIDs.DEFENDER, Resources.JPRagTools.Icons.cr_defender),
                new Buff("Dedication", EffectStatusIDs.LKCONCENTRATION, Resources.JPRagTools.Icons.lk_concentration),
                new Buff("Frenzy", EffectStatusIDs.BERSERK, Resources.JPRagTools.Icons.lk_berserk),
                new Buff("Twohand Quicken", EffectStatusIDs.TWOHANDQUICKEN, Resources.JPRagTools.Icons.mer_quicken),
                new Buff("Parry", EffectStatusIDs.PARRYING, Resources.JPRagTools.Icons.ms_parrying),
                new Buff("Aura Blade", EffectStatusIDs.AURABLADE, Resources.JPRagTools.Icons.lk_aurablade),
                new Buff("Enchant Blade", EffectStatusIDs.ENCHANT_BLADE, Resources.JPRagTools.Icons.enchant_blade),
                new Buff("Shrink", EffectStatusIDs.CR_SHRINK, Resources.JPRagTools.Icons.cr_shrink),
                new Buff("Inspiration", EffectStatusIDs.INSPIRATION, Resources.JPRagTools.Icons.lg_inspiration),
                new Buff("Prestige", EffectStatusIDs.PRESTIGE, Resources.JPRagTools.Icons.lg_prestige),
                new Buff("Shield Spell", EffectStatusIDs.SHIELDSPELL, Resources.JPRagTools.Icons.lg_shieldspell),
                new Buff("Vanguard Force", EffectStatusIDs.FORCEOFVANGUARD, Resources.JPRagTools.Icons.vanguard_force),
                new Buff("Reflect Damage", EffectStatusIDs.REFLECTDAMAGE, Resources.JPRagTools.Icons.reflect_damage),
                new Buff("Vigor", EffectStatusIDs.EFST_VIGOR, Resources.JPRagTools.Icons.vigor),
                new Buff("Servant Weapon", EffectStatusIDs.SERVANTWEAPON, Resources.JPRagTools.Icons.servant_weapon),
                new Buff("Attack Stance", EffectStatusIDs.EFST_ATTACK_STANCE, Resources.JPRagTools.Icons.attack_stance),
                new Buff("Guard Stance", EffectStatusIDs.EFST_GUARD_STANCE, Resources.JPRagTools.Icons.guard_stance),
                new Buff("Rebound Shield", EffectStatusIDs.EFST_REBOUND_S, Resources.JPRagTools.Icons.rebound_shield),
                new Buff("Guardian Shield", EffectStatusIDs.EFST_GUARDIAN_S, Resources.JPRagTools.Icons.guardian_shield),
                new Buff("Holy Shield", EffectStatusIDs.EFST_HOLY_S, Resources.JPRagTools.Icons.holy_shield),
                new Buff("Exceed Break", EffectStatusIDs.EFST_EXEEDBREAK, Resources.JPRagTools.Icons.exceed_break),
                new Buff("One-Hand Quicken", EffectStatusIDs.EFST_ONEHANDQUICKEN, Resources.JPRagTools.Icons.one_hand_quicken),
            };

            return skills;
        }

        //Mage Skills
        public static List<Buff> GetMageSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Energy Coat", EffectStatusIDs.ENERGYCOAT, Resources.JPRagTools.Icons.mg_energycoat),
                new Buff("Sight Blaster", EffectStatusIDs.SIGHTBLASTER, Resources.JPRagTools.Icons.wz_sightblaster),
                new Buff("Autospell", EffectStatusIDs.AUTOSPELL, Resources.JPRagTools.Icons.sa_autospell),
                new Buff("Double Casting", EffectStatusIDs.DOUBLECASTING, Resources.JPRagTools.Icons.pf_doublecasting),
                new Buff("Memorize", EffectStatusIDs.MEMORIZE, Resources.JPRagTools.Icons.pf_memorize),
                new Buff("Telekinesis Intense", EffectStatusIDs.TELEKINESIS_INTENSE, Resources.JPRagTools.Icons.telecinese),
                new Buff("Amplification", EffectStatusIDs.MYST_AMPLIFY, Resources.JPRagTools.Icons.amplify),
                new Buff("Recognized Spell", EffectStatusIDs.RECOGNIZEDSPELL, Resources.JPRagTools.Icons.recognized_spell),
                new Buff("Climax", EffectStatusIDs.EFST_CLIMAX, Resources.JPRagTools.Icons.climax),
            };

            return skills;
        }

        //Merchant Skills
        public static List<Buff> GetMerchantSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Crazy Uproar", EffectStatusIDs.CRAZY_UPROAR, Resources.JPRagTools.Icons.mc_loud),
                new Buff("Power-Thrust", EffectStatusIDs.OVERTHRUST, Resources.JPRagTools.Icons.bs_overthrust),
                new Buff("Adrenaline Rush", EffectStatusIDs.ADRENALINE, Resources.JPRagTools.Icons.bs_adrenaline),
                new Buff("Advanced Adrenaline Rush", EffectStatusIDs.ADRENALINE2, Resources.JPRagTools.Icons.bs_adrenaline2),
                new Buff("Maximum Power-Thrust", EffectStatusIDs.OVERTHRUSTMAX, Resources.JPRagTools.Icons.ws_overthrustmax),
                new Buff("Weapon Perfection", EffectStatusIDs.WEAPONPERFECT, Resources.JPRagTools.Icons.bs_weaponperfect),
                new Buff("Power Maximize", EffectStatusIDs.MAXIMIZE, Resources.JPRagTools.Icons.bs_maximize),
                new Buff("Cart Boost", EffectStatusIDs.CARTBOOST, Resources.JPRagTools.Icons.ws_cartboost),
                new Buff("Meltdown", EffectStatusIDs.MELTDOWN, Resources.JPRagTools.Icons.ws_meltdown),
                new Buff("Acceleration", EffectStatusIDs.ACCELERATION, Resources.JPRagTools.Icons.mec_acceleration),
                new Buff("Cart Boost", EffectStatusIDs.GN_CARTBOOST, Resources.JPRagTools.Icons.cart_boost),
                new Buff("Research Report", EffectStatusIDs.EFST_RESEARCHREPORT, Resources.JPRagTools.Icons.researchreport),
                new Buff("Create Hell Tree", EffectStatusIDs.EFST_BO_HELL_DUSTY, Resources.JPRagTools.Icons.create_hell_tree),
            };

            return skills;
        }

        //Thief Skills
        public static List<Buff> GetThiefSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Poison React", EffectStatusIDs.POISONREACT, Resources.JPRagTools.Icons.as_poisonreact),
                new Buff("Reject Sword", EffectStatusIDs.SWORDREJECT, Resources.JPRagTools.Icons.st_rejectsword),
                new Buff("Preserve", EffectStatusIDs.PRESERVE, Resources.JPRagTools.Icons.st_preserve),
                new Buff("Enchant Deadly Poison", EffectStatusIDs.EDP, Resources.JPRagTools.Icons.asc_edp),
                new Buff("Weapon Blocking", EffectStatusIDs.WEAPONBLOCKING, Resources.JPRagTools.Icons.weapon_blocking),
                new Buff("Dancing Knife", EffectStatusIDs.EFST_DANCING_KNIFE, Resources.JPRagTools.Icons.dancing_knife),
                new Buff("Enchanting Shadow", EffectStatusIDs.EFST_SHADOW_WEAPON, Resources.JPRagTools.Icons.enchanting_shadow),
                new Buff("Potent Venom", EffectStatusIDs.EFST_POTENT_VENOM, Resources.JPRagTools.Icons.potent_venom),
                new Buff("Shadow Exceed", EffectStatusIDs.EFST_SHADOW_EXCEED, Resources.JPRagTools.Icons.shadow_exceed),
                new Buff("Abyss Slayer", EffectStatusIDs.EFST_ABYSS_SLAYER, Resources.JPRagTools.Icons.abyss_slayer),
                new Buff("Abyss Dagger", EffectStatusIDs.EFST_ABYSS_DAGGER, Resources.JPRagTools.Icons.abyss_dagger),
            };

            return skills;
        }

        //Acolyte Skills
        public static List<Buff> GetAcolyteSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Gloria", EffectStatusIDs.GLORIA, Resources.JPRagTools.Icons.pr_gloria),
                new Buff("Magnificat", EffectStatusIDs.MAGNIFICAT, Resources.JPRagTools.Icons.pr_magnificat),
                new Buff("Angelus", EffectStatusIDs.ANGELUS, Resources.JPRagTools.Icons.al_angelus),
                new Buff("Rising Dragon", EffectStatusIDs.RAISINGDRAGON, Resources.JPRagTools.Icons.rising_dragon),
                new Buff("Gentle Touch-Revitalize", EffectStatusIDs.GENTLETOUCH_REVITALIZE, Resources.JPRagTools.Icons.gentle_touch_revitalize),
                new Buff("Gentle Touch-Convert", EffectStatusIDs.GENTLETOUCH_CHANGE, Resources.JPRagTools.Icons.gentle_touch_convert),
                new Buff("Fury ", EffectStatusIDs.FURY, Resources.JPRagTools.Icons.fury),
                new Buff("Impositio Manus",  EffectStatusIDs.IMPOSITIO, Resources.JPRagTools.Icons.impositio_manus),
                new Buff("Competentia", EffectStatusIDs.EFST_COMPETENTIA, Resources.JPRagTools.Icons.competentia),
                new Buff("Offertorium", EffectStatusIDs.EFST_OFFERTORIUM, Resources.JPRagTools.Icons.offertorium),
                new Buff("Sincere Faith", EffectStatusIDs.EFST_SINCERE_FAITH, Resources.JPRagTools.Icons.sincere_faith),
                new Buff("Firm Faith", EffectStatusIDs.FIRM_FAITH, Resources.JPRagTools.Icons.firm_faith),
                new Buff("Powerful Faith", EffectStatusIDs.POWERFUL_FAITH, Resources.JPRagTools.Icons.powerful_faith),
                new Buff("First Faith Power", EffectStatusIDs.EFST_FIRST_FAITH_POWER, Resources.JPRagTools.Icons.first_faith_power),
                new Buff("Second Judgement", EffectStatusIDs.EFST_SECOND_JUDGE, Resources.JPRagTools.Icons.second_judgement),
                new Buff("Third Exorcism Flame", EffectStatusIDs.EFST_THIRD_EXOR_FLAME, Resources.JPRagTools.Icons.third_exorcism_flame),
            };

            return skills;
        }

        //Ninja Skills
        public static List<Buff> GetNinjaSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Cicada Skin Shed", EffectStatusIDs.PEEL_CHANGE, Resources.JPRagTools.Icons.nj_utsusemi),
                new Buff("Ninja Aura", EffectStatusIDs.AURA_NINJA, Resources.JPRagTools.Icons.nj_nen),
                new Buff("Izayoi", EffectStatusIDs.IZAYOI, Resources.JPRagTools.Icons.izayoi)
            };

            return skills;
        }

        //Taekwon Skills
        public static List<Buff> GetTaekwonSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Mild Wind (Earth)", EffectStatusIDs.PROPERTYGROUND, Resources.JPRagTools.Icons.tk_mild_earth),
                new Buff("Mild Wind (Fire)", EffectStatusIDs.PROPERTYFIRE, Resources.JPRagTools.Icons.tk_mild_fire),
                new Buff("Mild Wind (Water)", EffectStatusIDs.PROPERTYWATER, Resources.JPRagTools.Icons.tk_mild_water),
                new Buff("Mild Wind (Wind)", EffectStatusIDs.PROPERTYWIND, Resources.JPRagTools.Icons.tk_mild_wind),
                new Buff("Mild Wind (Ghost)", EffectStatusIDs.PROPERTYTELEKINESIS, Resources.JPRagTools.Icons.tk_mild_ghost),
                new Buff("Mild Wind (Holy)", EffectStatusIDs.ASPERSIO, Resources.JPRagTools.Icons.tk_mild_holy),
                new Buff("Mild Wind (Shadow)", EffectStatusIDs.PROPERTYDARK, Resources.JPRagTools.Icons.tk_mild_shadow),
                new Buff("Calor solar", EffectStatusIDs.EFST_SG_SUN_WARM, Resources.JPRagTools.Icons.SG_SUN_WARM),
                new Buff("Proteção solar", EffectStatusIDs.EFST_SUN_COMFORT, Resources.JPRagTools.Icons.SG_SUN_COMFORT),
                new Buff("Calor lunar", EffectStatusIDs.EFST_SG_MOON_WARM, Resources.JPRagTools.Icons.SG_MOON_WARM),
                new Buff("Proteção lunar", EffectStatusIDs.EFST_MOON_COMFORT, Resources.JPRagTools.Icons.SG_MOON_COMFORT),
                new Buff("Calor estelar", EffectStatusIDs.EFST_SG_STAR_WARM, Resources.JPRagTools.Icons.SG_STAR_WARM),
                new Buff("Proteção estelar", EffectStatusIDs.EFST_STAR_COMFORT, Resources.JPRagTools.Icons.SG_STAR_COMFORT),
                new Buff("Tumbling", EffectStatusIDs.DODGE_ON, Resources.JPRagTools.Icons.tumbling),
                new Buff("Enchanting Sky", EffectStatusIDs.EFST_SKY_ENCHANT, Resources.JPRagTools.Icons.enchanting_sky),
                new Buff("Universal Stance", EffectStatusIDs.EFST_UNIVERSESTANCE, Resources.JPRagTools.Icons.universal_stance),
            };

            return skills;
        }


        public static List<Buff> GetGunsSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Gatling Fever", EffectStatusIDs.GATLINGFEVER, Resources.JPRagTools.Icons.gatling_fever));
            skills.Add(new Buff("Madness Canceller", EffectStatusIDs.MADNESSCANCEL, Resources.JPRagTools.Icons.madnesscancel));
            skills.Add(new Buff("Adjustment", EffectStatusIDs.ADJUSTMENT, Resources.JPRagTools.Icons.adjustment));
            skills.Add(new Buff("Increase Accuracy", EffectStatusIDs.ACCURACY, Resources.JPRagTools.Icons.increase_accuracy));

            return skills;
        }

        // [Summoner](https://irowiki.org/wiki/Summoner)
        public static List<Buff> GeSummonerSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Bunch of Shrimp", EffectStatusIDs.EFST_SHRIMP, Resources.JPRagTools.Icons.bunch_of_shrimp),
                new Buff("Temporary Communion", EffectStatusIDs.EFST_TEMPORARY_COMMUNION, Resources.JPRagTools.Icons.temporary_communion),
                new Buff("Marine Festival of Kisul", EffectStatusIDs.EFST_MARINE_FESTIVAL, Resources.JPRagTools.Icons.marine_festival_of_kisul),
                new Buff("Sandy Festival of Kisul", EffectStatusIDs.EFST_SANDY_FESTIVAL, Resources.JPRagTools.Icons.sandy_festival_of_kisul),
                new Buff("Colors of Hyunrok Lv 1", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_1, Resources.JPRagTools.Icons.colors_of_hyunrok_1),
                new Buff("Colors of Hyunrok Lv 2", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_2, Resources.JPRagTools.Icons.colors_of_hyunrok_2),
                new Buff("Colors of Hyunrok Lv 3", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_3, Resources.JPRagTools.Icons.colors_of_hyunrok_3),
                new Buff("Colors of Hyunrok Lv 4", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_4, Resources.JPRagTools.Icons.colors_of_hyunrok_4),
                new Buff("Colors of Hyunrok Lv 5", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_5, Resources.JPRagTools.Icons.colors_of_hyunrok_5),
                new Buff("Colors of Hyunrok Lv 6", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_6, Resources.JPRagTools.Icons.colors_of_hyunrok_6),
            };

            return skills;
        }

        // [Cardinal](https://irowiki.org/wiki/Cardinal)
        public static List<Buff> GeCardinalSkills()
        {
            List<Buff> skills = new List<Buff>
            {

            };

            return skills;
        }

        // [Soul Ascetic](https://wiki.historyreborn.org/index.php/Soul_Ascetic)
        public static List<Buff> GetSoulAsceticSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Soul of Heaven and Earth", EffectStatusIDs.EFST_HEAVEN_AND_EARTH, Resources.JPRagTools.Icons.soul_of_heaven_and_earth),
            };

            return skills;
        }

        // [Night Watch](https://wiki.ragna4th.com/Night_Watch)
        public static List<Buff> GetNightWatchSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Hidden Card", EffectStatusIDs.EFST_HIDDEN_CARD, Resources.JPRagTools.Icons.hidden_card),
                new Buff("Intensive Aim", EffectStatusIDs.EFST_INTENSIVE_AIM, Resources.JPRagTools.Icons.intensive_aim),
                new Buff("Auto Firing Launcher", EffectStatusIDs.EFST_AUTO_FIRING_LAUNCHEREFST, Resources.JPRagTools.Icons.auto_firing_launcher),
                new Buff("Platinum Altar", EffectStatusIDs.EFST_P_ALTER, Resources.JPRagTools.Icons.platinum_altar),
                new Buff("Hit Barrel", EffectStatusIDs.EFST_HEAT_BARREL, Resources.JPRagTools.Icons.hit_barrel),
                new Buff("Eternal Chain", EffectStatusIDs.EFST_E_CHAIN, Resources.JPRagTools.Icons.eternal_chain),
                new Buff("Grenade Fragmenth Lv 1", EffectStatusIDs.EFST_GRENADE_FRAGMENT_1, Resources.JPRagTools.Icons.grenade_fragment_1),
                new Buff("Grenade Fragmenth Lv 2", EffectStatusIDs.EFST_GRENADE_FRAGMENT_2, Resources.JPRagTools.Icons.grenade_fragment_2),
                new Buff("Grenade Fragmenth Lv 3", EffectStatusIDs.EFST_GRENADE_FRAGMENT_3, Resources.JPRagTools.Icons.grenade_fragment_3),
                new Buff("Grenade Fragmenth Lv 4", EffectStatusIDs.EFST_GRENADE_FRAGMENT_4, Resources.JPRagTools.Icons.grenade_fragment_4),
                new Buff("Grenade Fragmenth Lv 5", EffectStatusIDs.EFST_GRENADE_FRAGMENT_5, Resources.JPRagTools.Icons.grenade_fragment_5),
                new Buff("Grenade Fragmenth Lv 6", EffectStatusIDs.EFST_GRENADE_FRAGMENT_6, Resources.JPRagTools.Icons.grenade_fragment_6),
            };

            return skills;
        }

        // [Hyper Novice](https://www.divine-pride.net/tools/skilltree/4307)
        public static List<Buff> GetHyperNoviceSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Rule Break", EffectStatusIDs.EFST_RULEBREAK, Resources.JPRagTools.Icons.rule_break),
                new Buff("Breaking Limit", EffectStatusIDs.EFST_BREAKINGLIMIT, Resources.JPRagTools.Icons.breaking_limit),
            };

            return skills;
        }

        //--------------------- STUFFS ------------------------------
        //--------------------- Potions ------------------------------
        public static List<Buff> GetPotionsBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Concentration Potion", EffectStatusIDs.CONCENTRATION_POTION, Resources.JPRagTools.Icons.concentration_potiongif),
                new Buff("Awakening Potion", EffectStatusIDs.AWAKENING_POTION, Resources.JPRagTools.Icons.awakening_potion),
                new Buff("Berserk Potion", EffectStatusIDs.BERSERK_POTION, Resources.JPRagTools.Icons.berserk_potion),
                new Buff("Regeneration Potion", EffectStatusIDs.REGENERATION_POTION, Resources.JPRagTools.Icons.regeneration),
                new Buff("HP Increase Potion", EffectStatusIDs.HP_INCREASE_POTION_LARGE, Resources.JPRagTools.Icons.ghp),
                new Buff("SP Increase Potion", EffectStatusIDs.SP_INCREASE_POTION_LARGE, Resources.JPRagTools.Icons.gsp),
                new Buff("Red Herb Activator", EffectStatusIDs.RED_HERB_ACTIVATOR, Resources.JPRagTools.Icons.red_herb_activator),
                new Buff("Blue Herb Activator", EffectStatusIDs.BLUE_HERB_ACTIVATOR, Resources.JPRagTools.Icons.blue_herb_activator),
                new Buff("Golden X", EffectStatusIDs.REF_T_POTION, Resources.JPRagTools.Icons.Golden_X),
                new Buff("Energy Drink", EffectStatusIDs.ENERGY_DRINK_RESERCH, Resources.JPRagTools.Icons.energetic_drink),
                new Buff("Mega Resist Potion", EffectStatusIDs.TARGET_BLOOD, Resources.JPRagTools.Icons.mega_resist_potion),
                new Buff("Full SwingK Potion", EffectStatusIDs.FULL_SWINGK, Resources.JPRagTools.Icons.swing_k),
                new Buff("Mana Plus Potion", EffectStatusIDs.MANA_PLUS, Resources.JPRagTools.Icons.mana_plus),
                new Buff("Blessing Of Tyr", EffectStatusIDs.BASICHIT, Resources.JPRagTools.Icons.blessing_of_tyr),
                new Buff("True Limit Power Booster (Poção Ilimitada)", EffectStatusIDs.EFST_LIMIT_POWER_BOOSTER, Resources.JPRagTools.Icons.true_limit_power_booster),
                new Buff("Infinity Drink", EffectStatusIDs.EFST_INFINITY_DRINK, Resources.JPRagTools.Icons.infinity_drink),
                new Buff("Red Booster (ATK +30, MATK +30)", EffectStatusIDs.RWC_2011_SCROLL, Resources.JPRagTools.Icons.red_booster),
                new Buff("Poção Fantástica (Sealed Kiel Card)", EffectStatusIDs.EFST_KIEL_CARD, Resources.JPRagTools.Icons.pocao_fantastica),
                new Buff("Poção do Furor Físico", EffectStatusIDs.EFST_DF_FULLSWINGK, Resources.JPRagTools.Icons.full_swingK),
                new Buff("Poção Mágica", EffectStatusIDs.EFST_DRACULA_CARD, Resources.JPRagTools.Icons.pocao_magica),
                new Buff("True ASPD Intensifying Potion", EffectStatusIDs.EFST_REUSE_LIMIT_ASPD_POTION, Resources.JPRagTools.Icons.G_ASPD_Potion),
                new Buff("True Medium Life Potion", EffectStatusIDs.EFST_L_LIFEPOTION, Resources.JPRagTools.Icons.g_med_life_potion),
            };

            return skills;
        }

        public static List<Buff> GetElementalsBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Elemental Converter (Fire)", EffectStatusIDs.EFST_ATTACK_PROPERTY_FIRE, Resources.JPRagTools.Icons.PROPERTY_FIRE),
                new Buff("Elemental Converter (Wind)", EffectStatusIDs.EFST_ATTACK_PROPERTY_WIND, Resources.JPRagTools.Icons.PROPERTY_WIND),
                new Buff("Elemental Converter (Earth)", EffectStatusIDs.EFST_ATTACK_PROPERTY_GROUND, Resources.JPRagTools.Icons.PROPERTY_GROUND),
                new Buff("Elemental Converter (Water)", EffectStatusIDs.EFST_ATTACK_PROPERTY_WATER, Resources.JPRagTools.Icons.PROPERTY_WATER),
                new Buff("Cursed Water", EffectStatusIDs.EFST_ATTACK_PROPERTY_DARKNESS, Resources.JPRagTools.Icons.cursed_water),
                new Buff("Fire Conversor", EffectStatusIDs.PROPERTYFIRE, Resources.JPRagTools.Icons.ele_fire_converter),
                new Buff("Wind Conversor", EffectStatusIDs.PROPERTYWIND, Resources.JPRagTools.Icons.ele_wind_converter),
                new Buff("Earth Conversor", EffectStatusIDs.PROPERTYGROUND, Resources.JPRagTools.Icons.ele_earth_converter),
                new Buff("Water Conversor", EffectStatusIDs.PROPERTYWATER, Resources.JPRagTools.Icons.ele_water_converter),
                new Buff("Aspersio Scroll", EffectStatusIDs.ASPERSIO, Resources.JPRagTools.Icons.ele_holy_converter),
                new Buff("GHOST Conversor", EffectStatusIDs.PROPERTYTELEKINESIS, Resources.JPRagTools.Icons.ele_ghost_converter),
                new Buff("Fireproof Potion", EffectStatusIDs.RESIST_PROPERTY_FIRE, Resources.JPRagTools.Icons.fireproof),
                new Buff("Waterproof Potion", EffectStatusIDs.RESIST_PROPERTY_WATER, Resources.JPRagTools.Icons.coldproof),
                new Buff("Windproof Potion", EffectStatusIDs.RESIST_PROPERTY_WIND, Resources.JPRagTools.Icons.thunderproof),
                new Buff("Earthproof Potion", EffectStatusIDs.RESIST_PROPERTY_GROUND, Resources.JPRagTools.Icons.earhproof)
            };

            return skills;
        }

        public static List<Buff> GetFoodBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("STR Food", EffectStatusIDs.FOOD_STR, Resources.JPRagTools.Icons.strfood),
                new Buff("AGI Food", EffectStatusIDs.FOOD_AGI, Resources.JPRagTools.Icons.agi_food),
                new Buff("VIT Food", EffectStatusIDs.FOOD_VIT, Resources.JPRagTools.Icons.vit_food),
                new Buff("INT Food", EffectStatusIDs.FOOD_INT, Resources.JPRagTools.Icons.int_food),
                new Buff("DEX Food", EffectStatusIDs.FOOD_DEX, Resources.JPRagTools.Icons.dex_food),
                new Buff("LUK Food", EffectStatusIDs.FOOD_LUK, Resources.JPRagTools.Icons.luk_food),

                new Buff("3RD STR Food", EffectStatusIDs.STR_3RD_FOOD, Resources.JPRagTools.Icons.str_3rd_food),
                new Buff("3RD AGI Food", EffectStatusIDs.AGI_3RD_FOOD, Resources.JPRagTools.Icons.agi_3rd_food),
                new Buff("3RD VIT Food", EffectStatusIDs.VIT_3RD_FOOD, Resources.JPRagTools.Icons.vit_3rd_food),
                new Buff("3RD INT Food", EffectStatusIDs.INT_3RD_FOOD, Resources.JPRagTools.Icons.int_3rd_food),
                new Buff("3RD DEX Food", EffectStatusIDs.DEX_3RD_FOOD, Resources.JPRagTools.Icons.dex_3rd_food),
                new Buff("3RD LUK Food", EffectStatusIDs.LUK_3RD_FOOD, Resources.JPRagTools.Icons.luk_3rd_food),
                new Buff("Almighty", EffectStatusIDs.RWC_2011_SCROLL, Resources.JPRagTools.Icons.almighty),
                new Buff("CASH Food", EffectStatusIDs.FOOD_VIT_CASH, Resources.JPRagTools.Icons.cash_food),
                new Buff("Acarajé", EffectStatusIDs.EFST_ACARAJE, Resources.JPRagTools.Icons.acaraje),

                new Buff("STR Biscuit Stick", EffectStatusIDs.STR_Biscuit_Stick, Resources.JPRagTools.Icons.str_biscuit_stick),
                new Buff("AGI Biscuit Stick", EffectStatusIDs.AGI_Biscuit_Stick, Resources.JPRagTools.Icons.agi_biscuit_stick),
                new Buff("VIT Biscuit Stick", EffectStatusIDs.VIT_Biscuit_Stick, Resources.JPRagTools.Icons.vit_biscuit_stick),
                new Buff("INT Biscuit Stick", EffectStatusIDs.INT_Biscuit_Stick, Resources.JPRagTools.Icons.int_biscuit_stick),
                new Buff("DEX Biscuit Stick", EffectStatusIDs.DEX_Biscuit_Stick, Resources.JPRagTools.Icons.dex_biscuit_stick),
                new Buff("LUK Biscuit Stick", EffectStatusIDs.LUK_Biscuit_Stick, Resources.JPRagTools.Icons.luk_biscuit_stick),

                new Buff("STR Bubble Gum Orange", EffectStatusIDs.EFST_Bubble_Gum_Green, Resources.JPRagTools.Icons.str_bubble_gum_green),
                new Buff("AGI Biscuit Stick", EffectStatusIDs.EFST_Bubble_Gum_Red, Resources.JPRagTools.Icons.agi_bubble_gum_red),
                new Buff("INT Bubble Gum Yellow", EffectStatusIDs.EFST_Bubble_Gum_Yellow, Resources.JPRagTools.Icons.int_bubble_gum_yellow),
                new Buff("DEX Bubble Gum Orange", EffectStatusIDs.EFST_Bubble_Gum_Orange, Resources.JPRagTools.Icons.dex_bubble_gum_orange),

                new Buff("Winter Cookie ATK ", EffectStatusIDs.EFST_ATK_POPCORN, Resources.JPRagTools.Icons.winter_cookie),
                new Buff("Flora Cookie MATK", EffectStatusIDs.EFST_MATK_POPCORN, Resources.JPRagTools.Icons.flora_cookie),
                new Buff("Banquete Revigorante", EffectStatusIDs.STR_3RD_FOOD, Resources.JPRagTools.Icons.banquete),
            };

            return skills;
        }

        public static List<Buff> GetBoxesBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Drowsiness Box", EffectStatusIDs.DROWSINESS_BOX, Resources.JPRagTools.Icons.drowsiness),
                new Buff("Resentment Box", EffectStatusIDs.RESENTMENT_BOX, Resources.JPRagTools.Icons.resentment),
                new Buff("Sunlight Box", EffectStatusIDs.SUNLIGHT_BOX, Resources.JPRagTools.Icons.sunbox),
                new Buff("Box of Gloom", EffectStatusIDs.CONCENTRATION, Resources.JPRagTools.Icons.gloom),
                new Buff("Box of Thunder", EffectStatusIDs.BOX_OF_THUNDER, Resources.JPRagTools.Icons.speed),
                new Buff("Speed Potion / Guyak", EffectStatusIDs.SPEED_POT, Resources.JPRagTools.Icons.speedpotion),
                new Buff("Anodyne", EffectStatusIDs.ENDURE, Resources.JPRagTools.Icons.anodyne),
                new Buff("Aloevera", EffectStatusIDs.PROVOKE, Resources.JPRagTools.Icons.aloevera),
                new Buff("Abrasivo", EffectStatusIDs.CRITICALPERCENT, Resources.JPRagTools.Icons.abrasive),
                new Buff("Combat Pill", EffectStatusIDs.COMBAT_PILL, Resources.JPRagTools.Icons.combat_pill),
                new Buff("Advance Combat Pill", EffectStatusIDs.EFST_GM_BATTLE2, Resources.JPRagTools.Icons.advance_combat_pill),
                new Buff("Celermine Juice", EffectStatusIDs.ENRICH_CELERMINE_JUICE, Resources.JPRagTools.Icons.celermine),
                new Buff("Guarana Candy", EffectStatusIDs.SPEED_POT, Resources.JPRagTools.Icons.guarana_candy),
                new Buff("Poison Bottle", EffectStatusIDs.ASPDPOTIONINFINITY, Resources.JPRagTools.Icons.poison),
            };

            return skills;
        }

        public static List<Buff> GetScrollBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Éden Scroll", EffectStatusIDs.EFST_EDEN, Resources.JPRagTools.Icons.eden_scroll),
                new Buff("Increase Agility Scroll", EffectStatusIDs.INC_AGI, Resources.JPRagTools.Icons.al_incagi1),
                new Buff("Bless Scroll", EffectStatusIDs.BLESSING, Resources.JPRagTools.Icons.al_blessing1),
                new Buff("Full Chemical Protection (Scroll)", EffectStatusIDs.PROTECTARMOR, Resources.JPRagTools.Icons.cr_fullprotection),
                new Buff("Burn Incense",  EffectStatusIDs.EFST_BURNT_INCENSE, Resources.JPRagTools.Icons.burnt_incense),
                new Buff("Link Scroll", EffectStatusIDs.SOULLINK, Resources.JPRagTools.Icons.sl_soullinker),
                new Buff("Monster Transform",  EffectStatusIDs.MONSTER_TRANSFORM, Resources.JPRagTools.Icons.mob_transform),
                new Buff("Assumptio",  EffectStatusIDs.ASSUMPTIO, Resources.JPRagTools.Icons.assumptio),
                new Buff("Holy Armor Scroll",  EffectStatusIDs.EFST_ARMOR_PROPERTY, Resources.JPRagTools.Icons.holy_armor),
                new Buff("Shadow Armor Scroll",  EffectStatusIDs.EFST_ARMOR_PROPERTY, Resources.JPRagTools.Icons.shadow_armor_scroll),
                new Buff("Soul Scroll",  EffectStatusIDs.EFST_SOULSCROLL, Resources.JPRagTools.Icons.soul_scroll),
                new Buff("Undead Element Scroll",  EffectStatusIDs.EFST_RESIST_PROPERTY_UNDEAD, Resources.JPRagTools.Icons.undead_element_scroll),
            };

            return skills;
        }

        public static List<Buff> GetETCBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("THURISAZ Rune", EffectStatusIDs.THURISAZ, Resources.JPRagTools.Icons.THURISAZ),
                new Buff("OTHILA Rune", EffectStatusIDs.OTHILA, Resources.JPRagTools.Icons.OTHILA),
                new Buff("HAGALAZ Rune", EffectStatusIDs.HAGALAZ, Resources.JPRagTools.Icons.HAGALAZ),
                new Buff("LUX AMINA Rune", EffectStatusIDs.LUX_AMINA, Resources.JPRagTools.Icons.LUX_AMINA),
                new Buff("Cat Can", EffectStatusIDs.OVERLAPEXPUP, Resources.JPRagTools.Icons.cat_can),
                new Buff("HE Bubble Gum", EffectStatusIDs.CASH_RECEIVEITEM, Resources.JPRagTools.Icons.he_bubble_gum2),
                new Buff("Frost Giant Blood (GvG GIANT)", EffectStatusIDs.EFST_GVG_GIANT, Resources.JPRagTools.Icons.frost_giant_blood),
                new Buff("Battle Manual (GvG GOLEM)", EffectStatusIDs.EFST_GVG_GOLEM, Resources.JPRagTools.Icons.golem_stone),
                new Buff("Magic Candy", EffectStatusIDs.EFST_MAGIC_CANDY, Resources.JPRagTools.Icons.magic_candy),
                new Buff("Ghostring", EffectStatusIDs.EFST_GHOSTRING, Resources.JPRagTools.Icons.perg_ghostring),
                new Buff("Angeling", EffectStatusIDs.EFST_ANGELING, Resources.JPRagTools.Icons.perg_angeling),
                new Buff("Tao Gunka", EffectStatusIDs.EFST_TAO_GUNKA, Resources.JPRagTools.Icons.perg_taogunka),
                new Buff("Orc Lord", EffectStatusIDs.EFST_ORC_LORD, Resources.JPRagTools.Icons.perg_senhororc),
                new Buff("Orc Hero", EffectStatusIDs.EFST_ORC_HERO, Resources.JPRagTools.Icons.perg_orcheroi),
                new Buff("MISTRESS", EffectStatusIDs.EFST_MISTRESS, Resources.JPRagTools.Icons.perg_abelha),
            };

            return skills;
        }

        public static List<Buff> GetCandiesBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Sweets Macaron Cake", EffectStatusIDs.EFST_SWEETSFAIR_ATK, Resources.JPRagTools.Icons.sweets_macacake),
                new Buff("Sweets Strawberry Parfait", EffectStatusIDs.EFST_SWEETSFAIR_MATK, Resources.JPRagTools.Icons.sweets_sparfait),
                new Buff("Popcorn Festival Buff", EffectStatusIDs.EFST_FLOWER_LEAF2, Resources.JPRagTools.Icons.pop_corn_fes_buff),
                new Buff("Doce Hiper Açucarado", EffectStatusIDs.EFST_STEAMPACK, Resources.JPRagTools.Icons.spark_candy),
                new Buff("Elixir Ultra Milagroso", EffectStatusIDs.EFST_ALMIGHTY, Resources.JPRagTools.Icons.g_almighty),
                new Buff("Cherry Blossom Rice Cake", EffectStatusIDs.EFST_FLOWER_LEAF4, Resources.JPRagTools.Icons.cherry_blossom_cake),
            };

            return skills;
        }

        public static List<Buff> GetEXPBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Goma de Mascar", EffectStatusIDs.CASH_RECEIVEITEM, Resources.JPRagTools.Icons.he_bubble_gum),
                new Buff("Manual de Combate", EffectStatusIDs.CASH_PLUSEXP, Resources.JPRagTools.Icons.combat_manual_base),
                new Buff("Manual de Combate de classe", EffectStatusIDs.CASH_PLUSECLASSXP, Resources.JPRagTools.Icons.combat_manual_class),
            };

            return skills;
        }

        public static List<Buff> GetHomunculusBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Pyroclastic", EffectStatusIDs.EFST_PYROCLASTIC, Resources.JPRagTools.Icons.pyroclastic),
                new Buff("HOMUN_LAST", EffectStatusIDs.EFST_TEMPERING, Resources.JPRagTools.Icons.homun_last),
            };

            return skills;
        }

        //--------------------- DEBUFFS ------------------------------
        public static List<Buff> GetDebuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Critical Wounds", EffectStatusIDs.CRITICALWOUND, Resources.JPRagTools.Icons.critical_wound),
                new Buff("FREEZING", EffectStatusIDs.EFST_FREEZING, Resources.JPRagTools.Icons.freezing),
                new Buff("Curse", EffectStatusIDs.CURSE, Resources.JPRagTools.Icons.curse),
                new Buff("Bleeding", EffectStatusIDs.EFST_BLEEDING, Resources.JPRagTools.Icons.bleeding),
                new Buff("Silence", EffectStatusIDs.SILENCE, Resources.JPRagTools.Icons.silence),
                new Buff("Decrease Agi", EffectStatusIDs.EFST_DECREASE_AGI, Resources.JPRagTools.Icons.decrease_agi),
                new Buff("Confusion / chaos", EffectStatusIDs.CONFUSION, Resources.JPRagTools.Icons.chaos),
                new Buff("STUN", EffectStatusIDs.EFST_STUN, Resources.JPRagTools.Icons.stun),
                new Buff("Deep Sleep", EffectStatusIDs.EFST_DEEP_SLEEP, Resources.JPRagTools.Icons.deep_sleep),
                new Buff("Posion", EffectStatusIDs.POISON, Resources.JPRagTools.Icons.poison_status),
                new Buff("Lucky Water", EffectStatusIDs.EFST_HANDICAPSTATE_MISFORTUNE, Resources.JPRagTools.Icons.water_of_lucky),
            };

            return skills;
        }
    }
}