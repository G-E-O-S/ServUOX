
namespace Server.Mobiles
{
    [CorpseName("a grey wolf corpse")]
    [TypeAlias("Server.Mobiles.Greywolf")]
    public class GreyWolf : BaseCreature
    {
        [Constructable]
        public GreyWolf()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            Name = "a grey wolf";
            Body = Utility.RandomList(25, 27);
            BaseSoundID = 0xE5;

            SetStr(56, 80);
            SetDex(56, 75);
            SetInt(31, 55);

            SetHits(34, 48);
            SetMana(0);

            SetDamage(3, 7);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Fire, 10, 15);
            SetResistance(ResistanceType.Cold, 20, 25);
            SetResistance(ResistanceType.Poison, 10, 15);
            SetResistance(ResistanceType.Energy, 10, 15);

            SetSkill(SkillName.MagicResist, 20.1, 35.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 60.0);

            Fame = 450;
            Karma = 0;

            VirtualArmor = 16;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = 53.1;
        }

        public GreyWolf(Serial serial)
            : base(serial)
        {
        }

        public override int Meat { get { return 1; } }
        public override int Hides { get { return 6; } }
        public override FoodType FavoriteFood { get { return FoodType.Meat; } }
        public override PackInstinct PackInstinct { get { return PackInstinct.Canine; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    [CorpseName("a timber wolf corpse")]
    [TypeAlias("Server.Mobiles.Timberwolf")]
    public class TimberWolf : BaseCreature
    {
        [Constructable]
        public TimberWolf()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            Name = "a timber wolf";
            Body = 225;
            BaseSoundID = 0xE5;

            SetStr(56, 80);
            SetDex(56, 75);
            SetInt(11, 25);

            SetHits(34, 48);
            SetMana(0);

            SetDamage(5, 9);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Fire, 5, 10);
            SetResistance(ResistanceType.Cold, 10, 15);
            SetResistance(ResistanceType.Poison, 5, 10);
            SetResistance(ResistanceType.Energy, 5, 10);

            SetSkill(SkillName.MagicResist, 27.6, 45.0);
            SetSkill(SkillName.Tactics, 30.1, 50.0);
            SetSkill(SkillName.Wrestling, 40.1, 60.0);

            Fame = 450;
            Karma = 0;

            VirtualArmor = 16;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = 23.1;
        }

        public TimberWolf(Serial serial)
            : base(serial)
        {
        }

        public override int Meat { get { return 1; } }
        public override int Hides { get { return 5; } }
        public override FoodType FavoriteFood { get { return FoodType.Meat; } }
        public override PackInstinct PackInstinct { get { return PackInstinct.Canine; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    [CorpseName("a white wolf corpse")]
    [TypeAlias("Server.Mobiles.Whitewolf")]
    public class WhiteWolf : BaseCreature
    {
        [Constructable]
        public WhiteWolf()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            Name = "a white wolf";
            Body = Utility.RandomList(34, 37);
            BaseSoundID = 0xE5;

            SetStr(56, 80);
            SetDex(56, 75);
            SetInt(31, 55);

            SetHits(34, 48);
            SetMana(0);

            SetDamage(3, 7);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Fire, 10, 15);
            SetResistance(ResistanceType.Cold, 20, 25);
            SetResistance(ResistanceType.Poison, 10, 15);
            SetResistance(ResistanceType.Energy, 10, 15);

            SetSkill(SkillName.MagicResist, 20.1, 35.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 60.0);

            Fame = 450;
            Karma = 0;

            VirtualArmor = 16;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = 65.1;
        }

        public WhiteWolf(Serial serial)
            : base(serial)
        {
        }

        public override int Meat { get { return 1; } }
        public override int Hides { get { return 6; } }
        public override FoodType FavoriteFood { get { return FoodType.Meat; } }
        public override PackInstinct PackInstinct { get { return PackInstinct.Canine; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
