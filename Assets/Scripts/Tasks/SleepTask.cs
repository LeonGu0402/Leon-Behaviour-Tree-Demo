using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SleepTask : ActionTask {

        public BBParameter<float> timeOfSleep;
        public BBParameter<float> taskTime;

		public BBParameter<int> today;

        protected override string OnInit() 
		{
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() 
		{
			timeOfSleep.value = taskTime.value;
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
            timeOfSleep.value -= Time.deltaTime;
            if (timeOfSleep.value < 0)
            {
				today.value += 1;
				if (today.value > 7)
				{
					today.value = 1;
				}

                EndAction();
            }
        }

		//Called when the task is disabled.
		protected override void OnStop() 
		{
            Debug.Log("Wake up");
            timeOfSleep.value = 0;
        }

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}