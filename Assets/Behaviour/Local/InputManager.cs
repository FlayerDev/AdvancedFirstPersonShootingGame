using System.Collections.Generic;
using UnityEngine;

namespace Unity.Flayer.InputSystem
{
    public static class InputManager
    {
        public static KeyCode[] KeyCodes = (KeyCode[])System.Enum.GetValues(typeof(KeyCode));

        public static Dictionary<string, KeyCode> KeyBinds = new Dictionary<string, KeyCode>()
        {
            {"None" , KeyCode.None},
            {"Primary", KeyCode.Mouse0 },
            {"Secondary", KeyCode.Mouse1 },
            {"Jump", KeyCode.Space },
            {"Reload", KeyCode.R },
            {"Use", KeyCode.E },
            {"Drop", KeyCode.G },
            {"Console", KeyCode.F1 },
        };

        public static bool GetBind(string key) => KeyBinds.TryGetValue(key, out KeyCode code) ? Input.GetKey(code) : false;

        public static bool GetBindDown(string key) => KeyBinds.TryGetValue(key, out KeyCode code) ? Input.GetKeyDown(code) : false;

        public static bool GetBindUp(string key) => KeyBinds.TryGetValue(key, out KeyCode code) ? Input.GetKeyUp(code) : false;

        public static void ChangeValue(string key)
        {
            
        }

        static KeyCode GetKeyPressed(bool GetKeyDown = false)
        {
            foreach (var item in KeyCodes)
            {
                if (GetKeyDown)
                {
                    if (Input.GetKeyDown(item)) return item;
                }
                else
                {
                    if (Input.GetKey(item)) return item;
                }
            }
            return KeyCode.None;
        }
    }
}