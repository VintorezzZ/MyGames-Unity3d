using UnityEngine;

public class DoNotDestroyOnLoad : MonoBehaviour
{
    public static DoNotDestroyOnLoad instance;
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
