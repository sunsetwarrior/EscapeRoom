namespace VRTK.Examples
{
	using UnityEngine;

	public class drawer : VRTK_InteractableObject
	{
		Animator animator;
		public AudioClip ac;
		bool isOpen = false;

		public override void StartUsing(VRTK_InteractUse usingObject)
		{
			base.StartUsing(usingObject);
			OpenDrawer();
		}

		protected void Start()
		{

		}

		private void OpenDrawer()
		{
			isOpen = !isOpen;
			animator.SetBool ("open", isOpen);
			AudioSource.PlayClipAtPoint (ac, gameObject.transform.position);
		}
	}
}