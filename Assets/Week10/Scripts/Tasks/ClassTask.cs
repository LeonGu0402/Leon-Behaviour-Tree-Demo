using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ClassTask : ActionTask {

		public BBParameter<float> timeOfClass;
		public BBParameter<float> taskTime;

		public BBParameter<bool> afterClass;

		protected override string OnInit() 
		{
			return base.OnInit();
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() 
		{
            timeOfClass.value = taskTime.value;
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
			timeOfClass.value -= Time.deltaTime;
			if (timeOfClass.value < 0)
			{
				afterClass.value = true;
				EndAction();
				
			}
		}

		//Called when the task is disabled.
		protected override void OnStop() 
		{
            Debug.Log("Class ended");
			timeOfClass.value = 0;
        }

		//Called when the task is paused.
		protected override void OnPause() 
		{
			
		}
	}
}