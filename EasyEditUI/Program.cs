﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace EasyEditUI
{
	class Program
	{
		public static CookedWebClient webClient;
		[STAThread]
		static void Main()
		{
			#if !DEBUG
			if (Debugger.IsAttached)
				return;
			#endif

			webClient = new CookedWebClient();
			webClient.Headers.Add("user-agent", "EasyEdit");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}

		public static string GetSelfVersion()
		{
			FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
			string version = fileVersionInfo.ProductVersion;
			return version;
		}

		public static string GetExecutingFileHash()
		{
			byte[] myFileData = File.ReadAllBytes(Application.ExecutablePath);
			byte[] myHash = MD5.Create().ComputeHash(myFileData);

			return BitConverter.ToString(myHash).Replace("-", "").ToLower();
		}
	}

	public class CookedWebClient : WebClient
	{
		public CookieContainer Cookies { get; } = new CookieContainer();

		protected override WebRequest GetWebRequest(Uri address)
		{
			WebRequest request = base.GetWebRequest(address);

			if (request.GetType() == typeof(HttpWebRequest))
				((HttpWebRequest)request).CookieContainer = Cookies;

			return request;
		}
	}

	class Hotkey
	{
		public enum BuildType
		{
			Build_Floor,
			Build_Stair,
			Build_Cone,
			Build_Wall
		}

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void InitConfig();

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EditT();
		public static Thread m_EditThread;

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WallReplaceT();
		public static Thread m_WallReplaceThread;

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CheckForegroundT();
		public static Thread m_CheckForegroundThread;

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdateLastKeysT();
		public static Thread m_UpdateLastKeysThread;

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CrouchT();
		public static Thread m_CrouchThread;

		//GetBind(int bind, char* name, char* displaynames, char* description, int& vkcode)
		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetBind(int bind, StringBuilder name, StringBuilder displayname, StringBuilder description);

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetBindCount();

		[DllImport("EasyEditLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SetBind(byte[] name, int vkCode);

		private static List<Pair<int, string>> KeyboardMap = new List<Pair<int, string>>();

		public static void CreateKeyboardMap()
		{
			KeyboardMap.Add(new Pair<int, string>(0x0, "?"));
			KeyboardMap.Add(new Pair<int, string>(0x01, "LMOUSE"));
			KeyboardMap.Add(new Pair<int, string>(0x02, "RMOUSE"));
			KeyboardMap.Add(new Pair<int, string>(0x04, "MIDDLEMOUSE"));
			KeyboardMap.Add(new Pair<int, string>(0x05, "MB BACK"));
			KeyboardMap.Add(new Pair<int, string>(0x06, "MB FORWARD"));
			KeyboardMap.Add(new Pair<int, string>(0x08, "BACKSPACE"));
			KeyboardMap.Add(new Pair<int, string>(0x09, "TAB"));
			KeyboardMap.Add(new Pair<int, string>(0x0d, "ENTER"));
			KeyboardMap.Add(new Pair<int, string>(0x14, "CAPS LOCK"));
			KeyboardMap.Add(new Pair<int, string>(0x20, "SPACE"));
			KeyboardMap.Add(new Pair<int, string>(0x21, "PAGE UP"));
			KeyboardMap.Add(new Pair<int, string>(0x22, "PAGE DOWN"));
			KeyboardMap.Add(new Pair<int, string>(0x24, "HOME"));
			KeyboardMap.Add(new Pair<int, string>(0x25, "ARROW LEFT"));
			KeyboardMap.Add(new Pair<int, string>(0x26, "ARROW UP"));
			KeyboardMap.Add(new Pair<int, string>(0x27, "ARROW RIGHT"));
			KeyboardMap.Add(new Pair<int, string>(0x28, "ARROW DOWN"));
			KeyboardMap.Add(new Pair<int, string>(0x2c, "PRINT SCREEN"));
			KeyboardMap.Add(new Pair<int, string>(0x2d, "INSERT"));
			KeyboardMap.Add(new Pair<int, string>(0x2e, "DELETE"));
			KeyboardMap.Add(new Pair<int, string>(0x30, "0"));
			KeyboardMap.Add(new Pair<int, string>(0x31, "1"));
			KeyboardMap.Add(new Pair<int, string>(0x32, "2"));
			KeyboardMap.Add(new Pair<int, string>(0x33, "3"));
			KeyboardMap.Add(new Pair<int, string>(0x34, "4"));
			KeyboardMap.Add(new Pair<int, string>(0x35, "5"));
			KeyboardMap.Add(new Pair<int, string>(0x36, "6"));
			KeyboardMap.Add(new Pair<int, string>(0x37, "7"));
			KeyboardMap.Add(new Pair<int, string>(0x38, "8"));
			KeyboardMap.Add(new Pair<int, string>(0x39, "9"));
			KeyboardMap.Add(new Pair<int, string>(0x41, "A"));
			KeyboardMap.Add(new Pair<int, string>(0x42, "B"));
			KeyboardMap.Add(new Pair<int, string>(0x43, "C"));
			KeyboardMap.Add(new Pair<int, string>(0x44, "D"));
			KeyboardMap.Add(new Pair<int, string>(0x45, "E"));
			KeyboardMap.Add(new Pair<int, string>(0x46, "F"));
			KeyboardMap.Add(new Pair<int, string>(0x47, "G"));
			KeyboardMap.Add(new Pair<int, string>(0x48, "H"));
			KeyboardMap.Add(new Pair<int, string>(0x49, "I"));
			KeyboardMap.Add(new Pair<int, string>(0x4a, "J"));
			KeyboardMap.Add(new Pair<int, string>(0x4b, "K"));
			KeyboardMap.Add(new Pair<int, string>(0x4c, "L"));
			KeyboardMap.Add(new Pair<int, string>(0x4d, "M"));
			KeyboardMap.Add(new Pair<int, string>(0x4e, "N"));
			KeyboardMap.Add(new Pair<int, string>(0x4f, "O"));
			KeyboardMap.Add(new Pair<int, string>(0x50, "P"));
			KeyboardMap.Add(new Pair<int, string>(0x51, "Q"));
			KeyboardMap.Add(new Pair<int, string>(0x52, "R"));
			KeyboardMap.Add(new Pair<int, string>(0x53, "S"));
			KeyboardMap.Add(new Pair<int, string>(0x54, "T"));
			KeyboardMap.Add(new Pair<int, string>(0x55, "U"));
			KeyboardMap.Add(new Pair<int, string>(0x56, "V"));
			KeyboardMap.Add(new Pair<int, string>(0x57, "W"));
			KeyboardMap.Add(new Pair<int, string>(0x58, "X"));
			KeyboardMap.Add(new Pair<int, string>(0x59, "Y"));
			KeyboardMap.Add(new Pair<int, string>(0x5a, "Z"));
			KeyboardMap.Add(new Pair<int, string>(0x5b, "LWIN"));
			KeyboardMap.Add(new Pair<int, string>(0x5c, "RWIN"));
			KeyboardMap.Add(new Pair<int, string>(0x60, "NUMPAD 0"));
			KeyboardMap.Add(new Pair<int, string>(0x61, "NUMPAD 1"));
			KeyboardMap.Add(new Pair<int, string>(0x62, "NUMPAD 2"));
			KeyboardMap.Add(new Pair<int, string>(0x63, "NUMPAD 3"));
			KeyboardMap.Add(new Pair<int, string>(0x64, "NUMPAD 4"));
			KeyboardMap.Add(new Pair<int, string>(0x65, "NUMPAD 5"));
			KeyboardMap.Add(new Pair<int, string>(0x66, "NUMPAD 6"));
			KeyboardMap.Add(new Pair<int, string>(0x67, "NUMPAD 7"));
			KeyboardMap.Add(new Pair<int, string>(0x68, "NUMPAD 8"));
			KeyboardMap.Add(new Pair<int, string>(0x69, "NUMPAD 9"));
			KeyboardMap.Add(new Pair<int, string>(0x6a, "NUMPAD *"));
			KeyboardMap.Add(new Pair<int, string>(0x6b, "NUMPAD +"));
			KeyboardMap.Add(new Pair<int, string>(0x6d, "NUMPAD -"));
			KeyboardMap.Add(new Pair<int, string>(0x6e, "NUMPAD ."));
			KeyboardMap.Add(new Pair<int, string>(0x6f, "NUMPAD /"));
			KeyboardMap.Add(new Pair<int, string>(0x70, "F1"));
			KeyboardMap.Add(new Pair<int, string>(0x71, "F2"));
			KeyboardMap.Add(new Pair<int, string>(0x72, "F3"));
			KeyboardMap.Add(new Pair<int, string>(0x73, "F4"));
			KeyboardMap.Add(new Pair<int, string>(0x74, "F5"));
			KeyboardMap.Add(new Pair<int, string>(0x75, "F6"));
			KeyboardMap.Add(new Pair<int, string>(0x76, "F7"));
			KeyboardMap.Add(new Pair<int, string>(0x77, "F8"));
			KeyboardMap.Add(new Pair<int, string>(0x78, "F9"));
			KeyboardMap.Add(new Pair<int, string>(0x79, "F10"));
			KeyboardMap.Add(new Pair<int, string>(0x7a, "F11"));
			KeyboardMap.Add(new Pair<int, string>(0x7b, "F12"));
			KeyboardMap.Add(new Pair<int, string>(0x90, "NUMLOCK"));
			KeyboardMap.Add(new Pair<int, string>(0x91, "SCROLL LOCK"));
			KeyboardMap.Add(new Pair<int, string>(0xa0, "SHIFT"));
			KeyboardMap.Add(new Pair<int, string>(0xa2, "CONTROL"));
			KeyboardMap.Add(new Pair<int, string>(0xa4, "ALT"));
			KeyboardMap.Add(new Pair<int, string>(0xba, ";"));
			KeyboardMap.Add(new Pair<int, string>(0xbb, "="));
			KeyboardMap.Add(new Pair<int, string>(0xbc, ","));
			KeyboardMap.Add(new Pair<int, string>(0xbd, "-"));
			KeyboardMap.Add(new Pair<int, string>(0xbe, "."));
			KeyboardMap.Add(new Pair<int, string>(0xbf, "/"));
			KeyboardMap.Add(new Pair<int, string>(0xc0, "`"));
			KeyboardMap.Add(new Pair<int, string>(0xdb, "["));
			KeyboardMap.Add(new Pair<int, string>(0xdc, "\\"));
			KeyboardMap.Add(new Pair<int, string>(0xdd, "]"));
			KeyboardMap.Add(new Pair<int, string>(0xde, "'"));
			KeyboardMap.Add(new Pair<int, string>(0xe2, "\\"));
			KeyboardMap.Add(new Pair<int, string>(0xfe, "MWHEELDOWN"));
			KeyboardMap.Add(new Pair<int, string>(0xff, "MWHEELUP"));
		}

		public static string GetHotkeyName(int vk)
		{
			foreach(var i in KeyboardMap)
			{
				if (vk == i.First)
				{
					return i.Second;
				}
			}

			return "";
		}

		public static string GetHotkeyNameFromIndex(int index)
		{
			return KeyboardMap[index].Second;
		}

		public static int GetHotkeyIndex(int vk)
		{
			int index = 0;
			foreach (var i in KeyboardMap)
			{
				if (vk == i.First)
				{
					return index;
				}
				index++;
			}

			return -1;
		}
	}

	public class Pair<T, U>
	{
		public Pair()
		{
		}

		public Pair(T first, U second)
		{
			First  = first;
			Second = second;
		}

		public T First { get; set; }
		public U Second { get; set; }
	};
}
