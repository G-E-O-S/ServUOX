namespace Server.Items
{
    [Flipable(0x13b4, 0x13b3)]
    public class Club : BaseBashing
    {
        [Constructable]
        public Club()
            : base(0x13B4)
        {
            Weight = 9.0;
        }

        public Club(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.CrushingBlow;
        public override WeaponAbility SecondaryAbility => WeaponAbility.Dismount;
        public override int AosStrengthReq => 40;
        public override int AosMinDamage => 10;
        public override int AosMaxDamage => 14;
        public override int AosSpeed => 44;
        public override float MlSpeed => 2.50f;
        public override int OldStrengthReq => 10;
        public override int OldMinDamage => 8;
        public override int OldMaxDamage => 24;
        public override int OldSpeed => 40;
        public override int InitMinHits => 31;
        public override int InitMaxHits => 40;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }
}
