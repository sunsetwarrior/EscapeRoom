namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    [RequireComponent(typeof(PhotonView))]
    public class tellOther : Photon.MonoBehaviour
    {
        public TextMesh go;
        public GameObject door;
        private Animator animator;
        private VRTK_Control_UnityEvents controlEvents;
        private void Start()
        {
            animator = door.GetComponent<Animator>();
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
            if (e.value > 50)
            {
                //animator.SetBool("open", true);
                this.photonView.RPC("tellOpen", PhotonTargets.AllBufferedViaServer, true);
                Destroy(this.GetComponent<tellOther>());
            }
        }

        [PunRPC]
        public void tellOpen(bool open)
        {
            animator.SetBool("open", true);
        }
    }
}