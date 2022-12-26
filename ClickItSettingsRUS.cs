using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using System.Windows.Forms;

namespace ClickIt
{
    public class ClickItSettings : ISettings
    {
        public ToggleNode Enable { get; set; } = new ToggleNode(true);

        [Menu("Enable these if you run into a bug", 900)]
        public EmptyNode EmptyTesting { get; set; } = new EmptyNode();

        [Menu("Debug Mode", "You should only use this if you encounter an issue with the plugin. " +
            "It will flood your screen with debug information that you can provide on the plugin thread to help narrow down the issue.", 1, 900)]
        public ToggleNode DebugMode { get; set; } = new ToggleNode(false);

        [Menu("Additional Debug Information - Render", "Provides more debug text related to rendering the overlay. ", 2, 900)]
        public ToggleNode RenderDebug { get; set; } = new ToggleNode(false);

        [Menu("Report Bug", "If you run into a bug, please report it here.", 3, 900)]
        public ButtonNode ReportBugButton { get; set; } = new ButtonNode();


        [Menu("Accessibility", 1000)]
        public EmptyNode EmptyAccessibility { get; set; } = new EmptyNode();
        [Menu("Left-handed", "Changes the primary mouse button the plugin uses from left to right.", 1, 1000)]
        public ToggleNode LeftHanded { get; set; } = new ToggleNode(false);

        [Menu("Cache", 2000)]
        public EmptyNode EmptyCaching { get; set; } = new EmptyNode();
        [Menu("Caching", "Enables caching, improving CPU load while picking up items.\n\n" +
            "Reload the plugin below if you change this setting!", 1, 2000)]
        public ToggleNode CachingEnable { get; set; } = new ToggleNode(true);
        [Menu("Reload", "Press this when you toggle between caching and no caching", 2, 2000)]
        public ButtonNode ReloadPluginButton { get; set; } = new ButtonNode();
        [Menu("Cache Refresh Interval", "How often the cache refreshes. Higher value will typically mean less CPU load on your system, but more chance to missclick labels.", 3, 2000)]
        public RangeNode<int> CacheInterval { get; set; } = new RangeNode<int>(20, 5, 200);


        [Menu("General", 3000)]
        public EmptyNode Click { get; set; } = new EmptyNode();

        [Menu("Hotkey", "Held hotkey to start clicking", 1, 3000)]
        public HotkeyNode ClickLabelKey { get; set; } = new HotkeyNode(Keys.F1);

        [Menu("Wait Time Between Clicks", "Time between clicks in milliseconds\n\n" +
            "You will get disconnected for clicking too fast if setting this too low.", 2, 3000)]
        public RangeNode<int> WaitTimeInMs { get; set; } = new RangeNode<int>(55, 20, 200);

        [Menu("Search Radius", "Radius the plugin will search in for interactable objects.", 1, 3000)]
        public RangeNode<int> ClickDistance { get; set; } = new RangeNode<int>(95, 0, 300);

        [Menu("Items", "Click items", 2, 3000)]
        public ToggleNode ClickItems { get; set; } = new ToggleNode(true);

        [Menu("Ignore Unique Items", "Ignore unique items, aside from metamorph organs", 3, 3000)]
        public ToggleNode IgnoreUniques { get; set; } = new ToggleNode(false);

        //[Menu("Not yet implemented", 2, 3000)]
        //public ToggleNode MouseProximityMode { get; set; } = new ToggleNode(false);
        [Menu("Basic Chests", "Click normal (non-league related) chests", 6, 3000)]
        public ToggleNode ClickBasicChests { get; set; } = new ToggleNode(false);

        [Menu("League Mechanic 'Chests'", "Click league mechanic related 'chests' (blight pustules, legion war hoards / chests, sentinel caches, etc)", 7, 3000)]
        public ToggleNode ClickLeagueChests { get; set; } = new ToggleNode(true);

        [Menu("Shrines", "Click shrines", 8, 3000)]
        public ToggleNode ClickShrines { get; set; } = new ToggleNode(true);

        [Menu("Nearest Harvest", "Click nearest harvest", 9, 3000)]
        public ToggleNode NearestHarvest { get; set; } = new ToggleNode(true);

        [Menu("Area Transitions", "Click area transitions", 10, 3000)]
        public ToggleNode ClickAreaTransitions { get; set; } = new ToggleNode(false);

        [Menu("Block when Left or Right Panel open", "Prevent clicks when the inventory or character screen are open", 11, 3000)]
        public ToggleNode BlockOnOpenLeftRightPanel { get; internal set; } = new ToggleNode(true);

        [Menu("Chest Height Offset", "If you're experiencing a lot of missclicking for chests specifically (clicking too high or low),\n" +
            "change this value. If you're clicking too high, lower the value, if you're clicking too low, raise the value", 12, 3000)]
        public RangeNode<int> ChestHeightOffset { get; set; } = new RangeNode<int>(0, -100, 100);

        [Menu("Block User Input", "Blocks the user from moving the mouse / clicking while the hotkey is held. Will help stop missclicking.", 13, 3000)]
        public ToggleNode BlockUserInput { get; internal set; } = new ToggleNode(true);

        [Menu("Hide / Show Items occasionally", "This will occasionally double tap your Toggle Items Hotkey to correct the position of ground items / labels", 14, 3000)]
        public ToggleNode ToggleItems { get; set; } = new ToggleNode(true);

        [Menu("Toggle Items Hotkey", "Hotkey to toggle the display of ground items / labels", 15, 3000)]
        public HotkeyNode ToggleItemsHotkey { get; set; } = new HotkeyNode(Keys.Z);


        [Menu("Essences", 3500)]
        public EmptyNode Essences { get; set; } = new EmptyNode();

        [Menu("Essences", "Click essences", 1, 3500)]
        public ToggleNode ClickEssences { get; set; } = new ToggleNode(true);

        [Menu("Open Inventory Hotkey", "Hotkey to open your inventory", 2, 3500)]
        public HotkeyNode OpenInventoryKey { get; set; } = new HotkeyNode(Keys.I);

        [Menu("Corrupt Essences", "Corrupt misery, envy, dread, scorn.", 3, 3500)]
        public ToggleNode CorruptEssences { get; set; } = new ToggleNode(true);

        [Menu("Corrupt Essences that typically result in profit", "Corrupt certain essences that typically result in a profit (Currently: Loathing).\n\n" +
            "Warning: This may result in you losing money, check the price of the essences listed above occasionally during the league.", 4, 3500)]
        public ToggleNode CorruptProfitableEssences { get; set; } = new ToggleNode(true);

        [Menu("Corrupt Essences which don't contain a shrieking essence", "Corrupt any essences that don't have a shrieking essence on them.\n\n" +
            "This is for if you use the 'Crystal Resonance' atlas passive, which duplicates monsters when they contain a shrieking essence.", 5, 3500)]
        public ToggleNode CorruptAnyNonShrieking { get; set; } = new ToggleNode(true);


        [Menu("Searing Exarch", 4000)]
        public EmptyNode ExarchAltar { get; set; } = new EmptyNode();

        [Menu("Click recommended option",
            "Clicks searing exarch altars for you based on a decision tree created from your settings." +
            "\n\nIf both options are as good as each other (according to your weights), this won't click for you.", 1, 4000)]
        public ToggleNode ClickExarchAltars { get; set; } = new ToggleNode(false);

        [Menu("Highlight recommended option",
            "Highlights the recommended option for you to choose for searing exarch altars, based on a decision tree created from your settings below.", 2, 4000)]
        public ToggleNode HighlightExarchAltars { get; set; } = new ToggleNode(true);


