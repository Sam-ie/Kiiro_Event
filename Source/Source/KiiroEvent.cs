using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace Kiiro_Event
{
    [StaticConstructorOnStartup]
    public class Kiiro_Event_Patch
    {
        static Kiiro_Event_Patch()
        {
            Harmony harmony = new Harmony("Alfie.KiiroEvent");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
