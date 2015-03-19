using System.Reflection;
using ICities;
using UnityEngine;

namespace DynamicResolutionLowPower
{

    public class Mod : IUserMod
    {

        public string Name
        {
            get { return "Dynamic Resolution - Low Power"; }
        }

        public string Description
        {
            get { return "Version 1.0 of Dynamic Resolution for low power machines"; }
        }

    }

    public class ModLoad : LoadingExtensionBase
    {

        public override void OnLevelLoaded(LoadMode mode)
        {
            var cameraController = GameObject.FindObjectOfType<CameraController>();
            var camera = cameraController.gameObject.GetComponent<Camera>();
            camera.gameObject.AddComponent<CameraHook>();
        }

    }

}
