using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Coins;
    public AudioSource CoinAud;
    public AudioClip CoinSound;
    // Start is called before the first frame update
    public void MakeCoin()
    {
        Object.Instantiate(Coins);
        CoinAud.PlayOneShot(CoinSound);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
