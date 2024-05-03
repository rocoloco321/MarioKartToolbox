﻿using HaroohiePals.NitroKart.MapData;
using System.Collections.Generic;
using System.Linq;

namespace HaroohiePals.NitroKart.MapObj;

public class MkdsMapObjDatabase : IMkdsMapObjDatabase
{
    private static IReadOnlyDictionary<MkdsMapObjectId, MkdsMapObjInfo> _entries = new Dictionary<MkdsMapObjectId, MkdsMapObjInfo>()
    {
        //Ambient
        {MkdsMapObjectId.BeachWater, new(MkdsMapObjectId.BeachWater, "BeachWater", null, new[]{ "beach_waterA.nsbmd","beach_waterC.nsbmd" })},
        {MkdsMapObjectId.FallsWaterDst, new(MkdsMapObjectId.FallsWaterDst, "FallsWaterDst", null, null)},
        {MkdsMapObjectId.TownWater, new(MkdsMapObjectId.TownWater, "TownWater", null, new[]{ "town_waterA.nsbmd","town_waterC.nsbmd" })},
        {MkdsMapObjectId.WaterSplash, new(MkdsMapObjectId.WaterSplash, "WaterSplash", null, null)},
        {MkdsMapObjectId.YoshiWater, new(MkdsMapObjectId.YoshiWater, "YoshiWater", null, new[]{ "yoshi_waterC.nsbmd" })},
        {MkdsMapObjectId.AmbientSfxEmitter, new(MkdsMapObjectId.AmbientSfxEmitter, "AmbientSfxEmitter", null, null)},
        {MkdsMapObjectId.HyudoroWater, new(MkdsMapObjectId.HyudoroWater, "HyudoroWater", null, new[]{ "hyudoro_waterA.nsbmd","hyudoro_waterC.nsbmd" })},
        {MkdsMapObjectId.BirdSfxEmitter, new(MkdsMapObjectId.BirdSfxEmitter, "BirdSfxEmitter", null, null)},
        {MkdsMapObjectId.MissionBarrier, new(MkdsMapObjectId.MissionBarrier, "MissionBarrier", null, null)},
        {MkdsMapObjectId.MiniStage3Water, new(MkdsMapObjectId.MiniStage3Water, "MiniStage3Water", null, new[]{ "mini_stage3_waterA.nsbmd","mini_stage3_waterC.nsbmd" })},
        {MkdsMapObjectId.Puddle, new(MkdsMapObjectId.Puddle, "Puddle", null, new[]{ "puddle.nsbmd" })},
        {MkdsMapObjectId.LavaSplash, new(MkdsMapObjectId.LavaSplash, "LavaSplash", null, null)},
        {MkdsMapObjectId.HyudoroWaterSplash, new(MkdsMapObjectId.HyudoroWaterSplash, "HyudoroWaterSplash", null, null)},
        {MkdsMapObjectId.MrStageSteam, new(MkdsMapObjectId.MrStageSteam, "MrStageSteam", null, null)},

        //Common
        {MkdsMapObjectId.Itembox, new(MkdsMapObjectId.Itembox, "Itembox (Static)", null, null, IsTimeTrialVisible: false)},
        {MkdsMapObjectId.DummyPole, new(MkdsMapObjectId.DummyPole, "DummyPole", null, null)},
        {MkdsMapObjectId.Woodbox1, new(MkdsMapObjectId.Woodbox1, "Woodbox1", null, null)},
        {MkdsMapObjectId.Coin, new(MkdsMapObjectId.Coin, "Coin", null, null)},
        {MkdsMapObjectId.BalloonController, new(MkdsMapObjectId.BalloonController, "Balloon Controller", null, null)},
        {MkdsMapObjectId.Shine, new(MkdsMapObjectId.Shine, "Shine", null, null)},
        {MkdsMapObjectId.ShineController, new(MkdsMapObjectId.ShineController, "Shine Controller", null, null)},
        {MkdsMapObjectId.Balloon, new(MkdsMapObjectId.Balloon, "Balloon", null, null)},
        {MkdsMapObjectId.MissionGate, new(MkdsMapObjectId.MissionGate, "Mission Gate", null, null)},
        {MkdsMapObjectId.UnkItembox, new(MkdsMapObjectId.UnkItembox, "UnkItembox", null, null)},
        {MkdsMapObjectId.ShineBalloon, new(MkdsMapObjectId.ShineBalloon, "ShineBalloon", null, null)},

        //Obstacle
        {MkdsMapObjectId.MoveItembox, new(MkdsMapObjectId.MoveItembox, "Itembox (Moving)", null, null, IsTimeTrialVisible: false, IsPathRequired: true)},
        {MkdsMapObjectId.KoopaBlock, new(MkdsMapObjectId.KoopaBlock, "KoopaBlock", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.Gear, new(MkdsMapObjectId.Gear, "Gear", null, new[]{ "gear_black.nsbmd","gear_white.nsbmd" })},
        {MkdsMapObjectId.Bridge, new(MkdsMapObjectId.Bridge, "Bridge", null, new[]{ "bridge.nsbmd","bridge.nsbca" })},
        {MkdsMapObjectId.SecondHand, new(MkdsMapObjectId.SecondHand, "SecondHand", null, new[]{ "second_hand.nsbmd" })},
        {MkdsMapObjectId.TestCylinder, new(MkdsMapObjectId.TestCylinder, "TestCylinder", null, new[]{ "test_cylinder.nsbmd" })},
        {MkdsMapObjectId.Pendulum, new(MkdsMapObjectId.Pendulum, "Pendulum", null, new[]{ "pendulum.nsbmd","pendulum_shadow.nsbmd" })},
        {MkdsMapObjectId.RotaryRoom, new(MkdsMapObjectId.RotaryRoom, "RotaryRoom", null, new[]{ "rotary_room.nsbmd" })},
        {MkdsMapObjectId.RotaryBridge, new(MkdsMapObjectId.RotaryBridge, "RotaryBridge", null, new[]{ "rotary_bridge.nsbmd" })},
        {MkdsMapObjectId.Dram, new(MkdsMapObjectId.Dram, "Dram", null, null)},

        //Scenery
        {MkdsMapObjectId.BeachTree1Nocol, new(MkdsMapObjectId.BeachTree1Nocol, "BeachTree1Nocol", null, new[]{ "BeachTree1.nsbmd" })},
        {MkdsMapObjectId.BeachTree1, new(MkdsMapObjectId.BeachTree1, "BeachTree1", null, new[]{ "BeachTree1.nsbmd" })},
        {MkdsMapObjectId.EarthenPipe, new(MkdsMapObjectId.EarthenPipe, "EarthenPipe", null, null)},
        {MkdsMapObjectId.OpaTree1, new(MkdsMapObjectId.OpaTree1, "OpaTree1", null, new[]{ "opa_tree1.nsbmd" })},
        {MkdsMapObjectId.OlgPipe1, new(MkdsMapObjectId.OlgPipe1, "OlgPipe1", null, new[]{ "OlgPipe1.nsbmd" })},
        {MkdsMapObjectId.OlgMush1, new(MkdsMapObjectId.OlgMush1, "OlgMush1", null, new[]{ "OlgMush1.nsbmd" })},
        {MkdsMapObjectId.Of6Yoshi1, new(MkdsMapObjectId.Of6Yoshi1, "Of6Yoshi1", null, new[]{ "of6yoshi1.nsbmd" })},
        {MkdsMapObjectId.Cow, new(MkdsMapObjectId.Cow, "Cow", null, new[]{ "cow.nsbmd","cow.nsbtp" })},
        {MkdsMapObjectId.NsCannon1, new(MkdsMapObjectId.NsCannon1, "NsCannon1", null, new[]{ "NsCannon1.nsbmd" })},
        {MkdsMapObjectId.MiniDokan, new(MkdsMapObjectId.MiniDokan, "MiniDokan", null, new[]{ "mini_dokan.nsbmd" })},
        {MkdsMapObjectId.GardenTree1, new(MkdsMapObjectId.GardenTree1, "GardenTree1", null, new[]{ "GardenTree1.nsbmd" })},
        {MkdsMapObjectId.CrossTree1, new(MkdsMapObjectId.CrossTree1, "CrossTree1", null, new[]{ "CrossTree1.nsbmd" })},
        {MkdsMapObjectId.Teresa, new(MkdsMapObjectId.Teresa, "Boo", null, null)},
        {MkdsMapObjectId.Bakubaku, new(MkdsMapObjectId.Bakubaku, "Bakubaku", null, null)},
        {MkdsMapObjectId.TeresaController, new(MkdsMapObjectId.TeresaController, "TeresaController", null, null)},
        {MkdsMapObjectId.BankTree1, new(MkdsMapObjectId.BankTree1, "BankTree1", null, new[]{ "Bank_Tree1.nsbmd" })},
        {MkdsMapObjectId.GardenTree1Nocol, new(MkdsMapObjectId.GardenTree1Nocol, "GardenTree1Nocol", null, new[]{ "GardenTree1.nsbmd" })},
        {MkdsMapObjectId.Chandelier, new(MkdsMapObjectId.Chandelier, "Chandelier", null, new[]{ "chandelier.nsbmd","chandelier.nsbca" })},
        {MkdsMapObjectId.TownTree1Nocol, new(MkdsMapObjectId.TownTree1Nocol, "TownTree1Nocol", null, new[]{ "TownTree1.nsbmd" })},
        {MkdsMapObjectId.MarioTree3, new(MkdsMapObjectId.MarioTree3, "MarioTree3", null, new[]{ "MarioTree3.nsbmd" })},
        {MkdsMapObjectId.SnowTree1Nocol, new(MkdsMapObjectId.SnowTree1Nocol, "SnowTree1Nocol", null, new[]{ "Snow_Tree1.nsbmd" })},
        {MkdsMapObjectId.TownTree1, new(MkdsMapObjectId.TownTree1, "TownTree1", null, new[]{ "TownTree1.nsbmd" })},
        {MkdsMapObjectId.SnowTree1, new(MkdsMapObjectId.SnowTree1, "SnowTree1", null, new[]{ "Snow_Tree1.nsbmd" })},
        {MkdsMapObjectId.DeTree1Nocol, new(MkdsMapObjectId.DeTree1Nocol, "DeTree1Nocol", null, new[]{ "DeTree1.nsbmd" })},
        {MkdsMapObjectId.DeTree1, new(MkdsMapObjectId.DeTree1, "DeTree1", null, new[]{ "DeTree1.nsbmd" })},
        {MkdsMapObjectId.BankEgg1, new(MkdsMapObjectId.BankEgg1, "BankEgg1", null, new[]{ "BankEgg1.nsbmd" })},
        {MkdsMapObjectId.KinoHouse1, new(MkdsMapObjectId.KinoHouse1, "KinoHouse1", null, new[]{ "KinoHouse1.nsbmd" })},
        {MkdsMapObjectId.KinoHouse2, new(MkdsMapObjectId.KinoHouse2, "KinoHouse2", null, new[]{ "KinoHouse2.nsbmd" })},
        {MkdsMapObjectId.KinoMount1, new(MkdsMapObjectId.KinoMount1, "KinoMount1", null, new[]{ "KinoMount1.nsbmd" })},
        {MkdsMapObjectId.KinoMount2, new(MkdsMapObjectId.KinoMount2, "KinoMount2", null, new[]{ "KinoMount2.nsbmd" })},
        {MkdsMapObjectId.OlaTree1C, new(MkdsMapObjectId.OlaTree1C, "OlaTree1C", null, new[]{ "olaTree1c.nsbmd" })},
        {MkdsMapObjectId.OsaTree1C, new(MkdsMapObjectId.OsaTree1C, "OsaTree1C", null, new[]{ "osaTree1c.nsbmd" })},
        {MkdsMapObjectId.Picture1, new(MkdsMapObjectId.Picture1, "Picture1", null, null)},
        {MkdsMapObjectId.Picture2, new(MkdsMapObjectId.Picture2, "Picture2", null, null)},
        {MkdsMapObjectId.Om6Tree1, new(MkdsMapObjectId.Om6Tree1, "Om6Tree1", null, new[]{ "om6Tree1.nsbmd" })},
        {MkdsMapObjectId.RainStar, new(MkdsMapObjectId.RainStar, "RainStar", null, null)},
        {MkdsMapObjectId.Of6TreeNocol, new(MkdsMapObjectId.Of6TreeNocol, "Of6TreeNocol", null, new[]{ "Of6Tree1.nsbmd" })},
        {MkdsMapObjectId.Of6Tree, new(MkdsMapObjectId.Of6Tree, "Of6Tree", null, new[]{ "Of6Tree1.nsbmd" })},
        {MkdsMapObjectId.TownMonte, new(MkdsMapObjectId.TownMonte, "Pianta", null, null)},
        {MkdsMapObjectId.Airship, new(MkdsMapObjectId.Airship, "Airship", null, null)},
        {MkdsMapObjectId.StopSign, new(MkdsMapObjectId.StopSign, "StopSign", null, null)},

        //Enemy
        {MkdsMapObjectId.Kuribo, new(MkdsMapObjectId.Kuribo, "Goomba", null, null)},
        {MkdsMapObjectId.Rock, new(MkdsMapObjectId.Rock, "Rock", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.Dossun, new(MkdsMapObjectId.Dossun, "Thwomp", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.Stubbed404, new(MkdsMapObjectId.Stubbed404, "Stubbed404", null, null)},
        {MkdsMapObjectId.Bus, new(MkdsMapObjectId.Bus, "Bus", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.WanwanFixed, new(MkdsMapObjectId.WanwanFixed, "Chain Chomp (Fixed)", null, null)},
        {MkdsMapObjectId.WanwanChain, new(MkdsMapObjectId.WanwanChain, "Chain Chomp's Chain", null, null)},
        {MkdsMapObjectId.MkdEfBubble, new(MkdsMapObjectId.MkdEfBubble, "MkdEfBubble", null, null)},
        {MkdsMapObjectId.Choropu, new(MkdsMapObjectId.Choropu, "Choropu", null, null)},
        {MkdsMapObjectId.Car, new(MkdsMapObjectId.Car, "Car", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.Pukupuku, new(MkdsMapObjectId.Pukupuku, "Cheep-Cheep", null, null)},
        {MkdsMapObjectId.Truck, new(MkdsMapObjectId.Truck, "Truck", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.Snowman, new(MkdsMapObjectId.Snowman, "Snowman", null, null)},
        {MkdsMapObjectId.Kanoke64, new(MkdsMapObjectId.Kanoke64, "Kanoke64", null, null)},
        {MkdsMapObjectId.Basabasa, new(MkdsMapObjectId.Basabasa, "Swoop", "Note: spawned by Swoop Spawner (BasabasaSpawner)", null)},
        {MkdsMapObjectId.BasabasaSpawner, new(MkdsMapObjectId.BasabasaSpawner, "Swoop Spawner", null, null)},
        {MkdsMapObjectId.NsKiller1, new(MkdsMapObjectId.NsKiller1, "Cannon (Moving)", null, new[]{ "NsKiller1.nsbmd","NsKiller2.nsbmd","NsKiller2_s.nsbmd" }, IsPathRequired: true)},
        {MkdsMapObjectId.NsKiller2, new(MkdsMapObjectId.NsKiller2, "Bullet Bill", "Note: spawned by Cannon (NsKiller1)", new[]{ "NsKiller2.nsbmd","NsKiller2_s.nsbmd" })},
        {MkdsMapObjectId.MoveTree, new(MkdsMapObjectId.MoveTree, "Move Tree", null, new[]{ "move_tree.nsbmd","move_tree.nsbca" }, IsPathRequired: true)},
        {MkdsMapObjectId.MkdEfBurner, new(MkdsMapObjectId.MkdEfBurner, "MkdEfBurner", null, new[]{ "mkd_ef_burner.nsbmd","mkd_ef_burner.nsbta" })},
        {MkdsMapObjectId.WanwanMove, new(MkdsMapObjectId.WanwanMove, "Chain Chomp (Moving)", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.ObPakkun, new(MkdsMapObjectId.ObPakkun, "Piranha Plant (2D)", null, null)},
        {MkdsMapObjectId.Poo, new(MkdsMapObjectId.Poo, "Rocky Wrench", null, null)},
        {MkdsMapObjectId.Bound, new(MkdsMapObjectId.Bound, "Bound", null, null)},
        {MkdsMapObjectId.Flipper, new(MkdsMapObjectId.Flipper, "Flipper", null, null)},
        {MkdsMapObjectId.Pakkun, new(MkdsMapObjectId.Pakkun, "Piranha Plant (3D)", null, null)},
        {MkdsMapObjectId.PakkunFire, new(MkdsMapObjectId.PakkunFire, "PakkunFire", null, null)},
        {MkdsMapObjectId.Crab, new(MkdsMapObjectId.Crab, "Crab", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.Sun, new(MkdsMapObjectId.Sun, "Sun", null, null, IsPathRequired: true)},
        {MkdsMapObjectId.SunFireSnake, new(MkdsMapObjectId.SunFireSnake, "SunFireSnake", null, null)},
        {MkdsMapObjectId.Fireball2, new(MkdsMapObjectId.Fireball2, "Fireball2", null, new[]{ "fireball2.nsbmd" })},
        {MkdsMapObjectId.IronBall, new(MkdsMapObjectId.IronBall, "Iron Ball", null, new[]{ "IronBall.nsbmd" }, IsPathRequired: true)},
        {MkdsMapObjectId.Rock2, new(MkdsMapObjectId.Rock2, "Rock2", null, null)},
        {MkdsMapObjectId.Sanbo, new(MkdsMapObjectId.Sanbo, "Pokey", null, null)},
        {MkdsMapObjectId.IronBallNocol, new(MkdsMapObjectId.IronBallNocol, "Iron Ball (No Collision)", null, new[]{ "IronBall.nsbmd" })},
        {MkdsMapObjectId.Cream, new(MkdsMapObjectId.Cream, "Cream", null, null)},
        {MkdsMapObjectId.Berry, new(MkdsMapObjectId.Berry, "Berry", null, null)},
        {MkdsMapObjectId.Unk438MrParticle, new(MkdsMapObjectId.Unk438MrParticle, "Unk438MrParticle", null, null)},

        //Boss
        {MkdsMapObjectId.BossDonketu, new(MkdsMapObjectId.BossDonketu, "Big Bully", null, null)},
        {MkdsMapObjectId.KingIceDonketu, new(MkdsMapObjectId.KingIceDonketu, "King Chill Bully", null, null)},
        {MkdsMapObjectId.KuriKing, new(MkdsMapObjectId.KuriKing, "King Goomba", null, null)},
        {MkdsMapObjectId.BombKing, new(MkdsMapObjectId.BombKing, "King Bob-omb", null, null)},
        {MkdsMapObjectId.IwanteL, new(MkdsMapObjectId.IwanteL, "Eyerok", null, null)},
        {MkdsMapObjectId.Hanachan, new(MkdsMapObjectId.Hanachan, "Wiggler", null, null)},
        {MkdsMapObjectId.KingTeresa, new(MkdsMapObjectId.KingTeresa, "King Boo", null, null)},
        {MkdsMapObjectId.HanachanBodyPart, new(MkdsMapObjectId.HanachanBodyPart, "Wiggler's Body Part", null, null)},
        {MkdsMapObjectId.Unk511MrParticle, new(MkdsMapObjectId.Unk511MrParticle, "Unk511MrParticle", null, null)},
        {MkdsMapObjectId.IwanteController, new(MkdsMapObjectId.IwanteController, "Eyerok Controller", null, null)},
    };

    public IReadOnlyList<MkdsMapObjInfo> GetAll() => _entries.Values.ToList();
    public MkdsMapObjInfo GetById(MkdsMapObjectId id) => _entries.ContainsKey(id) ? _entries[id] : null;
}