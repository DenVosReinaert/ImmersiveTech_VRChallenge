using UnityEngine;

public class RadioBehaviour : MonoBehaviour
{


    [SerializeField] GameObject soundEmitter;

    public void ToggleRadio()
    {
        soundEmitter.SetActive(!soundEmitter.activeSelf);
    }
}
