using System;
using System.Collections.Generic;
using Server.Commands;
using Server.Mobiles;

namespace Server.Engines.Craft
{
    public class Recipe
    {
        private static int m_LargestRecipeID;

        private TextDefinition m_TD;

        public Recipe(int id, CraftSystem system, CraftItem item)
        {
            ID = id;
            CraftSystem = system;
            CraftItem = item;

            if (Recipes.ContainsKey(id))
                throw new Exception("Attempting to create recipe with preexisting ID.");

            Recipes.Add(id, this);
            m_LargestRecipeID = Math.Max(id, m_LargestRecipeID);
        }

        public static Dictionary<int, Recipe> Recipes { get; } = new Dictionary<int, Recipe>();
        public static int LargestRecipeID => m_LargestRecipeID;
        public CraftSystem CraftSystem { get; set; }
        public CraftItem CraftItem { get; set; }
        public int ID { get; }
        public TextDefinition TextDefinition
        {
            get
            {
                if (m_TD == null)
                    m_TD = new TextDefinition(CraftItem.NameNumber, CraftItem.NameString);

                return m_TD;
            }
        }
        public static void Initialize()
        {
            CommandSystem.Register("LearnAllRecipes", AccessLevel.GameMaster, new CommandEventHandler(LearnAllRecipes_OnCommand));
            CommandSystem.Register("ForgetAllRecipes", AccessLevel.GameMaster, new CommandEventHandler(ForgetAllRecipes_OnCommand));
        }

        [Usage("LearnAllRecipes")]
        [Description("Teaches a player all available recipes.")]
        private static void LearnAllRecipes_OnCommand(CommandEventArgs e)
        {
            Mobile m = e.Mobile;
            m.SendMessage("Target a player to teach them all of the recipies.");

            m.BeginTarget(-1, false, Server.Targeting.TargetFlags.None, new TargetCallback(
                delegate(Mobile from, object targeted)
                {
                    if (targeted is PlayerMobile)
                    {
                        foreach (KeyValuePair<int, Recipe> kvp in Recipes)
                            ((PlayerMobile)targeted).AcquireRecipe(kvp.Key);

                        m.SendMessage("You teach them all of the recipies.");
                    }
                    else
                    {
                        m.SendMessage("That is not a player!");
                    }
                }));
        }

        [Usage("ForgetAllRecipes")]
        [Description("Makes a player forget all the recipies they've learned.")]
        private static void ForgetAllRecipes_OnCommand(CommandEventArgs e)
        {
            Mobile m = e.Mobile;
            m.SendMessage("Target a player to have them forget all of the recipies they've learned.");

            m.BeginTarget(-1, false, Targeting.TargetFlags.None, new TargetCallback(
                delegate(Mobile from, object targeted)
                {
                    if (targeted is PlayerMobile)
                    {
                        ((PlayerMobile)targeted).ResetRecipes();

                        m.SendMessage("They forget all their recipies.");
                    }
                    else
                    {
                        m.SendMessage("That is not a player!");
                    }
                }));
        }
    }
}
