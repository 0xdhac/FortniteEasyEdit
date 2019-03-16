// dllmain.cpp : Defines the entry point for the DLL application.
#include "stdafx.h"
#include "Mouse.h"
#include "Keyboard.h"
#include "Config.h"
#include "Binds.h"
#include <fstream>

enum BuildType
{
	Build_Floor,
	Build_Stair,
	Build_Cone,
	Build_Wall
};

enum LastKeyType
{
	Key_None,
	Key_Build,
	Key_Weapon
};

#define KEY_WALL VK_XBUTTON2
#define KEY_FLOOR 'Q'
#define KEY_STAIR 'C'
#define KEY_CONE VK_XBUTTON1

bool g_IsGameUp           = false;
unsigned int g_LastWeapon = -1;
unsigned int g_LastBuild  = -1;
LastKeyType g_LastKeyType = Key_None;
int g_FakeEditBind        = VK_LSHIFT;
int g_RealEditBind        = 'L';
int g_FakeCrouchBind      = VK_LCONTROL;
int g_RealCrouchBind      = 'U';
int g_WallRetakeBind      = 'G';
int g_ShotgunBind         = '3';
int g_UseBind             = 'E';

int g_BuildList[] =
{
	KEY_FLOOR, KEY_STAIR, KEY_CONE, KEY_WALL
};

int g_WeaponList[] =
{
	'1', '2', '3', '4', '5', '6'
};

Config* g_Config;

HHOOK hMouseHook;
HHOOK hKeyboardHook;

LRESULT CALLBACK mouseProc(int nCode, WPARAM wParam, LPARAM lParam)
{
	if (nCode >= 0)
	{
		switch (wParam)
		{
		case WM_LBUTTONDOWN:
			
			break;

		case WM_LBUTTONUP:
			
			break;
		}
	}

	return CallNextHookEx(hMouseHook, nCode, wParam, lParam);
}

LRESULT CALLBACK keyboardProc(int nCode, WPARAM wParam, LPARAM lParam)
{
	switch (wParam)
	{
	case WM_KEYDOWN:
		KBDLLHOOKSTRUCT k = *(LPKBDLLHOOKSTRUCT)lParam;
		
		break;
	}

	return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
}

