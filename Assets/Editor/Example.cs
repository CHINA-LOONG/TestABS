using UnityEngine;
using UnityEditor;

public class Example : MonoBehaviour
{
    //Creates a new menu (Build Asset Bundles) and item (Normal) in the Editor
    [MenuItem("Build Asset Bundles/Normal")]
    static void BuildABsNone()
    {
        //Create a folder to put the Asset Bundle in.
        // This puts the bundles in your custom folder (this case it's "MyAssetBuilds") within the Assets folder.
        //Build AssetBundles with no special options
        BuildPipeline.BuildAssetBundles("Assets/MyAssetBuilds", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }

    //Creates a new item (Deterministic) in the new Build Asset Bundles menu
    [MenuItem("Build Asset Bundles/Deterministic ")]
    static void BuildABsDeterministic()
    {
        //Build the AssetBundles in this mode
        BuildPipeline.BuildAssetBundles("Assets/MyAssetBuilds", BuildAssetBundleOptions.DeterministicAssetBundle, BuildTarget.StandaloneWindows64);
    }
}