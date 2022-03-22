using System;
using UnityEngine;

namespace UI
{
    public class BackToMenuView : MonoBehaviour
    {
        public event Action BackToMenuEvent;

        public void OnBackToMenuEvnet()
        {
            BackToMenuEvent?.Invoke();
        }
    }
}
