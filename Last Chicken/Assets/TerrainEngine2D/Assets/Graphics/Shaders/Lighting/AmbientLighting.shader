﻿// Copyright (C) 2018 Matthew K Wilson
Shader "TerrainEngine2D/AmbientLighting"
{
	Properties
	{
		//Texture of the ambientlight
		_MainTex ("Texture", 2D) = "white" {}
		//Color of the ambientlight
		_Alpha ("Opacity", Float) = 1
	}
	SubShader
	{
		Tags{
		"Queue" = "Transparent"
		"RenderType" = "Transparent"
		"IgnoreProjector" = "True"
		}
		//No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			Blend SrcAlpha OneMinusSrcAlpha

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			sampler2D _MainTex;
			float _Alpha;

			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.uv);
				col.a = _Alpha;
				return col;
			}
			ENDCG
		}
	}
}