        [Menu("Searing Exarch Mod Weights - Downsides (Map Boss)", 5000)]
        public EmptyNode ExarchDownsideMapBossMods { get; set; } = new EmptyNode();

        [Menu("Map Boss:    Создает освященную землю при нанесении удара, длящуюся 6 секунд", 1, 5000)]
        public ToggleNode Exarch_MapBossCreateConsecratedGroundonHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 2, 5000)]
        public RangeNode<int> Exarch_MapBossCreateConsecratedGroundonHit_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:    +10% к максимальному сопротивлению огню\n" +
            "                       +80% к сопротивлению огню\n" +
            "                       +10% к максимальному сопротивлению хаосу\n" +
            "                       +80% к сопротивлению хаосу  ", 3, 5000)]
        public ToggleNode Exarch_MapBosstoMaximumFireResistance { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 4, 5000)]
        public RangeNode<int> Exarch_MapBosstoMaximumFireResistance_Weight
        { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:    +50000 к броне ", 5, 5000)]
        public ToggleNode Exarch_MapBossToArmour { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 6, 5000)]
        public RangeNode<int> Exarch_MapBossToArmour_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:    Дарует (50 to 80)% от физического урона в виде дополнительного урона от огня\n" +
            "                       Покрывает врагов пеплом при нанесении удара ", 7, 5000)]
        public ToggleNode Exarch_MapBossGainofPhysicalDamageasExtraFire { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 8, 5000)]
        public RangeNode<int> Exarch_MapBossGainofPhysicalDamageasExtraFire_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Map Boss:    Отравляет при нанесении удара\n" +
            "                       Весь урон от ударов может наложить отравление ", 11, 5000)]
        public ToggleNode Exarch_MapBossPoisonOnHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 12, 5000)]
        public RangeNode<int> Exarch_MapBossPoisonOnHit_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:    Враги теряют 6 заряда(-ов) флакона каждые 3 секунды и не могут получать\n" +
            "                       заряды флакона в течение 6 секунд после получения удара", 13, 5000)]
        public ToggleNode Exarch_MapBossEnemiesLoseFlaskChargesEverySeconds { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 14, 5000)]
        public RangeNode<int> Exarch_MapBossEnemiesLoseFlaskChargesEverySeconds_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:    Дарует (50 to 80)% физического урона в виде дополнительного урона от случайной стихии\n" +
            "                       Урон пробивает (15 to 25)% вражеского сопротивления стихиям", 15, 5000)]
        public ToggleNode Exarch_MapBossGainOfPhysicalDamageAsExtraDamageOfARandomElement { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 16, 5000)]
        public RangeNode<int> Exarch_MapBossGainOfPhysicalDamageAsExtraDamageOfARandomElement_Weight { get; set; } = new RangeNode<int>(65, 1, 100);

        [Menu("Map Boss:    Ваши удары накладывают Злословие\n" +
            "                       (10% reduced damage dealt, 10% increased damage taken)", 16, 5000)]
        public ToggleNode Exarch_MapBossYourHitsInflictMalediction { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 17, 5000)]
        public RangeNode<int> Exarch_MapBossYourHitsInflictMalediction_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:    Ваши удары всегда накладывают поджог\n" +
            "                       Дарует (70 to 130)% от физического урона в виде дополнительного урона от огня\n" +
            "                       Весь урон может наложить поджог ", 18, 5000)]
        public ToggleNode Exarch_MapBossHitsAlwaysIgnite { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 19, 5000)]
        public RangeNode<int> Exarch_MapBossHitsAlwaysIgnite_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Map Boss:    Дарует (70 to 130)% от физического урона в виде дополнительного урона хаосом\n" +
            "                       Отравляет при нанесении удара\n" +
            "                       Весь урон от ударов может наложить отравление ", 20, 5000)]
        public ToggleNode Exarch_MapBossGainOfPhysicalDamageAsExtraChaos { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 21, 5000)]
        public RangeNode<int> Exarch_MapBossGainOfPhysicalDamageAsExtraChaos_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Map Boss:    (100 to 200)% повышение брони\n" +
            "                       (100 to 200)% увеличение уклонения  ", 22, 5000)]
        public ToggleNode Exarch_MapBossIncreasedArmour { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 23, 5000)]
        public RangeNode<int> Exarch_MapBossIncreasedArmour_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:    Ближайшие враги скованы, их скорость передвижения снижена на", 24, 5000)]
        public ToggleNode Exarch_MapBossNearbyEnemiesAreHindered { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 25, 5000)]
        public RangeNode<int> Exarch_MapBossNearbyEnemiesAreHindered_Weight { get; set; } = new RangeNode<int>(40, 1, 100);



        [Menu("Searing Exarch Mod Weights - Downsides (Eldritch Minions)", 6000)]
        public EmptyNode ExarchDownsideMinionsMods { get; set; } = new EmptyNode();

        [Menu("Eldritch Minions:    При смерти оставляет горящую землю, длящуюся 3 секунды ", 1, 6000)]
        public ToggleNode Exarch_EldritchMinionsDropsBurningGroundOnDeath { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 2, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsDropsBurningGroundOnDeath_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

        [Menu("Eldritch Minions:    Создает освящённую землю при смерти, длящуюся 6 секунд  ", 3, 6000)]
        public ToggleNode Exarch_EldritchMinionsCreateConsecratedGroundOnDeath { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 4, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsCreateConsecratedGroundOnDeath_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:    Дарует (70 to 130)% физического урона в виде дополнительного урона от случайной стихии\n" +
            "                                   Накладывает восприимчивость к огню, холоду и молнии при нанесении удара ", 5, 6000)]
        public ToggleNode Exarch_EldritchMinionsGainOfPhysicalDamageAsExtraDamageOfARandomElement { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 6, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsGainOfPhysicalDamageAsExtraDamageOfARandomElement_Weight { get; set; } = new RangeNode<int>(70, 1, 100);

        [Menu("Eldritch Minions:    Враги теряют 6 заряда(-ов) флакона каждые 3 секунды и не могут получать\n" +
            "                                   заряды флакона в течение 6 секунд после получения удара  ", 7, 6000)]
        public ToggleNode Exarch_EldritchMinionsEnemiesLoseFlaskChargesEvery { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 8, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsEnemiesLoseFlaskChargesEvery_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:    +10% к максимальному сопротивлению огню\n" +
            "                                   +80% к сопротивлению огню\n" +
            "                                   +10% к максимальному сопротивлению хаосу\n" +
            "                                   +80% к сопротивлению хаосу ", 9, 6000)]
        public ToggleNode Exarch_EldritchMinionsToMaximumFireResistance { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 10, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsToMaximumFireResistance_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:    +50000 к броне", 11, 6000)]
        public ToggleNode Exarch_EldritchMinionsToArmour { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 12, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsToArmour_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:    (70 to 130)% увеличение области действия ", 13, 6000)]
        public ToggleNode Exarch_EldritchMinionsIncreasedAreaOfEffect { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 14, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsIncreasedAreaOfEffect_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:    (250 to 500)% увеличение уклонения ", 15, 6000)]
        public ToggleNode Exarch_EldritchMinionsIncreasedEvasionRating { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 16, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsIncreasedEvasionRating_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:    Ваши удары всегда накладывают поджог\n" +
            "                                   Весь урон может наложить поджог ", 17, 6000)]
        public ToggleNode Exarch_EldritchMinionsHitsAlwaysIgnite { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 18, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsHitsAlwaysIgnite_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

        [Menu("Eldritch Minions:    Отравляет при нанесении удара\n" +
            "                                   Весь урон от ударов может наложить отравление ", 19, 6000)]
        public ToggleNode Exarch_EldritchMinionsPoisonOnHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 20, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsPoisonOnHit_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:    Проклинает врагов Беззащитностью при нанесении удара\n" +
            "                                   (Take 30% increased Physical Damage)", 21, 6000)]
        public ToggleNode Exarch_EldritchMinionsCurseEnemiesWithVulnerabilityOnHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 22, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsCurseEnemiesWithVulnerabilityOnHit_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Eldritch Minions:    Дарует (70 to 130)% от физического урона в виде дополнительного урона хаосом ", 23, 6000)]
        public ToggleNode Exarch_EldritchMinionsGainOfPhysicalDamageAsExtraChaos { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 24, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsGainOfPhysicalDamageAsExtraChaos_Weight { get; set; } = new RangeNode<int>(65, 1, 100);

        [Menu("Eldritch Minions:    Дарует (70 to 130)% от физического урона в виде дополнительного урона от огня ", 25, 6000)]
        public ToggleNode Exarch_EldritchMinionsGainOfPhysicalDamageAsExtraFire { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 26, 6000)]
        public RangeNode<int> Exarch_EldritchMinionsGainOfPhysicalDamageAsExtraFire_Weight { get; set; } = new RangeNode<int>(40, 1, 100);



        [Menu("Searing Exarch Mod Weights - Downsides (Player)", 7000)]
        public EmptyNode ExarchDownsidePlayerMods { get; set; } = new EmptyNode();

        [Menu("Player:  (-60 to -40)% к сопротивлению огню\n" +
            "               (-60 to -40)% к сопротивлению хаосу ", 1, 7000)]
        public ToggleNode Exarch_PlayerToFireResistance { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 2, 7000)]
        public RangeNode<int> Exarch_PlayerToFireResistance_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Player:  -3000 к броне\n" +
            "               -3000 to Evasion Rating  ", 3, 7000)]
        public ToggleNode Exarch_PlayerToArmour { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 4, 7000)]
        public RangeNode<int> Exarch_PlayerToArmour_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  (20 to 40)% увеличение используемого количества зарядов флакона\n" +
            "               (40 to60)% уменьшение длительности эффекта флакона ", 5, 7000)]
        public ToggleNode Exarch_PlayerIncreasedFlaskChargesUsed { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 6, 7000)]
        public RangeNode<int> Exarch_PlayerIncreasedFlaskChargesUsed_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Player:  Получает 600 урона хаосом в секунду во время действия любого эффекта флакона ", 7, 7000)]
        public ToggleNode Exarch_PlayerTakeChaosDamagePerSecondDuringAnyFlaskEffect { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 8, 7000)]
        public RangeNode<int> Exarch_PlayerTakeChaosDamagePerSecondDuringAnyFlaskEffect_Weight { get; set; } = new RangeNode<int>(100, 1, 100);

        [Menu("Player:  Удары чарами с (20 to 30)% шансом могут сковать вас ", 9, 7000)]
        public ToggleNode Exarch_PlayerSpellHitsHaveChanceToHinderYou { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 10, 7000)]
        public RangeNode<int> Exarch_PlayerSpellHitsHaveChanceToHinderYou_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Player:  Весь получаемый урон от ударов может опалить вас\n" +
            "               (25 to 35)% шанс получить Опаление при получении удара ", 11, 7000)]
        public ToggleNode Exarch_PlayerAllDamageTakenFromHitsCanScorchYou { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 12, 7000)]
        public RangeNode<int> Exarch_PlayerAllDamageTakenFromHitsCanScorchYou_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  Накладываемые вами проклятия отражаются обратно на вас ", 13, 7000)]
        public ToggleNode Exarch_PlayerCursesYouInflictAreReflectedBackToYou { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 14, 7000)]
        public RangeNode<int> Exarch_PlayerCursesYouInflictAreReflectedBackToYou_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  (15 to 20)% шанс для врагов оставить горящую землю при нанесении удара по вам, но не чаще, чем раз каждые 2 секунды", 15, 7000)]
        public ToggleNode Exarch_PlayerChanceForEnemiesToDropBurningGroundWhenHittingYou { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 16, 7000)]
        public RangeNode<int> Exarch_PlayerChanceForEnemiesToDropBurningGroundWhenHittingYou_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

        [Menu("Player:  30% шанс стать целью Метеорита, когда вы используете флакон ", 17, 7000)]
        public ToggleNode Exarch_PlayerChanceToBeTargetedByAMeteor { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 18, 7000)]
        public RangeNode<int> Exarch_PlayerChanceToBeTargetedByAMeteor_Weight { get; set; } = new RangeNode<int>(100, 1, 100);

        [Menu("Player:  Ближайшие враги наносят 100% от их физического урона в виде дополнительного урона от огня ", 19, 7000)]
        public ToggleNode Exarch_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraFire { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 20, 7000)]
        public RangeNode<int> Exarch_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraFire_Weight { get; set; } = new RangeNode<int>(60, 1, 100);

        [Menu("Player:  Ближайшие враги наносят 100% от их физического урона в виде дополнительного урона хаосом ", 21, 7000)]
        public ToggleNode Exarch_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraChaos { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 22, 7000)]
        public RangeNode<int> Exarch_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraChaos_Weight { get; set; } = new RangeNode<int>(85, 1, 100);



        [Menu("Searing Exarch Mod Weights - Upsides (Map Boss)", 8000)]
        public EmptyNode ExarchUpsideMapBossMods { get; set; } = new EmptyNode();

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительного пробужденного секстантаs ", 3, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalAwakenedSextants { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 4, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalAwakenedSextants_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительной сферы сплетения ", 5, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalOrbsOfBinding { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 6, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalOrbsOfBinding_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительной сферы горизонтов ", 7, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalOrbsOfHorizons { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 8, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalOrbsOfHorizons_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительной сферы небытия ", 9, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalOrbsOfUnmaking { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 10, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalOrbsOfUnmaking_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительного резца картографа ", 11, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalCartographer { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 12, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalCartographer_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительного мелкого древнего уголька ", 13, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalLesserEldritchEmbers { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 14, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalLesserEldritchEmbers_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительного крупного древнего уголька ", 15, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGreaterEldritchEmbers { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 16, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGreaterEldritchEmbers_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительного великого древнего уголька ", 17, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGrandEldritchEmbers { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 18, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGrandEldritchEmbers_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных мистических сфер хаоса", 19, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalEldritchChaosOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 20, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalEldritchChaosOrbs_Weight { get; set; } = new RangeNode<int>(85, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных мистических сфер возвышения", 21, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalEldritchExaltedOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 22, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalEldritchExaltedOrbs_Weight { get; set; } = new RangeNode<int>(75, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных мистических сфер отмены", 23, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalEldritchOrbsOfAnnulment { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 24, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalEldritchOrbsOfAnnulment_Weight { get; set; } = new RangeNode<int>(80, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) additional Orbs of Annulment ", 25, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalOrbsOfAnnulment { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 26, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalOrbsOfAnnulment_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) additional Vaal Orbs ", 27, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalVaalOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 28, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalVaalOrbs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) additional Enkindling Orbs ", 29, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalEnkindlingOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 30, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalEnkindlingOrbs_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) additional Instilling Orbs ", 31, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalInstillingOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 32, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalInstillingOrbs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) additional Orbs of Regret ", 33, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalOrbsOfRegret { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 34, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalOrbsOfRegret_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) additional Glassblower's Baubles ", 35, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGlassblowersBaubles { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 36, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGlassblowersBaubles_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) additional Gemcutter's Prisms", 35, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGemcuttersPrisms { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 36, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGemcuttersPrisms_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер хаоса", 37, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalChaosOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 38, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalChaosOrbs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Бестиария", 39, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedBestiaryScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 40, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedBestiaryScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Бестиария", 41, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedBestiaryScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 42, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedBestiaryScarabs_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Бестиария", 43, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedBestiaryScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 44, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedBestiaryScarabs_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Мучений", 45, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedTormentScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 46, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedTormentScarabs_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Мучений", 47, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedTormentScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 48, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedTormentScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Мучений", 49, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedTormentScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 50, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedTormentScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Метаморфа", 51, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedMetamorphScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 52, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedMetamorphScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Метаморфа", 53, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedMetamorphScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 54, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedMetamorphScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Метаморфа", 55, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedMetamorphScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 56, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedMetamorphScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Скверны", 57, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedBlightScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 58, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedBlightScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Скверны", 59, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedBlightScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 60, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedBlightScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Скверны", 61, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedBlightScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 62, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedBlightScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых реликтовых скарабеев", 63, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedReliquaryScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 64, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedReliquaryScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких реликтовых скарабеев", 65, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedReliquaryScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 66, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedReliquaryScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных реликтовых скарабеев", 67, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedReliquaryScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 68, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedReliquaryScarabs_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев предсказания", 69, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedDivinationScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 70, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedDivinationScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев предсказания", 71, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedDivinationScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 72, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedDivinationScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев предсказания", 73, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedDivinationScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 74, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedDivinationScarabs_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Создателя", 75, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedShaperScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 76, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedShaperScarabs_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Создателя", 77, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedShaperScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 78, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedShaperScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Создателя", 79, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedShaperScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 80, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedShaperScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев картографии", 81, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalRustedCartographyScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 82, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalRustedCartographyScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев картографии", 83, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalPolishedCartographyScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 84, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalPolishedCartographyScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев картографии", 85, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalGildedCartographyScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 86, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalGildedCartographyScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на уникальный предмет", 87, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueItem { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 88, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueItem_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на уникальное оружие", 89, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueWeapon { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 90, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueWeapon_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на уникальную броню", 91, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueArmour { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 92, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueArmour_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на уникальную бижутерию", 93, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardUniqueJewellery { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 94, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardUniqueJewellery_Weight { get; set; } = new RangeNode<int>(60, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на оскверненный уникальный предмет", 95, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardACorruptedUniqueItem { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 96, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardACorruptedUniqueItem_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на оскверненный уникальный предмет", 97, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAMap { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 98, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAMap_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на уникальную карту", 99, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueMap { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 100, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardAUniqueMap_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на оскверненный предмет", 101, 8000)]
        public ToggleNode Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardACorruptedItem { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 102, 8000)]
        public RangeNode<int> Exarch_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardACorruptedItem_Weight { get; set; } = new RangeNode<int>(20, 1, 100);



        [Menu("Searing Exarch Mod Weights - Upsides (Eldritch Minions)", 9000)]
        public EmptyNode ExarchUpsideEldritchMinionsMods { get; set; } = new EmptyNode();

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной божественной сферы ", 1, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivineOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 2, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivineOrb_Weight { get; set; } = new RangeNode<int>(100, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного пробужденного секстанта ", 3, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalAwakenedSextant { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 4, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalAwakenedSextant_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы сплетения ", 5, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfBinding { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 6, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfBinding_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы горизонтов ", 7, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfHorizons { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 8, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfHorizons_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы небытия ", 9, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfUnmaking { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 10, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfUnmaking_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного резца картографа ", 11, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalCartographersChisel { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 12, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalCartographersChisel_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного мелкого древнего уголька ", 13, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalLesserEldritchEmber { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 14, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalLesserEldritchEmber_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного крупного древнего уголька ", 15, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGreaterEldritchEmber { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 16, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGreaterEldritchEmber_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного великого древнего уголька ", 17, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGrandEldritchEmber { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 18, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGrandEldritchEmber_Weight { get; set; } = new RangeNode<int>(45, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной мистической сферы хаоса ", 19, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalEldritchChaosOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 20, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalEldritchChaosOrb_Weight { get; set; } = new RangeNode<int>(97, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной мистической сферы возвышения ", 21, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalEldritchExaltedOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 22, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalEldritchExaltedOrb_Weight { get; set; } = new RangeNode<int>(92, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной мистической сферы отмены ", 23, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalEldritchOrbOfAnnulment { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 24, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalEldritchOrbOfAnnulment_Weight { get; set; } = new RangeNode<int>(94, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы отмены ", 25, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfAnnulment { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 26, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfAnnulment_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы ваал ", 25, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalVaalOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 26, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalVaalOrb_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной растопляющей сферы ", 27, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalEnkindlingOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 28, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalEnkindlingOrb_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной дополнительной вливающей сферы ", 29, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalInstillingOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 30, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalInstillingOrb_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной дополнительной сферы раскаяния ", 31, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfRegret { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 32, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalOrbOfRegret_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной стекольной массы ", 33, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGlassblowersBauble { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 34, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGlassblowersBauble_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной призмы камнереза ", 35, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGemcuttersPrism { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 36, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGemcuttersPrism_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы хаоса ", 37, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalChaosOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 38, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalChaosOrb_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Разлома ", 39, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedBreachScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 40, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedBreachScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Разлома ", 41, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedBreachScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 42, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedBreachScarab_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Разлома ", 43, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedBreachScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 44, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedBreachScarab_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Мучения ", 45, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedTormentScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 46, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedTormentScarab_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Мучения ", 47, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedTormentScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 48, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedTormentScarab_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Мучения ", 49, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedTormentScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 50, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedTormentScarab_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Метаморфа ", 51, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedMetamorphScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 52, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedMetamorphScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Метаморфа ", 53, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedMetamorphScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 54, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedMetamorphScarab_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Метаморфа ", 55, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedMetamorphScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 56, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedMetamorphScarab_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Скверны ", 57, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedBlightScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 58, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedBlightScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Скверны ", 59, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedBlightScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 60, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedBlightScarab_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Скверны ", 61, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedBlightScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 62, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedBlightScarab_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого реликтового скарабея ", 63, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedReliquaryScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 64, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedReliquaryScarab_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого реликтового скарабея ", 65, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedReliquaryScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 66, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedReliquaryScarab_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного реликтового скарабея ", 67, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedReliquaryScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 68, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedReliquaryScarab_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея предсказания ", 69, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedDivinationScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 70, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedDivinationScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея предсказания ", 71, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedDivinationScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 72, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedDivinationScarab_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея предсказания ", 73, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedDivinationScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 74, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedDivinationScarab_Weight { get; set; } = new RangeNode<int>(45, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Создателя ", 75, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedShaperScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 76, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedShaperScarab_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Создателя ", 77, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedShaperScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 78, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedShaperScarab_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Создателя ", 79, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedShaperScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 80, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedShaperScarab_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея картографии ", 81, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalRustedCartographyScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 82, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalRustedCartographyScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея картографии ", 83, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedCartographyScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 84, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalPolishedCartographyScarab_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея картографии ", 85, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalGildedCartographyScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 86, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalGildedCartographyScarab_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на уникальный предмет ", 87, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueItem { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 88, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueItem_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на уникальное оружие ", 89, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueWeapon { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 90, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueWeapon_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на уникальную броню ", 91, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueArmour { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 92, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueArmour_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на уникальную бижутерию ", 93, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsUniqueJewellery { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 94, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsUniqueJewellery_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на оскверненный уникальный предмет ", 95, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsACorruptedUniqueItem { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 96, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsACorruptedUniqueItem_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на карту ", 97, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAMap { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 98, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAMap_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на уникальную карту ", 99, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueMap { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 100, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsAUniqueMap_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на оскверненный предмет ", 101, 9000)]
        public ToggleNode Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsACorruptedItem { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 102, 9000)]
        public RangeNode<int> Exarch_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsACorruptedItem_Weight { get; set; } = new RangeNode<int>(15, 1, 100);



        [Menu("Searing Exarch Mod Weights - Upsides (Player)", 10000)]
        public EmptyNode ExarchUpsidePlayerMods { get; set; } = new EmptyNode();

        [Menu("Player:  	Выпадающие из убитых врагов уникальные предметы с (15 to 30)% шансом может быть продублирована  ", 1, 10000)]
        public ToggleNode Exarch_PlayerUniqueItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 2, 10000)]
        public RangeNode<int> Exarch_PlayerUniqueItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов скарабеи с (15 to 30)% шансом может быть продублирована   ", 3, 10000)]
        public ToggleNode Exarch_PlayerScarabsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 4, 10000)]
        public RangeNode<int> Exarch_PlayerScarabsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов карты с (15 to 30)% шансом может быть продублирована   ", 5, 10000)]
        public ToggleNode Exarch_PlayerMapsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 6, 10000)]
        public RangeNode<int> Exarch_PlayerMapsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов гадальные карты с (15 to 30)% шансом может быть продублирована   ", 5, 10000)]
        public ToggleNode Exarch_PlayerDivinationCardsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 6, 10000)]
        public RangeNode<int> Exarch_PlayerDivinationCardsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Player:  	(10 to 30)% увеличение количества найденных предметов в этой области\n" +
            "                   (15 to 35)% повышение редкости найденных предметов в этой области ", 7, 10000)]
        public ToggleNode Exarch_PlayerIncreasedQuantityOfItemsFoundInThisArea { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 8, 10000)]
        public RangeNode<int> Exarch_PlayerIncreasedQuantityOfItemsFoundInThisArea_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  	Выпадающая из убитых врагов простая валюта с (10 to 15)% шансом может быть продублирована", 9, 10000)]
        public ToggleNode Exarch_PlayerBasicCurrencyItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 10, 10000)]
        public RangeNode<int> Exarch_PlayerBasicCurrencyItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов камни с (10 to 15)% шансом может быть продублирована ", 11, 10000)]
        public ToggleNode Exarch_PlayerGemsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 12, 10000)]
        public RangeNode<int> Exarch_PlayerGemsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(1, 1, 100);



        [Menu("Eater of Worlds", 11000)]
        public EmptyNode EaterAltar { get; set; } = new EmptyNode();

        [Menu("Click recommended option",
            "Clicks searing exarch altars for you based on a decision tree created from your settings." +
            "\n\nIf both options are as good as each other (according to your weights), this won't click for you.", 1, 11000)]
        public ToggleNode ClickEaterAltars { get; set; } = new ToggleNode(false);

        [Menu("Highlight recommended option",
            "Highlights the recommended option for you to choose for searing exarch altars, based on a decision tree created from your settings below.", 2, 11000)]
        public ToggleNode HighlightEaterAltars { get; set; } = new ToggleNode(true);


        [Menu("Eater of Worlds Mod Weights - Downsides (Map Boss)", 12000)]
        public EmptyNode EaterDownsideMapBossMods { get; set; } = new EmptyNode();

        [Menu("Map Boss:    +10% к максимальному сопротивлению холоду\n" +
            "                       +80% к сопротивлению холоду\n" +
            "                       +10% к максимальному сопротивлению молнии\n" +
            "                       +80% к сопротивлению молнии ", 3, 12000)]
        public ToggleNode Eater_MapBosstoMaximumColdResistance
        { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 4, 12000)]
        public RangeNode<int> Eater_MapBosstoMaximumColdResistance_Weight
        { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:    (50 to 70)% дополнительного уменьшения получаемого физического урона ", 5, 12000)]
        public ToggleNode Eater_MapBossAdditionalPhysicalDamageReduction { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 6, 12000)]
        public RangeNode<int> Eater_MapBossAdditionalPhysicalDamageReduction_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:    Весь урон от ударов может наложить охлаждение ", 7, 12000)]
        public ToggleNode Eater_MapBossAllDamageWtihHitsCanChill { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 8, 12000)]
        public RangeNode<int> Eater_MapBossAllDamageWtihHitsCanChill_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:    Ваши удары всегда накладывают шок\n" +
            "                       Дарует (70 to 130)% от физического урона в виде дополнительного урона от молнии\n" +
            "                       Весь урон может наложить шок ", 9, 12000)]
        public ToggleNode Eater_MapBossHitsAlwaysShock { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 10, 12000)]
        public RangeNode<int> Eater_MapBossHitsAlwaysShock_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Map Boss:    Предотвращает получение +(20 to 30)% урона от подавленных чар\n" +
            "                       +100% шанс подавить урон от чар ", 11, 12000)]
        public ToggleNode Eater_MapBossPreventOfSuppressedSpellDamage { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 12, 12000)]
        public RangeNode<int> Eater_MapBossPreventOfSuppressedSpellDamage_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:    Дарует (50–80)% физического урона в виде дополнительного урона от случайной стихии\n" +
            "                       Урон пробивает (15–25)% вражеского сопротивления стихиям ", 13, 12000)]
        public ToggleNode Eater_MapBossGainOfPhysicalDamageAsExtraDamageOfARandomElement { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 14, 12000)]
        public RangeNode<int> Eater_MapBossGainOfPhysicalDamageAsExtraDamageOfARandomElement_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:    Дарует (50 to 130)% от физического урона в виде дополнительного урона от холода\n" +
            "                       Покрывает противников инеем при нанесении удара ", 15, 12000)]
        public ToggleNode Eater_MapBossGainOfPhysicalDamageAsExtraColdDamage { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 16, 12000)]
        public RangeNode<int> Eater_MapBossGainOfPhysicalDamageAsExtraColdDamage_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:    100% глобальный шанс ослепить врага при нанесении удара\n" +
            "                       (100 to 200)% усиление эффекта ослепления ", 16, 12000)]
        public ToggleNode Eater_MapBossGlobalChanceToBlindEnemiesOnHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 17, 12000)]
        public RangeNode<int> Eater_MapBossGlobalChanceToBlindEnemiesOnHit_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:    Дарует (50 to 70)% от максимума здоровья в виде дополнительного максимума энергетического щита ", 18, 12000)]
        public ToggleNode Eater_MapBossGainOfMaximumLifeAsExtraMaximumEnergyShield { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 19, 12000)]
        public RangeNode<int> Eater_MapBossGainOfMaximumLifeAsExtraMaximumEnergyShield_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Map Boss:    Древние щупальца", 20, 12000)]
        public ToggleNode Eater_MapBossEldritchTentacles { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 21, 12000)]
        public RangeNode<int> Eater_MapBossEldritchTentacles_Weight { get; set; } = new RangeNode<int>(40, 1, 100);




        [Menu("Eater of Worlds Mod Weights - Downsides (Eldritch Minions)", 13000)]
        public EmptyNode EaterDownsideMinionsMods { get; set; } = new EmptyNode();

        [Menu("Eldritch Minions:    Подавляет (50 to 80)% уменьшения получаемого физического урона ", 1, 13000)]
        public ToggleNode Eater_EldritchMinionsOverwhelmPhysicalDamageReduction { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 2, 13000)]
        public RangeNode<int> Eater_EldritchMinionsOverwhelmPhysicalDamageReduction_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:    Умения выпускают (3 to 5) дополнительных снарядов:", 3, 13000)]
        public ToggleNode Eater_EldritchMinionsSkillsFireAdditionalProjectiles { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 4, 13000)]
        public RangeNode<int> Eater_EldritchMinionsSkillsFireAdditionalProjectiles_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Eldritch Minions:    (30 to 50)% повышение скорости атаки\n" +
            "                               (30 to 50)% повышение скорости сотворения чар\n" +
            "                               (30 to 50)% повышение скорости передвижения ", 5, 13000)]
        public ToggleNode Eater_EldritchMinionsIncreasedAttackSpeed { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 6, 13000)]
        public RangeNode<int> Eater_EldritchMinionsIncreasedAttackSpeed_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:    +10% к максимальному сопротивлению холоду\n" +
            "                               +80% к сопротивлению холоду\n" +
            "                               +10% к максимальному сопротивлению молнии\n" +
            "                               +80% к сопротивлению молнии ", 7, 13000)]
        public ToggleNode Eater_EldritchMinionsToMaximumColdResistance { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 8, 13000)]
        public RangeNode<int> Eater_EldritchMinionsToMaximumColdResistance_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:    (50 to 80)% дополнительного уменьшения получаемого физического урона ", 9, 13000)]
        public ToggleNode Eater_EldritchMinionsToMaximumFireResistance { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 10, 13000)]
        public RangeNode<int> Eater_EldritchMinionsToMaximumFireResistance_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:    Предотвращает получение +(20 to 30)% урона от подавленных чар\n" +
            "                               +100% шанс подавить урон от чар ", 11, 13000)]
        public ToggleNode Eater_EldritchMinionsPreventOfSuppressedSpellDamage { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 12, 13000)]
        public RangeNode<int> Eater_EldritchMinionsPreventOfSuppressedSpellDamage_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:    100% шанс удалить случайный заряд у врага при нанесении удара ", 13, 13000)]
        public ToggleNode Eater_EldritchMinionsChanceToRemoveARandomChargeFromEnemyOnHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 14, 13000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToRemoveARandomChargeFromEnemyOnHit_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:    При смерти оставляет замёрзшую землю, длящуюся 3 секунды ", 15, 13000)]
        public ToggleNode Eater_EldritchMinionsDropsChilledGroundOnDeath { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 16, 13000)]
        public RangeNode<int> Eater_EldritchMinionsDropsChilledGroundOnDeath_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:    100% шанс создать заряженную землю при смерти, длящуюся 6 секунд ", 17, 13000)]
        public ToggleNode Eater_EldritchMinionsChanceToCreateShockedGroundOnDeath { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 18, 13000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToCreateShockedGroundOnDeath_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:    Накладывает 1 цепкую лиану при нанесении удара ", 19, 13000)]
        public ToggleNode Eater_EldritchMinionsInflictGraspingVineOnHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 20, 13000)]
        public RangeNode<int> Eater_EldritchMinionsInflictGraspingVineOnHit_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:    Проклинает врагов Наказанием при нанесении удара ", 21, 13000)]
        public ToggleNode Eater_EldritchMinionsCurseEnemiesWithPunishmentOnHit { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 22, 13000)]
        public RangeNode<int> Eater_EldritchMinionsCurseEnemiesWithPunishmentOnHit_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:    Дарует (70 to 130)% от физического урона в виде дополнительного урона от молнии ", 23, 13000)]
        public ToggleNode Eater_EldritchMinionsGainOfPhysicalDamageAsExtraLightning { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 24, 13000)]
        public RangeNode<int> Eater_EldritchMinionsGainOfPhysicalDamageAsExtraLightning_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Eldritch Minions:    Дарует (70 to 130)% от физического урона в виде дополнительного урона от холода ", 25, 13000)]
        public ToggleNode Eater_EldritchMinionsGainOfPhysicalDamageAsExtraCold { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 26, 13000)]
        public RangeNode<int> Eater_EldritchMinionsGainOfPhysicalDamageAsExtraCold_Weight { get; set; } = new RangeNode<int>(40, 1, 100);



        [Menu("Eater of Worlds Mod Weights - Downsides (Player)", 14000)]
        public EmptyNode EaterDownsidePlayerMods { get; set; } = new EmptyNode();

        [Menu("Player:  (-60 to -40)% к сопротивлению холоду\n" +
            "               (-60 to -40)% к сопротивлению молнии ", 1, 14000)]
        public ToggleNode Eater_PlayerToColdResistance { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 2, 14000)]
        public RangeNode<int> Eater_PlayerToColdResistance_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Player:  (-60 to -40)% дополнительного уменьшения получаемого физического урона ", 3, 14000)]
        public ToggleNode Eater_PlayerAdditionalPhysicalDamageReduction { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 4, 14000)]
        public RangeNode<int> Eater_PlayerAdditionalPhysicalDamageReduction_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Player:  (30 to 50)% уменьшение защиты за заряд ярости ", 5, 14000)]
        public ToggleNode Eater_PlayerReducedDefencesPerFrenzyCharge { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 6, 14000)]
        public RangeNode<int> Eater_PlayerReducedDefencesPerFrenzyCharge_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Player:  (10 to 20)% снижение скорости восстановления здоровья, маны и энергетического щита за заряд выносливости ", 7, 14000)]
        public ToggleNode Eater_PlayerReducedRecoveryRateOfLifeManaAndEnergyShieldPerEnduranceCharge { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 8, 14000)]
        public RangeNode<int> Eater_PlayerReducedRecoveryRateOfLifeManaAndEnergyShieldPerEnduranceCharge_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Player:  (10 to 20)% снижение скорости перезарядки умений за заряд энергии  ", 7, 14000)]
        public ToggleNode Eater_PlayerReducedCooldownRecoveryRatePerPowerCharge { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 8, 14000)]
        public RangeNode<int> Eater_PlayerReducedCooldownRecoveryRatePerPowerCharge_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  (25 to 35)% шанс для врагов оставить замерзшую землю при нанесении удара по вам, но не чаще, чем раз каждые 2 секунды ", 9, 14000)]
        public ToggleNode Eater_PlayerChanceForEnemiesToDropChilledGroundWhenHittingYou { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 10, 14000)]
        public RangeNode<int> Eater_PlayerChanceForEnemiesToDropChilledGroundWhenHittingYou_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  (25 to 35)% шанс для врагов оставить заряженную землю при нанесении удара по вам, но не чаще, чем раз каждые 2 секунды ", 11, 14000)]
        public ToggleNode Eater_PlayerChanceForEnemiesToDropShockedGroundWhenHittingYou { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 12, 14000)]
        public RangeNode<int> Eater_PlayerChanceForEnemiesToDropShockedGroundWhenHittingYou_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  Весь получаемый урон от ударов может ошеломить вас\n" +
            "               (25 to 35)% шанс получить Ошеломление при получении удара ", 13, 14000)]
        public ToggleNode Eater_PlayerAllDamageTakenFromHitsCanSapYou { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 14, 14000)]
        public RangeNode<int> Eater_PlayerAllDamageTakenFromHitsCanSapYou_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Player:  Ближайшие враги наносят 100% от их физического урона в виде дополнительного урона от холода ", 15, 14000)]
        public ToggleNode Eater_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraCold { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 16, 14000)]
        public RangeNode<int> Eater_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraCold_Weight { get; set; } = new RangeNode<int>(60, 1, 100);

        [Menu("Player:  Ближайшие враги наносят 100% от их физического урона в виде дополнительного урона от молнии ", 17, 14000)]
        public ToggleNode Eater_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraLightning { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 18, 14000)]
        public RangeNode<int> Eater_PlayerNearbyEnemiesGainOfTheirPhysicalDamageAsExtraLightning_Weight { get; set; } = new RangeNode<int>(60, 1, 100);

        [Menu("Player:  Снаряды выпускаются в случайных направлениях ", 19, 14000)]
        public ToggleNode Eater_PlayerProjectilesAreFiredInRandomDirections { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 20, 14000)]
        public RangeNode<int> Eater_PlayerProjectilesAreFiredInRandomDirections_Weight { get; set; } = new RangeNode<int>(100, 1, 100);

        [Menu("Player:  Удары чарами с (25 to 35)% шансом могут сковать вас ", 21, 14000)]
        public ToggleNode Eater_PlayerSpellHitsHaveChanceToHinder { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 22, 14000)]
        public RangeNode<int> Eater_PlayerSpellHitsHaveChanceToHinder_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Player:  Накладываемые вами не-наносящие урон состояние отражаются обратно на вас ", 23, 14000)]
        public ToggleNode Eater_PlayerNonDamagingAilmentsYouInflictAreReflected { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 24, 14000)]
        public RangeNode<int> Eater_PlayerNonDamagingAilmentsYouInflictAreReflected_Weight { get; set; } = new RangeNode<int>(50, 1, 100);

        [Menu("Player:  Number of grasping vines to gain every second while stationary", 25, 14000)]
        public ToggleNode Eater_PlayerNumberOfGraspingVinesToGainEverySecondWhileStationary { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How detrimental is this mod to your build?\n\n" +
            "If you cannot do this mod, set this to 100.\n\n" +
            "If the mod is very difficult, but still doable, a value of 75 would be good.\n\n" +
            "If the mod doesn't affect your build at all, set the weight to 1.", 26, 14000)]
        public RangeNode<int> Eater_PlayerNumberOfGraspingVinesToGainEverySecondWhileStationary_Weight { get; set; } = new RangeNode<int>(100, 1, 100);



        [Menu("Eater of Worlds Mod Weights - Upsides (Map Boss)", 15000)]
        public EmptyNode EaterUpsideMapBossMods { get; set; } = new EmptyNode();

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных божественных сфер ", 1, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivineOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 2, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivineOrbs_Weight { get; set; } = new RangeNode<int>(100, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер возвышения", 3, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalExaltedOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 4, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalExaltedOrbs_Weight { get; set; } = new RangeNode<int>(75, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер царей", 5, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRegalOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 6, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRegalOrbs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер скрытого хаоса", 7, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalVeiledChaosOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 8, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalVeiledChaosOrbs_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер перемен", 9, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalOrbsOfAlteration { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 10, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalOrbsOfAlteration_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных благодатных сфер", 11, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalBlessedOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 12, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalBlessedOrbs_Weight { get; set; } = new RangeNode<int>(12, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных малых зловещих ихоров ", 13, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalLesserEldritchIchors { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 14, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalLesserEldritchIchors_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных средних зловещих ихоров ", 15, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGreaterEldritchIchors { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 16, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGreaterEldritchIchors_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных великих зловещих ихоров ", 17, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGrandEldritchIchors { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 18, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGrandEldritchIchors_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных мистических сфер хаоса", 19, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalEldritchChaosOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 20, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalEldritchChaosOrbs_Weight { get; set; } = new RangeNode<int>(85, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных мистических сфер возвышения", 21, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalEldritchExaltedOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 22, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalEldritchExaltedOrbs_Weight { get; set; } = new RangeNode<int>(75, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных мистических сфер отмены", 23, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalEldritchOrbsOfAnnulment { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 24, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalEldritchOrbsOfAnnulment_Weight { get; set; } = new RangeNode<int>(80, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер очищения", 25, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalOrbsOfScouring { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 26, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalOrbsOfScouring_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных цветных сфер", 27, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalChromaticOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 28, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalChromaticOrbs_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер соединения", 29, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalOrbsOfFusing { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 30, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalOrbsOfFusing_Weight { get; set; } = new RangeNode<int>(7, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер златокузнеца", 31, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalJewellersOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 32, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalJewellersOrbs_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных сфер хаоса", 37, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalChaosOrbs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 38, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalChaosOrbs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Разлома", 39, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedBreachScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 40, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedBreachScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Разлома", 41, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedBreachScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 42, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedBreachScarabs_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Разлома", 43, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedBreachScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 44, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedBreachScarabs_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Древнего", 45, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedElderScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 46, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedElderScarabs_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Древнего", 47, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedElderScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 48, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedElderScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Древнего", 49, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedElderScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 50, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedElderScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых сульфитовых скарабеев", 51, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedSulphiteScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 52, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedSulphiteScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких сульфитовых скарабеев", 53, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedSulphiteScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 54, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedSulphiteScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных сульфитовых скарабеев", 55, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedSulphiteScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 56, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedSulphiteScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Засады", 57, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedAmbushScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 58, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedAmbushScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Засады", 59, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedAmbushScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 60, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedAmbushScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Засады", 61, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedAmbushScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 62, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedAmbushScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Предвестника", 63, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedHarbingerScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 64, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedHarbingerScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Предвестника", 65, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedHarbingerScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 66, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedHarbingerScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Предвестника", 67, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedHarbingerScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 68, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedHarbingerScarabs_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Экспедиции", 69, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedExpeditionScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 70, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedExpeditionScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Экспедиции", 71, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedExpeditionScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 72, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedExpeditionScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Экспедиции", 73, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedExpeditionScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 74, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedExpeditionScarabs_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Легиона", 75, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedLegionScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 76, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedLegionScarabs_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Легиона", 77, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedLegionScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 78, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedLegionScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Легиона", 79, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedLegionScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 80, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedLegionScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных ржавых скарабеев Бездны", 81, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalRustedAbyssScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 82, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalRustedAbyssScarabs_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гладких скарабеев Бездны", 83, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalPolishedAbyssScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 84, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalPolishedAbyssScarabs_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных золочёных скарабеев Бездны", 85, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalGildedAbyssScarabs { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 86, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalGildedAbyssScarabs_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на валюту", 87, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardCurrency { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 88, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardCurrency_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на обычную валюту", 89, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardBasicCurrency { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 90, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardBasicCurrency_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на валюту лиг", 91, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardLeagueCurrency { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 92, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardLeagueCurrency_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на другие гадальные карты", 93, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardOtherDivinationCards { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 94, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardOtherDivinationCards_Weight { get; set; } = new RangeNode<int>(100, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на камни", 95, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardGems { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 96, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardGems_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на камни с уровнем", 97, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardLevelledGems { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 98, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardLevelledGems_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Map Boss:  Из последнего босса выпадает (2 to 4) дополнительных гадальных карт на камни с качеством", 99, 15000)]
        public ToggleNode Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardQualityGems { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 100, 15000)]
        public RangeNode<int> Eater_MapBossFinalBossDropsAdditionalDivinationCardsWhichRewardQualityGems_Weight { get; set; } = new RangeNode<int>(5, 1, 100);



        [Menu("Eater of Worlds Mod Weights - Upsides (Eldritch Minions)", 16000)]
        public EmptyNode EaterUpsideEldritchMinionsMods { get; set; } = new EmptyNode();

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной божественной сферы ", 1, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivineOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 2, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivineOrb_Weight { get; set; } = new RangeNode<int>(100, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы возвышения", 3, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalExaltedOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 4, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalExaltedOrb_Weight { get; set; } = new RangeNode<int>(75, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы царей", 5, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRegalOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 6, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRegalOrb_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы скрытого хаоса", 7, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalVeiledChaosOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 8, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalVeiledChaosOrb_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы перемен", 9, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalOrbOfAlteration { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 10, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalOrbOfAlteration_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной благодатной сферы ", 11, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalBlessedOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 12, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalBlessedOrb_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного мелкого зловещего ихора ", 13, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalLesserEldritchIchor { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 14, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalLesserEldritchIchor_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного крупного зловещего ихора ", 15, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGreaterEldritchIchor { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 16, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGreaterEldritchIchor_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного великого зловещего ихора ", 17, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGrandEldritchIchor { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 18, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGrandEldritchIchor_Weight { get; set; } = new RangeNode<int>(45, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной мистической сферы хаоса ", 19, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalEldritchChaosOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 20, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalEldritchChaosOrb_Weight { get; set; } = new RangeNode<int>(97, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной мистической сферы возвышения ", 21, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalEldritchExaltedOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 22, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalEldritchExaltedOrb_Weight { get; set; } = new RangeNode<int>(92, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной мистической сферы отмены ", 23, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalEldritchOrbOfAnnulment { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 24, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalEldritchOrbOfAnnulment_Weight { get; set; } = new RangeNode<int>(94, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы очищения", 25, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalOrbOfScouring { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 26, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalOrbOfScouring_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной цветной сферы", 27, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalChromaticOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 28, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalChromaticOrb_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы соединения", 29, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalOrbOfFusing { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 30, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalOrbOfFusing_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы златокузнеца ", 31, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalJewellersOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 32, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalJewellersOrb_Weight { get; set; } = new RangeNode<int>(3, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной сферы хаоса ", 37, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalChaosOrb { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 38, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalChaosOrb_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Разлома ", 39, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedBreachScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 40, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedBreachScarab_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Разлома ", 41, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedBreachScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 42, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedBreachScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Разлома ", 43, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedBreachScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 44, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedBreachScarab_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Древнего ", 45, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedElderScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 46, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedElderScarab_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Древнего ", 47, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedElderScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 48, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedElderScarab_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Древнего ", 49, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedElderScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 50, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedElderScarab_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого сульфитового скарабея ", 51, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedSulphiteScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 52, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedSulphiteScarab_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого сульфитового скарабея ", 53, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedSulphiteScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 54, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedSulphiteScarab_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного сульфитового скарабея ", 55, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedSulphiteScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 56, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedSulphiteScarab_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Засады ", 57, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedAmbushScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 58, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedAmbushScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Засады ", 59, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedAmbushScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 60, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedAmbushScarab_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Засады ", 61, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedAmbushScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 62, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedBlightScarab_Weight { get; set; } = new RangeNode<int>(40, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Предвестника ", 63, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedHarbingerScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 64, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedHarbingerScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Предвестника ", 65, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedHarbingerScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 66, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedHarbingerScarab_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Предвестника ", 67, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedHarbingerScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 68, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedHarbingerScarab_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Экспедиции ", 69, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedExpeditionScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 70, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedExpeditionScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Экспедиции ", 71, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedExpeditionScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 72, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedExpeditionScarab_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Экспедиции ", 73, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedExpeditionScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 74, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedExpeditionScarab_Weight { get; set; } = new RangeNode<int>(45, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Легиона ", 75, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedLegionScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 76, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedLegionScarab_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Легиона ", 77, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedLegionScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 78, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedLegionScarab_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Легиона ", 79, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedLegionScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 80, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedLegionScarab_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного ржавого скарабея Бездны ", 81, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalRustedAbyssScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 82, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalRustedAbyssScarab_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного гладкого скарабея Бездны ", 83, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalPolishedAbyssScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 84, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalPolishedAbyssScarab_Weight { get; set; } = new RangeNode<int>(25, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительного золочёного скарабея Бездны ", 85, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalGildedAbyssScarab { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 86, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalGildedAbyssScarab_Weight { get; set; } = new RangeNode<int>(35, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на валюту ", 87, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsCurrency { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 88, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsCurrency_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на простую валюту ", 89, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsBasicCurrency { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 90, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsBasicCurrency_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на валюту лиг ", 91, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsLeagueCurrency { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 92, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsLeagueCurrency_Weight { get; set; } = new RangeNode<int>(30, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на другие гадальные карты ", 93, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsOtherDivinationCards { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 94, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsOtherDivinationCards_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на камни ", 95, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsGems { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 96, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsGems_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на камни с уровнем ", 97, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsLevelledGems { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 98, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsLevelledGems_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Eldritch Minions:  (1.6 to 3.2)% шанс выпадения дополнительной гадальной карты на камни с качеством ", 99, 16000)]
        public ToggleNode Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsQualityGems { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 100, 16000)]
        public RangeNode<int> Eater_EldritchMinionsChanceToDropAnAdditionalDivinationCardWhichRewardsQualityGems_Weight { get; set; } = new RangeNode<int>(5, 1, 100);



        [Menu("Eater of Worlds Mod Weights - Upsides (Player)", 17000)]
        public EmptyNode EaterUpsidePlayerMods { get; set; } = new EmptyNode();

        [Menu("Player:  	Выпадающие из убитых врагов уникальные предметы с (15 to 30)% шансом может быть продублирована  ", 1, 17000)]
        public ToggleNode Eater_PlayerUniqueItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 2, 17000)]
        public RangeNode<int> Eater_PlayerUniqueItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(5, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов скарабеи с (15 to 30)% шансом может быть продублирована   ", 3, 17000)]
        public ToggleNode Eater_PlayerScarabsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 4, 17000)]
        public RangeNode<int> Eater_PlayerScarabsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов карты с (15 to 30)% шансом может быть продублирована   ", 5, 17000)]
        public ToggleNode Eater_PlayerMapsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 6, 17000)]
        public RangeNode<int> Eater_PlayerMapsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов гадальные карты с (15 to 30)% шансом может быть продублирована   ", 7, 17000)]
        public ToggleNode Eater_PlayerDivinationCardsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 8, 17000)]
        public RangeNode<int> Eater_PlayerDivinationCardsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(15, 1, 100);

        [Menu("Player:  	(10 to 20)% увеличение количества найденных предметов в этой области\n" +
            "                   (15 to 35)% повышение редкости найденных предметов в этой области ", 9, 17000)]
        public ToggleNode Eater_PlayerIncreasedQuantityOfItemsFoundInThisArea { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 10, 17000)]
        public RangeNode<int> Eater_PlayerIncreasedQuantityOfItemsFoundInThisArea_Weight { get; set; } = new RangeNode<int>(20, 1, 100);

        [Menu("Player:  	Выпадающая из убитых врагов простая валюта с (10 to 15)% шансом может быть продублирована", 11, 17000)]
        public ToggleNode Eater_PlayerBasicCurrencyItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 12, 17000)]
        public RangeNode<int> Eater_PlayerBasicCurrencyItemsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(10, 1, 100);

        [Menu("Player:  	Выпадающие из убитых врагов камни с (10 to 15)% шансом может быть продублирована ", 13, 17000)]
        public ToggleNode Eater_PlayerGemsDroppedBySlainEnemiesHaveChanceToBeDuplicated { get; set; } = new ToggleNode(false);

        [Menu("Weight", "How good is this reward?\n\n" +
            "If this reward is perfect, and couldn't be better, set it to 100.\n\n" +
            "If the mod is very good, but not amazing, set it to 75.\n\n" +
            "If the mod is garbage, set it to 0.", 14, 17000)]
        public RangeNode<int> Eater_PlayerGemsDroppedBySlainEnemiesHaveChanceToBeDuplicated_Weight { get; set; } = new RangeNode<int>(1, 1, 100);

    }
}
