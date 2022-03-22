using System;
using UnityEngine;

namespace UI
{
    public class ExitButtonView : MonoBehaviour
    {
        public event Action ExitEvent;

        public void OnExitEvent()
        {
            ExitEvent?.Invoke();
        }
    }
}
