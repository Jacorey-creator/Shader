using UnityEngine;
[ExecuteInEditMode]
public class Shader_Handler : MonoBehaviour
{
    public Material effectMaterial;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, effectMaterial);
    }
}
