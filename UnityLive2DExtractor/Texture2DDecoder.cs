// Texture2DDecoderWrapper, Version=0.16.8.0, Culture=neutral, PublicKeyToken=null
// Texture2DDecoder.TextureDecoder
using System;
using System.Runtime.InteropServices;
using AssetStudio.PInvoke;

namespace Texture2DDecoder;

// Texture2DDecoderWrapper, Version=0.16.8.0, Culture=neutral, PublicKeyToken=null
// Texture2DDecoder.T2DDll
internal static class T2DDll
{
    internal const string DllName = "Texture2DDecoderNative";
}


public static class TextureDecoder
{
	static TextureDecoder()
	{
		DllLoader.PreloadDll("Texture2DDecoderNative");
	}

	public unsafe static bool DecodeDXT1(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeDXT1(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeDXT5(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeDXT5(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodePVRTC(byte[] data, int width, int height, byte[] image, bool is2bpp)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodePVRTC(data2, width, height, image2, is2bpp);
			}
		}
	}

	public unsafe static bool DecodeETC1(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeETC1(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeETC2(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeETC2(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeETC2A1(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeETC2A1(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeETC2A8(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeETC2A8(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeEACR(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeEACR(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeEACRSigned(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeEACRSigned(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeEACRG(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeEACRG(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeEACRGSigned(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeEACRGSigned(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeBC4(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeBC4(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeBC5(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeBC5(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeBC6(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeBC6(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeBC7(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeBC7(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeATCRGB4(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeATCRGB4(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeATCRGBA8(byte[] data, int width, int height, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeATCRGBA8(data2, width, height, image2);
			}
		}
	}

	public unsafe static bool DecodeASTC(byte[] data, int width, int height, int blockWidth, int blockHeight, byte[] image)
	{
		fixed (byte* data2 = data)
		{
			fixed (byte* image2 = image)
			{
				return DecodeASTC(data2, width, height, blockWidth, blockHeight, image2);
			}
		}
	}

	public unsafe static byte[] UnpackCrunch(byte[] data)
	{
		void* result;
		uint resultSize;
		fixed (byte* data2 = data)
		{
			UnpackCrunch(data2, (uint)data.Length, out result, out resultSize);
		}
		if (result == null)
		{
			return null;
		}
		byte[] array = new byte[resultSize];
		Marshal.Copy(new IntPtr(result), array, 0, (int)resultSize);
		DisposeBuffer(ref result);
		return array;
	}

	public unsafe static byte[] UnpackUnityCrunch(byte[] data)
	{
		void* result;
		uint resultSize;
		fixed (byte* data2 = data)
		{
			UnpackUnityCrunch(data2, (uint)data.Length, out result, out resultSize);
		}
		if (result == null)
		{
			return null;
		}
		byte[] array = new byte[resultSize];
		Marshal.Copy(new IntPtr(result), array, 0, (int)resultSize);
		DisposeBuffer(ref result);
		return array;
	}

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeDXT1(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeDXT5(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodePVRTC(void* data, int width, int height, void* image, [MarshalAs(UnmanagedType.Bool)] bool is2bpp);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeETC1(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeETC2(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeETC2A1(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeETC2A8(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeEACR(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeEACRSigned(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeEACRG(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeEACRGSigned(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeBC4(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeBC5(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeBC6(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeBC7(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeATCRGB4(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeATCRGBA8(void* data, int width, int height, void* image);

	[DllImport("Texture2DDecoderNative")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static extern bool DecodeASTC(void* data, int width, int height, int blockWidth, int blockHeight, void* image);

	[DllImport("Texture2DDecoderNative")]
	private unsafe static extern void DisposeBuffer(ref void* ppBuffer);

	[DllImport("Texture2DDecoderNative")]
	private unsafe static extern void UnpackCrunch(void* data, uint dataSize, out void* result, out uint resultSize);

	[DllImport("Texture2DDecoderNative")]
	private unsafe static extern void UnpackUnityCrunch(void* data, uint dataSize, out void* result, out uint resultSize);
}
