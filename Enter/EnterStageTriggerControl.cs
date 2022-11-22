
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Video.Components.Base;

public class EnterStageTriggerControl : UdonSharpBehaviour
{
    [SerializeField] GameObject _trigger;
    [SerializeField] Animator _anim;
    private BaseVRCVideoPlayer vp;

    void Start()
    {
        vp = (BaseVRCVideoPlayer)GetComponent(typeof(BaseVRCVideoPlayer));
    }

    public override void OnVideoEnd()
    {
        _anim.SetTrigger("IsFin");
    }
}
