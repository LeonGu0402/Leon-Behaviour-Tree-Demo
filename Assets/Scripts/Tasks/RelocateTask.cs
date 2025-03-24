using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class RelocateTask : ActionTask {

		public NavMeshAgent navAgent;
        public BBParameter<Vector3> targetLocation;



        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() 
		{
			//navAgent = agent.GetComponent<NavMeshAgent>();
            return base.OnInit();
        }



		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
			navAgent.destination = targetLocation.value;

			if (Vector3.Distance(targetLocation.value,navAgent.transform.position) <= 0.8)
			{
				
				EndAction();
			}
		}

        protected override void OnStop()
        {
            Debug.Log("Arrived");
        }
    }
}