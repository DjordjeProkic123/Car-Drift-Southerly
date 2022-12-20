using System.Collections.Generic;
using UnityEngine;
using PathCreation;


    public class CarBehaviour : MonoBehaviour
    {
        
        public ParticleSystem moneyDrip;
        public ParticleSystem bigMoneyDrip;
        
        public ParticleSystem smoke;

        public bool boostActive = false;

        public PathCreator pathCreator;
        public static  float speed = 4;
        private float boostSpeed;
        float distanceTravelled;

        private float boostTimer = 0f;
        private float boostDuration = 0.8f;

        public GameObject carMesh;

        private float driftCounter = 0;

        public GameObject[] green;

        [SerializeField] private AudioSource UraSound;

        //[SerializeField] private AudioSource driftSound;

        private void Update()
        {   
            if(Input.GetMouseButtonDown(0)){
                boostActive = true;
                boostTimer = boostDuration;
            }
            
            if (boostActive)
            {
                boostSpeed = speed *2;
                Follower(boostSpeed);
                boostTimer -= Time.deltaTime;

                
                    if (boostTimer <= 0)
                {
                    boostActive = false;
                }
            }
            else {
                Follower(speed);
            }
            
        }

        private void Follower(float a){
            distanceTravelled += a * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }

        public void Drift()
        {   
            
            if (boostActive)
            {        
                
                driftCounter = 1;
                
                carMesh.transform.Rotate(0, 60, 0);

                //driftSound.Play();
                
                foreach(var g in green){
                    g.SetActive(true);
                }
                

                bigMoneyDrip.Play();
                
                //GameObject m = GameObject.Find("Manager");
                //MoneySystem moneySystem = m.GetComponent<MoneySystem>();
                MoneySystem.earnedMoney =MoneySystem.earnedMoney + ButtonController.moneyVariableA;
                
                smoke.Play();

                UraSound.Play();

            }
            else
            {
                //GameObject m = GameObject.Find("Manager");
                //MoneySystem moneySystem = m.GetComponent<MoneySystem>();
                MoneySystem.earnedMoney =MoneySystem.earnedMoney + ButtonController.moneyVariableB;
                moneyDrip.Play();
            }
        }

        public void StopDrift()
        {   
            if(driftCounter == 1){
                carMesh.transform.Rotate(0,-60f, 0);
                driftCounter = 0;
                foreach(var g in green){
                    g.SetActive(false);
                }
                smoke.Stop();
            }
            

            //foreach (var wheelSmoke in smokeFromWheels)
                //wheelSmoke.Stop();

            //zaustavi zvuk i animaciju za drift
        }

    }

