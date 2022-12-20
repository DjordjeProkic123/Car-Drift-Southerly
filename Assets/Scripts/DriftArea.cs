using UnityEngine;


    
    public class DriftArea : MonoBehaviour
    {


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Car"))
            other.GetComponent<CarBehaviour>().Drift();
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Car"))
            other.GetComponent<CarBehaviour>().StopDrift();
        }
    }

