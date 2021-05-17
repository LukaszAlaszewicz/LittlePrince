Shader "GUI/3D Text Shader" {

		SubShader{
			Tags { "Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent" }
			Lighting Off Cull Off ZWrite Off Fog { Mode Global }
			Blend SrcAlpha OneMinusSrcAlpha
			Pass {
				
			}
		}
}
