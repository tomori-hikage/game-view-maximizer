using UnityEditor;
using System;

namespace SIN.Editor
{
    public class GameViewMaximizer
    {
        [MenuItem("Window/Maximize GameView %#x")]
        private static void MaximizeGameView()
        {
            var gameViewWindowType = Type.GetType("UnityEditor.GameView,UnityEditor");
            var window = EditorWindow.GetWindow(gameViewWindowType);
            window.maximized = !window.maximized;
        }
    }
}