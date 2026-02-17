using UnityEngine;

public class UnicornHornBehaviour : MonoBehaviour
{
    [SerializeField] Material hornMat;
    Color rndColor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Select()
    {
        rndColor = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        hornMat.color = rndColor;
    }
}
