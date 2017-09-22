namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    public class ControlReactor : MonoBehaviour
    {
        public TextMesh go;
		public GameObject lift;
		private Animator animator;
        private VRTK_Control_UnityEvents controlEvents;
        private void Start()
        {
			animator = lift.GetComponent<Animator>();
            controlEvents = GetComponent<VRTK_Control_UnityEvents>();
            if (controlEvents == null)
            {
                controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
            }

            controlEvents.OnValueChanged.AddListener(HandleChange);
        }

        private void HandleChange(object sender, Control3DEventArgs e)
        {
            go.text = e.value.ToString() + "(" + e.normalizedValue.ToString() + "%)";
			if(e.value > 0){
				animator.SetBool ("open", true);
			}
        }
    }
}