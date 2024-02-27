using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [Header("Value To Scale To")]
    [SerializeField] private float xValue;
    [SerializeField] private float yValue;
    [SerializeField] private float zValue;

    [Header("Speed To Scale Object")]
    [SerializeField] private float tweenTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        Tween();
    }

    private void Tween()
    {
        LeanTween.cancel(gameObject);

        LeanTween.scale(gameObject, new Vector3(xValue, yValue, zValue), tweenTime).setEaseInOutSine();
    }
}
