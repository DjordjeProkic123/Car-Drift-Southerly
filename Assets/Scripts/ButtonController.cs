using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    // Start is called before the first frame update
    //public GameObject newCar;
    //public GameObject newModel;

    public  float countingCars = 2;

    public Button addingCarButton;
    public Button mergeButton;
    public Button updateCrowdButton;
    public Button nextMapButton;

    public  GameObject[] modelList;

    public  GameObject[] crowdList;

    private static int a = 0;
    private static int b = 0;

    public static int moneyVariableA = 10;
    public static int moneyVariableB = 5;

    [SerializeField] private AudioSource buttonSound;

    //napravi listu i koristi lista[A] gde je a neki integer koji ce samo da se pomera za jedan gore pri svakoj iteraciji
    //u najgorem slucaju dodaj promenljivu B koja pomaze

     private void Update() {

        //GameObject m = GameObject.Find("Manager");
        //MoneySystem moneySystem = m.GetComponent<MoneySystem>();

        if(MoneySystem.earnedMoney < 100 || countingCars == 0){
            addingCarButton.interactable = false;
        }
        else{
            addingCarButton.interactable = true;
        }
        if(MoneySystem.earnedMoney < 300 || countingCars != 0){
            mergeButton.interactable = false;
        }
        else{
            mergeButton.interactable = true;
        }
        if(MoneySystem.earnedMoney < 400){
            updateCrowdButton.interactable = false;
        }
        else{
            updateCrowdButton.interactable = true;
        }
        if(MoneySystem.earnedMoney < 500){
            nextMapButton.interactable = false;
        }
        else{
            nextMapButton.interactable = true;
        }
        
    }

    public void addingCar()
    {   
        buttonSound.Play();

        //GameObject m = GameObject.Find("Manager");
        //MoneySystem moneySystem = m.GetComponent<MoneySystem>();

        if(MoneySystem.earnedMoney >= 100){
            Vector3 pos = new Vector3(-2.432f, -0.002f ,4.726f );
        
            if(countingCars > 0){
            //pristupi na svaki objekat car i ukoliko je u range blizu pocetne pozicije odlozi instantiate

            //GameObject car = GameObject.FindWithTag("Car");
            
                //Instantiate(modelList[a], pos, modelList[a].transform.rotation);
                modelList[a].SetActive(true);
                a = a + 1;
                countingCars = countingCars -1;
                MoneySystem.earnedMoney = MoneySystem.earnedMoney - 100;
                
                if(countingCars == 0){
                
                addingCarButton.interactable = false;

                 }
            
            
            }
        }
        
        
    }

    public void merge(){

        buttonSound.Play();

        //GameObject m = GameObject.Find("Manager");
        //MoneySystem moneySystem = m.GetComponent<MoneySystem>();

        if(MoneySystem.earnedMoney >= 300){
            if(countingCars == 0){

                GameObject.FindWithTag("Car").SetActive(false);
                GameObject.FindWithTag("Car").SetActive(false);
                GameObject.FindWithTag("Car").SetActive(false);   

            //Instantiate(modelList[a+1]);
            modelList[a].SetActive(true);

            a = a + 1;

            MoneySystem.earnedMoney = MoneySystem.earnedMoney - 300;
            countingCars = 2;

            //GameObject auto = GameObject.Find("Car");
            //CarBehaviour carB = auto.GetComponent<CarBehaviour>();

            //carB.speed = carB.speed + 2;

            CarBehaviour.speed = CarBehaviour.speed + 1;

        }
        }
        
    }

    public void upgradeCrowd(){

        buttonSound.Play();

        //GameObject m = GameObject.Find("Manager");
       // MoneySystem moneySystem = m.GetComponent<MoneySystem>();

        if(MoneySystem.earnedMoney >= 400){
                GameObject.FindWithTag("Crowd").SetActive(false);

                crowdList[b].SetActive(true);
                b = b + 1;
                MoneySystem.earnedMoney = MoneySystem.earnedMoney - 400;

                moneyVariableA = moneyVariableA + 5;
                moneyVariableB = moneyVariableB + 5;
        }
       
        
    }

    public void nextMap(){  
        buttonSound.Play();

       // GameObject m = GameObject.Find("Manager");
        //MoneySystem moneySystem = m.GetComponent<MoneySystem>();

        if(MoneySystem.earnedMoney >= 500){
            int numberOfScene = (SceneManager.GetActiveScene().buildIndex + 1) % 3;
            SceneManager.LoadScene(numberOfScene);

            MoneySystem.earnedMoney = MoneySystem.earnedMoney - 500;
        }
    }
            
        
}
