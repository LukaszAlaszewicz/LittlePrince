using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LP
{ 
    public class QualityLevelChange : MonoBehaviour
    {
        public Dropdown drop;
        public void Start()
        {
            drop.SetValueWithoutNotify(QualitySettings.GetQualityLevel());
        }
        public void SetQuality(int qualityIndex)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
            Debug.Log(QualitySettings.GetQualityLevel());
        }

    }

}