
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Video.Components.Base;

public class VideoRetry : UdonSharpBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] GameObject[] enterUi;
    [SerializeField] BaseVRCVideoPlayer vp;

    public override void Interact()
    {
        enterUi[0].SetActive(false);
        enterUi[1].SetActive(false);
        _anim.SetTrigger("Retry");
        vp.Play();
    }
}
