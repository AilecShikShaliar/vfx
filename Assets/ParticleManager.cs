using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


public class ParticleManager : MonoBehaviour
{
    public UnityEvent event01;
    public UnityEvent event02;
    public UnityEvent event03;
    public UnityEvent event04;
    public UnityEvent event05;
    public UnityEvent event06;
    public UnityEvent event07;
    public UnityEvent event08;
    public UnityEvent event09;
  



    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame) event01.Invoke();
        if (Keyboard.current.digit2Key.wasPressedThisFrame) event02.Invoke();
        if (Keyboard.current.digit3Key.wasPressedThisFrame) event03.Invoke();
        if (Keyboard.current.digit4Key.wasPressedThisFrame) event04.Invoke();
        if (Keyboard.current.digit5Key.wasPressedThisFrame) event05.Invoke();
        if (Keyboard.current.digit5Key.wasPressedThisFrame) event06.Invoke();
        if (Keyboard.current.digit5Key.wasPressedThisFrame) event07.Invoke();
        if (Keyboard.current.digit5Key.wasPressedThisFrame) event08.Invoke();
        if (Keyboard.current.digit5Key.wasPressedThisFrame) event09.Invoke();
    }
}
