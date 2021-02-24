﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Linq;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModHidden : ManiaModPlayfieldCover
    {
        public override string Description => @"Keys fade out before you hit them!";
        public override double ScoreMultiplier => 1;

        public override Type[] IncompatibleMods => base.IncompatibleMods.Append(typeof(ManiaModFadeIn)).ToArray();
    }
}
