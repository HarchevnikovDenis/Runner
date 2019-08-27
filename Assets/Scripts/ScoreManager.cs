using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private float timeStartScene;
    public float score;
    [SerializeField]
    private Text scoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        timeStartScene = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        score = ((Time.time - timeStartScene) * 10.0f);
        scoreText.text = score.ToString("0");
    }
}
