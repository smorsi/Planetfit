using UnityEngine;
using System.Collections;

public class LoadTrackers : MonoBehaviour {

GameObject ExerciseTracker; 
GameObject CalorieTracker; 
	
public Camera mainCam; 
	
public float ScalingFactor=1.0f; 
	
		void Start() {
		
		LoadExerciseTrackerImage();
		LoadCalorieTrackerImage();
		
	}
	
	
	
	public void LoadExerciseTrackerImage() {
		
		if (ExerciseTracker != null) 
			GameObject.Destroy (ExerciseTracker);
		
		string prefabName = "ExerciseTrackerHolder"; 
		
		GameObject prefab = Resources.Load (prefabName) as GameObject; 
		
		Quaternion rot = Quaternion.identity * Quaternion.Euler (new Vector3(0,180f, 0f)); 
		
		ExerciseTracker = Instantiate(prefab, new Vector3(1107,200,200), rot) as GameObject; 
		
		ExerciseTracker.name = "ExerciseTracker"; 
		
		Texture2D tex = (Texture2D) Resources.Load ("Exercise tracker 1", typeof(Texture2D));
		
		if (tex != null) {
			
			
			Debug.Log (tex.width);
			Debug.Log (tex.height);
			ExerciseTracker.transform.localScale = new Vector3(804, 912, 1); 
			ExerciseTracker.renderer.material.mainTexture = Resources.Load ("Exercise tracker 1", typeof(Texture2D)) as Texture2D; 
			
		}
		
	}
	
	public void LoadCalorieTrackerImage() {
		
		if (CalorieTracker != null) 
			GameObject.Destroy (CalorieTracker);
		
		string prefabName = "CalorieTrackerHolder"; 
		
		GameObject prefab = Resources.Load (prefabName) as GameObject; 
		
		Quaternion rot = Quaternion.identity * Quaternion.Euler (new Vector3(0,180f, 0f)); 
		
		CalorieTracker = Instantiate(prefab, new Vector3(2678,500,500), rot) as GameObject; 
		
		CalorieTracker.name = "CalorieTracker"; 
		
		Texture2D tex = (Texture2D) Resources.Load ("caloriesgraph", typeof(Texture2D));
		
		if (tex != null) {
			
			Debug.Log (tex.width);
			Debug.Log (tex.height);
			CalorieTracker.transform.localScale = new Vector3(564, 265, 1); 
			CalorieTracker.renderer.material.mainTexture = Resources.Load ("caloriesgraph", typeof(Texture2D)) as Texture2D; 
			
		}
		
	}
	
	}
	

