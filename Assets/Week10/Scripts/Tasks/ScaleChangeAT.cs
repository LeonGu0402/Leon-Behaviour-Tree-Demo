using NodeCanvas.Framework;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    public class ScaleChangeAT : ActionTask {

		public Transform targetTransform;
		public float targetScale = 2f;

		private float oringalscale;

        protected override string OnInit()
        {
            oringalscale = targetTransform.localScale.x;
            return base.OnInit();
        }

        //protected override void OnExecute()
        //{
        //    targetTransform.localScale = new Vector3(targetScale, targetScale, targetScale);
        //    EndAction(true);
        //}

        protected override void OnUpdate()
        {
            float stepValue = Mathf.PingPong(Time.time, 1f);
            float currentState = Mathf.Lerp(oringalscale, targetScale, stepValue);

            targetTransform.localScale = new Vector3(currentState, currentState, currentState);
        }

        protected override void OnStop()
        {
            targetTransform.localScale = new Vector3(oringalscale, oringalscale, oringalscale);
        }
    }
}