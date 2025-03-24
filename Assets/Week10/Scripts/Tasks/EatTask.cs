using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class EatTask : ActionTask {

        public BBParameter<float> timeOfEating;
        public BBParameter<float> taskTime;

        public BBParameter<bool> afterClass;
        protected override string OnInit() 
		{
            
            return null;
		}

		protected override void OnExecute() 
		{
            timeOfEating.value = taskTime.value;
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
			timeOfEating.value -= Time.deltaTime;
			if (timeOfEating.value < 0)
			{
				afterClass.value = false;
				EndAction();
			}

		}

		//Called when the task is disabled.
		protected override void OnStop() 
		{
            Debug.Log("Class ended");
            timeOfEating.value = 0;
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}