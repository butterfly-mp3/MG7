# MG7
## Devlog
*In about a paragraph, explain your TreeOfBirds script. Mention both how an array is used in this script and how vectors are used. Write about a paragraph.*
    First of all, an array is created to store each of the birds in the scene, so we can quickly reference all of them in a single script. We make it public (or SerializeField) so we can tune it in the inspector and drag+drop each bird into the array. Then the script runs through the array every frame and check using the Vector3 positions of the indexed bird we're on and the Colobus. Based on the distance between the two, the script activates the bird if it's close enough.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
