﻿using HaroohiePals.Gui;
using System.Collections.Generic;

namespace HaroohiePals.MarioKartToolbox.Gui
{
    internal static class IconConsts
    {
        public static ImGuiIcon[] Icons = new ImGuiIcon[]
        {
            new ImGuiIcon(Resources.Icons.Model3D_16x, FileTypes.Model, 16),
            new ImGuiIcon(Resources.Icons.TrafficCone_16x, FileTypes.MapData, 16),
            new ImGuiIcon(Resources.Icons.ImageStack_16x, FileTypes.Animation, 16),
        };

        public static Dictionary<string, char> FileExtIcons = new Dictionary<string, char>
        {
            { ".nkm", FileTypes.MapData },
            { ".nsbmd", FileTypes.Model },
            { ".nsbtp", FileTypes.Animation },
        };

        public static class MapData
        {
            //todo
        }

        public static class FileTypes
        {
            public static char MapData = FontAwesome6.Map[0];
            public static char Model = FontAwesome6.Cube[0];
            public static char Animation = FontAwesome6.Images[0];
        }
    }
}