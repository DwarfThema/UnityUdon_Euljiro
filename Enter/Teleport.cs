
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Teleport : UdonSharpBehaviour
{
    [SerializeField] GameObject _teleportTo;
    public override void Interact()
    {
        Networking.LocalPlayer.TeleportTo(_teleportTo.transform.position, Quaternion.Euler(_teleportTo.transform.rotation.x, _teleportTo.transform.rotation.y - 90, _teleportTo.transform.rotation.z));
    }
}
