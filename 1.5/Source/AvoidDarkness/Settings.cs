﻿using UnityEngine;
using Verse;

namespace AvoidDarkness;

public class Settings : ModSettings
{
    //Use Mod.settings.setting to refer to this setting.
    public bool setting = true;

    public void DoWindowContents(Rect wrect)
    {
        Listing_Standard options = new Listing_Standard();
        options.Begin(wrect);

        options.CheckboxLabeled("AvoidDarkness_Settings_SettingName".Translate(), ref setting);
        options.Gap();

        options.End();
    }

    public override void ExposeData()
    {
        Scribe_Values.Look(ref setting, "setting", true);
    }
}