extern "C"
{
	DllExport void InitConfig()
	{
		
		Config("config.cfg");

		g_FakeEditBind           = Config::FindValue("FakeEdit");
		g_RealEditBind           = Config::FindValue("RealEdit");
		g_FakeCrouchBind		 = Config::FindValue("FakeCrouch");
		g_RealCrouchBind		 = Config::FindValue("RealCrouch");
		g_UseBind                = Config::FindValue("Use");
		g_WallRetakeBind         = Config::FindValue("WallRetake");
		g_ShotgunBind            = Config::FindValue("Shotgun");
		g_BuildList[Build_Floor] = Config::FindValue("Floor");
		g_BuildList[Build_Stair] = Config::FindValue("Stair");
		g_BuildList[Build_Cone]  = Config::FindValue("Cone");
		g_BuildList[Build_Wall]  = Config::FindValue("Wall");
		g_WeaponList[0]          = Config::FindValue("Weapon1");
		g_WeaponList[1]          = Config::FindValue("Weapon2");
		g_WeaponList[2]          = Config::FindValue("Weapon3");
		g_WeaponList[3]          = Config::FindValue("Weapon4");
		g_WeaponList[4]          = Config::FindValue("Weapon5");
		g_WeaponList[5]          = Config::FindValue("Weapon6");

		hMouseHook    = SetWindowsHookEx(WH_MOUSE_LL, mouseProc, NULL, 0);
		hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, keyboardProc, NULL, 0);
	}

	DllExport void SetWeaponHotkey(int index, int vk)
	{
		g_WeaponList[index] = vk;
		
		switch(index)
		{
		case 0:
			Config::SetValue("Weapon1", vk);
			break;
		case 1:
			Config::SetValue("Weapon2", vk);
			break;
		case 2:
			Config::SetValue("Weapon3", vk);
			break;
		case 3:
			Config::SetValue("Weapon4", vk);
			break;
		case 4:
			Config::SetValue("Weapon5", vk);
			break;
		case 5:
			Config::SetValue("Weapon6", vk);
			break;
		}
	}

	DllExport int GetWeaponHotkey(int index)
	{
		return g_WeaponList[index];
	}

	DllExport void SetBuildHotkey(int index, int vk)
	{
		g_BuildList[index] = vk;

		switch (index)
		{
		case Build_Floor:
			Config::SetValue("Floor", vk);
			break;
		case Build_Stair:
			Config::SetValue("Stair", vk);
			break;
		case Build_Cone:
			Config::SetValue("Cone", vk);
			break;
		case Build_Wall:
			Config::SetValue("Wall", vk);
			break;
		}
	}

	DllExport int GetBuildHotkey(int index)
	{
		return g_BuildList[index];
	}

	DllExport void SetFakeEditHotkey(int vk)
	{
		Config::SetValue("FakeEdit", vk);
		g_FakeEditBind = vk;
	}

	DllExport int GetFakeEditHotkey()
	{
		return g_FakeEditBind;
	}

	DllExport void SetUseHotkey(int vk)
	{
		Config::SetValue("Use", vk);
		g_UseBind = vk;
	}

	DllExport int GetUseHotkey()
	{
		return g_UseBind;
	}

	DllExport void SetRealEditHotkey(int vk)
	{
		Config::SetValue("RealEdit", vk);
		g_RealEditBind = vk;
	}

	DllExport int GetRealEditHotkey()
	{
		return g_RealEditBind;
	}

	DllExport void SetFakeCrouchHotkey(int vk)
	{
		Config::SetValue("FakeCrouch", vk);
		g_FakeCrouchBind = vk;
	}

	DllExport int GetFakeCrouchHotkey()
	{
		return g_FakeCrouchBind;
	}

	DllExport void SetRealCrouchHotkey(int vk)
	{
		Config::SetValue("RealCrouch", vk);
		g_RealCrouchBind = vk;
	}

	DllExport int GetRealCrouchHotkey()
	{
		return g_RealCrouchBind;
	}

	DllExport void SetWallRetakeHotkey(int vk)
	{
		Config::SetValue("WallRetake", vk);
		g_WallRetakeBind = vk;
	}

	DllExport int GetWallRetakeHotkey()
	{
		return g_WallRetakeBind;
	}

	DllExport void SetShotgunHotkey(int vk)
	{
		Config::SetValue("Shotgun", vk);
		g_ShotgunBind = vk;
	}

	DllExport int GetShotgunHotkey()
	{
		return g_ShotgunBind;
	}

	DllExport void EditT()
	{
		srand(time(NULL));
		bool bIsEditKeyPressed = false;

		while (true)
		{
			if (g_IsGameUp)
			{
				if (bIsEditKeyPressed == false && GetAsyncKeyState(g_FakeEditBind))
				{
					bIsEditKeyPressed = true;

					if (g_LastKeyType == Key_Build && g_LastWeapon != -1)
					{
						Keyboard::PressKey(g_WeaponList[g_LastWeapon], (rand() % 10) + 10);
						Sleep((rand() % 10) + 10);
					}

					Keyboard::PressKey(g_RealEditBind, (rand() % 15) + 15); // Start edit
					Sleep((rand() % 10) + 10); // Wait 10(+ 0-10)ms to allow edit reset
					Mouse::RightClick(0); // Edit reset
				}

				if (bIsEditKeyPressed == true && !GetAsyncKeyState(g_FakeEditBind))
				{
					bIsEditKeyPressed = false;

					Keyboard::PressKey(g_RealEditBind, (rand() % 15) + 15); // End edit
					Sleep(rand() % 20); // Wait 0-20ms to pull out shotgun
					Keyboard::PressKey(g_ShotgunBind, (rand() % 15) + 15); // Pull out shotgun
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}

	DllExport void WallReplaceT()
	{
		srand(time(NULL));
		bool bIsRetakeKeyPressed = false;
		while (true)
		{
			if (g_IsGameUp)
			{
				if (bIsRetakeKeyPressed == false && GetAsyncKeyState(g_WallRetakeBind))
				{
					bIsRetakeKeyPressed = true;
					DWORD structureKey = g_BuildList[Build_Wall];

					Mouse::LeftClick(0);

					if (g_LastWeapon == 0) // Pickaxe swing has a delay, 165ms is perfect
						Sleep(165);
					Sleep(7);

					Keyboard::HoldKey(structureKey);

					for (int i = 0; i < 20; i++) // Spam the structure place button
					{
						Mouse::LeftClick(0);
						Sleep(10);
					}

					Sleep(rand() % 20);

					Keyboard::ReleaseKey(structureKey);

					Sleep(10);

					Keyboard::PressKey(g_WeaponList[g_LastWeapon], rand() % 10 + 10);
				}
				else if (bIsRetakeKeyPressed == true && !GetAsyncKeyState(g_WallRetakeBind))
				{
					bIsRetakeKeyPressed = false;
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}

	DllExport void CrouchT()
	{
		srand(time(NULL));
		bool bIsCrouchKeyPressed = false;

		while (true)
		{
			if (g_IsGameUp)
			{
				if (bIsCrouchKeyPressed == false && GetAsyncKeyState(g_FakeCrouchBind))
				{
					bIsCrouchKeyPressed = true;

					Keyboard::PressKey(g_RealCrouchBind, (rand() % 15) + 15); // Start crouch
				}

				if (bIsCrouchKeyPressed == true && !GetAsyncKeyState(g_FakeCrouchBind))
				{
					bIsCrouchKeyPressed = false;

					Keyboard::PressKey(g_RealCrouchBind, (rand() % 15) + 15); // End crouch
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}

	DllExport void CheckForegroundT()
	{
		while (true)
		{
			#ifdef NDEBUG
			if (IsDebuggerPresent())
			{
				g_IsGameUp = false;
				return;
			}
			#endif
				
			HWND fw = GetForegroundWindow();
			char sTitle[64];

			GetWindowTextA(fw, sTitle, sizeof(sTitle));
			std::string s = sTitle;
			
			g_IsGameUp = s.find("Fortnite") == 0;

			Sleep(1000);
		}
	}

	DllExport void UpdateLastKeysT()
	{
		while (true)
		{
			if (g_IsGameUp)
			{
				for (int i = 0; i < 4; i++)
				{
					if (GetAsyncKeyState(g_BuildList[i]))
					{
						g_LastBuild   = i;
						g_LastKeyType = Key_Build;
					}
				}

				for (int i = 0; i < 6; i++)
				{
					if (GetAsyncKeyState(g_WeaponList[i]))
					{
						g_LastWeapon  = i;
						g_LastKeyType = Key_Weapon;
					}
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}
}