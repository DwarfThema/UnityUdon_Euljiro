
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class VideoController : UdonSharpBehaviour
{
    [SerializeField] GameObject[] enterUi;

    public void EnterUI()
    {
        enterUi[0].SetActive(true);
        enterUi[1].SetActive(true);
    }
}
