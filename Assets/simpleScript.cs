using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Michsky.UI.ModernUIPack
{
    public class simpleScript : MonoBehaviour
    {
        public int money = 1000;
        public TMP_Text text;
        public ProgressBar progressBar;

        public void sell()
        {
            text.text = (money + 10).ToString();
            money += 10;
            progressBar.currentPercent = 0;
            progressBar.specifiedValue -= 10;
        }

        public void buy()
        {
            text.text = (money - 10).ToString();
            money -= 10;
            progressBar.specifiedValue += 10;
        }

    }
}
