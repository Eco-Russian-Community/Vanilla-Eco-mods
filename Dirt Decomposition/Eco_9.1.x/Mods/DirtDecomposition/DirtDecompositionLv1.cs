
namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;


	[Serialized]
    [RequiresSkill(typeof(FertilizersSkill), 3)]
	  public partial class DirtDecayRecipe :
        RecipeFamily
    {
        public DirtDecayRecipe()
        {
            var product = new Recipe(
                "DirtDecay",
                Localizer.DoStr("DirtDecay"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(DirtItem), 20),   
                },
               new CraftingElement<ClayItem>(9),
               new CraftingElement<SandItem>(9),
               new CraftingElement<CompostFertilizerItem>(2)			   
            );
            this.Initialize(Localizer.DoStr("DirtDecay"), typeof(DirtDecayRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(1000); 
            this.CraftMinutes = CreateCraftTimeValue(10f);
            this.Initialize(Localizer.DoStr("DirtDecay"), typeof(DirtDecayRecipe));
            CraftingComponent.AddRecipe(typeof(RockerBoxObject), this);
        }
    }

}
