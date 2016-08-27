using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class NPC
    {
        public NPC(int _entry, int _difficulty_entry_1, int _difficulty_entry_2, int _difficulty_entry_3, int _KillCredit1, int _KillCredit2, int _modelid1, int _modelid2, int _modelid3,
                    int _modelid4, String _name, String _subname, String _IconName, int _gossip_menu_id, int _minlevel, int _maxlevel, int _exp, int _faction, int _npcflag,
                    float _speed_walk, float _speed_run, float _scale, int _rank, int _dmgschool, int _BaseAttackTime, int _RangeAttackTime, float _BaseVariance, float _RangeVariance,
                    int _unit_class, int _unit_flags, int _unit_flags2, int _dynamicflags, int _family, int _trainer_type, int _trailer_spell, int _trainer_class, int _trainer_race,
                    int _type, int _type_flags, int _lootid, int _pickpocketloot, int _skinloot, int _resistance1, int _resistance2, int _resistance3, int _resistance4, int _resistance5,
                    int _resistance6, int _spell1, int _spell2, int _spell3, int _spell4, int _spell5, int _spell6, int _PetSpellDataId, int _VehicleId, int _mingold, int _maxgold, 
                    String _AIName, int _MovementType, int _InhabitType, float _HoverHeight, float _HealthModifier, float _ManaModifier, float _Armormodifier, float _DamageModifier, 
                    float _ExperienceModifier, int _RacialLeader, int _movementId, int _RegenHealth, int _mechanic_immune_mask, int _flags_extra, String _ScriptName, int _VerifiedBuild)
        {
            entry = _entry;
            difficulty_entry_1 = _difficulty_entry_1;
            difficulty_entry_2 = _difficulty_entry_2;
            difficulty_entry_3 = _difficulty_entry_3;
            KillCredit1 = _KillCredit1;
            KillCredit2 = _KillCredit2;
            modelid1 = _modelid1;
            modelid2 = _modelid2;
            modelid3 = _modelid3;
            modelid4 = _modelid4;
            name = _name;
            subname = _subname;
            gossip_menu_id = _gossip_menu_id;
            minlevel = _minlevel;
            maxlevel = _maxlevel;
            exp = _exp;
            faction = _faction;
            npcflag = _npcflag;
            speed_walk = _speed_walk;
            speed_run = speed_run;
            scale = _scale;
            rank = _rank;
            dmgschool = _dmgschool;
            BaseAttackTime = _BaseAttackTime;
            RangeAttackTime = _RangeAttackTime;
            BaseVariance = _BaseVariance;
            RangeVariance = _RangeVariance;
            unit_class = _unit_class;
            unit_flags = _unit_flags;
            unit_flags2 = _unit_flags2;
            dynamicflags = _dynamicflags;
            family = _family;
            trainer_type = _trainer_type;
            trainer_spell = _trailer_spell;
            trainer_class = _trainer_class;
            trainer_race = _trainer_race;
            type = _type;
            type_flags = _type_flags;
            lootid = _lootid;
            pickpocketloot = _pickpocketloot;
            skinloot = _skinloot;
            resistance1 = _resistance1;
            resistance2 = _resistance2;
            resistance3 = _resistance3;
            resistance4 = _resistance4;
            resistance5 = _resistance5;
            resistance6 = _resistance6;
            spell1 = _spell1;
            spell2 = _spell2;
            spell3 = _spell3;
            spell4 = _spell4;
            spell5 = _spell5;
            spell6 = _spell6;
            PetSpellDataId = _PetSpellDataId;
            VehicleId = _VehicleId;
            mingold = _mingold;
            maxgold = _maxgold;
            AIName = _AIName;
            MovementType = _MovementType;
            InhabitType = _InhabitType;
            HoverHeight = _HoverHeight;
            HealthModifier = _HealthModifier;
            ManaModifier = _ManaModifier;
            ArmorModifier = _Armormodifier;
            DamageModifier = _DamageModifier;
            ExperienceModifier = _ExperienceModifier;
            RacialLeader = _RacialLeader;
            movementId = _movementId;
            RegenHealth = _RegenHealth;
            mechanic_immune_mask = _mechanic_immune_mask;
            flags_extra = _flags_extra;
            ScriptName = _ScriptName;
            VerifiedBuild = _VerifiedBuild;


        }

        //Database Structure: creature_template 
        public int entry                    { get; private set; }
        public int difficulty_entry_1       { get; private set; }
        public int difficulty_entry_2       { get; private set; }
        public int difficulty_entry_3       { get; private set; }
        public int KillCredit1              { get; private set; }
        public int KillCredit2              { get; private set; }
        public int modelid1                 { get; private set; }
        public int modelid2                 { get; private set; }
        public int modelid3                 { get; private set; }
        public int modelid4                 { get; private set; }
        public String name                  { get; private set; }
        public String subname               { get; private set; }
        public String IconName              { get; private set; }
        public int gossip_menu_id           { get; private set; }
        public int minlevel                 { get; private set; }
        public int maxlevel                 { get; private set; }
        public int exp                      { get; private set; }
        public int faction                  { get; private set; }
        public int npcflag                  { get; private set; }
        public float speed_walk             { get; private set; }
        public float speed_run              { get; private set; }
        public float scale                  { get; private set; }
        public int rank                     { get; private set; }
        public int dmgschool                { get; private set; }
        public int BaseAttackTime           { get; private set; }
        public int RangeAttackTime          { get; private set; }
        public float BaseVariance           { get; private set; }
        public float RangeVariance          { get; private set; }
        public int unit_class               { get; private set; }
        public int unit_flags               { get; private set; }
        public int unit_flags2              { get; private set; }
        public int dynamicflags             { get; private set; }
        public int family                   { get; private set; }
        public int trainer_type             { get; private set; }
        public int trainer_spell            { get; private set; }
        public int trainer_class            { get; private set; }
        public int trainer_race             { get; private set; }
        public int type                     { get; private set; }
        public int type_flags               { get; private set; }
        public int lootid                   { get; private set; }
        public int pickpocketloot           { get; private set; }
        public int skinloot                 { get; private set; }
        public int resistance1              { get; private set; }
        public int resistance2              { get; private set; }
        public int resistance3              { get; private set; }
        public int resistance4              { get; private set; }
        public int resistance5              { get; private set; }
        public int resistance6              { get; private set; }
        public int spell1                   { get; private set; }
        public int spell2                   { get; private set; }
        public int spell3                   { get; private set; }
        public int spell4                   { get; private set; }
        public int spell5                   { get; private set; }
        public int spell6                   { get; private set; }
        public int PetSpellDataId           { get; private set; }
        public int VehicleId                { get; private set; }
        public int mingold                  { get; private set; }
        public int maxgold                  { get; private set; }
        public String AIName                { get; private set; }
        public int MovementType             { get; private set; }
        public int InhabitType              { get; private set; }
        public float HoverHeight            { get; private set; }
        public float HealthModifier         { get; private set; }
        public float ManaModifier           { get; private set; }
        public float ArmorModifier          { get; private set; }
        public float DamageModifier         { get; private set; }
        public float ExperienceModifier     { get; private set; }
        public int RacialLeader             { get; private set; }
        public int movementId               { get; private set; }
        public int RegenHealth              { get; private set; }
        public int mechanic_immune_mask     { get; private set; }
        public int flags_extra              { get; private set; }
        public String ScriptName            { get; private set; }
        public int VerifiedBuild            { get; private set; }

    }
}
