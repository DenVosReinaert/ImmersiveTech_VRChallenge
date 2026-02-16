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
        int i = Random.Range(0, 2);

        switch (i)
        {
            case (0):
                rndColor = Color.red;
                break;

                case (1):
                rndColor = Color.blue;
                break;

                case (2):
                rndColor = Color.green;
                break;
        }
        hornMat.color = rndColor;
    }
}
