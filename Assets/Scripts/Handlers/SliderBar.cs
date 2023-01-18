using Controllers.Player;
using UnityEngine;
using UnityEngine.UI;


public class SliderBar : MonoBehaviour
{
    public GemManager gemManager;
    public Slider _bar;
    public PlayerPhysicsController _playerPhysicsController;
    public static SliderBar instance;
    private void Awake()
    {
        _bar = GameObject.Find("Slider").GetComponent<Slider>();
        instance = this;
    }
    
    private void Start()
    {
      
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            _bar.value += 2;
        }

    }

    void Update()
    {
        if (gemManager.gem20 == true)
        {
            Debug.Log("you win 20 gem");
        }
        if (gemManager.gem50 == true)
        {
            Debug.Log("you win 50 gem");
        }
        if (gemManager.gem100 == true)
        {
            Debug.Log("you win 100 gem");
        }
        
        
        
    }
}
