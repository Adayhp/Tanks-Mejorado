using UnityEngine;
using System.Collections;

public class PickUpHealth : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag("PickUp"))
		{

			other.gameObject.SetActive(false);

			Rigidbody targetRigidbody = GetComponent<Rigidbody>();
			TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();

			float heal = 30f;

			targetHealth.TakeHeal(heal); 
		}
		
	}
	
}




/* ESTO ESTA BIEN, FALTA HACER QUE SOLO FUNCIONE SI TIENES MENOS DE 100 DE VIDA Y QUE APAREZCA RANDOM
 * 
 public class PickUpHealth : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag("PickUp"))
		{

			other.gameObject.SetActive(false);

			Rigidbody targetRigidbody = GetComponent<Rigidbody>();
			TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();

			float heal = 20f;

			targetHealth.TakeHeal(heal); 
		}
		
	}
	
}
*/