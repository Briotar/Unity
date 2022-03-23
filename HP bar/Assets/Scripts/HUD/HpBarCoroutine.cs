using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HpBarCoroutine : MonoBehaviour
    {
        public void StartHpBarCoroutine(Slider slider, float targetHP, float speed)
        {
            StartCoroutine(MovingHPBar(slider, targetHP, speed)); ;
        }

        private IEnumerator MovingHPBar(Slider slider, float targetHP, float speed)
        {
            while (slider.normalizedValue != targetHP && slider.normalizedValue != 0 && slider.normalizedValue != 1)
            {
                slider.normalizedValue = Mathf.MoveTowards(slider.normalizedValue, targetHP, speed * Time.deltaTime);

                yield return new WaitForSeconds(.01f);
            }
        }
    }

}
