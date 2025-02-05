using UnityEngine;
using UnityEngine.UI;

public class ImageAnimationManager : MonoBehaviour
{
    [SerializeField, Header("UI�V�X�e��")]
    public ImageAnimation_Gabu[] uiSystems = null;
    [SerializeField, Header("�摜")]
    public Image[] images = null;
    [SerializeField, Header("pixsels per unit multiplie.�@133pixel�̉~�g���Ă�Ȃ�2���炢�ł����Ǝv��")]
    public float pixelsPerUnitMultiplier = 2;

    private void Start()
    {
        if (uiSystems == null)
        {
            Debug.LogWarning(gameObject.name+"uiSystems����ł�:" + uiSystems.Length);
            enabled = false;
        }
        foreach (var uiSystem in uiSystems)
        {
            uiSystem.SetPpuMultiplier(pixelsPerUnitMultiplier);
        }
        foreach (var image in images)
        {
            image.pixelsPerUnitMultiplier = pixelsPerUnitMultiplier;
        }
    }
}
