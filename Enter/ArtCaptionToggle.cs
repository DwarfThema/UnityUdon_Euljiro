
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ArtCaptionToggle : UdonSharpBehaviour
{
    Animator captionAnim;

    void Start()
    {
        captionAnim = (Animator)gameObject.GetComponent(typeof(Animator));
    }

    public override void Interact()
    {
        if(captionAnim.GetBool("isOn")){
            captionAnim.SetBool("isOn",false);
        }else{
            captionAnim.SetBool("isOn",true);
        }
    }
}
