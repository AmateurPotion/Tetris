using System.Collections;
using UnityEngine.ResourceManagement.Util;

namespace Tetris.Scenes.Basic
{
    public class GameManager : ComponentSingleton<GameManager>
    {
        private void Awake()
        {
            
        }

        private IEnumerator FieldInputUpdater()
        {
            yield break;
        }
    }
}