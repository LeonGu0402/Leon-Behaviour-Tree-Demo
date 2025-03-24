using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions 
{

	public class classCheck : ConditionTask 
	{
		public BBParameter<bool> afterClass;

        protected override bool OnCheck()
        {
            if (afterClass.value == true)
            {
                return true;
            }

            return false;

        }

    }
}