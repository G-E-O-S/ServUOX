using Server;
using System;

namespace Server.Items
{
    public class EpauletteBearingTheCrestOfBlackthorn6 : Cloak
    {
        public override bool IsArtifact { get { return true; } }

        public override int LabelNumber { get { return 1123325; } } // Epaulette

        [Constructable]
        public EpauletteBearingTheCrestOfBlackthorn6()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            ItemID = 0x9985;            
            Attributes.AttackChance = 3;
            Attributes.DefendChance = 3;
            Attributes.SpellDamage = 3;
            Hue = 2019;

			Layer = Layer.OuterTorso;
        } 

        public EpauletteBearingTheCrestOfBlackthorn6(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
			
			if (version == 0)
            {
                MaxHitPoints = 0;
                HitPoints = 0;

                if (Layer != Layer.OuterTorso)
                {
                    if (Parent is Mobile)
                    {
                        ((Mobile)Parent).AddToBackpack(this);
                    }

                    Layer = Layer.OuterTorso;
                }
            }
        }
    }
}