using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GameObject mainCam; 
	
	//public Rigidbody Cat; 
	
	public string stringToEdit = "";
	public string stringToEdit2 = "";
	
	string Weight; 
	
	string Height; 
	
	double BMI; 
	
	Rect textArea = new Rect(0,0,Screen.width, Screen.height);
	
	

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,160,250), "PlanetFIT Menu");
		
		GUI.Label(new Rect(30,40,160,90), "Human -- John Smith");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,70,130,20), "BMI")) {
			
			mainCam.transform.position = new Vector3 (200, 100, 100); 
		
		}
			
			
			
			if (mainCam.transform.position == new Vector3(200, 100, 100)) {
			
			GUI.Box(new Rect(350,100,160,250), "BMI -- John Smith");
			
			//Rigidbody clone; 
			
			//clone = Instantiate(Cat, transform.position, transform.rotation) as Rigidbody;
           // clone.velocity = transform.TransformDirection(Vector3.forward * 10);
			
			GUI.Label(new Rect(390,130,160,250), "Height");
			
			stringToEdit = GUI.TextField(new Rect(370, 150, 130, 20), stringToEdit, 25);
			
			GUI.Label(new Rect(390,170,160,250), "Weight");
			
			stringToEdit2 = GUI.TextField(new Rect(370, 190, 130, 20), stringToEdit2, 25);
			
			
		//	BMI = ( Weight)/ (( Height * 2) * 703);
			
			print (BMI);
			
			GUI.Button (new Rect(370, 220, 100, 30), "Submit"); 
			
		//	GUI.Label(textArea, BMI); 
			
			GUI.Button (new Rect(0,Screen.height - 50, 100,30), "Back");
			
			if(GUI.Button (new Rect(0,Screen.height - 50, 100,30), "Back")) {
			
			mainCam.transform.position = new Vector3(0, 101, -200); 
		}
			
		}
			

		// Make the second button.
		if(GUI.Button(new Rect(20,100,130,20), "Exercise Tracker")) {
			//Application.LoadLevel(2);
			
			mainCam.transform.position = new Vector3(1082.82f, 182.28f, -633.88f);
		
			
		
	}
		
		GUI.Label(new Rect(30,130,160,90), "Cat");
	
	
	
		if(GUI.Button(new Rect(20,160,130,20), "BMI")) {
			//Application.LoadLevel(1);
				mainCam.transform.position = new Vector3(100, 100, 100);
			
		}
			
			if (mainCam.transform.position == new Vector3(100, 100, 100)) {
			
			GUI.Box(new Rect(350,100,160,250), "BMI -- Cat");
			
			//Rigidbody clone; 
			
			//clone = Instantiate(Cat, transform.position, transform.rotation) as Rigidbody;
           // clone.velocity = transform.TransformDirection(Vector3.forward * 10);
			
			GUI.Label(new Rect(390,130,160,250), "Height");
			
			stringToEdit = GUI.TextField(new Rect(370, 150, 130, 20), stringToEdit, 25);
			
			GUI.Label(new Rect(390,170,160,250), "Weight");
			
			stringToEdit2 = GUI.TextField(new Rect(370, 190, 130, 20), stringToEdit2, 25);
			
			//BMI = ( Weight)/ (( Height * 2) * 703);
			
			if (GUI.Button (new Rect(370, 220, 100, 30), "Submit")) {
				
			//print (BMI);
			
				
			} 
			
		GUI.Button (new Rect(0,Screen.height - 50, 100,30), "Back");
			
			}
		

		// Make the second button.
		if(GUI.Button(new Rect(20,190,130,20), "Calorie Tracker")) {
			
			mainCam.transform.position = new Vector3(2643f,460f,10);
			
			
			
}
		
		
		if(GUI.Button (new Rect(0,Screen.height - 50, 100,30), "Back")) {
			
			mainCam.transform.position = new Vector3(0, 101, -200); 
		}
		
		
		
	}
}
	

