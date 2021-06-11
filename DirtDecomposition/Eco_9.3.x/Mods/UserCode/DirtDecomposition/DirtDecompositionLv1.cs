﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

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
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;

    [RequiresSkill(typeof(MiningSkill), 3)]
    public partial class DirtDecayLv1Recipe :
        RecipeFamily
    {
        public DirtDecayLv1Recipe()
        {

            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "DirtDecayLv1",
                    Localizer.DoStr("Dirt Decay Lv1"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(DirtItem), 20, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<ClayItem>(9),
               new CraftingElement<SandItem>(9),
               new CraftingElement<CompostFertilizerItem>(2),					
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(MiningSkill)); 
            this.ExperienceOnCraft = 0.5f;  
            this.CraftMinutes = CreateCraftTimeValue(typeof(DirtDecayLv1Recipe), 10f, typeof(MiningSkill));     
            this.Initialize(Localizer.DoStr("Dirt Decay Lv1"), typeof(DirtDecayLv1Recipe));

            CraftingComponent.AddRecipe(typeof(RockerBoxObject), this);
        }
    }

}
