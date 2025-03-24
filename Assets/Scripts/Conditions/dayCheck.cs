using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class dayCheck : ConditionTask {

        public BBParameter<int> today;

		protected override bool OnCheck() 
		{
			if (today.value >= 1 && today.value <= 5)
			{
                Debug.Log("Time to go to school");
                return true;
			}
			else
			{
				return false;
			}

            
		}
	}
}