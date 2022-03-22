using System;
using UnityEngine;

namespace UI
{
    public class ChangeHPView : MonoBehaviour
    {
        public event Action IncreaseEvent;
        public event Action DecreaseEvent;

        public void OnIncreaseEvent()
        {
            IncreaseEvent?.Invoke();
        }

        public void OnDecreaseEvent()
        {
            DecreaseEvent?.Invoke();
        }
    }
}
