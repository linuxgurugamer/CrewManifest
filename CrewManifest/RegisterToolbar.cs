using UnityEngine;
using ToolbarControl_NS;
using KSP_Log;

namespace CrewManifest
{

    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RegisterToolbar : MonoBehaviour
    {
        internal static Log Log = null;

        public const string MODID = "CM";
        public const string MODNAME = "Crew Manifest";


        void Awake()
        {
            if (Log == null)
#if DEBUG
                Log = new Log("CrewManifest", Log.LEVEL.INFO);
#else
                Log = new Log("CrewManifest", Log.LEVEL.ERROR);
#endif

        }


        void Start()
        {
            ToolbarControl.RegisterMod(MODID, MODNAME);
        }

#if false
        static public bool initted = false;
            static public GUIStyle buttonLeft;


            void OnGUI()
            {
                if (!initted)
                {
                    GUI.skin = HighLogic.Skin;

                    initted = true;
                    buttonLeft = new GUIStyle(GUI.skin.label);
                    buttonLeft.alignment = TextAnchor.MiddleLeft;

                }
            }
#endif
    }
}

