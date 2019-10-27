using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject phone;
    public Camera camera;
    public float timer;
    public float totalTime = 30f;
    public int score = 0;
    public float position = 0.2f;
    public float time;
    public float distance = 6f;
    public TextMesh fScore;

    // Start is called before the first frame update
    void Start()
    {
        Transport();
        time = 0f;
        timer = totalTime;
         
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit)){
            if(hit.transform.name == "Phone"){
                time = time + Time.deltaTime;
            }
            else {
                time = 0f; 
            }
        }
        if(position <= time && timer >= 0f){
                time = 0f;
                Transport();

                score = score + 1;

                Debug.Log(score); 
            }

            timer = timer - Time.deltaTime;
            if(timer >= 0f){
                fScore.text = "Score: " + score; 
                fScore.text += "\nTimer: " +  Mathf.Floor(timer);
            }
            else{

                fScore.text = "Final Score:" + score;
            }
            
    }

    void  Transport() {

        float angle = Random.Range(0, 360);

        phone.transform.position = new Vector3(
            Mathf.Sin(angle) * distance, Random.Range(0, distance), Mathf.Cos(angle) * distance 
        ); 
    }
}
