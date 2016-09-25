using UnityEngine;
using System.Collections;

public class RagePixelMario : MonoBehaviour {
	//Storing the reference to RagePixelSprite -component
	private IRagePixel ragePixel;													// er moet worden gewezen op het feit dat er gebruik wordt gemaakt van een extensie.

	// de start wordt opgeroepen op het moment dat het spel wordt gestart.
	void Start () {
		ragePixel = GetComponent<RagePixelSprite>();
	}
	
	Vector3 richting = new Vector3();											// een die demensionaal punt wordt aangemaakt onder de naam richting op 0,0,0       0 op de x    0 op de y    0 op de z

	// Update wordt continu aangeroepen.
	void Update () {
		// als
		if (Input.GetKey(KeyCode.LeftArrow)) {
			ragePixel.SetHorizontalFlip(true);										// de sprites worden omgedraaid
			ragePixel.PlayNamedAnimation("LOPEN");									// de animatie van lopen wordt afgespeeld
			richting = new Vector3(-1f, 0f, 0f);									// de richting wordt gezet,  een drie demensionaal punt
		} // anders als
		else if (Input.GetKey(KeyCode.RightArrow)) {
			ragePixel.SetHorizontalFlip(false);										// de sprites worden terug gezet naar de standaard
			ragePixel.PlayNamedAnimation("LOPEN");									// de animatie van lopen wordt afgespeeld.
			richting = new Vector3(1f, 0f, 0f);										// de richting wordt gezet 
		} // anders
		else {
			ragePixel.PlayNamedAnimation("STILSTAAN");								// de animatie van stilstaan wordt afgespeeld
			richting = new Vector3(0f, 0f, 0f);										// de richting wordt gezet 
		}
		transform.Translate(richting * 90 * Time.deltaTime);						// de speler wordt verplaatst door de plek waar hij nu staat + de richting * 90 om de kracht te versnellen * een frame tijd factor 
	}																				//  (dit is een getal rond de een dat er voor zorgt dat de beweging er op elke computer het erhetzelfde uit ziet, of je nou een oude of nieuwe computer hebt)
}