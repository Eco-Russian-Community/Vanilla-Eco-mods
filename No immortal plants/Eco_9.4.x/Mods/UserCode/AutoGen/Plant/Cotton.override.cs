// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />


// WORLD LAYER INFO
namespace Eco.Mods.WorldLayers
{
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers.Layers;

    public partial class PlantLayerSettingsCotton : PlantLayerSettings
    {
        public PlantLayerSettingsCotton() : base()
        {
            this.Name = "Cotton";  //noloc
            this.DisplayName = Localizer.DoStr("Cotton");
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.OverrideRenderRange = new Range(0f, 0.333333f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Cotton"; //noloc
            this.VoxelsPerEntry = 5;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
            this.Subcategory = "Cotton".AddSpacesBetweenCapitals(); //noloc
        }
    }
}

namespace Eco.Mods.Organisms
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Plants;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Simulation;
    using Eco.Simulation.Types;
    using Eco.World.Blocks;

    [Serialized]
    public partial class Cotton : PlantEntity
    {
        public Cotton(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public Cotton() { }
        static PlantSpecies species;

        [Ecopedia("Plants", "Plants", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)] 
        [Tag("Plants")]
        [Localized(false, true)]
        public partial class CottonSpecies : PlantSpecies
        {
            public CottonSpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(Cotton);
                this.SetDefaultProperties();

                // Info
                this.Decorative = false;
                this.Name = "Cotton"; //noloc
                this.DisplayName = Localizer.DoStr("Cotton");
                // Lifetime
                this.MaturityAgeDays = 0.8f;
                // Generation
                this.Height = 1;
                // Food
                this.CalorieValue = 1;
                // Resources
                this.PostHarvestingGrowth = 0;
                this.PickableAtPercent = 0;
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(CottonBollItem), new Range(1, 3), 1),
                };
                this.ResourceBonusAtGrowth = 0.9f;
                // Visuals
                this.BlockType = typeof(CottonBlock);
                // Climate
                this.ReleasesCO2TonsPerDay = -0.0002f;
                // WorldLayers
                this.MaxGrowthRate = 0.02f;
                this.MaxDeathRate = 0.01f;
                this.SpreadRate = 0.001f;
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Nitrogen", HalfSpeedConcentration = 0.1f, MaxResourceContent = 0.1f }); //noloc
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Phosphorus", HalfSpeedConcentration = 0.1f, MaxResourceContent = 0.15f }); //noloc
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "Potassium", HalfSpeedConcentration = 0.2f, MaxResourceContent = 0.2f }); //noloc
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration = 0.2f, MaxResourceContent = 0.2f }); //noloc
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop = 1 }); //noloc
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "ShrubSpace", ConsumedCapacityPerPop = 3 }); //noloc
                this.BlanketSpawnPercent = 0.6f;
                this.IdealTemperatureRange = new Range(0.4f, 0.6f);
                this.IdealMoistureRange = new Range(0.6f, 0.8f);
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.4f, 0.6f);
                this.MoistureExtremes = new Range(0.6f, 0.8f);
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 5;
            }

            partial void SetDefaultProperties();
        }
    }

    [Serialized]
    [Clearable]
    [MoveEfficiency(0.75f)]
    public partial class CottonBlock :
        InteractablePlantBlock { }
}
