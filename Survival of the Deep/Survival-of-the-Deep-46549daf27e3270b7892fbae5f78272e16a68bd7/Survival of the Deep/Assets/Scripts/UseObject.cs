using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseObject : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Probably just the main camera.. but referenced here to avoid Camera.main calls")]
    private Camera camera;
    [SerializeField]
    [Tooltip("The Layers the items to pickup will be on")]
    private LayerMask LayerMask;
    [SerializeField]
    [Tooltip("How long it takes to pick up an item")]
    private float pickupTime = 2f;
    [SerializeField]
    [Tooltip("the ring around the button that fills")]
    private ImageConversion pickupProgressImage;
    [SerializeField]
    private TextMeshProUGUI itemNameText;

    private Item interactWithObject;
    // this private class is hopefully going to be "press e to use"
    private float interactTimer
    // if we want an animation or a timer to use object

    // Update is called once per frame
    private void Update()
    // turned default void update to private void update
    {
        SelectObjectBeingUsedFromRay();
        //coppied from a video "Simple Unity Interactions with UI - HOld to Pickup / Interact"
        //changed name from SelectItemBeingPickedUpFromRay to SelectItemBeingUsedFromRay

        if (HasObjectTargetted())
        {
            PickupImageRoot.gameObject.SetActive(true);

            if (Input.GetButton("Fire1"))
            // Fire1 is A on xbox, the youtuber controller is and xbox layout
            //look up how to map an button to an input
            {
                IncrementPickupProgressAndTryComplete();
            }
            else
            {
                currentPickupTimerElapsed = 0f;
            }

            UpdatePickupProgressImage();
        }
        else
        {
            pickupImageRoot.gameObject.SetActive(false);
            currentPickupTimerElapsed = 0f;
        }
    }
    private bool HasObjectTargetted()
            {
                return itemBeingUsed! = null;
            }
    private void IncrementalPickupProgressAndTryComplete()
        {
            currentUseTimerElapsed += Time.deltaTime;
            //watching the frams since you press the button
            if (currentUserTimerElapsed >= pickupTime)
            //when timer is overlapping timer do blank
            {
                MoveItemToInventoy()
            }
        }

    private void UpdatePickupProgressImage()
        {
            float pct = currentPickupTimerElapsed / pickupTime;
            pickupProgressImage.fillAmount = pct;
        }

        void private SelectObjectBeingUsedFromRay()
        {
            Ray ray = Camera.ViewportPointToRay(Vector3.one / 2f);
            Debug.DrawRay(ray. origin, ray.direction * 2f, Color.red);

            RaycastHit hitInfor;
            if (Physics.Raycast(ray, out hitInfor, 2f, LayerMask))
            // this makes a ray (I think of it like cross hairs or an invisable line) to make sure the object is in the item layer
            {
                var hitItem = hitInfor.collider.GetComponent<Item>();

                if (hitItem ==null)
                {
                itemBeingUsed = null;
                    // Video named it itemBeingPickedUP
                }
                else if (hitItem ! = null && hitItem ! = itemBeingUsed)
                {
                    itemBeingUsed = hitItem;
                    itemNameText.text = "Use " + itemBeingUsed.gameobject.name;
                    // Instead of Pickup its Use
                }
            }
            else
            {
                itemBeingUsed = null;
            }
        }
    private void MoveItemToInventory()
    {
        Destroy(itemBeingUsed.gameObject);
        ItemBingUsed = null;
        //there is no inventroy it just delets item. So in theory when I go up and use 'Fire1' the box I made should be deleted.
    }
}
