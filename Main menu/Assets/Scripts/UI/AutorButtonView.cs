using System;
using UnityEngine;

namespace UI
{ 
    public class AutorButtonView : MonoBehaviour
    {
        public event Action AutorEvent;

        public void OnAutorEvent()
        {
            AutorEvent?.Invoke();
        }
    }
}
