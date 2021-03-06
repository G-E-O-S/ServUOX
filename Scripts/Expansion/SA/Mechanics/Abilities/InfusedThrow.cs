using System;
using Server.Mobiles;

namespace Server.Items
{
    public class InfusedThrow : WeaponAbility
    {
        public override int BaseMana => 25;

        public override void OnHit(Mobile attacker, Mobile defender, int damage)
        {
            if (!CheckMana(attacker, true))
                return;

            ClearCurrentAbility(attacker);

            attacker.SendLocalizedMessage(1149563); //The infused projectile strikes a target!
            defender.SendLocalizedMessage(1149564); //You are struck by the infused projectile and take damage!

            AOS.Damage(defender, attacker, 15, false, 0, 0, 0, 0, 0, 100, 0, false);

            IMount mount = defender.Mount;

            if ((defender.Mounted || defender.Flying || Server.Spells.Ninjitsu.AnimalForm.UnderTransformation(defender)) && !attacker.Mounted && !attacker.Flying && !(defender is ChaosDragoon) && !(defender is ChaosDragoonElite))
            {
                defender.PlaySound(0x140);
                defender.FixedParticles(0x3728, 10, 15, 9955, EffectLayer.Waist);

                Items.Dismount.DoDismount(attacker, defender, BlockMountType.DismountRecovery, TimeSpan.FromSeconds(10.0), true);
            }
            else
            {
                defender.FixedEffect(0x376A, 9, 32);
                defender.PlaySound(0x204);

                TimeSpan duration = defender.Player ? TimeSpan.FromSeconds(3.0) : TimeSpan.FromSeconds(6.0);
                defender.Paralyze(duration);
            }
        }
    }
}
