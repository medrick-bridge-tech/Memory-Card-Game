using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private Text text;
        
        private string value;
        private bool isHidden = true;
        public string Value => value;
        public bool IsHidden => isHidden;
        public void Setup(string value)
        {
            this.value = value;
        }
        public void Hide()
        {
            isHidden = true;
        }
        public void Show()
        {
            isHidden = false;
        }
        public void UpdateDisplay()
        {
            if (isHidden)
                text.text = "x";
            else
                text.text = value;
        }

        
    }
}