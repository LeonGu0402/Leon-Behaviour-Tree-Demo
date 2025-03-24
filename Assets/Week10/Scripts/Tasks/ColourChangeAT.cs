using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class ColourChangeAT : ActionTask 
	{
		public Renderer renderer;
		public Color targetColour;

		private Color originalColour;

        protected override string OnInit()
        {
            originalColour = renderer.material.color;
            return base.OnInit();
        }

        protected override void OnUpdate()
        {
            float stepValue = Mathf.PingPong(Time.time, 1f);
            renderer.material.color = Color.Lerp(originalColour, targetColour, stepValue);
        }

        protected override void OnStop()
        {
            renderer.material.color = originalColour;
        }
    }
}